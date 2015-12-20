using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class SelectionForm : Form
    {
        public bool LeftButtonDown = false;
        public bool RectangleDrawn = false;
        public bool ReadyToDrag = false;

        public Point ClickPoint = new Point();
        public Point CurrentTopLeft = new Point();
        public Point CurrentBottomRight = new Point();
        public Point DragClickRelative = new Point();

        public int RectangleHeight = new int();
        public int RectangleWidth = new int();

        Graphics g;
        Pen BlackPen = new Pen(Color.Black, 1);
        SolidBrush TransparentBrush = new SolidBrush(Color.White);
        Pen EraserPen = new Pen(Color.FromArgb(051, 153, 255), 1);
        SolidBrush EraserBrush = new SolidBrush(Color.FromArgb(051, 153, 255));

        private MainForm instanceRef = null;
        public MainForm InstanceRef
        {
            get
            {
                return instanceRef;
            }
            set
            {
                instanceRef = value;
            }
        }

        public SelectionForm(MainForm instanceRef)
        {
            InitializeComponent();
            InstanceRef = instanceRef;
            this.MouseDown += HandleMouseClick;
            this.MouseMove += HandleMouseMove;
            this.MouseUp += HandleMouseUp;

            this.Left = 0;
            this.Top = 0;
            var width = 0;
            var height = 0;
            var screens = Screen.AllScreens;
            foreach (var screen in screens)
            {
                if (screen.Bounds.Height > height)
                {
                    height = screen.Bounds.Height;
                }
                width += screen.Bounds.Width;
            }

            this.Width = width;
            this.Height = height;

            g = this.CreateGraphics();
        }

        private void HandleMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickPoint = new Point(MousePosition.X, MousePosition.Y);
                LeftButtonDown = true;
            }
        }

        private void HandleMouseUp(object sender, MouseEventArgs e)
        {
            instanceRef.SendRectangle(CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);
            this.Close();
        }

        private void HandleMouseMove(object sender, MouseEventArgs e)
        {
            if (LeftButtonDown)
            {
                DrawSelection();
            }
        }

        private void DrawSelection()
        {
            //Erase the previous rectangle
            g.DrawRectangle(EraserPen, CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);

            //Calculate X Coordinates
            if (Cursor.Position.X < ClickPoint.X)
            {
                CurrentTopLeft.X = Cursor.Position.X;
                CurrentBottomRight.X = ClickPoint.X;
            }
            else
            {
                CurrentTopLeft.X = ClickPoint.X;
                CurrentBottomRight.X = Cursor.Position.X;
            }

            //Calculate Y Coordinates
            if (Cursor.Position.Y < ClickPoint.Y)
            {
                CurrentTopLeft.Y = Cursor.Position.Y;
                CurrentBottomRight.Y = ClickPoint.Y;
            }
            else
            {
                CurrentTopLeft.Y = ClickPoint.Y;
                CurrentBottomRight.Y = Cursor.Position.Y;
            }

            //Draw a new rectangle
            g.DrawRectangle(BlackPen, CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);
        }
    }
}
