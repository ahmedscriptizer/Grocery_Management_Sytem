namespace db2
{
    partial class Cheez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cheez));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnView = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            btnSearch = new Button();
            label6 = new Label();
            txtSearchbar = new TextBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            txtCode = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(211, 9);
            label1.Name = "label1";
            label1.Size = new Size(393, 40);
            label1.TabIndex = 0;
            label1.Text = "Product Management ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 182);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 224);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Category";
            // 
            // txtName
            // 
            txtName.Location = new Point(75, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 5;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(75, 141);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 6;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(75, 179);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(121, 23);
            txtQuantity.TabIndex = 7;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Electronics", "furniture", "Accesories", "Clothing" });
            comboBox1.Location = new Point(75, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 270);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(121, 270);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(245, 84);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 35);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources._3439691;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Location = new Point(245, 141);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 35);
            btnDelete.TabIndex = 12;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(245, 202);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 37);
            btnView.TabIndex = 13;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSearchbar);
            groupBox1.Location = new Point(13, 344);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 45);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(279, 19);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 19;
            label8.Text = "Enter Product Code !!!";
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Location = new Point(233, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(31, 23);
            btnSearch.TabIndex = 18;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 19);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 17;
            label6.Text = "Search";
            // 
            // txtSearchbar
            // 
            txtSearchbar.Location = new Point(63, 16);
            txtSearchbar.Name = "txtSearchbar";
            txtSearchbar.Size = new Size(155, 23);
            txtSearchbar.TabIndex = 16;
            txtSearchbar.Text = " ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 395);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(791, 72);
            dataGridView1.TabIndex = 16;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 65);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 18;
            label7.Text = "Product Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(96, 62);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(100, 23);
            txtCode.TabIndex = 19;
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.l_intro_1681327495;
            pictureBox1.Location = new Point(362, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 273);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // Cheez
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(858, 630);
            Controls.Add(pictureBox1);
            Controls.Add(txtCode);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cheez";
            Text = "Cheez";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnView;
        private GroupBox groupBox1;
        private TextBox txtSearchbar;
        private DataGridView dataGridView1;
        private Label label6;
        private Button btnSearch;
        private Label label7;
        private TextBox txtCode;
        private Label label8;
        private PictureBox pictureBox1;
    }
}