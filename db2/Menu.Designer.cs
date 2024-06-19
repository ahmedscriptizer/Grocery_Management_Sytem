namespace db2
{
    partial class Menu
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
            product = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 20);
            label1.Name = "label1";
            label1.Size = new Size(175, 40);
            label1.TabIndex = 0;
            label1.Text = "AL-Fatah ";
            // 
            // product
            // 
            product.BackColor = SystemColors.ActiveBorder;
            product.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            product.Location = new Point(117, 99);
            product.Name = "product";
            product.Size = new Size(100, 41);
            product.TabIndex = 1;
            product.Text = "Products";
            product.UseVisualStyleBackColor = false;
            product.Click += product_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(314, 99);
            button2.Name = "button2";
            button2.Size = new Size(112, 41);
            button2.TabIndex = 1;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(506, 99);
            button3.Name = "button3";
            button3.Size = new Size(111, 41);
            button3.TabIndex = 1;
            button3.Text = "Employee";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(100, 182);
            button4.Name = "button4";
            button4.Size = new Size(117, 41);
            button4.TabIndex = 1;
            button4.Text = "Promotion";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(302, 182);
            button5.Name = "button5";
            button5.Size = new Size(137, 41);
            button5.TabIndex = 1;
            button5.Text = "Login Panel";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveBorder;
            button6.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(506, 182);
            button6.Name = "button6";
            button6.Size = new Size(111, 41);
            button6.TabIndex = 1;
            button6.Text = "Feedback";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveBorder;
            button7.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(100, 263);
            button7.Name = "button7";
            button7.Size = new Size(117, 41);
            button7.TabIndex = 1;
            button7.Text = "Inventory";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaption;
            button8.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(314, 263);
            button8.Name = "button8";
            button8.Size = new Size(100, 41);
            button8.TabIndex = 1;
            button8.Text = "sales";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveBorder;
            button9.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(506, 263);
            button9.Name = "button9";
            button9.Size = new Size(100, 41);
            button9.TabIndex = 1;
            button9.Text = "supplier";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(product);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button product;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}