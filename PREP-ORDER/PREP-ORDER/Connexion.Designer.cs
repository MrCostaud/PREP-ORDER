namespace PREP_ORDER
{
    partial class Connexion
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
            lbNom = new Label();
            tbLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbMdp = new TextBox();
            btnConnexion = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbNom.ForeColor = SystemColors.ButtonHighlight;
            lbNom.Location = new Point(23, 9);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(317, 65);
            lbNom.TabIndex = 0;
            lbNom.Text = "PREP'ORDER";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(187, 37);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(100, 23);
            tbLogin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(47, 30);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 2;
            label1.Text = "Identifiant :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(17, 86);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(164, 30);
            label2.TabIndex = 3;
            label2.Text = "Mot de passe :";
            // 
            // tbMdp
            // 
            tbMdp.Location = new Point(187, 95);
            tbMdp.Name = "tbMdp";
            tbMdp.Size = new Size(100, 23);
            tbMdp.TabIndex = 4;
            // 
            // btnConnexion
            // 
            btnConnexion.BackColor = Color.Blue;
            btnConnexion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnexion.ForeColor = SystemColors.ButtonHighlight;
            btnConnexion.Location = new Point(99, 170);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(138, 49);
            btnConnexion.TabIndex = 5;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Navy;
            groupBox1.Controls.Add(btnConnexion);
            groupBox1.Controls.Add(tbLogin);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbMdp);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 239);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Se connecter";
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(355, 327);
            Controls.Add(lbNom);
            Controls.Add(groupBox1);
            Name = "Connexion";
            Text = "Connexion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNom;
        private TextBox tbLogin;
        private Label label1;
        private Label label2;
        private TextBox tbMdp;
        private Button btnConnexion;
        private GroupBox groupBox1;
    }
}