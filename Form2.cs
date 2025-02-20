using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public static string nomJoueur;
        private void button1_Click(object sender, EventArgs e)
        {
 
            nomJoueur = textBox1.Text;

            var truc = new Form1();
            truc.Show();
        }
    }
}
