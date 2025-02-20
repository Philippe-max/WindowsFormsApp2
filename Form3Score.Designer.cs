namespace WindowsFormsApp2
{
    partial class Form3Score
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxNomJoueur = new System.Windows.Forms.TextBox();
            this.textBoxNbre = new System.Windows.Forms.TextBox();
            this.textBoxTemps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxNomJoueur
            // 
            this.txtBoxNomJoueur.Enabled = false;
            this.txtBoxNomJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomJoueur.Location = new System.Drawing.Point(74, 36);
            this.txtBoxNomJoueur.Multiline = true;
            this.txtBoxNomJoueur.Name = "txtBoxNomJoueur";
            this.txtBoxNomJoueur.Size = new System.Drawing.Size(148, 261);
            this.txtBoxNomJoueur.TabIndex = 1;
            // 
            // textBoxNbre
            // 
            this.textBoxNbre.Enabled = false;
            this.textBoxNbre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNbre.Location = new System.Drawing.Point(228, 36);
            this.textBoxNbre.Multiline = true;
            this.textBoxNbre.Name = "textBoxNbre";
            this.textBoxNbre.Size = new System.Drawing.Size(148, 261);
            this.textBoxNbre.TabIndex = 2;
            // 
            // textBoxTemps
            // 
            this.textBoxTemps.Enabled = false;
            this.textBoxTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTemps.Location = new System.Drawing.Point(382, 36);
            this.textBoxTemps.Multiline = true;
            this.textBoxTemps.Name = "textBoxTemps";
            this.textBoxTemps.Size = new System.Drawing.Size(148, 261);
            this.textBoxTemps.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Joueur";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre parties";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Meilleur temps";
            // 
            // Form3Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTemps);
            this.Controls.Add(this.textBoxNbre);
            this.Controls.Add(this.txtBoxNomJoueur);
            this.Name = "Form3Score";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3Score_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxNomJoueur;
        private System.Windows.Forms.TextBox textBoxNbre;
        private System.Windows.Forms.TextBox textBoxTemps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}