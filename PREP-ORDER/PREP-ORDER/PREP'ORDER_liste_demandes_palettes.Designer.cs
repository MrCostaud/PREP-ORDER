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
            columnIdPalette = new ColumnHeader();
            columnProduit1 = new ColumnHeader();
            columnQte1 = new ColumnHeader();
            columnZone1 = new ColumnHeader();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(140, 65);
            label1.Name = "label1";
            label1.Size = new Size(418, 38);
            label1.TabIndex = 0;
            label1.Text = "Liste des demandes de palettes :";
            // 
            // lvPalettes
            // 
            lvPalettes.Columns.AddRange(new ColumnHeader[] { columnIdPalette, columnProduit1, columnQte1, columnZone1 });
            lvPalettes.Location = new Point(140, 144);
            lvPalettes.Name = "lvPalettes";
            lvPalettes.Size = new Size(418, 242);
            lvPalettes.TabIndex = 1;
            lvPalettes.UseCompatibleStateImageBehavior = false;
            lvPalettes.View = View.Details;
            // 
            // columnIdPalette
            // 
            columnIdPalette.Text = "Numéro de palette";
            columnIdPalette.Width = 120;
            // 
            // columnProduit1
            // 
            columnProduit1.Text = "Produit";
            columnProduit1.Width = 120;
            // 
            // columnQte1
            // 
            columnQte1.Text = "Quantité";
            columnQte1.Width = 180;
            // 
            // columnZone1
            // 
            columnZone1.Text = "Zone de destination";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(640, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(640, 190);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(640, 258);
            button1.Name = "button1";
            button1.Size = new Size(151, 58);
            button1.TabIndex = 4;
            button1.Text = "Notifier comme rempli";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PREP_ORDER_liste_demandes_palettes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(908, 498);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(lvPalettes);
            Controls.Add(label1);
            Name = "PREP_ORDER_liste_demandes_palettes";
            Text = "PREP_ORDER_liste_demandes_palettes";
            Load += PREP_ORDER_liste_demandes_palettes_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvPalettes;
        private ColumnHeader columnIdPalette;
        private ColumnHeader columnProduit1;
        private ColumnHeader columnQte1;
        private ColumnHeader columnZone1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Button button1;
    }
}