namespace BaiKiemTra_WinForm
{
    partial class BangCap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaBangCap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTenBC = new System.Windows.Forms.TextBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.dgvMaBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongSobangCap = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMaBangCap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtTenBC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bằng Cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tìm Kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Bằng Cấp";
            // 
            // lblMaBangCap
            // 
            this.lblMaBangCap.AutoSize = true;
            this.lblMaBangCap.Location = new System.Drawing.Point(152, 54);
            this.lblMaBangCap.Name = "lblMaBangCap";
            this.lblMaBangCap.Size = new System.Drawing.Size(0, 25);
            this.lblMaBangCap.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Bằng Cấp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 30);
            this.textBox1.TabIndex = 0;
            // 
            // txtTenBC
            // 
            this.txtTenBC.Location = new System.Drawing.Point(157, 134);
            this.txtTenBC.Name = "txtTenBC";
            this.txtTenBC.Size = new System.Drawing.Size(166, 30);
            this.txtTenBC.TabIndex = 0;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaBC,
            this.dgvTenBC});
            this.dgvDanhSach.Location = new System.Drawing.Point(420, 75);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(551, 264);
            this.dgvDanhSach.TabIndex = 1;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // dgvMaBC
            // 
            this.dgvMaBC.HeaderText = "Mã Bằng Cấp";
            this.dgvMaBC.MinimumWidth = 6;
            this.dgvMaBC.Name = "dgvMaBC";
            // 
            // dgvTenBC
            // 
            this.dgvTenBC.HeaderText = "Tên Bằng Cấp";
            this.dgvTenBC.MinimumWidth = 6;
            this.dgvTenBC.Name = "dgvTenBC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bằng Cấp";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(37, 355);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 43);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(169, 355);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 43);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(281, 355);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 43);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(886, 427);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 43);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(714, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng Số Bằng Cấp";
            // 
            // lblTongSobangCap
            // 
            this.lblTongSobangCap.AutoSize = true;
            this.lblTongSobangCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSobangCap.Location = new System.Drawing.Point(910, 361);
            this.lblTongSobangCap.Name = "lblTongSobangCap";
            this.lblTongSobangCap.Size = new System.Drawing.Size(27, 25);
            this.lblTongSobangCap.TabIndex = 2;
            this.lblTongSobangCap.Text = "...";
            // 
            // BangCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1069, 561);
            this.Controls.Add(this.lblTongSobangCap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BangCap";
            this.Text = "BangCap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenBC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenBC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongSobangCap;
        private System.Windows.Forms.Label lblMaBangCap;
    }
}