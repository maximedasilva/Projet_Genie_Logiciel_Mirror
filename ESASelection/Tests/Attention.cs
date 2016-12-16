using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace ESASelection
{
    public class Attention : Test
    {

        shape[] tabShape = new shape[] { shape.rectangle, shape.circle, shape.square };//Tableau des formes
        Color[] tabColor = new Color[] { Color.Green, Color.Blue, Color.Yellow };//Tableau des couleurs

        List<string> tabRegleSimple = new List<string> { "même couleur", "même nombre de points", "même forme" };
        //Tableau des règles
        private string regle1; // correspond au bouton 1
        private string regle2; // de même ...
        private string regle3;
        private int  nbtest;

        int cptObjet = 0;
        int cptPoint = 0;
        double res;

        Color couleurAvant;//mémorisation de la couleur la forme et nbPoint d'avant
        shape formeAvant;
        int nbPointAvant;
        private Button btn1;
        private Button btn2;
        private Button btn3;

        private Random rd ;//Random pour la gestion de formes, couleurs et nbPoint aléatoire
        int rd1;
        int rd2;
        int rd3;
        private Font ftGrande;
        public Attention(Presenter p, DifficultyLevel df) : base(p, df)
        {
            //Instanciations
            ftGrande = new Font("Arial", 20);
            rd = new Random();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            nbtest = 0;
            Consigne = " PLusieurs objets vont apparaitre ainsi que 3 boutons,\nl'objectif est de reconnaitre les similitudes entre deux objets consécutifs.\n Il y a 3 boutons avec chacun une règle qui change d'une série à une autre.\n Ces règles seront énoncées entre chaque série\n Regles : \n";
            foreach (string s in tabRegleSimple)
            { Consigne += "\n" + s; }
            btn1.Text = "Bouton 1 (règle 1)";
            btn2.Text = "Bouton 2 (règle 2)";
            btn3.Text = "Bouton 3 (règle 3)";

            regle1 = tabRegleSimple[0];
            regle2 = tabRegleSimple[1];
            regle3 = "Autre cas";

            btn1.Top = (this.myPresenter.height - btn1.Height) / 2 - 100;
            btn2.Top = (this.myPresenter.height - btn2.Height) / 2;
            btn3.Top = (this.myPresenter.height - btn3.Height) / 2 + 100;
            btn1.Left = (this.myPresenter.width - btn1.Width) / 2 + 200;
            btn2.Left = (this.myPresenter.width - btn2.Width) / 2 + 200;
            btn3.Left = (this.myPresenter.width - btn3.Width) / 2 + 200;
            btn1.AutoSize = true;
            btn2.AutoSize = true;
            btn3.AutoSize = true;

            //On définit les boutons et on instancie le timer
            btn1.Click += new EventHandler(choosing);
            btn2.Click += new EventHandler(choosing);
            btn3.Click += new EventHandler(choosing);
            myTime = new Timer();
            myTime.Tick += new EventHandler(choosing);

            this.Load();//On lance le chargement

        }
        public override void Load()
        {
            MessageBox.Show(Consigne, "consigne", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //On affiche la consigne
            this.TestSerieAttention();
        }
        public void TestSerieAttention()
        {
            cptObjet = 0;//C'est le premier test
            Process();//On lance le process
        }
        public override void Process()
        {
            if (Difficulty == DifficultyLevel.hard)//Si cest difficile on lance un timer
            {
                myTime.Start();
                myTime.Interval = 1000;
            }

            if (cptObjet != 0)//Si ce n'est pas le premier objet affiché
            {
                formeAvant = tabShape[rd1];
                couleurAvant = tabColor[rd2];
                nbPointAvant = rd3;
            }

            myPresenter.ClearForm();//On nettoie

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;


            rd1 = rd.Next(0, 3);
            rd2 = rd.Next(0, 3);//On affecte nos random
            rd3 = rd.Next(1, 4);
            int abscisse = this.myPresenter.width / 2 - 100;
            int ordonnee = this.myPresenter.height / 2 - 50;


            myPresenter.add(tabShape[rd1], tabColor[rd2], rd3, abscisse, ordonnee);//On ajoute une forme 
            //grâce à nos random

            btn1.Text = "Bouton 1 \n" + regle1;
            btn2.Text = "Bouton 2 \n" + regle2;
            btn3.Text = "Bouton 3 \n" + regle3;

            myPresenter.add(btn1);
            myPresenter.add(btn2);
            myPresenter.add(btn3);

            if (cptObjet == 0)//Si c'est le premier objet, seul le bouton "autre règle" peut etre cliqué
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
            }


            cptObjet++;

        }

       

     


       

        public void ChangmentRegle()//Au changement de règle
        {
            int nb1;
            int nb2;
            do
            {
                nb1 = rd.Next(0, tabRegleSimple.Count);//Règle 1
                nb2 = rd.Next(0, tabRegleSimple.Count);//Règle
            } while (nb1 == nb2);//tant que regle1=regle2(on ne veut pas deux fois la meme regle

            regle1 = tabRegleSimple[nb1];
            regle2 = tabRegleSimple[nb2];
        }
        public void choosing(object sender, EventArgs e)//L'utilisateur choisit (ou que le timer est arrivé a son terme
        {
            myTime.Stop();//On arrête le timer
            string reponse = "";
            if (sender is Button)//Si c'est l'utilisateur qui a appuyé
            {
                Button ceBtn = (Button)sender;
                // On attribue la reponse au bouton
                if (ceBtn.Text == btn1.Text)
                {
                    reponse = regle1;
                }
                else if (ceBtn.Text == btn2.Text)
                {
                    reponse = regle2;
                }
                else // if (ceBtn.Text == "btn3")
                {
                    reponse = regle3;
                }
            }
                                   
            // On analyse le resultat
            if (btn1.Enabled == false)
            {
                //On compte pas le passage si c'est le premier
            }
            else
            {

                if (couleurAvant == tabColor[rd2]&& reponse == tabRegleSimple[0]) // Il repond "couleur" et c'est juste
                {
                     cptPoint++;
                }
               else if (formeAvant == tabShape[rd1]&& reponse == tabRegleSimple[2]) // Il repond "forme" et c'est juste
                {
                     cptPoint++; 
                }
                else if(nbPointAvant == rd3&& reponse == tabRegleSimple[1])//Il répond meme nombre de point et c'est juste
                {

                        cptPoint++;
                        
                    
                }
                else if ( reponse == "")//IL n'a pas eu le temps
                {

                }
                else // Il repond "autre cas"
                {
                    if ((regle1!= tabRegleSimple[1] && regle2 != tabRegleSimple[1]) || rd3 != nbPointAvant)//le nombre de point est différent ou la regle nbpoint n'est pas utilisée
                    {
                        if ((regle1 != tabRegleSimple[0] && regle1 != tabRegleSimple[0]) || couleurAvant != tabColor[rd2])//les couleurs sont différentes ou la regle couleur n'est pas utilisée
                        {
                            if ((regle1 != tabRegleSimple[2] && regle1 != tabRegleSimple[2]) || formeAvant != tabShape[rd1])//lesformes  sont différentes ou la regle forme n'est pas utilisée
                            {
                                 cptPoint++; 
                            }
                        }
                    }
                    
                }

                nbtest++;

            }



            if (cptObjet == 5)//Changement de règle
            {
                MessageBox.Show("Changement de règle ! ", "Regles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangmentRegle();
                TestSerieAttention(); numberOfTest++;
            }
            else if (numberOfTest == 5)//Il a fini les tests

            {
                myPresenter.backTomenu();//On retourne au menu
                res = 100 * ((1.0*cptPoint)/nbtest);
                if (Difficulty == DifficultyLevel.Easy)
                {
                    result[2] = res;
                }
                else
                    result[3] = res;
                MessageBox.Show("Fin du test Attention et concentration\nResultat : " + res + "%", "Fin test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //On fait le traitement du score
            }
            else
            {
                Process();//On continue le test
            }


        }

    }
}