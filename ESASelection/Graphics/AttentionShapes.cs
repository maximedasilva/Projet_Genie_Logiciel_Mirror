using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESASelection.Tests
{
   public class AttentionShapes: Panel
    {
        public shape myShape { get; private set; }//forme 
        public Color myColor { get; private set; }//couleur
        public int myNb_point { get; private set; }//nbPoint
        private View myView { get;  set; }//Ou l'afficher


        public AttentionShapes(shape s, Color c, int nb_point, int _x, int _y,View v)//Affectation
        {
            myShape = s;
            myColor = c;
            myNb_point = nb_point;
            myView = v;
            this.Width = 120;
            this.Height = 100;
            myView.Controls.Add(this);//On l'ajoute a la vue
            this.Left = _x;
            this.Top = _y;
        }

        protected override void OnPaint(PaintEventArgs pe)//Lorsqu'on rafrachit la page
        {

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(myColor);//On definit avec la couleur prédéfini
            SolidBrush point = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();//On crée tout ce qui nous est utile pour dessiner
            if (myShape == shape.square)//si c'est un carré
            {
                formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 100, 100));//On dessine un rectangle
               
            }
            else if(myShape==shape.circle)
            {
                formGraphics.FillEllipse(myBrush, new Rectangle(0, 0, 100, 100));
            }
            else
            {
                formGraphics.FillRectangle(myBrush, new Rectangle(0, 25, 100, 50));
            }
            if(myNb_point==1)
            {
                formGraphics.FillRectangle(point, new Rectangle(50, 50, 10, 10));
            }
            if (myNb_point == 2)
            {
                formGraphics.FillRectangle(point, new Rectangle(30, 50, 10, 10));
                formGraphics.FillRectangle(point, new Rectangle(60, 50, 10, 10));
            }
            if (myNb_point == 3)
            {
                formGraphics.FillEllipse(point, new Rectangle(50, 30, 10, 10));
                formGraphics.FillEllipse(point, new Rectangle(70, 60, 10, 10));
                formGraphics.FillEllipse(point, new Rectangle(30, 60, 10, 10));
            }
            myBrush.Dispose();
            formGraphics.Dispose();
        }
        
    }
}
