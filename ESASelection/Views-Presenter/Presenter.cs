using ESASelection.Tests;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ESASelection
{
    public class Presenter
    {
        public int height { get; set; }//hauteur de fenetre
        public int width { get; set; }//largeur de la fentre
        public Test Test
        { get; private set; }//le tet actuel

        public View myView { get; private set; }//ma vue


        public Presenter(View v)
        {
            myView = v;
            width = v.Width;
            height = v.Height;
        }
        public void add(Control b)//ajout d'un controle
        {
            myView.Controls.Add(b);
        }
        public void backTomenu()//retour menu
        {
            myView.Controls.Clear();
            Test.stopTimer();//on force l'arret du timer
            myView.MenuSender();//on retourne au menu
        }
        public void add(shape s, Color c, int x, int y, int number, char letter)//surcharge de add pour une forme (memoire)
        {
            new memroyShapes(s, c, x, y, myView, number, letter);//on crée une nouvelle forme
            myView.Refresh();//on rafrachit
        }
        public void add(shape s, Color c, int nbPoint, int x, int y)//surcharge de add pour une forme (attention)
        {
            new AttentionShapes(s, c, nbPoint, x, y, myView);//on crée une nouvelle forme
            myView.Refresh();//on rafrachit
        }

        internal void newTest(string name)//on crée un nouveau test
        {
            this.ClearForm();
            switch (name)//on fait le switch pour connaitre le test a faire
            {
                case "memory":
                    if (myView.easymemoryRB.Checked)
                        Test = new Memory(this, DifficultyLevel.Easy);
                    else
                        Test = new Memory(this, DifficultyLevel.hard);
                    break;
                case "attention":

                    if (myView.easyattentionRB.Checked)
                        Test = new Attention(this, DifficultyLevel.Easy);
                    else
                        Test = new Attention(this, DifficultyLevel.hard);

                    break;
                case "mathematics":

                    if (myView.eaysmathematicsRB.Checked)
                        Test = new Problems(this, DifficultyLevel.Easy, ProblemType.Mathematic);
                    else
                        Test = new Problems(this, DifficultyLevel.hard, ProblemType.Mathematic);

                    break;
                case "calcul":

                    if (myView.easycalculRB.Checked)
                        Test = new Calcul(this, DifficultyLevel.Easy);
                    else
                        Test = new Calcul(this, DifficultyLevel.hard);

                    break;
                case "physics":
                    if (myView.easyphysicsRB.Checked)
                        Test = new Problems(this, DifficultyLevel.Easy, ProblemType.Physics);
                    else
                        Test = new Problems(this, DifficultyLevel.hard, ProblemType.Physics);
                    break;
            }

        }

        internal void ClearForm()//effacement du contenu
        {
            myView.Controls.Clear();//On nettoie tout
            addBackToMenuBtn();//On rajoute le bouton retour menu
        }

        public void addBackToMenuBtn()
        {///Bouton retour menu (en haut a gauche)
            Font f = new Font("Arial",15);
            Button back = new Button();
            back.Click += new EventHandler(Retour_click);
            back.Text = "Retour Menu";
            back.Font = f;
            back.AutoSize = true;
            myView.Controls.Add(back);

        }

        private void Retour_click(object sender, EventArgs e)//Evenement de click sur le bouton
        {
            backTomenu();
        }
    }
}