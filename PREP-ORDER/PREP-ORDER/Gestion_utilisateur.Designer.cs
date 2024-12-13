namespace PREP_ORDER
{
    partial class Gestion_utilisateur
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
            lvUser = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1 = new GroupBox();
            btnUpdate = new Button();
            cbSecteur = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            tbLogin = new TextBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            cbSecteurAdd = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            tbLoginAdd = new TextBox();
            cbRoleAdd = new ComboBox();
            label5 = new Label();
            tbMdpAdd = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lvUser
            // 
            lvUser.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvUser.Location = new Point(12, 12);
            lvUser.Name = "lvUser";
            lvUser.Size = new Size(375, 426);
            lvUser.TabIndex = 0;
            lvUser.UseCompatibleStateImageBehavior = false;
            lvUser.View = View.Details;
            lvUser.SelectedIndexChanged += lvUser_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Numéro";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Identifiant";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Rôle";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Zone";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(cbSecteur);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbLogin);
            groupBox1.Location = new Point(393, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 159);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modification d'un utilisateur";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(97, 112);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(149, 41);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Sauvegarder les modifications";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbSecteur
            // 
            cbSecteur.FormattingEnabled = true;
            cbSecteur.Location = new Point(97, 70);
            cbSecteur.Name = "cbSecteur";
            cbSecteur.Size = new Size(121, 23);
            cbSecteur.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 73);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "Secteur :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "Identifiant :";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(97, 34);
            tbLogin.MaxLength = 50;
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(276, 23);
            tbLogin.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbMdpAdd);
            groupBox2.Controls.Add(cbRoleAdd);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(cbSecteurAdd);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbLoginAdd);
            groupBox2.Location = new Point(393, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(403, 251);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ajout d'un utilisateur";
            // 
            // button1
            // 
            button1.Location = new Point(97, 204);
            button1.Name = "button1";
            button1.Size = new Size(149, 41);
            button1.TabIndex = 2;
            button1.Text = "Ajouter l'utilisateur";
            button1.UseVisualStyleBackColor = true;
            // 
            // cbSecteurAdd
            // 
            cbSecteurAdd.FormattingEnabled = true;
            cbSecteurAdd.Location = new Point(97, 153);
            cbSecteurAdd.Name = "cbSecteurAdd";
            cbSecteurAdd.Size = new Size(121, 23);
            cbSecteurAdd.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 156);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 6;
            label2.Text = "Secteur :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 37);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Identifiant :";
            // 
            // tbLoginAdd
            // 
            tbLoginAdd.Location = new Point(97, 34);
            tbLoginAdd.MaxLength = 50;
            tbLoginAdd.Name = "tbLoginAdd";
            tbLoginAdd.Size = new Size(276, 23);
            tbLoginAdd.TabIndex = 2;
            // 
            // cbRoleAdd
            // 
            cbRoleAdd.FormattingEnabled = true;
            cbRoleAdd.Location = new Point(97, 112);
            cbRoleAdd.Name = "cbRoleAdd";
            cbRoleAdd.Size = new Size(121, 23);
            cbRoleAdd.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 115);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Rôle :";
            // 
            // tbMdpAdd
            // 
            tbMdpAdd.Location = new Point(97, 74);
            tbMdpAdd.MaxLength = 50;
            tbMdpAdd.Name = "tbMdpAdd";
            tbMdpAdd.Size = new Size(276, 23);
            tbMdpAdd.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 77);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 11;
            label6.Text = "Mot de passe :";
            // 
            // Gestion_utilisateur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lvUser);
            Name = "Gestion_utilisateur";
            Text = "Gestion_utilisateur";
            Load += Gestion_utilisateur_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        public ListView lvUser;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbLogin;
        private Button btnUpdate;
        private ComboBox cbSecteur;
        private Label label3;
        private GroupBox groupBox2;
        private Button button1;
        private ComboBox cbSecteurAdd;
        private Label label2;
        private Label label4;
        private TextBox tbLoginAdd;
        private Label label6;
        private TextBox tbMdpAdd;
        private ComboBox cbRoleAdd;
        private Label label5;
    }
}