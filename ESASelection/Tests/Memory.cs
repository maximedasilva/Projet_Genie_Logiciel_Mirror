using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace ESASelection
{
    public class Memory : Test
    {
        private static string[] answerToString = new string[] { "Carré bleu", "Carré jaune", "Rond bleu", "Rond jaune" };
        //Tableau des réponses
        private static char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L' };
        //Lettres
        private Dictionary<string, int> reponse;//Dictionaire pour la réponse (lettre +valeur)
        private Label Question;
        private NumericUpDown myAnswer;

        int numberOfAnswer;
        int TestNumber;
        private int TotalAnswer;
        public Memory(Presenter p, DifficultyLevel df) : base(p, df)
        {
            this.Consigne = "Dans cet exercice vous devrez identifier les chiffres contenus dans une forme et une couleur donnée et les restituer dans l'ordre";
            //On affecte la consigne
            valid.Click += new System.EventHandler(click_valid);
            numberOfTest = 0;
            goodAnswer = 0;
            myTime = new Timer();
            myTime.Tick += new EventHandler(traitementReponse);
            if (df == DifficultyLevel.Easy)
                myTime.Interval = 4000;
            else
                myTime.Interval = 2000;
            TestNumber = 0;
            numberOfAnswer = 0;
            Question = new Label();
            Question.Left = myPresenter.width / 2;
            Question.Top = myPresenter.height / 2;
            this.Load();
            TotalAnswer = 0;

        }
        public override void Process()
        {
            numberOfAnswer = 0;//On remet a 0 le nombre de réponses
            reponse = new Dictionary<string, int>();
            Random rd = new Random();
            int number;
            int lettercpt;
            int type;
            int reptype;


            List<int> typeList = new List<int>();
            reptype = rd.Next(1, 5);//le type de réponse (carré bleu par exemple)
            int cpt=0;
            while (cpt < 3 || cpt > 4) //Tant qu'il n'y a pas 3 ou 4 formes égale à celle a retrouver
            {
                cpt = 0;
                typeList.Clear();
                for (int i = 0; i < 12; i++)
                {

                        type = rd.Next(1,5);//On affecte le tableau des types
                        typeList.Add(type);
                        if(type==reptype)
                        {
                            cpt++;//On incrémente le compteur si c'est une forme a retrouver
                        }
                    
                }
            }
                myPresenter.ClearForm();//ON efface tout
                ConsigneLabel.Text = "Mémorisez les chiffres présents dans les " + answerToString[reptype-1];//On affecte la consigne
            myPresenter.add(ConsigneLabel);
                cpt = 0;
                reponse.Clear();
                lettercpt = 0;

            for (int i = 0; i < 3; i++)//on place toutes les formes
            {
                for (int j = 0; j < 4; j++)
                {
                    number = rd.Next(1, 10);
                        type = rd.Next(1, 5);
                        switch (typeList.ElementAt(lettercpt))
                        {
                            case 1:
                                myPresenter.add(shape.square, Color.Blue, 250 + 100 * j, 200 + 100 * i, number, letters[lettercpt]);
                                break;
                            case 2:

                                myPresenter.add(shape.square, Color.Yellow, 250 + 100 * j, 200 + 100 * i, number, letters[lettercpt]);
                                break;
                            case 3:
                                myPresenter.add(shape.circle, Color.Blue, 250 + 100 * j, 200 + 100 * i, number, letters[lettercpt]);
                                break;
                            case 4:
                                myPresenter.add(shape.circle, Color.Yellow, 250 + 100 * j, 200 + 100 * i, number, letters[lettercpt]);
                                break;

                        }
                        if (typeList.ElementAt(lettercpt) == reptype)
                        {
                            reponse.Add(letters[lettercpt].ToString(), number);//On ajoute la lettre et le chiffre a notre dictionnaire
                        }

                        lettercpt++;
                    }
                }
                myTime.Start();
            }
           
        
     

        private void traitementReponse(object sender, EventArgs e)
        {
            myTime.Stop();
            myPresenter.ClearForm();
            if(numberOfAnswer<reponse.Count)//tant qu'on a pas trouvé toutes les formes
            {
                Font ft = new Font("Arial", 20);
                Question = new Label();
                Question.Font = ft;
                Question.Text = "Quel numéro se cachait derrière la lettre " + reponse.ElementAt(numberOfAnswer).Key;
                Question.Width = Question.PreferredWidth;
                Question.Height = Question.PreferredHeight;
                Question.Left = (myPresenter.width - Question.Width) / 2;
                Question.Top = myPresenter.height / 2 - Question.Height / 2;

                myPresenter.add(Question);
                myAnswer = new NumericUpDown();
                myAnswer.Font = new Font("Arial", 20);
                myAnswer.Maximum = 10000;
                myAnswer.AutoSize = true;

                myAnswer.Left = (myPresenter.width - myAnswer.Width) / 2;
                myAnswer.Top = myPresenter.height / 2 + 2 * Question.Height - myAnswer.Height / 2;
                myPresenter.add(myAnswer);
                myPresenter.add(valid);
               
            }
            else//On passe au test suivant
            {
                TestNumber++;
                if (TestNumber < 10)
                    Process();
                else
                {
                    myPresenter.backTomenu();

                    double res = (1.0 * goodAnswer / TotalAnswer) * 100.0;
                    MessageBox.Show("vous avez fait un score de " + res + " %");
                    if (Difficulty == DifficultyLevel.Easy)
                    {
                        result[0] = res;
                    }
                    else
                        result[1] = res;
                }
            }

        }

        private void click_valid(object sender, EventArgs e)
        {
            if(myAnswer.Value == reponse.ElementAt(numberOfAnswer).Value)
            {
                goodAnswer++;
            }
            TotalAnswer++;
            numberOfAnswer++;
            traitementReponse(null,null);
        }

        public override void Load()
        {
            MessageBox.Show(this.Consigne, "consignes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process();       
        }

    }
    
}