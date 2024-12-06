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
            SuspendLayout();
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbNom.ForeColor = SystemColors.ButtonHighlight;
            lbNom.Location = new Point(256, 9);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(316, 65);
            lbNom.TabIndex = 0;
            lbNom.Text = "PREP'ORDER";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(472, 144);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(100, 23);
            tbLogin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(278, 117);
            label1.Name = "label1";
            label1.Size = new Size(181, 65);
            label1.TabIndex = 2;
            label1.Text = "Login :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(112, 222);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(354, 65);
            label2.TabIndex = 3;
            label2.Text = "Mot de passe :";
            // 
            // tbMdp
            // 
            tbMdp.Location = new Point(472, 250);
            tbMdp.Name = "tbMdp";
            tbMdp.Size = new Size(100, 23);
            tbMdp.TabIndex = 4;
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(353, 347);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(138, 49);
            btnConnexion.TabIndex = 5;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConnexion);
            Controls.Add(tbMdp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbLogin);
            Controls.Add(lbNom);
            Name = "Connexion";
            Text = "Connexion";
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
    }
}