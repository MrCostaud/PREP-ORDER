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
            label6 = new Label();
            tbMdpAdd = new TextBox();
            cbRoleAdd = new ComboBox();
            label5 = new Label();
            btnAdd = new Button();
            cbSecteurAdd = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            tbLoginAdd = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lvUser
            // 
            lvUser.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvUser.Location = new Point(14, 16);
            lvUser.Margin = new Padding(3, 4, 3, 4);
            lvUser.Name = "lvUser";
            lvUser.Size = new Size(428, 567);
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
            groupBox1.Location = new Point(449, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(461, 212);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modification d'un utilisateur";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(111, 149);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(170, 55);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Sauvegarder les modifications";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbSecteur
            // 
            cbSecteur.FormattingEnabled = true;
            cbSecteur.Location = new Point(111, 93);
            cbSecteur.Margin = new Padding(3, 4, 3, 4);
            cbSecteur.Name = "cbSecteur";
            cbSecteur.Size = new Size(138, 28);
            cbSecteur.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 97);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 6;
            label3.Text = "Secteur :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 49);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 3;
            label1.Text = "Identifiant :";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(111, 45);
            tbLogin.Margin = new Padding(3, 4, 3, 4);
            tbLogin.MaxLength = 50;
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(315, 27);
            tbLogin.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbMdpAdd);
            groupBox2.Controls.Add(cbRoleAdd);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(cbSecteurAdd);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbLoginAdd);
            groupBox2.Location = new Point(449, 249);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(461, 335);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ajout d'un utilisateur";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 103);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 11;
            label6.Text = "Mot de passe :";
            // 
            // tbMdpAdd
            // 
            tbMdpAdd.Location = new Point(111, 100);
            tbMdpAdd.Margin = new Padding(3, 4, 3, 4);
            tbMdpAdd.MaxLength = 50;
            tbMdpAdd.Name = "tbMdpAdd";
            tbMdpAdd.PasswordChar = '●';
            tbMdpAdd.Size = new Size(315, 27);
            tbMdpAdd.TabIndex = 10;
            // 
            // cbRoleAdd
            // 
            cbRoleAdd.FormattingEnabled = true;
            cbRoleAdd.Location = new Point(111, 149);
            cbRoleAdd.Margin = new Padding(3, 4, 3, 4);
            cbRoleAdd.Name = "cbRoleAdd";
            cbRoleAdd.Size = new Size(138, 28);
            cbRoleAdd.TabIndex = 9;
            cbRoleAdd.SelectedIndexChanged += cbRoleAdd_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 153);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "Rôle :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(111, 272);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 55);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Ajouter l'utilisateur";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbSecteurAdd
            // 
            cbSecteurAdd.FormattingEnabled = true;
            cbSecteurAdd.Location = new Point(111, 204);
            cbSecteurAdd.Margin = new Padding(3, 4, 3, 4);
            cbSecteurAdd.Name = "cbSecteurAdd";
            cbSecteurAdd.Size = new Size(138, 28);
            cbSecteurAdd.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 208);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 6;
            label2.Text = "Secteur :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 49);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Identifiant :";
            // 
            // tbLoginAdd
            // 
            tbLoginAdd.Location = new Point(111, 45);
            tbLoginAdd.Margin = new Padding(3, 4, 3, 4);
            tbLoginAdd.MaxLength = 50;
            tbLoginAdd.Name = "tbLoginAdd";
            tbLoginAdd.Size = new Size(315, 27);
            tbLoginAdd.TabIndex = 2;
            // 
            // Gestion_utilisateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lvUser);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnAdd;
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