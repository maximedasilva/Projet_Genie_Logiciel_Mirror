using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;

namespace ESASelection
{
    public enum ProblemType { Mathematic, Physics }

    public class Problems : Test
    {

        //Variables
        private List<chargement> ListeProb = new List<chargement>();
        private int i = 1;
        private string resReponse;
        private ProblemType type;
        private Label probleme = new Label();
        private PictureBox img = new PictureBox();
        private RadioButton reponse1 = new RadioButton();
        private RadioButton reponse2 = new RadioButton();
        private RadioButton reponse3 = new RadioButton();
        private RadioButton reponse4 = new RadioButton();
        private Button btn_valider = new Button();

        private Random rnd = new Random();

        public Problems(Presenter p, DifficultyLevel df, ProblemType t) : base(p, df) {
            type = t;
            Consigne = "Dans ce test vous devez répondre à un QCM. Les mauvaises réponses ne font pas perdre de point";
            this.Load();

        }

        public override void Load()
        {
            MessageBox.Show(Consigne, "consigne", MessageBoxButtons.OK, MessageBoxIcon.Information);
            generate(); //On charge les problemes mathéatiques à partir du fichier xml
        }

        //deserialisation des problèmes

        public void generate()
        {
            IEnumerable<XElement> p = new List<XElement>();
            btn_valider.Click += new System.EventHandler(this.choosing);
            if (type == ProblemType.Mathematic)// On charge nos xml
            {
                try {
                    XDocument document = XDocument.Load(@"../../Resources/probMaths.xml");
                    p = document.Descendants("probMaths");
                }
                catch (Exception e) { MessageBox.Show(e.ToString()); }
            }
            else
            {
                try {
                    XDocument document = XDocument.Load(@"../../Resources/probPhysics.xml");
                    p = document.Descendants("probPhysics");
                }
                catch (Exception e) { MessageBox.Show(e.ToString()); }
            }
            foreach (var prob in p)//Pour chaque probleme
            {//On le déserialise
                chargement probleme = new chargement((int)prob.Attribute("id"), (string)prob.Attribute("enonce"), (string)prob.Attribute("reponse1"), (string)prob.Attribute("reponse2"), (string)prob.Attribute("reponse3"), (string)prob.Attribute("reponse4"), (string)prob.Attribute("bonnereponse"), (string)prob.Attribute("cheminImage"));
                ListeProb.Add(probleme);//On l'ajoute a la liste
                numberOfTest++; // On compte le nombre de questions généré pour le test

            }

            for (int cpt = 0; cpt < 10; cpt++)
            {
                int r = rnd.Next(0, 20 - cpt);
                ListeProb.RemoveAt(r);
                numberOfTest--;
            }

            Process();

        }

        public override void Process()
        {
            //Placement de l'image
            img.Left = (this.myPresenter.width - img.Width) / 2;
            img.Top = ((this.myPresenter.height - img.Height) / 4) - 100;
            img.Height = 130;
            img.Width = img.Height;
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Image = Image.FromFile(@"../../Resources/" + ListeProb[i - 1].cheminImage);
            myPresenter.add(img);


            probleme.Left = (this.myPresenter.width - img.Width) / 2;
            probleme.Top = img.Top + 200;
            probleme.Text = ListeProb[i - 1].enonce;
            probleme.MaximumSize =new Size(300, 0);
            probleme.AutoSize = true;
            myPresenter.add(probleme);

            reponse1.Top = probleme.Top + 100;
            reponse1.Checked = false;
            reponse1.Left = (this.myPresenter.width - img.Width) / 2;
            reponse1.Text = ListeProb[i - 1].reponse1;
            myPresenter.add(reponse1);
            reponse1.MaximumSize = new Size(300, 0);
            reponse1.AutoSize = true;

            reponse2.Width = 1000;
            reponse2.Top = reponse1.Top + 50;
            reponse2.Left = reponse1.Left;
            reponse2.Checked = false;
            reponse2.Text = ListeProb[i - 1].reponse2;
            reponse2.MaximumSize = new Size(300, 0);
            reponse2.AutoSize = true;
            myPresenter.add(reponse2);


            reponse3.Top = reponse2.Top + 50;
            reponse3.Left = reponse1.Left;
            reponse3.Checked = false;
            reponse3.Text = ListeProb[i - 1].reponse3;
            reponse3.MaximumSize = new Size(300, 0);
            reponse3.AutoSize = true;
            myPresenter.add(reponse3);

            reponse4.Top = reponse3.Top + 50;
            reponse4.Left = reponse1.Left;
            reponse4.Checked = false;
            reponse4.Text = ListeProb[i - 1].reponse4;
            reponse4.MaximumSize = new Size(300, 0);
            reponse4.AutoSize = true;
            myPresenter.add(reponse4);

            reponse4.Width = 1000;
            btn_valider.Text = "Valider";
            btn_valider.Left = img.Left;
            btn_valider.Top = reponse4.Top + 50;
            myPresenter.add(btn_valider);

        }




        private void choosing(object sender, EventArgs e)//on regarde l'action utilisateur
        {

            Button myButton = (Button)sender;

            if (reponse1.Checked == true)
            {
                resReponse = reponse1.Text;
            }
            else if (reponse2.Checked == true)
            {
                resReponse = reponse2.Text;
            }
            else if (reponse3.Checked == true)
            {
                resReponse = reponse3.Text;
            }
            else if (reponse4.Checked == true)
            {
                resReponse = reponse4.Text;
            }
            else
            {
                resReponse = "";
            }


            if (resReponse == ListeProb[i - 1].bonneReponse)
            { goodAnswer++; }
            else
            { }



            if (i < numberOfTest)
            {
                i++;
                this.Process();
            }
            else
            { finTest(); }





        }

        public void finTest()//a la fin du test
        {

            //Affecter les variables de test
            int res = goodAnswer * 100 / numberOfTest;


            MessageBox.Show("Fin du test\nResultat : " + res + "%", "Test problemes ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (type == ProblemType.Mathematic) { 
            if (Difficulty == DifficultyLevel.Easy)
            {
                result[6] = res;
            }
            else
                result[7] = res;
            
        }
            else
            {
                if (Difficulty == DifficultyLevel.Easy)
                {
                    result[8] = res;
                }
                else
                    result[9] = res;
            }
            myPresenter.backTomenu();
        }
    }
}