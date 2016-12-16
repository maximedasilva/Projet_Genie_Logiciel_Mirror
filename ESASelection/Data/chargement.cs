using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESASelection
{
   public class chargement
    {
        public int iD { get; private set; }
        public string enonce { get; private set; }
        public string reponse1 { get; private set; }
        public string reponse2 { get; private set; }
        public string reponse3 { get; private set; }
        public string reponse4 { get; private set; }
        public string bonneReponse { get; private set; }
        public string cheminImage { get; private set; }

        public chargement(int i, string e, string rep1, string rep2, string rep3, string rep4, string bonneRep, string cheminimage)
        {//Création du nouveau problème
            iD = i;
            enonce = e;
            reponse1 = rep1;
            reponse2 = rep2;
            reponse3 = rep3;
            reponse4 = rep4;
            bonneReponse = bonneRep;
            cheminImage = cheminimage;
        }

        public override string ToString()
        {
            return "ID : " + iD + "\nEnonce : " + enonce + "\nReponse 1 : " + reponse1 + "\nReponse 2 : " + reponse2 + "\nReponse 3 : " + reponse3 + "\nReponse 4 : " + reponse4 + "\nBonne reponse : " + bonneReponse;
        }
    }
}
