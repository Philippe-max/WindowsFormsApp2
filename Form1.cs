using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Label firstClicked = null;

        // secondClicked points to the second Label control 
        // that the player clicks
        System.Windows.Forms.Label secondClicked = null;
        public static int TempsJeu = 0; 

        public Form1()
        {
            InitializeComponent();
            timer2.Start();
            string s = Form2.nomJoueur;
         


        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == true)
                return;
            
            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;
            

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void label15_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == true)
                return;
            
            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void label14_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;


            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void label13_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void label12_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void label11_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void label10_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void label9_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void label8_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void label7_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void label6_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer1.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            int a;
            Random Aleatoire = new Random();
            List<string> ListIcones = new List<string>()
                { "!", "!", "N", "N", ",", ",", "k", "k","b", "b", "v", "v", "w", "w", "z", "z"};
            foreach (Control controle in tableLayoutPanel1.Controls)
                {
                System.Windows.Forms.Label iconLabel = controle as System.Windows.Forms.Label;
                if (iconLabel != null)
                {
                    int randomNumber = Aleatoire.Next(ListIcones.Count);
                    iconLabel.Text = ListIcones[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    ListIcones.RemoveAt(randomNumber);
                }
            }
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TempsJeu = TempsJeu + 1;
            // test si tous les icons sont trouvés
            if ((label1.ForeColor == Color.Black)&& (label2.ForeColor == Color.Black)
                && (label3.ForeColor == Color.Black) && (label4.ForeColor == Color.Black)
                && (label5.ForeColor == Color.Black) && (label6.ForeColor == Color.Black)
                && (label7.ForeColor == Color.Black) && (label8.ForeColor == Color.Black)
                && (label9.ForeColor == Color.Black) && (label10.ForeColor == Color.Black)
                && (label11.ForeColor == Color.Black) && (label12.ForeColor == Color.Black) 
                && (label13.ForeColor == Color.Black) && (label14.ForeColor == Color.Black) 
                && (label15.ForeColor == Color.Black) && (label16.ForeColor == Color.Black))
            {
                timer2.Stop();
                var truc = new Form3Score();
                truc.Show();
                


            }
        }
    }
}
