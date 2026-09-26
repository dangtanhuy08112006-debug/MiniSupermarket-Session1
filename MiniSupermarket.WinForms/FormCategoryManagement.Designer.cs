namespace MiniSupermarket.WinForms
{
    partial class FormCategoryManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtKeyword = new TextBox();
            btnSearch = new Button();
            dgvCategories = new DataGridView();
            btnLoad = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtDescription = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtCategoryName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(44, 85);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(351, 23);
            txtKeyword.TabIndex = 0;
            txtKeyword.Text = "Nhập từ khóa";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(376, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(6, 22);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.Size = new Size(526, 283);
            dgvCategories.TabIndex = 2;
            dgvCategories.CellClick += dgvCategories_CellClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(457, 19);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Tải lại";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Location = new Point(25, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 55);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvCategories);
            groupBox2.Location = new Point(25, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(543, 311);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Nhóm hàng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(txtDescription);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtCategoryName);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtId);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(574, 127);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(221, 311);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin Nhóm hàng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 195);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(77, 195);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(65, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(148, 195);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(6, 150);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(208, 23);
            txtDescription.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(50, 132);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 6;
            label5.Text = "Mô tả chi tiết";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 132);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "Mô tả";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(6, 95);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(208, 23);
            txtCategoryName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(104, 77);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 3;
            label3.Text = "Ví dụ: Bánh kẹo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên Nhóm hàng";
            // 
            // txtId
            // 
            txtId.Location = new Point(6, 40);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(209, 23);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã ID";
            // 
            // FormCategoryManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(txtKeyword);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FormCategoryManagement";
            Text = "FormCategoryManagement";
            Load += FormCategoryManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKeyword;
        private Button btnSearch;
        private DataGridView dgvCategories;
        private Button btnLoad;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private TextBox txtCategoryName;
        private Label label4;
        private TextBox txtDescription;
        private Label label5;
    }
}