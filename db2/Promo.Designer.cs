namespace db2
{
    partial class Promo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Promo));
            txtCode = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label8 = new Label();
            btnSearch = new Button();
            label6 = new Label();
            txtSearchbar = new TextBox();
            btnView = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            btnAdd = new Button();
            txtBrand = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(85, 91);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(113, 23);
            txtCode.TabIndex = 37;
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 95);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 36;
            label7.Text = "Promo Code";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 413);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(828, 193);
            dataGridView1.TabIndex = 35;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSearchbar);
            groupBox1.Location = new Point(12, 347);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 45);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(279, 19);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 19;
            label8.Text = "Enter promo Code !!!";
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
            txtSearchbar.TextChanged += txtSearchbar_TextChanged;
            // 
            // btnView
            // 
            btnView.Location = new Point(237, 202);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 37);
            btnView.TabIndex = 33;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(237, 141);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 35);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(237, 84);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 35);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(113, 262);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 30;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 262);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(84, 197);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(121, 23);
            txtBrand.TabIndex = 26;
            txtBrand.TextChanged += txtBrand_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(84, 141);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(121, 23);
            txtDescription.TabIndex = 25;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 141);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 21;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 9);
            label1.Name = "label1";
            label1.Size = new Size(339, 40);
            label1.TabIndex = 20;
            label1.Text = "Brands Promotion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 205);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 22;
            label3.Text = "Brand Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Brand_Promotion_Explained;
            pictureBox1.Location = new Point(363, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(470, 294);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // Promo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(855, 630);
            Controls.Add(pictureBox1);
            Controls.Add(txtCode);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(txtBrand);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Promo";
            Text = "Promo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private Label label7;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label8;
        private Button btnSearch;
        private Label label6;
        private TextBox txtSearchbar;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnBack;
        private Button btnAdd;
        private TextBox txtBrand;
        private TextBox txtDescription;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}