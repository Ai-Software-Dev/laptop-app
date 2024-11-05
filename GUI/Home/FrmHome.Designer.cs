namespace GUI.Home
{
    partial class FrmHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_statistical = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btnClose1 = new Component.btnClose();
            this.btn_logout = new Component.CustomButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose1);
            this.panel1.Location = new System.Drawing.Point(198, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 56);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ CỬA HÀNG KINH DOANH LAPTOP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_statistical);
            this.panel2.Controls.Add(this.btn_report);
            this.panel2.Controls.Add(this.btn_category);
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Controls.Add(this.btn_customer);
            this.panel2.Controls.Add(this.btn_product);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 759);
            this.panel2.TabIndex = 1;
            // 
            // btn_statistical
            // 
            this.btn_statistical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_statistical.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistical.Image = global::GUI.Properties.Resources.barchart24;
            this.btn_statistical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_statistical.Location = new System.Drawing.Point(2, 499);
            this.btn_statistical.Name = "btn_statistical";
            this.btn_statistical.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_statistical.Size = new System.Drawing.Size(200, 50);
            this.btn_statistical.TabIndex = 7;
            this.btn_statistical.Text = "Thông kê";
            this.btn_statistical.UseVisualStyleBackColor = false;
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_report.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Image = global::GUI.Properties.Resources.printer24;
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Location = new System.Drawing.Point(2, 444);
            this.btn_report.Name = "btn_report";
            this.btn_report.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_report.Size = new System.Drawing.Size(199, 49);
            this.btn_report.TabIndex = 6;
            this.btn_report.Text = "Báo cáo";
            this.btn_report.UseVisualStyleBackColor = false;
            // 
            // btn_category
            // 
            this.btn_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_category.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_category.Image = global::GUI.Properties.Resources.category24;
            this.btn_category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_category.Location = new System.Drawing.Point(3, 281);
            this.btn_category.Name = "btn_category";
            this.btn_category.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_category.Size = new System.Drawing.Size(199, 49);
            this.btn_category.TabIndex = 5;
            this.btn_category.Text = "Danh mục";
            this.btn_category.UseVisualStyleBackColor = false;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_home.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Image = global::GUI.Properties.Resources.home24;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(3, 226);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(199, 49);
            this.btn_home.TabIndex = 4;
            this.btn_home.Text = "Trang chủ";
            this.btn_home.UseVisualStyleBackColor = false;
            // 
            // btn_customer
            // 
            this.btn_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_customer.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.Image = global::GUI.Properties.Resources.person24;
            this.btn_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer.Location = new System.Drawing.Point(3, 391);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_customer.Size = new System.Drawing.Size(199, 49);
            this.btn_customer.TabIndex = 3;
            this.btn_customer.Text = "Khách hàng";
            this.btn_customer.UseVisualStyleBackColor = false;
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_product.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.Image = global::GUI.Properties.Resources.package24;
            this.btn_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.Location = new System.Drawing.Point(3, 336);
            this.btn_product.Name = "btn_product";
            this.btn_product.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_product.Size = new System.Drawing.Size(199, 49);
            this.btn_product.TabIndex = 2;
            this.btn_product.Text = "Sản phẩm";
            this.btn_product.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo_shopbvt;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_name);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(3, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 61);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.admin24;
            this.pictureBox2.Location = new System.Drawing.Point(12, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(53, 16);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(73, 25);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Admin";
            // 
            // btnClose1
            // 
            this.btnClose1.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose1.Location = new System.Drawing.Point(1106, 0);
            this.btnClose1.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(55, 56);
            this.btnClose1.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_logout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_logout.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_logout.BorderRadius = 20;
            this.btn_logout.BorderSize = 1;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Image = global::GUI.Properties.Resources.logout24blue;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(14, 698);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(173, 50);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Đăng xuất";
            this.btn_logout.TextColor = System.Drawing.Color.Black;
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 760);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Component.btnClose btnClose1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_statistical;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Component.CustomButton btn_logout;
    }
}