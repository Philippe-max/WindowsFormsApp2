using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace WindowsFormsApp2
{
    public partial class Form3Score : Form
    {
        public Form3Score()
        {
            InitializeComponent();
        }

        private void Form3Score_Load(object sender, EventArgs e)
        {
            //lecture fichier noms des joueurs
            StreamReader sr1 = new StreamReader("C:\\Users\\Thierry\\Desktop\\Scores\\NomScores.txt");
            string strFichier = "";
            string[] StrScoreS;
            int iDejaJoueur = 100;
            int iTemps = 0;


            strFichier = sr1.ReadLine();
            sr1.Close();
            // recherche si joueur deja existant
            
            StrScoreS = strFichier.Split(';');
            int iLongueurTab = 0;
            iLongueurTab = StrScoreS.Length;
            for ( int i = 0; i<iLongueurTab-1; i++)
            {
                //
                if (StrScoreS[i]== Form2.nomJoueur)
                {
                    iDejaJoueur = i;
                }
            }
            if (iDejaJoueur == 100 )
            {
                //joueur n est pas dans le fichier, on le rajoute a la fin de la chaine
                strFichier = strFichier + ";" + Form2.nomJoueur+";1;"+Form1.TempsJeu  ;

            }
            else
            {
                //joueur dans le fichier,
                
                //ajout d'une partie
                StrScoreS[iDejaJoueur + 1] = (Int32.Parse(StrScoreS[iDejaJoueur + 1]) + 1).ToString();
                // modification meileurs temps
                iTemps = Int32.Parse(StrScoreS[iDejaJoueur + 2]);
                if ( iTemps > Form1.TempsJeu)
                {
                        StrScoreS[iDejaJoueur+2]  = Form1.TempsJeu.ToString();
                }
                //re-creation de la chaine strFichier
                strFichier = "";
                foreach (var StrScore in StrScoreS)
                {
                    strFichier= strFichier + StrScore.ToString() + ";";
                }
            }


            

            int indexScore = 0;
            StrScoreS = strFichier.Split(';');
            foreach (var StrScore in StrScoreS)
            //affichage des noms dans le textbox
            {
                if ( indexScore == 0 || indexScore == 3 || indexScore == 6 || indexScore == 9 || indexScore == 12 || indexScore == 15
                    || indexScore == 18 || indexScore == 21 || indexScore == 24 || indexScore == 27 || indexScore == 30)
                {
                    txtBoxNomJoueur.Text = txtBoxNomJoueur.Text + StrScore + Environment.NewLine;
                }
                if (indexScore == 1 || indexScore == 4 || indexScore == 7 || indexScore == 10 || indexScore == 13 || indexScore == 16
                    || indexScore == 19 || indexScore == 22 || indexScore == 25 || indexScore == 28 || indexScore == 31)
                { 
                    textBoxNbre.Text = textBoxNbre.Text + StrScore + Environment.NewLine;
                }
                if (indexScore == 2 || indexScore == 5 || indexScore == 8 || indexScore == 11 || indexScore == 14 || indexScore == 17
                    || indexScore == 20 || indexScore == 23 || indexScore == 28 || indexScore == 29 || indexScore == 32)
                {
                    textBoxTemps.Text = textBoxTemps.Text + StrScore + Environment.NewLine;
                }
                indexScore++;
            }
                



            // ecriture fichier
            StreamWriter sw = File.CreateText("C:\\Users\\Thierry\\Desktop\\Scores\\NomScores.txt");

            sw.WriteLine(strFichier);


            sw.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
