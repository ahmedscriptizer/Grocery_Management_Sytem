namespace db2
{
    partial class Custom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Custom));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCode = new TextBox();
            txtName = new TextBox();
            txtContact = new TextBox();
            txtStatus = new TextBox();
            btnADD = new Button();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            label6 = new Label();
            txtSearchbar = new TextBox();
            btnView = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
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
            label1.Location = new Point(188, 9);
            label1.Name = "label1";
            label1.Size = new Size(405, 40);
            label1.TabIndex = 0;
            label1.Text = "Customer Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 153);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 190);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "status";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(63, 71);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(100, 23);
            txtCode.TabIndex = 5;
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(63, 108);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 6;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(63, 150);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(100, 23);
            txtContact.TabIndex = 7;
            txtContact.TextChanged += txtContact_TextChanged;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(63, 187);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 8;
            txtStatus.TextChanged += txtStatus_TextChanged;
            // 
            // btnADD
            // 
            btnADD.Location = new Point(10, 236);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(75, 23);
            btnADD.TabIndex = 9;
            btnADD.Text = "add";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnADD_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(107, 236);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 10;
            btnBack.Text = "back";
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSearchbar);
            groupBox1.Location = new Point(12, 361);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 45);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
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
            label6.Location = new Point(15, 19);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 17;
            label6.Text = "Search";
            // 
            // txtSearchbar
            // 
            txtSearchbar.Location = new Point(72, 15);
            txtSearchbar.Name = "txtSearchbar";
            txtSearchbar.Size = new Size(155, 23);
            txtSearchbar.TabIndex = 16;
            txtSearchbar.Text = " ";
            // 
            // btnView
            // 
            btnView.Location = new Point(197, 182);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 37);
            btnView.TabIndex = 19;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources._3439691;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Location = new Point(197, 121);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 35);
            btnDelete.TabIndex = 18;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(197, 64);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 35);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 412);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(771, 116);
            dataGridView1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(283, 19);
            label7.Name = "label7";
            label7.Size = new Size(103, 15);
            label7.TabIndex = 21;
            label7.Text = "Enter Code only !!!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.customer_shopping_grocery_store;
            pictureBox1.Location = new Point(278, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 303);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Custom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 595);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Controls.Add(btnADD);
            Controls.Add(txtStatus);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Custom";
            Text = "Custom";
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
        private TextBox txtCode;
        private TextBox txtName;
        private TextBox txtContact;
        private TextBox txtStatus;
        private Button btnADD;
        private Button btnBack;
        private GroupBox groupBox1;
        private Button btnSearch;
        private Label label6;
        private TextBox txtSearchbar;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private Label label7;
        private PictureBox pictureBox1;
    }
}