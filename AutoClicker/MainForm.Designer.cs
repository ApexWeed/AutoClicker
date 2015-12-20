namespace AutoClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.grpClickType = new System.Windows.Forms.GroupBox();
            this.rdbClickDoubleRight = new System.Windows.Forms.RadioButton();
            this.rdbClickDoubleMiddle = new System.Windows.Forms.RadioButton();
            this.rdbClickDoubleLeft = new System.Windows.Forms.RadioButton();
            this.rdbClickSingleRight = new System.Windows.Forms.RadioButton();
            this.rdbClickSingleMiddle = new System.Windows.Forms.RadioButton();
            this.rdbClickSingleLeft = new System.Windows.Forms.RadioButton();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnHotkeyRemove = new System.Windows.Forms.Button();
            this.txtHotkey = new System.Windows.Forms.TextBox();
            this.grpCount = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.rdbCount = new System.Windows.Forms.RadioButton();
            this.rdbUntilStopped = new System.Windows.Forms.RadioButton();
            this.grpDelay = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numDelayFixed = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numDelayRangeMax = new System.Windows.Forms.NumericUpDown();
            this.numDelayRangeMin = new System.Windows.Forms.NumericUpDown();
            this.rdbDelayRange = new System.Windows.Forms.RadioButton();
            this.rdbDelayFixed = new System.Windows.Forms.RadioButton();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numRandomHeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numRandomWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numRandomY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numRandomX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numFixedY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numFixedX = new System.Windows.Forms.NumericUpDown();
            this.rdbLocationRandomArea = new System.Windows.Forms.RadioButton();
            this.rdbLocationFixed = new System.Windows.Forms.RadioButton();
            this.rdbLocationRandom = new System.Windows.Forms.RadioButton();
            this.rdbLocationMouse = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grpMain.SuspendLayout();
            this.grpClickType.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.grpCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.grpDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayFixed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMin)).BeginInit();
            this.grpLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedX)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.grpClickType);
            this.grpMain.Controls.Add(this.grpControls);
            this.grpMain.Controls.Add(this.grpCount);
            this.grpMain.Controls.Add(this.grpDelay);
            this.grpMain.Controls.Add(this.grpLocation);
            this.grpMain.Location = new System.Drawing.Point(12, 12);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(750, 287);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Click details";
            // 
            // grpClickType
            // 
            this.grpClickType.Controls.Add(this.rdbClickDoubleRight);
            this.grpClickType.Controls.Add(this.rdbClickDoubleMiddle);
            this.grpClickType.Controls.Add(this.rdbClickDoubleLeft);
            this.grpClickType.Controls.Add(this.rdbClickSingleRight);
            this.grpClickType.Controls.Add(this.rdbClickSingleMiddle);
            this.grpClickType.Controls.Add(this.rdbClickSingleLeft);
            this.grpClickType.Location = new System.Drawing.Point(353, 97);
            this.grpClickType.Name = "grpClickType";
            this.grpClickType.Size = new System.Drawing.Size(391, 103);
            this.grpClickType.TabIndex = 2;
            this.grpClickType.TabStop = false;
            this.grpClickType.Text = "Click type";
            // 
            // rdbClickDoubleRight
            // 
            this.rdbClickDoubleRight.AutoSize = true;
            this.rdbClickDoubleRight.Location = new System.Drawing.Point(100, 62);
            this.rdbClickDoubleRight.Name = "rdbClickDoubleRight";
            this.rdbClickDoubleRight.Size = new System.Drawing.Size(89, 16);
            this.rdbClickDoubleRight.TabIndex = 5;
            this.rdbClickDoubleRight.Text = "Right Double";
            this.rdbClickDoubleRight.UseVisualStyleBackColor = true;
            this.rdbClickDoubleRight.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickDoubleMiddle
            // 
            this.rdbClickDoubleMiddle.AutoSize = true;
            this.rdbClickDoubleMiddle.Location = new System.Drawing.Point(100, 40);
            this.rdbClickDoubleMiddle.Name = "rdbClickDoubleMiddle";
            this.rdbClickDoubleMiddle.Size = new System.Drawing.Size(95, 16);
            this.rdbClickDoubleMiddle.TabIndex = 4;
            this.rdbClickDoubleMiddle.Text = "Middle Double";
            this.rdbClickDoubleMiddle.UseVisualStyleBackColor = true;
            this.rdbClickDoubleMiddle.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickDoubleLeft
            // 
            this.rdbClickDoubleLeft.AutoSize = true;
            this.rdbClickDoubleLeft.Location = new System.Drawing.Point(100, 18);
            this.rdbClickDoubleLeft.Name = "rdbClickDoubleLeft";
            this.rdbClickDoubleLeft.Size = new System.Drawing.Size(82, 16);
            this.rdbClickDoubleLeft.TabIndex = 3;
            this.rdbClickDoubleLeft.Text = "Left Double";
            this.rdbClickDoubleLeft.UseVisualStyleBackColor = true;
            this.rdbClickDoubleLeft.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickSingleRight
            // 
            this.rdbClickSingleRight.AutoSize = true;
            this.rdbClickSingleRight.Location = new System.Drawing.Point(6, 62);
            this.rdbClickSingleRight.Name = "rdbClickSingleRight";
            this.rdbClickSingleRight.Size = new System.Drawing.Size(50, 16);
            this.rdbClickSingleRight.TabIndex = 2;
            this.rdbClickSingleRight.Text = "Right";
            this.rdbClickSingleRight.UseVisualStyleBackColor = true;
            this.rdbClickSingleRight.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickSingleMiddle
            // 
            this.rdbClickSingleMiddle.AutoSize = true;
            this.rdbClickSingleMiddle.Location = new System.Drawing.Point(6, 40);
            this.rdbClickSingleMiddle.Name = "rdbClickSingleMiddle";
            this.rdbClickSingleMiddle.Size = new System.Drawing.Size(56, 16);
            this.rdbClickSingleMiddle.TabIndex = 1;
            this.rdbClickSingleMiddle.Text = "Middle";
            this.rdbClickSingleMiddle.UseVisualStyleBackColor = true;
            this.rdbClickSingleMiddle.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickSingleLeft
            // 
            this.rdbClickSingleLeft.AutoSize = true;
            this.rdbClickSingleLeft.Checked = true;
            this.rdbClickSingleLeft.Location = new System.Drawing.Point(6, 18);
            this.rdbClickSingleLeft.Name = "rdbClickSingleLeft";
            this.rdbClickSingleLeft.Size = new System.Drawing.Size(43, 16);
            this.rdbClickSingleLeft.TabIndex = 0;
            this.rdbClickSingleLeft.TabStop = true;
            this.rdbClickSingleLeft.Text = "Left";
            this.rdbClickSingleLeft.UseVisualStyleBackColor = true;
            this.rdbClickSingleLeft.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.label11);
            this.grpControls.Controls.Add(this.btnToggle);
            this.grpControls.Controls.Add(this.btnHotkeyRemove);
            this.grpControls.Controls.Add(this.txtHotkey);
            this.grpControls.Location = new System.Drawing.Point(353, 18);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(391, 73);
            this.grpControls.TabIndex = 1;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "Hotkey";
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(310, 44);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(75, 23);
            this.btnToggle.TabIndex = 3;
            this.btnToggle.Text = "Start";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnHotkeyRemove
            // 
            this.btnHotkeyRemove.Location = new System.Drawing.Point(229, 15);
            this.btnHotkeyRemove.Name = "btnHotkeyRemove";
            this.btnHotkeyRemove.Size = new System.Drawing.Size(156, 23);
            this.btnHotkeyRemove.TabIndex = 2;
            this.btnHotkeyRemove.Text = "Clear Hotkey";
            this.btnHotkeyRemove.UseVisualStyleBackColor = true;
            this.btnHotkeyRemove.Click += new System.EventHandler(this.btnHotkeyRemove_Click);
            // 
            // txtHotkey
            // 
            this.txtHotkey.Location = new System.Drawing.Point(8, 46);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.Size = new System.Drawing.Size(296, 19);
            this.txtHotkey.TabIndex = 0;
            this.txtHotkey.Text = "None";
            this.txtHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHotkey_KeyDown);
            // 
            // grpCount
            // 
            this.grpCount.Controls.Add(this.label1);
            this.grpCount.Controls.Add(this.numCount);
            this.grpCount.Controls.Add(this.rdbCount);
            this.grpCount.Controls.Add(this.rdbUntilStopped);
            this.grpCount.Location = new System.Drawing.Point(6, 206);
            this.grpCount.Name = "grpCount";
            this.grpCount.Size = new System.Drawing.Size(341, 69);
            this.grpCount.TabIndex = 1;
            this.grpCount.TabStop = false;
            this.grpCount.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "clicks";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(104, 41);
            this.numCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(120, 19);
            this.numCount.TabIndex = 2;
            this.numCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCount.ValueChanged += new System.EventHandler(this.CountHandler);
            // 
            // rdbCount
            // 
            this.rdbCount.AutoSize = true;
            this.rdbCount.Location = new System.Drawing.Point(6, 41);
            this.rdbCount.Name = "rdbCount";
            this.rdbCount.Size = new System.Drawing.Size(92, 16);
            this.rdbCount.TabIndex = 1;
            this.rdbCount.Text = "Fixed number";
            this.rdbCount.UseVisualStyleBackColor = true;
            this.rdbCount.CheckedChanged += new System.EventHandler(this.CountHandler);
            // 
            // rdbUntilStopped
            // 
            this.rdbUntilStopped.AutoSize = true;
            this.rdbUntilStopped.Checked = true;
            this.rdbUntilStopped.Location = new System.Drawing.Point(6, 19);
            this.rdbUntilStopped.Name = "rdbUntilStopped";
            this.rdbUntilStopped.Size = new System.Drawing.Size(91, 16);
            this.rdbUntilStopped.TabIndex = 0;
            this.rdbUntilStopped.TabStop = true;
            this.rdbUntilStopped.Text = "Until stopped";
            this.rdbUntilStopped.UseVisualStyleBackColor = true;
            this.rdbUntilStopped.CheckedChanged += new System.EventHandler(this.CountHandler);
            // 
            // grpDelay
            // 
            this.grpDelay.Controls.Add(this.label10);
            this.grpDelay.Controls.Add(this.label9);
            this.grpDelay.Controls.Add(this.numDelayFixed);
            this.grpDelay.Controls.Add(this.label8);
            this.grpDelay.Controls.Add(this.numDelayRangeMax);
            this.grpDelay.Controls.Add(this.numDelayRangeMin);
            this.grpDelay.Controls.Add(this.rdbDelayRange);
            this.grpDelay.Controls.Add(this.rdbDelayFixed);
            this.grpDelay.Location = new System.Drawing.Point(353, 206);
            this.grpDelay.Name = "grpDelay";
            this.grpDelay.Size = new System.Drawing.Size(391, 69);
            this.grpDelay.TabIndex = 1;
            this.grpDelay.TabStop = false;
            this.grpDelay.Text = "Delay";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "ms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "ms";
            // 
            // numDelayFixed
            // 
            this.numDelayFixed.Location = new System.Drawing.Point(96, 18);
            this.numDelayFixed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDelayFixed.Name = "numDelayFixed";
            this.numDelayFixed.Size = new System.Drawing.Size(120, 19);
            this.numDelayFixed.TabIndex = 11;
            this.numDelayFixed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDelayFixed.ValueChanged += new System.EventHandler(this.DelayHandler);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "-";
            // 
            // numDelayRangeMax
            // 
            this.numDelayRangeMax.Location = new System.Drawing.Point(239, 43);
            this.numDelayRangeMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDelayRangeMax.Name = "numDelayRangeMax";
            this.numDelayRangeMax.Size = new System.Drawing.Size(120, 19);
            this.numDelayRangeMax.TabIndex = 9;
            this.numDelayRangeMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDelayRangeMax.ValueChanged += new System.EventHandler(this.DelayHandler);
            // 
            // numDelayRangeMin
            // 
            this.numDelayRangeMin.Location = new System.Drawing.Point(96, 43);
            this.numDelayRangeMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDelayRangeMin.Name = "numDelayRangeMin";
            this.numDelayRangeMin.Size = new System.Drawing.Size(120, 19);
            this.numDelayRangeMin.TabIndex = 8;
            this.numDelayRangeMin.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDelayRangeMin.ValueChanged += new System.EventHandler(this.DelayHandler);
            // 
            // rdbDelayRange
            // 
            this.rdbDelayRange.AutoSize = true;
            this.rdbDelayRange.Location = new System.Drawing.Point(6, 43);
            this.rdbDelayRange.Name = "rdbDelayRange";
            this.rdbDelayRange.Size = new System.Drawing.Size(84, 16);
            this.rdbDelayRange.TabIndex = 1;
            this.rdbDelayRange.Text = "Delay range";
            this.rdbDelayRange.UseVisualStyleBackColor = true;
            this.rdbDelayRange.CheckedChanged += new System.EventHandler(this.DelayHandler);
            // 
            // rdbDelayFixed
            // 
            this.rdbDelayFixed.AutoSize = true;
            this.rdbDelayFixed.Checked = true;
            this.rdbDelayFixed.Location = new System.Drawing.Point(6, 18);
            this.rdbDelayFixed.Name = "rdbDelayFixed";
            this.rdbDelayFixed.Size = new System.Drawing.Size(82, 16);
            this.rdbDelayFixed.TabIndex = 0;
            this.rdbDelayFixed.TabStop = true;
            this.rdbDelayFixed.Text = "Fixed delay";
            this.rdbDelayFixed.UseVisualStyleBackColor = true;
            this.rdbDelayFixed.CheckedChanged += new System.EventHandler(this.DelayHandler);
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.btnSelect);
            this.grpLocation.Controls.Add(this.label6);
            this.grpLocation.Controls.Add(this.numRandomHeight);
            this.grpLocation.Controls.Add(this.label7);
            this.grpLocation.Controls.Add(this.numRandomWidth);
            this.grpLocation.Controls.Add(this.label4);
            this.grpLocation.Controls.Add(this.numRandomY);
            this.grpLocation.Controls.Add(this.label5);
            this.grpLocation.Controls.Add(this.numRandomX);
            this.grpLocation.Controls.Add(this.label3);
            this.grpLocation.Controls.Add(this.numFixedY);
            this.grpLocation.Controls.Add(this.label2);
            this.grpLocation.Controls.Add(this.numFixedX);
            this.grpLocation.Controls.Add(this.rdbLocationRandomArea);
            this.grpLocation.Controls.Add(this.rdbLocationFixed);
            this.grpLocation.Controls.Add(this.rdbLocationRandom);
            this.grpLocation.Controls.Add(this.rdbLocationMouse);
            this.grpLocation.Location = new System.Drawing.Point(6, 18);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(341, 182);
            this.grpLocation.TabIndex = 0;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "Height";
            // 
            // numRandomHeight
            // 
            this.numRandomHeight.Location = new System.Drawing.Point(215, 156);
            this.numRandomHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRandomHeight.Name = "numRandomHeight";
            this.numRandomHeight.Size = new System.Drawing.Size(120, 19);
            this.numRandomHeight.TabIndex = 14;
            this.numRandomHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numRandomHeight.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Width";
            // 
            // numRandomWidth
            // 
            this.numRandomWidth.Location = new System.Drawing.Point(45, 156);
            this.numRandomWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRandomWidth.Name = "numRandomWidth";
            this.numRandomWidth.Size = new System.Drawing.Size(120, 19);
            this.numRandomWidth.TabIndex = 12;
            this.numRandomWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numRandomWidth.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y";
            // 
            // numRandomY
            // 
            this.numRandomY.Location = new System.Drawing.Point(215, 131);
            this.numRandomY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRandomY.Name = "numRandomY";
            this.numRandomY.Size = new System.Drawing.Size(120, 19);
            this.numRandomY.TabIndex = 10;
            this.numRandomY.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // numRandomX
            // 
            this.numRandomX.Location = new System.Drawing.Point(45, 131);
            this.numRandomX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRandomX.Name = "numRandomX";
            this.numRandomX.Size = new System.Drawing.Size(120, 19);
            this.numRandomX.TabIndex = 8;
            this.numRandomX.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // numFixedY
            // 
            this.numFixedY.Location = new System.Drawing.Point(215, 84);
            this.numFixedY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numFixedY.Name = "numFixedY";
            this.numFixedY.Size = new System.Drawing.Size(120, 19);
            this.numFixedY.TabIndex = 6;
            this.numFixedY.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            // 
            // numFixedX
            // 
            this.numFixedX.Location = new System.Drawing.Point(45, 84);
            this.numFixedX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numFixedX.Name = "numFixedX";
            this.numFixedX.Size = new System.Drawing.Size(120, 19);
            this.numFixedX.TabIndex = 4;
            this.numFixedX.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationRandomArea
            // 
            this.rdbLocationRandomArea.AutoSize = true;
            this.rdbLocationRandomArea.Location = new System.Drawing.Point(6, 109);
            this.rdbLocationRandomArea.Name = "rdbLocationRandomArea";
            this.rdbLocationRandomArea.Size = new System.Drawing.Size(90, 16);
            this.rdbLocationRandomArea.TabIndex = 3;
            this.rdbLocationRandomArea.Text = "Random area";
            this.rdbLocationRandomArea.UseVisualStyleBackColor = true;
            this.rdbLocationRandomArea.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationFixed
            // 
            this.rdbLocationFixed.AutoSize = true;
            this.rdbLocationFixed.Location = new System.Drawing.Point(6, 62);
            this.rdbLocationFixed.Name = "rdbLocationFixed";
            this.rdbLocationFixed.Size = new System.Drawing.Size(95, 16);
            this.rdbLocationFixed.TabIndex = 2;
            this.rdbLocationFixed.Text = "Fixed location";
            this.rdbLocationFixed.UseVisualStyleBackColor = true;
            this.rdbLocationFixed.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationRandom
            // 
            this.rdbLocationRandom.AutoSize = true;
            this.rdbLocationRandom.Location = new System.Drawing.Point(6, 40);
            this.rdbLocationRandom.Name = "rdbLocationRandom";
            this.rdbLocationRandom.Size = new System.Drawing.Size(118, 16);
            this.rdbLocationRandom.TabIndex = 1;
            this.rdbLocationRandom.Text = "Random on screen";
            this.rdbLocationRandom.UseVisualStyleBackColor = true;
            this.rdbLocationRandom.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationMouse
            // 
            this.rdbLocationMouse.AutoSize = true;
            this.rdbLocationMouse.Checked = true;
            this.rdbLocationMouse.Location = new System.Drawing.Point(6, 18);
            this.rdbLocationMouse.Name = "rdbLocationMouse";
            this.rdbLocationMouse.Size = new System.Drawing.Size(100, 16);
            this.rdbLocationMouse.TabIndex = 0;
            this.rdbLocationMouse.TabStop = true;
            this.rdbLocationMouse.Text = "Mouse location";
            this.rdbLocationMouse.UseVisualStyleBackColor = true;
            this.rdbLocationMouse.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 310);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(774, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(279, 17);
            this.tslStatus.Text = "Not currently doing much helpful here to be honest";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(102, 106);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "Select...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 332);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Auto Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMain.ResumeLayout(false);
            this.grpClickType.ResumeLayout(false);
            this.grpClickType.PerformLayout();
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.grpCount.ResumeLayout(false);
            this.grpCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.grpDelay.ResumeLayout(false);
            this.grpDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayFixed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMin)).EndInit();
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedX)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.GroupBox grpClickType;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnHotkeyRemove;
        private System.Windows.Forms.TextBox txtHotkey;
        private System.Windows.Forms.GroupBox grpCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.RadioButton rdbCount;
        private System.Windows.Forms.RadioButton rdbUntilStopped;
        private System.Windows.Forms.GroupBox grpDelay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDelayFixed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numDelayRangeMax;
        private System.Windows.Forms.NumericUpDown numDelayRangeMin;
        private System.Windows.Forms.RadioButton rdbDelayRange;
        private System.Windows.Forms.RadioButton rdbDelayFixed;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numRandomHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numRandomWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numRandomY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numRandomX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numFixedY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFixedX;
        private System.Windows.Forms.RadioButton rdbLocationRandomArea;
        private System.Windows.Forms.RadioButton rdbLocationFixed;
        private System.Windows.Forms.RadioButton rdbLocationRandom;
        private System.Windows.Forms.RadioButton rdbLocationMouse;
        private System.Windows.Forms.RadioButton rdbClickDoubleRight;
        private System.Windows.Forms.RadioButton rdbClickDoubleMiddle;
        private System.Windows.Forms.RadioButton rdbClickDoubleLeft;
        private System.Windows.Forms.RadioButton rdbClickSingleRight;
        private System.Windows.Forms.RadioButton rdbClickSingleMiddle;
        private System.Windows.Forms.RadioButton rdbClickSingleLeft;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSelect;
    }
}

