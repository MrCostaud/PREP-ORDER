namespace PREP_ORDER
{
    partial class confirmation_stockage
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
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 78);
            label1.Name = "label1";
            label1.Size = new Size(1214, 46);
            label1.TabIndex = 0;
            label1.Text = "La palette qui était marqué comme vide a bien été remplie !";
            // 
            // button1
            // 
            button1.Location = new Point(531, 165);
            button1.Name = "button1";
            button1.Size = new Size(243, 85);
            button1.TabIndex = 1;
            button1.Text = "FERMER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // confirmation_stockage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1216, 291);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "confirmation_stockage";
            Text = "confirmation_stockageg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}