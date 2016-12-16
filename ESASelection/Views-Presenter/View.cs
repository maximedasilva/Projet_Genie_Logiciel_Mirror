using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESASelection
{
    public partial class View : Form
    {

        public Presenter myPresenter { get; set; }
        public View()
        {
            Test.initTab();//On initialise le tableau des résultats au lancement
            this.MenuSender();
            myPresenter = new Presenter(this);
        }
        internal void MenuSender()
        {//On initialise le menu et on affecte tous les scores
            InitializeComponent();
            this.resPerceptionF.Text = Test.result[0].ToString();
            this.resPerceptionD.Text = Test.result[1].ToString();
            this.resAttentionF.Text = Test.result[2].ToString();
            this.resAttentionD.Text = Test.result[3].ToString();
            this.resCalculF.Text = Test.result[4].ToString();
            this.resCalculD.Text = Test.result[5].ToString();
            this.resMathsF.Text = Test.result[6].ToString();
            this.resMathsD.Text = Test.result[7].ToString();
            this.resPhysiqueF.Text = Test.result[8].ToString();
            this.resPhysiqueD.Text = Test.result[9].ToString();
        }

        private void launchTestClick(object sender, EventArgs ste)//Lancement d'un test
        {
            Button gave = (Button)sender;
            myPresenter.ClearForm();
            myPresenter.newTest(gave.Name); 
        }
    }
}
