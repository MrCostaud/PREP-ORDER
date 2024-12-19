namespace PREP_ORDER
{
    partial class Gestion_commandes
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
            btnLoad = new Button();
            lvCommande = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lvSec = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            lvLiquide = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            lvDPH = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            btnDivide = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbSec = new ComboBox();
            cbLiquide = new ComboBox();
            cbDPH = new ComboBox();
            label4 = new Label();
            cbMag = new ComboBox();
            btnAdd = new Button();
            lvListComm = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Red;
            btnLoad.ForeColor = SystemColors.ButtonHighlight;
            btnLoad.Location = new Point(519, 671);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(147, 63);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Charger une commande";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // lvCommande
            // 
            lvCommande.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvCommande.Location = new Point(519, 47);
            lvCommande.Name = "lvCommande";
            lvCommande.Size = new Size(506, 618);
            lvCommande.TabIndex = 1;
            lvCommande.UseCompatibleStateImageBehavior = false;
            lvCommande.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Code Produit";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nom Produit";
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Quantité";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Secteur";
            columnHeader4.Width = 80;
            // 
            // lvSec
            // 
            lvSec.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7 });
            lvSec.Location = new Point(1056, 47);
            lvSec.Name = "lvSec";
            lvSec.Size = new Size(407, 173);
            lvSec.TabIndex = 2;
            lvSec.UseCompatibleStateImageBehavior = false;
            lvSec.View = View.Details;
            lvSec.SelectedIndexChanged += lvSec_SelectedIndexChanged;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Code Produit";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Nom Produit";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Quantité";
            columnHeader7.Width = 80;
            // 
            // lvLiquide
            // 
            lvLiquide.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11 });
            lvLiquide.Location = new Point(1056, 270);
            lvLiquide.Name = "lvLiquide";
            lvLiquide.Size = new Size(407, 173);
            lvLiquide.TabIndex = 3;
            lvLiquide.UseCompatibleStateImageBehavior = false;
            lvLiquide.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Code Produit";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Nom Produit";
            columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Quantité";
            columnHeader11.Width = 80;
            // 
            // lvDPH
            // 
            lvDPH.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15 });
            lvDPH.Location = new Point(1056, 492);
            lvDPH.Name = "lvDPH";
            lvDPH.Size = new Size(412, 173);
            lvDPH.TabIndex = 4;
            lvDPH.UseCompatibleStateImageBehavior = false;
            lvDPH.View = View.Details;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Code Produit";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Nom Produit";
            columnHeader14.Width = 200;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Quantité";
            columnHeader15.Width = 80;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Red;
            btnDivide.ForeColor = SystemColors.ButtonHighlight;
            btnDivide.Location = new Point(878, 671);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(147, 63);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "Séparer en sous-commandes";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1056, 24);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 6;
            label1.Text = "Sec :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1056, 247);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 7;
            label2.Text = "Liquide :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(1056, 469);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 8;
            label3.Text = "DPH :";
            // 
            // cbSec
            // 
            cbSec.FormattingEnabled = true;
            cbSec.Location = new Point(1478, 47);
            cbSec.Name = "cbSec";
            cbSec.Size = new Size(151, 28);
            cbSec.TabIndex = 9;
            cbSec.SelectedIndexChanged += cbSec_SelectedIndexChanged;
            // 
            // cbLiquide
            // 
            cbLiquide.FormattingEnabled = true;
            cbLiquide.Location = new Point(1478, 270);
            cbLiquide.Name = "cbLiquide";
            cbLiquide.Size = new Size(151, 28);
            cbLiquide.TabIndex = 10;
            cbLiquide.SelectedIndexChanged += cbLiquide_SelectedIndexChanged;
            // 
            // cbDPH
            // 
            cbDPH.FormattingEnabled = true;
            cbDPH.Location = new Point(1478, 492);
            cbDPH.Name = "cbDPH";
            cbDPH.Size = new Size(151, 28);
            cbDPH.TabIndex = 11;
            cbDPH.SelectedIndexChanged += cbDPH_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(519, 20);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 12;
            label4.Text = "Magasin :";
            // 
            // cbMag
            // 
            cbMag.FormattingEnabled = true;
            cbMag.Location = new Point(597, 16);
            cbMag.Name = "cbMag";
            cbMag.Size = new Size(151, 28);
            cbMag.TabIndex = 13;
            cbMag.SelectedIndexChanged += cbMag_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Red;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(1478, 671);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 63);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Ajouter la commande";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lvListComm
            // 
            lvListComm.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader12, columnHeader16 });
            lvListComm.Location = new Point(29, 47);
            lvListComm.Name = "lvListComm";
            lvListComm.Size = new Size(418, 668);
            lvListComm.TabIndex = 15;
            lvListComm.UseCompatibleStateImageBehavior = false;
            lvListComm.View = View.Details;
            lvListComm.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "N°";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Nom Magasin";
            columnHeader12.Width = 220;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Etat ";
            columnHeader16.Width = 120;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(29, 16);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 16;
            label5.Text = "Liste des commandes :";
            // 
            // Gestion_commandes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            BackgroundImage = Properties.Resources.rackinstallationjpg_6214ed9e3315e;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1662, 740);
            Controls.Add(label5);
            Controls.Add(lvListComm);
            Controls.Add(btnAdd);
            Controls.Add(cbMag);
            Controls.Add(label4);
            Controls.Add(cbDPH);
            Controls.Add(cbLiquide);
            Controls.Add(cbSec);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDivide);
            Controls.Add(btnLoad);
            Controls.Add(lvDPH);
            Controls.Add(lvLiquide);
            Controls.Add(lvSec);
            Controls.Add(lvCommande);
            Name = "Gestion_commandes";
            Text = "Gestion_commandes";
            Load += Gestion_commandes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private ListView lvCommande;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView lvSec;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ListView lvLiquide;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ListView lvDPH;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private Button btnDivide;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbSec;
        private ComboBox cbLiquide;
        private ComboBox cbDPH;
        private Label label4;
        private ComboBox cbMag;
        private Button btnAdd;
        private ListView lvListComm;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader16;
        private Label label5;
    }
}