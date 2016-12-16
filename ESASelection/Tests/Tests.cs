using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ESASelection
{
    public enum DifficultyLevel { Easy,hard};
    public abstract class Test
    {
        public Button valid { get;protected set; }//Bouton de validation
        public int goodAnswer { get; protected set; }//Nombre de bonne reponse
        public DifficultyLevel Difficulty//DIfficulté
        { get; protected set; }
        public int numberOfTest { get; protected set; }//Nombre de test a faire

        public string Consigne//Consigne
        { get; protected set; }
        public Timer myTime { get; protected set; }//Temps pour réaliser le test
        public Label ConsigneLabel { get; protected set; }//Label de consigne
        public static double[] result;//Resultats pour l'affichage menu
        public Presenter myPresenter { get; private set; }//mon presenter
       public static void initTab()//Methode statique pour l'affectation du tableau a lancement du programme
        {
            result = new Double[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        public Test(Presenter p,DifficultyLevel df)
        {
            Font consigne = new Font("Arial", 14);
            Font ValidFont= new Font("Arial", 20);
            Difficulty = df;
            myPresenter = p;
            numberOfTest = 0;
            goodAnswer = 0;
            ConsigneLabel = new Label();
            ConsigneLabel.Top = 100;
            ConsigneLabel.Width = myPresenter.width;
            ConsigneLabel.TextAlign = ContentAlignment.TopCenter;
            ConsigneLabel.Font = consigne;
            valid = new Button();
            valid.Text = "Valider";
            valid.AutoSize = true;
            valid.Left = (myPresenter.width - 2*valid.Width) / 2;
            valid.Top = myPresenter.height-100;
            valid.Font = ValidFont;

        }
        public void stopTimer()//Ppour forcer le timer a se stopper si l'utilisateur fait un retour menu
        {
            if (myTime!=null)
            {
                myTime.Stop();
            }
        }


        public abstract void Process();//methode abstraite pour le test 

        public abstract void Load();//methode abstraite pour le lanement du test
    }
}