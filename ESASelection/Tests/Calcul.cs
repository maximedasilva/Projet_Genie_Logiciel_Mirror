using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ESASelection
{
    public class Calcul : Test
    {
        string CalculChoisi;//+ - / *
        int reponse;//résultat donné par l'utilisateur
        NumericUpDown repControl { get; set;  }//Controle permettant de rentrer ses informations
        public Calcul(Presenter p,DifficultyLevel df) : base(p, df)
        {
            this.Consigne = " Dans ce test vous devez résoudre des opération mentalement";
            this.Load();
            myTime = new Timer();//Timer du mode difficile
            myTime.Interval = 5000;
            valid.Click += new System.EventHandler(validateClick);//Event handler pour le click sur valider 
        }
        public override void Process()//Execution du test
        {
            Random rand = new Random();//Random Pour les opérandes
            int left = 0;
            int right = 0;
            switch (CalculChoisi){//Switch pour le respect de valeur des opérandes
                case ("+"):
                    left = rand.Next(100, 999);
                    right = rand.Next(100, 999);
                    reponse = right + left;
                    break;
                case ("-"):
                    while(right>=left)
                    {
                        left = rand.Next(100, 999);
                        right = rand.Next(10, 999);
                        reponse = left - right;
                    }
                    break;
                case ("*"):
                    left = rand.Next(2, 99);
                    right=rand.Next(2,9);
                    reponse = left * right;
                    break;
                case ("/"):
                    left = rand.Next(10, 999);
                    right = rand.Next(1, 9);
                    reponse = left / right;
                    break;
            }
            myPresenter.ClearForm();//On nettoie le form pour faire l'affichage de réponse
            if (this.Difficulty == DifficultyLevel.hard)//Si c'est dur, on lance le timer
            {
                myTime.Tick += new EventHandler(TimerEnd);
                myTime.Start();
               
            }
            Font ft = new Font("Arial", 45);
            
            Label operand = new Label();//Label gérant l'affichage de l'opération
           
            
            operand.Font = ft;
            operand.Text = left + " " + CalculChoisi + " " + right;
            operand.Width = operand.PreferredWidth;
            operand.Height = operand.PreferredHeight;
            operand.Left = (myPresenter.width - operand.Width) / 2;
            operand.Top = myPresenter.height / 2 - operand.Height / 2;//Toutes les options du controle

            myPresenter.add(operand);//Ajout du label
            repControl = new NumericUpDown();
            repControl.Font = new Font("Arial", 20);
            repControl.Maximum = 100000;
            repControl.AutoSize = true;

            repControl.Left = (myPresenter.width - repControl.Width) / 2;
            repControl.Top = myPresenter.height / 2 + 2 * operand.Height - repControl.Height / 2;

            myPresenter.add(repControl);            
            myPresenter.add(valid);
        }

        private void TimerEnd(object sender, EventArgs e)//Lorsque le timer se termine
        {
            repControl.Text = "";
            myTime.Stop();
            myTime = new Timer();
            myTime.Interval = 5000;
            myTime.Tick += new EventHandler(TimerEnd);
            validateClick(null, null);//On lance la fonction qui est déclenchée au clic(sauf que la réponse 
            //sera fausse puisqeu =""

        }

        private void validateClick(object sender, EventArgs e)//Lorsqu'on valide son choix
        {
            numberOfTest++;//On incrémente le nombre de tests
            if (reponse.ToString() == repControl.Text)//On compare
            {
                goodAnswer++;//On incrémente le nombre de réponses juste (si elle est juste évidement)
            }
            if (numberOfTest < 10)
                this.Process();//Tant qu'on a pas fait 10 tests, on recommence
            else
            {
                double res= (goodAnswer * 1.0 / numberOfTest) * 100;//On calcule le résultat

                MessageBox.Show(String.Format("Vous avez Fini le test avec un pourcentage de {0} %",res));//Qu'on affiche
                if (Difficulty == DifficultyLevel.Easy)//On met a jour la table des résultats
                {
                    result[4] = res;
                }
                else
                    result[5] = res;
                myTime.Dispose();//On arrete le chrono
                myPresenter.backTomenu();//on revient au menu
            }
        }

        public override void Load()//au chargement
        {
            //ON fait choisir l'opération
            Font f = new Font("Arial", 20);
            Button add = new Button();
            add.Left = myPresenter.width / 2;
            add.Top = myPresenter.height / 5;
            add.Text = ("+");
            add.Font = f;
            add.AutoSize = true;
            Button minus = new Button();
            minus.Left = myPresenter.width / 2;
            minus.Top = 2*myPresenter.height / 5;
            minus.Text = ("-");
            minus.Font = f;
            minus.AutoSize = true;
            Button multiple = new Button();
            multiple.Left = myPresenter.width / 2;
            multiple.Top = 3*myPresenter.height / 5;
            multiple.Text = ("*");
            multiple.Font = f;
            multiple.AutoSize = true;
            Button divide = new Button();
            divide.Left = myPresenter.width / 2;
            divide.Top = 4*myPresenter.height / 5;
            divide.Text = ("/");
            divide.Font = f;
            divide.AutoSize = true;

            divide.Click += new System.EventHandler(this.choosing);
            multiple.Click += new System.EventHandler(this.choosing);
            minus.Click += new System.EventHandler(this.choosing);
            add.Click += new System.EventHandler(this.choosing);

            myPresenter.add(add);
            myPresenter.add(multiple);
            myPresenter.add(minus);
            myPresenter.add(divide);

            MessageBox.Show(Consigne, "consigne", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void choosing(object sender, EventArgs e)//l'user choisit son opération
        {
          Button myButton=  (Button)sender;
            CalculChoisi = myButton.Text;
            myPresenter.ClearForm();
            this.Process();//On lance le test
        }
    }
}