namespace PREP_ORDER
{
    partial class PREP_ORDER_liste_demandes_palettes
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
            label1 = new Label();
            lvPalettes = new ListView();
            columnProduit = new ColumnHeader();
            columnQte = new ColumnHeader();
            columnZone = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(258, 50);
            label1.Name = "label1";
            label1.Size = new Size(418, 38);
            label1.TabIndex = 0;
            label1.Text = "Liste des demandes de palettes :";
            // 
            // lvPalettes
            // 
            lvPalettes.Columns.AddRange(new ColumnHeader[] { columnProduit, columnQte, columnZone });
            lvPalettes.Location = new Point(258, 129);
            lvPalettes.Name = "lvPalettes";
            lvPalettes.Size = new Size(418, 242);
            lvPalettes.TabIndex = 1;
            lvPalettes.UseCompatibleStateImageBehavior = false;
            lvPalettes.View = View.Details;
            // 
            // columnProduit
            // 
            columnProduit.Text = "Produit";
            columnProduit.Width = 120;
            // 
            // columnQte
            // 
            columnQte.Text = "Quantité";
            columnQte.Width = 120;
            // 
            // columnZone
            // 
            columnZone.Text = "Zone de destination";
            columnZone.Width = 180;
            // 
            // PREP_ORDER_liste_demandes_palettes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(908, 498);
            Controls.Add(lvPalettes);
            Controls.Add(label1);
            Name = "PREP_ORDER_liste_demandes_palettes";
            Text = "PREP_ORDER_liste_demandes_palettes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvPalettes;
        private ColumnHeader columnProduit;
        private ColumnHeader columnQte;
        private ColumnHeader columnZone;
    }
}