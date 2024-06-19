namespace db2
{
    partial class Emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp));
            txtRegistrationCode = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label5 = new Label();
            btnSearch = new Button();
            label6 = new Label();
            txtSearchbar = new TextBox();
            btnView = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            btnAdd = new Button();
            comboPosition = new ComboBox();
            txtContact = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtRegistrationCode
            // 
            txtRegistrationCode.Location = new Point(72, 62);
            txtRegistrationCode.Name = "txtRegistrationCode";
            txtRegistrationCode.Size = new Size(121, 23);
            txtRegistrationCode.TabIndex = 37;
            txtRegistrationCode.TextChanged += txtRegistrationCode_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 65);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 36;
            label7.Text = "Emp Reg";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 361);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(829, 118);
            dataGridView1.TabIndex = 35;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSearchbar);
            groupBox1.Location = new Point(12, 310);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 45);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(280, 19);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 38;
            label5.Text = "Enter Reg no !!!";
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
            txtSearchbar.Location = new Point(72, 16);
            txtSearchbar.Name = "txtSearchbar";
            txtSearchbar.Size = new Size(155, 23);
            txtSearchbar.TabIndex = 16;
            txtSearchbar.Text = " ";
            // 
            // btnView
            // 
            btnView.Location = new Point(229, 202);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 37);
            btnView.TabIndex = 33;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(229, 141);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 35);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(229, 84);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 35);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(118, 226);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 30;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 226);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboPosition
            // 
            comboPosition.FormattingEnabled = true;
            comboPosition.Items.AddRange(new object[] { "CEO", "HR", "Shebaz Shareef", "Manager", "Nikama" });
            comboPosition.Location = new Point(72, 141);
            comboPosition.Name = "comboPosition";
            comboPosition.Size = new Size(121, 23);
            comboPosition.TabIndex = 28;
            comboPosition.SelectedIndexChanged += comboPosition_SelectedIndexChanged;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(72, 179);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(121, 23);
            txtContact.TabIndex = 27;
            txtContact.TextChanged += txtContact_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(72, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 25;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 179);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 23;
            label4.Text = "Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 22;
            label3.Text = "Position";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 21;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(200, 9);
            label1.Name = "label1";
            label1.Size = new Size(407, 40);
            label1.TabIndex = 20;
            label1.Text = "Employee Management ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._360_F_652332193_1WzQanKdUBIUieRcuWlgdaCP9aoxFtmy;
            pictureBox1.Location = new Point(329, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(506, 261);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // Emp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(847, 566);
            Controls.Add(pictureBox1);
            Controls.Add(txtRegistrationCode);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(comboPosition);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Emp";
            Text = "Emp";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRegistrationCode;
        private Label label7;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnSearch;
        private Label label6;
        private TextBox txtSearchbar;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnBack;
        private Button btnAdd;
        private ComboBox comboPosition;
        private TextBox txtContact;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private PictureBox pictureBox1;
    }
}