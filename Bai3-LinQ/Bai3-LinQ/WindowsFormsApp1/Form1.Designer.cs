namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ngayHHtb = new System.Windows.Forms.DateTimePicker();
            this.btndel = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.tenSPtb = new System.Windows.Forms.TextBox();
            this.SLtb = new System.Windows.Forms.TextBox();
            this.XStb = new System.Windows.Forms.TextBox();
            this.giatb = new System.Windows.Forms.TextBox();
            this.maSPtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.maxPrice = new System.Windows.Forms.TextBox();
            this.minPrice = new System.Windows.Forms.TextBox();
            this.tuNhat = new System.Windows.Forms.Button();
            this.xuatQuaHan = new System.Windows.Forms.Button();
            this.xuatTheoGia = new System.Windows.Forms.Button();
            this.giaCaoNhat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deletEndDate = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.checkDate = new System.Windows.Forms.Button();
            this.xsXoa = new System.Windows.Forms.RichTextBox();
            this.xoaTheoXS = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.editProduct = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.editProduct);
            this.panel2.Controls.Add(this.ngayHHtb);
            this.panel2.Controls.Add(this.btndel);
            this.panel2.Controls.Add(this.btnluu);
            this.panel2.Controls.Add(this.tenSPtb);
            this.panel2.Controls.Add(this.SLtb);
            this.panel2.Controls.Add(this.XStb);
            this.panel2.Controls.Add(this.giatb);
            this.panel2.Controls.Add(this.maSPtb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(27, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 400);
            this.panel2.TabIndex = 0;
            // 
            // ngayHHtb
            // 
            this.ngayHHtb.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayHHtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayHHtb.Location = new System.Drawing.Point(108, 268);
            this.ngayHHtb.Name = "ngayHHtb";
            this.ngayHHtb.Size = new System.Drawing.Size(287, 27);
            this.ngayHHtb.TabIndex = 14;
            this.ngayHHtb.ValueChanged += new System.EventHandler(this.ngayHHtb_ValueChanged);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.LightGray;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(233, 301);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(162, 41);
            this.btndel.TabIndex = 13;
            this.btndel.Text = "Xóa sản phẩm";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.LightGray;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(27, 301);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(162, 41);
            this.btnluu.TabIndex = 12;
            this.btnluu.Text = "Lưu sản phẩm";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // tenSPtb
            // 
            this.tenSPtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSPtb.Location = new System.Drawing.Point(108, 77);
            this.tenSPtb.Name = "tenSPtb";
            this.tenSPtb.Size = new System.Drawing.Size(287, 30);
            this.tenSPtb.TabIndex = 10;
            this.tenSPtb.TextChanged += new System.EventHandler(this.tenSPtb_TextChanged);
            // 
            // SLtb
            // 
            this.SLtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLtb.Location = new System.Drawing.Point(108, 127);
            this.SLtb.Name = "SLtb";
            this.SLtb.Size = new System.Drawing.Size(287, 30);
            this.SLtb.TabIndex = 9;
            this.SLtb.TextChanged += new System.EventHandler(this.SLtb_TextChanged);
            // 
            // XStb
            // 
            this.XStb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XStb.Location = new System.Drawing.Point(108, 220);
            this.XStb.Name = "XStb";
            this.XStb.Size = new System.Drawing.Size(287, 30);
            this.XStb.TabIndex = 8;
            this.XStb.TextChanged += new System.EventHandler(this.XStb_TextChanged);
            // 
            // giatb
            // 
            this.giatb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giatb.Location = new System.Drawing.Point(108, 172);
            this.giatb.Name = "giatb";
            this.giatb.Size = new System.Drawing.Size(287, 30);
            this.giatb.TabIndex = 7;
            this.giatb.TextChanged += new System.EventHandler(this.giatb_TextChanged);
            // 
            // maSPtb
            // 
            this.maSPtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSPtb.Location = new System.Drawing.Point(108, 30);
            this.maSPtb.Name = "maSPtb";
            this.maSPtb.Size = new System.Drawing.Size(287, 30);
            this.maSPtb.TabIndex = 6;
            this.maSPtb.TextChanged += new System.EventHandler(this.maSPtb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(23, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(23, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Xuất sứ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(11, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày HH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên SP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Controls.Add(this.maxPrice);
            this.panel1.Controls.Add(this.minPrice);
            this.panel1.Controls.Add(this.tuNhat);
            this.panel1.Controls.Add(this.xuatQuaHan);
            this.panel1.Controls.Add(this.xuatTheoGia);
            this.panel1.Controls.Add(this.giaCaoNhat);
            this.panel1.Location = new System.Drawing.Point(459, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 400);
            this.panel1.TabIndex = 1;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(27, 84);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(977, 282);
            this.listView2.TabIndex = 20;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // maxPrice
            // 
            this.maxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPrice.Location = new System.Drawing.Point(950, 30);
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(74, 34);
            this.maxPrice.TabIndex = 19;
            this.maxPrice.TextChanged += new System.EventHandler(this.maxPrice_TextChanged);
            // 
            // minPrice
            // 
            this.minPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPrice.Location = new System.Drawing.Point(857, 30);
            this.minPrice.Name = "minPrice";
            this.minPrice.Size = new System.Drawing.Size(73, 34);
            this.minPrice.TabIndex = 18;
            this.minPrice.TextChanged += new System.EventHandler(this.minPrice_TextChanged);
            // 
            // tuNhat
            // 
            this.tuNhat.BackColor = System.Drawing.Color.LightGray;
            this.tuNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuNhat.Location = new System.Drawing.Point(182, 13);
            this.tuNhat.Name = "tuNhat";
            this.tuNhat.Size = new System.Drawing.Size(175, 65);
            this.tuNhat.TabIndex = 17;
            this.tuNhat.Text = "1 SP từ Nhật Bản";
            this.tuNhat.UseVisualStyleBackColor = false;
            this.tuNhat.Click += new System.EventHandler(this.tuNhat_Click);
            // 
            // xuatQuaHan
            // 
            this.xuatQuaHan.BackColor = System.Drawing.Color.LightGray;
            this.xuatQuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatQuaHan.Location = new System.Drawing.Point(367, 13);
            this.xuatQuaHan.Name = "xuatQuaHan";
            this.xuatQuaHan.Size = new System.Drawing.Size(244, 65);
            this.xuatQuaHan.TabIndex = 16;
            this.xuatQuaHan.Text = "Xuất toàn bộ SP quá hạn";
            this.xuatQuaHan.UseVisualStyleBackColor = false;
            this.xuatQuaHan.Click += new System.EventHandler(this.xuatQuaHan_Click);
            // 
            // xuatTheoGia
            // 
            this.xuatTheoGia.BackColor = System.Drawing.Color.LightGray;
            this.xuatTheoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatTheoGia.Location = new System.Drawing.Point(620, 13);
            this.xuatTheoGia.Name = "xuatTheoGia";
            this.xuatTheoGia.Size = new System.Drawing.Size(231, 65);
            this.xuatTheoGia.TabIndex = 15;
            this.xuatTheoGia.Text = "Xuất SP theo ĐG [a..b]:";
            this.xuatTheoGia.UseVisualStyleBackColor = false;
            this.xuatTheoGia.Click += new System.EventHandler(this.xuatTheoGia_Click);
            // 
            // giaCaoNhat
            // 
            this.giaCaoNhat.BackColor = System.Drawing.Color.LightGray;
            this.giaCaoNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giaCaoNhat.Location = new System.Drawing.Point(12, 13);
            this.giaCaoNhat.Name = "giaCaoNhat";
            this.giaCaoNhat.Size = new System.Drawing.Size(164, 65);
            this.giaCaoNhat.TabIndex = 14;
            this.giaCaoNhat.Text = "1 SP có ĐG cao nhất";
            this.giaCaoNhat.UseVisualStyleBackColor = false;
            this.giaCaoNhat.Click += new System.EventHandler(this.giaCaoNhat_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(27, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1473, 369);
            this.panel3.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1025, 318);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(1187, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 27);
            this.label10.TabIndex = 15;
            this.label10.Text = "Chọn thao tác:";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.deletEndDate);
            this.panel4.Controls.Add(this.deleteAll);
            this.panel4.Controls.Add(this.checkDate);
            this.panel4.Controls.Add(this.xsXoa);
            this.panel4.Controls.Add(this.xoaTheoXS);
            this.panel4.Location = new System.Drawing.Point(1078, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 271);
            this.panel4.TabIndex = 1;
            // 
            // deletEndDate
            // 
            this.deletEndDate.BackColor = System.Drawing.Color.LightGray;
            this.deletEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletEndDate.Location = new System.Drawing.Point(199, 187);
            this.deletEndDate.Name = "deletEndDate";
            this.deletEndDate.Size = new System.Drawing.Size(153, 68);
            this.deletEndDate.TabIndex = 18;
            this.deletEndDate.Text = "Xóa toàn bộ SP quá hạn";
            this.deletEndDate.UseVisualStyleBackColor = false;
            this.deletEndDate.Click += new System.EventHandler(this.deletEndDate_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.BackColor = System.Drawing.Color.LightGray;
            this.deleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAll.Location = new System.Drawing.Point(16, 189);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(165, 66);
            this.deleteAll.TabIndex = 17;
            this.deleteAll.Text = "Xóa toàn bộ SP trong kho";
            this.deleteAll.UseVisualStyleBackColor = false;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // checkDate
            // 
            this.checkDate.BackColor = System.Drawing.Color.LightGray;
            this.checkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDate.Location = new System.Drawing.Point(17, 111);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(335, 70);
            this.checkDate.TabIndex = 16;
            this.checkDate.Text = "Kiểm tra kho có SP quá hạn hay không ?";
            this.checkDate.UseVisualStyleBackColor = false;
            this.checkDate.Click += new System.EventHandler(this.checkDate_Click);
            // 
            // xsXoa
            // 
            this.xsXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xsXoa.Location = new System.Drawing.Point(187, 38);
            this.xsXoa.Name = "xsXoa";
            this.xsXoa.Size = new System.Drawing.Size(165, 67);
            this.xsXoa.TabIndex = 15;
            this.xsXoa.Text = "";
            // 
            // xoaTheoXS
            // 
            this.xoaTheoXS.BackColor = System.Drawing.Color.LightGray;
            this.xoaTheoXS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaTheoXS.Location = new System.Drawing.Point(16, 38);
            this.xoaTheoXS.Name = "xoaTheoXS";
            this.xoaTheoXS.Size = new System.Drawing.Size(165, 67);
            this.xoaTheoXS.TabIndex = 14;
            this.xoaTheoXS.Text = "Xóa SP theo xuất sứ bất kì:";
            this.xoaTheoXS.UseVisualStyleBackColor = false;
            this.xoaTheoXS.Click += new System.EventHandler(this.xoaTheoXS_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(149, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Thông tin sản phẩm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(884, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 27);
            this.label8.TabIndex = 13;
            this.label8.Text = "Chọn chức năng tìm kiếm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(75, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 27);
            this.label9.TabIndex = 14;
            this.label9.Text = "Danh sách sản phẩm đẫ nhập:";
            // 
            // editProduct
            // 
            this.editProduct.BackColor = System.Drawing.Color.LightGray;
            this.editProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProduct.Location = new System.Drawing.Point(122, 348);
            this.editProduct.Name = "editProduct";
            this.editProduct.Size = new System.Drawing.Size(162, 41);
            this.editProduct.TabIndex = 15;
            this.editProduct.Text = "Sửa sản phẩm";
            this.editProduct.UseVisualStyleBackColor = false;
            this.editProduct.Click += new System.EventHandler(this.editProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1528, 839);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox tenSPtb;
        private System.Windows.Forms.TextBox SLtb;
        private System.Windows.Forms.TextBox XStb;
        private System.Windows.Forms.TextBox giatb;
        private System.Windows.Forms.TextBox maSPtb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button tuNhat;
        private System.Windows.Forms.Button xuatQuaHan;
        private System.Windows.Forms.Button xuatTheoGia;
        private System.Windows.Forms.Button giaCaoNhat;
        private System.Windows.Forms.TextBox maxPrice;
        private System.Windows.Forms.TextBox minPrice;
        private System.Windows.Forms.DateTimePicker ngayHHtb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button xoaTheoXS;
        private System.Windows.Forms.Button deletEndDate;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Button checkDate;
        private System.Windows.Forms.RichTextBox xsXoa;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button editProduct;
    }
}

