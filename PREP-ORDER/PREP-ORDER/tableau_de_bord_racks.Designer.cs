namespace PREP_ORDER
{
    partial class tableau_de_bord_racks
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
            listView1 = new ListView();
            libelleZone = new ColumnHeader();
            emplacementPalette = new ColumnHeader();
            libelleProduit = new ColumnHeader();
            qtLotProduit = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { libelleZone, emplacementPalette, libelleProduit, qtLotProduit });
            listView1.Location = new Point(43, 52);
            listView1.Name = "listView1";
            listView1.Size = new Size(496, 349);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // libelleZone
            // 
            libelleZone.Text = "Zone";
            // 
            // emplacementPalette
            // 
            emplacementPalette.Text = "Emplacement";
            emplacementPalette.Width = 150;
            // 
            // libelleProduit
            // 
            libelleProduit.Text = "Produit";
            libelleProduit.Width = 100;
            // 
            // qtLotProduit
            // 
            qtLotProduit.Text = "Quantité disponible";
            qtLotProduit.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(728, 205);
            button1.Name = "button1";
            button1.Size = new Size(177, 60);
            button1.TabIndex = 1;
            button1.Text = "Afficher les demandes de palettes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableau_de_bord_racks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1043, 521);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "tableau_de_bord_racks";
            Text = "tableau_de_bord_racks";
            Load += tableau_de_bord_racks_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader libelleZone;
        private ColumnHeader emplacementPalette;
        private ColumnHeader libelleProduit;
        private ColumnHeader qtLotProduit;
        private Button button1;
    }
}