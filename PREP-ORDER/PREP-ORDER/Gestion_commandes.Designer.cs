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
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 666);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(147, 63);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Charger une commande";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lvCommande
            // 
            lvCommande.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvCommande.Location = new Point(12, 53);
            lvCommande.Name = "lvCommande";
            lvCommande.Size = new Size(506, 607);
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
            lvSec.Location = new Point(549, 42);
            lvSec.Name = "lvSec";
            lvSec.Size = new Size(407, 195);
            lvSec.TabIndex = 2;
            lvSec.UseCompatibleStateImageBehavior = false;
            lvSec.View = View.Details;
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
            lvLiquide.Location = new Point(549, 286);
            lvLiquide.Name = "lvLiquide";
            lvLiquide.Size = new Size(407, 196);
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
            lvDPH.Location = new Point(549, 535);
            lvDPH.Name = "lvDPH";
            lvDPH.Size = new Size(412, 194);
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
            btnDivide.Location = new Point(371, 666);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(147, 63);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "Séparer en sous-commandes";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 6;
            label1.Text = "Sec :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 263);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 7;
            label2.Text = "Liquide :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 512);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "DPH :";
            // 
            // cbSec
            // 
            cbSec.FormattingEnabled = true;
            cbSec.Location = new Point(971, 42);
            cbSec.Name = "cbSec";
            cbSec.Size = new Size(151, 28);
            cbSec.TabIndex = 9;
            cbSec.SelectedIndexChanged += cbSec_SelectedIndexChanged;
            // 
            // cbLiquide
            // 
            cbLiquide.FormattingEnabled = true;
            cbLiquide.Location = new Point(971, 286);
            cbLiquide.Name = "cbLiquide";
            cbLiquide.Size = new Size(151, 28);
            cbLiquide.TabIndex = 10;
            cbLiquide.SelectedIndexChanged += cbLiquide_SelectedIndexChanged;
            // 
            // cbDPH
            // 
            cbDPH.FormattingEnabled = true;
            cbDPH.Location = new Point(971, 535);
            cbDPH.Name = "cbDPH";
            cbDPH.Size = new Size(151, 28);
            cbDPH.TabIndex = 11;
            cbDPH.SelectedIndexChanged += cbDPH_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 23);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 12;
            label4.Text = "Magasin :";
            // 
            // cbMag
            // 
            cbMag.FormattingEnabled = true;
            cbMag.Location = new Point(91, 19);
            cbMag.Name = "cbMag";
            cbMag.Size = new Size(151, 28);
            cbMag.TabIndex = 13;
            cbMag.SelectedIndexChanged += cbMag_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1121, 630);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(294, 99);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Ajouter la commande";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Gestion_commandes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 741);
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
    }
}