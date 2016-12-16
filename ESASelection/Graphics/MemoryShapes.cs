using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESASelection
{
    public enum shape { square,circle,rectangle}
    public class memroyShapes : Panel
    {
        public shape myShape { get; set; }//forme
        public Color myColor { get; set; }//couleur
        private int number {get; set; }//nombre
        private char myLetter { get; set; }//lettre
  
        public View myView { get; set; }
        public memroyShapes(shape s,Color c,int _x, int _y,View v,int _number, char letter)
        {
            myLetter = letter;
            number = _number;
            myShape = s;
            myColor = c;
            this.Left = _x;
            this.Top = _y;
            myView = v;
            this.Width =80;
            this.Height = 80;
            myView.Controls.Add(this);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(myColor);
            SolidBrush text= new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            if (myShape == shape.square)
            {
                formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 75, 75));
                formGraphics.DrawString(number.ToString(), new Font("arial", 16), text, 25, 25);
                formGraphics.DrawString(myLetter.ToString(), new Font("arial", 16), text, 25,0);
            }
            else
            {
                formGraphics.FillEllipse(myBrush, new Rectangle(0, 0, 75, 75));
                formGraphics.DrawString(number.ToString(), new Font("arial", 16), text, 25, 25);
                formGraphics.DrawString(myLetter.ToString(), new Font("arial", 16), text,25, 0);
            }
            myBrush.Dispose();
            formGraphics.Dispose();
        }
        
    }
}
