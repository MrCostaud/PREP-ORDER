namespace PREP_ORDER
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(224, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1089, 400);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(349, 12);
            label1.Name = "label1";
            label1.Size = new Size(579, 26);
            label1.TabIndex = 1;
            label1.Text = "Commandes assignées à leur zone de préparation";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ZONE A", "ZONE B", "ZONE C" });
            comboBox1.Location = new Point(720, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._54fe1c6deb3c5_intermarche2180x1501;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 139);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(384, 73);
            label2.Name = "label2";
            label2.Size = new Size(292, 22);
            label2.TabIndex = 4;
            label2.Text = "Trier par zone de préparation :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 575);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}