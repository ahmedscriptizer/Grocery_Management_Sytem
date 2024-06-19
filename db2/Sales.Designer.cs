namespace db2
{
    partial class Sales
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
            label2 = new Label();
            label3 = new Label();
            txtProductsSold = new TextBox();
            txtTotalSales = new TextBox();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 40);
            label1.TabIndex = 0;
            label1.Text = "Sales Analysis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Typewriter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 161);
            label2.Name = "label2";
            label2.Size = new Size(322, 23);
            label2.TabIndex = 1;
            label2.Text = "Total products Purchased";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Typewriter", 15.75F, FontStyle.Bold);
            label3.Location = new Point(36, 252);
            label3.Name = "label3";
            label3.Size = new Size(231, 23);
            label3.TabIndex = 2;
            label3.Text = "Total Sales Today";
            // 
            // txtProductsSold
            // 
            txtProductsSold.Location = new Point(374, 165);
            txtProductsSold.Name = "txtProductsSold";
            txtProductsSold.Size = new Size(217, 23);
            txtProductsSold.TabIndex = 3;
            txtProductsSold.TextChanged += txtProductsSold_TextChanged;
            // 
            // txtTotalSales
            // 
            txtTotalSales.Location = new Point(374, 252);
            txtTotalSales.Name = "txtTotalSales";
            txtTotalSales.Size = new Size(217, 23);
            txtTotalSales.TabIndex = 4;
            txtTotalSales.TextChanged += txtTotalSales_TextChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(36, 332);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.screen_0;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._562_5628859_respect_gta_mission_passed_transparent_background_hd_png;
            pictureBox2.Location = new Point(234, 316);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(348, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.aBr1EYx_460s;
            pictureBox3.Location = new Point(528, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(270, 135);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(txtTotalSales);
            Controls.Add(txtProductsSold);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sales";
            Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProductsSold;
        private TextBox txtTotalSales;
        private Button btnBack;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}