namespace db2
{
    partial class Invent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invent));
            txtCode = new TextBox();
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
            txtLocation = new TextBox();
            txtStock = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(77, 127);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(121, 23);
            txtCode.TabIndex = 53;
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 127);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 52;
            label7.Text = "Code";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(337, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(493, 117);
            dataGridView1.TabIndex = 51;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSearchbar);
            groupBox1.Location = new Point(17, 320);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 45);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(280, 19);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 38;
            label5.Text = "Enter Code !!!";
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
            btnView.Location = new Point(234, 256);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 37);
            btnView.TabIndex = 49;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(234, 185);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 35);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(234, 127);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 35);
            btnUpdate.TabIndex = 47;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(123, 270);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 46;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 270);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 45;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(77, 221);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(121, 23);
            txtLocation.TabIndex = 43;
            txtLocation.TextChanged += txtLocation_TextChanged;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(77, 171);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(121, 23);
            txtStock.TabIndex = 42;
            txtStock.TextChanged += txtStock_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 224);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 41;
            label4.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 174);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 39;
            label2.Text = "Qty_stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 40);
            label1.Name = "label1";
            label1.Size = new Size(364, 40);
            label1.TabIndex = 38;
            label1.Text = "Inventory Handling";
            // 
            // Invent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.store_5619201_1920;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(861, 572);
            Controls.Add(txtCode);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(txtLocation);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Invent";
            Text = "Invent";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private Label label7;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label5;
        private Button btnSearch;
        private Label label6;
        private TextBox txtSearchbar;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnBack;
        private Button btnAdd;
        private TextBox txtLocation;
        private TextBox txtStock;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}