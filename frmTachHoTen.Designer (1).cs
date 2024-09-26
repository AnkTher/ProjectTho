namespace HoTen
{
    partial class frmTachHoTen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblHo = new Label();
            lblTen = new Label();
            btnTach = new Button();
            lblShowHo = new Label();
            lblShowTen = new Label();
            lblShowDem = new Label();
            lblDem = new Label();
            grbKetQua = new GroupBox();
            label1 = new Label();
            btnKetThuc = new Button();
            grbKetQua.SuspendLayout();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(67, 129);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(226, 30);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Nhập họ tên của bạn:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(299, 124);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(433, 35);
            txtHoTen.TabIndex = 0;
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHo.Location = new Point(90, 47);
            lblHo.Name = "lblHo";
            lblHo.Size = new Size(42, 30);
            lblHo.TabIndex = 2;
            lblHo.Text = "Họ";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTen.Location = new Point(90, 153);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(53, 30);
            lblTen.TabIndex = 3;
            lblTen.Text = "Tên:";
            // 
            // btnTach
            // 
            btnTach.BackColor = Color.FromArgb(67, 121, 242);
            btnTach.ForeColor = SystemColors.ControlLightLight;
            btnTach.Location = new Point(399, 200);
            btnTach.Name = "btnTach";
            btnTach.Size = new Size(244, 55);
            btnTach.TabIndex = 4;
            btnTach.Text = "Tách";
            btnTach.UseVisualStyleBackColor = false;
            btnTach.Click += btnTach_Click;
            // 
            // lblShowHo
            // 
            lblShowHo.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblShowHo.ForeColor = Color.Blue;
            lblShowHo.Location = new Point(193, 47);
            lblShowHo.Name = "lblShowHo";
            lblShowHo.Size = new Size(397, 30);
            lblShowHo.TabIndex = 5;
            // 
            // lblShowTen
            // 
            lblShowTen.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblShowTen.ForeColor = Color.Blue;
            lblShowTen.Location = new Point(193, 153);
            lblShowTen.Name = "lblShowTen";
            lblShowTen.Size = new Size(397, 30);
            lblShowTen.TabIndex = 6;
            // 
            // lblShowDem
            // 
            lblShowDem.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblShowDem.ForeColor = Color.Blue;
            lblShowDem.Location = new Point(193, 101);
            lblShowDem.Name = "lblShowDem";
            lblShowDem.Size = new Size(397, 30);
            lblShowDem.TabIndex = 8;
            // 
            // lblDem
            // 
            lblDem.AutoSize = true;
            lblDem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDem.Location = new Point(90, 101);
            lblDem.Name = "lblDem";
            lblDem.Size = new Size(58, 30);
            lblDem.TabIndex = 7;
            lblDem.Text = "Đệm";
            // 
            // grbKetQua
            // 
            grbKetQua.Controls.Add(lblHo);
            grbKetQua.Controls.Add(lblShowDem);
            grbKetQua.Controls.Add(lblTen);
            grbKetQua.Controls.Add(lblDem);
            grbKetQua.Controls.Add(lblShowHo);
            grbKetQua.Controls.Add(lblShowTen);
            grbKetQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbKetQua.Location = new Point(105, 286);
            grbKetQua.Name = "grbKetQua";
            grbKetQua.Size = new Size(651, 216);
            grbKetQua.TabIndex = 9;
            grbKetQua.TabStop = false;
            grbKetQua.Text = "Kết quả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(276, 33);
            label1.Name = "label1";
            label1.Size = new Size(344, 50);
            label1.TabIndex = 10;
            label1.Text = "Tách Họ, Đệm, Tên";
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(735, 526);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(142, 64);
            btnKetThuc.TabIndex = 11;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // frmTachHoTen
            // 
            AcceptButton = btnTach;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 620);
            Controls.Add(btnKetThuc);
            Controls.Add(label1);
            Controls.Add(grbKetQua);
            Controls.Add(btnTach);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Name = "frmTachHoTen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            grbKetQua.ResumeLayout(false);
            grbKetQua.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblHo;
        private Label lblTen;
        private Button btnTach;
        private Label lblShowHo;
        private Label lblShowTen;
        private Label lblShowDem;
        private Label lblDem;
        private GroupBox grbKetQua;
        private Label label1;
        private Button btnKetThuc;
    }
}
