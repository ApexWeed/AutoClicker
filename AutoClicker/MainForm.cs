using System;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        private AutoClicker clicker;
        private Keys hotkey;
        private Win32.fsModifiers modifiers;
        private bool hotkeySet;

        private Thread countdownThread;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clicker = new AutoClicker();
            ClickTypeHandler(null, null);
            LocationHandler(null, null);
            DelayHandler(null, null);
            CountHandler(null, null);

            clicker.NextClick += HandleNextClick;
        }

        private void HandleNextClick(object sender, AutoClicker.NextClickEventArgs e)
        {
            countdownThread = new Thread(() => CountDown(e.NextClick));
            countdownThread.Start();
        }

        private void CountDown(int Milliseconds)
        {
            for (int i = 0; i < Milliseconds; i += 10)
            {
                tslStatus.Text = string.Format("Next click: {0}ms", Milliseconds - i);
                Thread.Sleep(9);
            }
        }

        private void ClickTypeHandler(object sender, EventArgs e)
        {
            AutoClicker.ButtonType buttonType;
            bool doubleClick = false;

            if (rdbClickSingleLeft.Checked || rdbClickDoubleLeft.Checked)
            {
                buttonType = AutoClicker.ButtonType.Left;
            }
            else if (rdbClickSingleMiddle.Checked || rdbClickDoubleMiddle.Checked)
            {
                buttonType = AutoClicker.ButtonType.Middle;
            }
            else
            {
                buttonType = AutoClicker.ButtonType.Right;
            }

            if (rdbClickDoubleLeft.Checked || rdbClickDoubleMiddle.Checked || rdbClickDoubleRight.Checked)
            {
                doubleClick = true;
            }

            clicker.UpdateButton(buttonType, doubleClick);
        }

        private void LocationHandler(object sender, EventArgs e)
        {
            AutoClicker.LocationType locationType;
            int x = -1;
            int y = -1;
            int width = -1;
            int height = -1;

            if (rdbLocationFixed.Checked)
            {
                locationType = AutoClicker.LocationType.Fixed;
                x = (int)numFixedX.Value;
                y = (int)numFixedY.Value;
            }
            else if (rdbLocationMouse.Checked)
            {
                locationType = AutoClicker.LocationType.Cursor;
            }
            else if (rdbLocationRandom.Checked)
            {
                locationType = AutoClicker.LocationType.Random;
            }
            else
            {
                locationType = AutoClicker.LocationType.RandomRange;
                x = (int)numRandomX.Value;
                y = (int)numRandomY.Value;
                width = (int)numRandomWidth.Value;
                height = (int)numRandomHeight.Value;
            }

            // Toggle visibility of controls.
            if (locationType == AutoClicker.LocationType.Fixed)
            {
                numFixedX.Enabled = true;
                numFixedY.Enabled = true;
            }
            else
            {
                numFixedX.Enabled = false;
                numFixedY.Enabled = false;
            }

            if (locationType == AutoClicker.LocationType.RandomRange)
            {
                numRandomX.Enabled = true;
                numRandomY.Enabled = true;
                numRandomWidth.Enabled = true;
                numRandomHeight.Enabled = true;
            }
            else
            {
                numRandomX.Enabled = false;
                numRandomY.Enabled = false;
                numRandomWidth.Enabled = false;
                numRandomHeight.Enabled = false;
            }

            clicker.UpdateLocation(locationType, x, y, width, height);
        }

        private void DelayHandler(object sender, EventArgs e)
        {
            AutoClicker.DelayType delayType;
            int delay = -1;
            int delayRange = -1;

            if (rdbDelayFixed.Checked)
            {
                delayType = AutoClicker.DelayType.Fixed;
                delay = (int)numDelayFixed.Value;
            }
            else
            {
                delayType = AutoClicker.DelayType.Range;
                delay = (int)numDelayRangeMin.Value;
                delayRange = (int)numDelayRangeMax.Value;
            }

            // Toggle visibility of controls.
            if (delayType == AutoClicker.DelayType.Fixed)
            {
                numDelayFixed.Enabled = true;
                numDelayRangeMax.Enabled = false;
                numDelayRangeMin.Enabled = false;
            }
            else
            {
                numDelayFixed.Enabled = false;
                numDelayRangeMax.Enabled = true;
                numDelayRangeMin.Enabled = true;
            }

            clicker.UpdateDelay(delayType, delay, delayRange);
        }

        private void CountHandler(object sender, EventArgs e)
        {
            AutoClicker.CountType countType;
            int count = -1;

            if (rdbCount.Checked)
            {
                countType = AutoClicker.CountType.Fixed;
                count = (int)numCount.Value;
            }
            else
            {
                countType = AutoClicker.CountType.UntilStopped;
            }

            // Toggle visibility of controls.
            if (countType == AutoClicker.CountType.Fixed)
            {
                numCount.Enabled = true;
            }
            else
            {
                numCount.Enabled = false;
            }

            clicker.UpdateCount(countType, count);
        }

        private void btnHotkeyRemove_Click(object sender, EventArgs e)
        {
            Win32.UnregisterHotKey(this.Handle, (int)hotkey);
            hotkeySet = false;
            btnHotkeyRemove.Enabled = false;
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (!clicker.IsAlive)
            {
                grpClickType.Enabled = false;
                grpLocation.Enabled = false;
                grpDelay.Enabled = false;
                grpCount.Enabled = false;
                clicker.Start();
                btnToggle.Text = "Stop";
            }
            else
            {
                clicker.Stop();
                countdownThread.Abort();
                tslStatus.Text = "Not currently doing much helpful here to be honest";
                grpClickType.Enabled = true;
                grpLocation.Enabled = true;
                grpDelay.Enabled = true;
                grpCount.Enabled = true;
                btnToggle.Text = "Start";
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == Win32.WM_HOTKEY)
            {
                // Ignore the hotkey if the user is editing it.
                if (txtHotkey.Focused)
                {
                    return;
                }

                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                if (key == Keys.F2)
                {
                    btnToggle_Click(null, null);
                }
            }
        }

        private void txtHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            // Don't want to do anything if only a modifier key is pressed.
            //     Modifiers                                 Asian keys (kana, hanja, kanji etc)       IME related keys (convert etc)           Korean alt (process)  Windows keys
            if (!((e.KeyValue >= 16 && e.KeyValue <= 18) || (e.KeyValue >= 21 && e.KeyValue <= 25) || (e.KeyValue >= 28 && e.KeyValue <= 31) || e.KeyValue == 229 || (e.KeyValue >= 91 && e.KeyValue <= 92)))
            {
                Win32.UnregisterHotKey(this.Handle, (int)hotkey);
                txtHotkey.Text = KeysConverter.Convert(e.KeyData);
                hotkey = e.KeyData;
                // Extract modifiers
                modifiers = 0;
                if ((e.Modifiers & Keys.Shift) != 0)
                {
                    modifiers |= Win32.fsModifiers.Shift;
                }
                if ((e.Modifiers & Keys.Control) != 0)
                {
                    modifiers |= Win32.fsModifiers.Control;
                }
                if ((e.Modifiers & Keys.Alt) != 0)
                {
                    modifiers |= Win32.fsModifiers.Alt;
                }

                Win32.RegisterHotKey(this.Handle, (int)hotkey, (uint)modifiers, (uint)(hotkey & Keys.KeyCode));
                hotkeySet = true;
                btnHotkeyRemove.Enabled = true;
            }
        }
    }
}
