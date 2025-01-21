using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace UATassignment2._1._1
{
    public class DarkMode : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool SolidStyle = true;
        //Properties
        public Color OnBackColor
        {
            get
            {
                return onBackColor;
            }
            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }
        public Color OnToggleColor {
            get
            {
                return onToggleColor;
            }
            set {
                onBackColor = value;
                this.Invalidate();
            }
        }
        public Color OffBackColor
        {
            get
            {
                return offBackColor;
            }
            set
            {
                offBackColor = value;
                this.Invalidate();
            }
        }
        public Color OffToggleColor {
            get {
                return offToggleColor;
            }
            set
            {
                offToggleColor = value;
                this.Invalidate();
            }
        }
        [DefaultValue(true)]
        public bool SolidStyle1 {
            get {
                return SolidStyle;

            }
            set {
                  SolidStyle = value; 
                 this.Invalidate();
            }
        }

        public DarkMode()
        {
            this.MinimumSize = new Size(45, 22);
        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;

        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)//ON
            {
                //Draw surface
                if (SolidStyle)
               
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
              
                //Draw toggle
                else pevent.Graphics.DrawPath(new Pen(onBackColor,2), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));

            }
            else { //off
                //Draw surface
                if (SolidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                //Draw toggle
                else pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
