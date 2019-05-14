namespace matris
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.manuel = new System.Windows.Forms.Button();
            this.auto_button = new System.Windows.Forms.Button();
            this.hesaplaBtn = new System.Windows.Forms.Button();
            this.text_box_26 = new System.Windows.Forms.TextBox();
            this.matris_size = new System.Windows.Forms.Label();
            this.tb_0_0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sutun_arttir = new System.Windows.Forms.Button();
            this.satir_azalt = new System.Windows.Forms.Button();
            this.sutun_azalt = new System.Windows.Forms.Button();
            this.satir_arttir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // manuel
            // 
            this.manuel.FlatAppearance.BorderSize = 0;
            this.manuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manuel.Font = new System.Drawing.Font("Modern No. 20", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manuel.Location = new System.Drawing.Point(14, 29);
            this.manuel.Name = "manuel";
            this.manuel.Size = new System.Drawing.Size(130, 55);
            this.manuel.TabIndex = 0;
            this.manuel.Text = "Kullanıcı Girişi";
            this.manuel.UseVisualStyleBackColor = true;
            this.manuel.Click += new System.EventHandler(this.Manuel_Click);
            // 
            // auto_button
            // 
            this.auto_button.FlatAppearance.BorderSize = 0;
            this.auto_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auto_button.Font = new System.Drawing.Font("Modern No. 20", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auto_button.Location = new System.Drawing.Point(12, 126);
            this.auto_button.Name = "auto_button";
            this.auto_button.Size = new System.Drawing.Size(132, 56);
            this.auto_button.TabIndex = 1;
            this.auto_button.Text = "Rastgele Oluştur";
            this.auto_button.UseVisualStyleBackColor = true;
            this.auto_button.Click += new System.EventHandler(this.Auto_button_Click);
            // 
            // hesaplaBtn
            // 
            this.hesaplaBtn.Location = new System.Drawing.Point(413, 12);
            this.hesaplaBtn.Name = "hesaplaBtn";
            this.hesaplaBtn.Size = new System.Drawing.Size(119, 23);
            this.hesaplaBtn.TabIndex = 40;
            this.hesaplaBtn.Text = "Hesapla";
            this.hesaplaBtn.UseVisualStyleBackColor = true;
            this.hesaplaBtn.Click += new System.EventHandler(this.HesaplaBtn_Click);
            // 
            // text_box_26
            // 
            this.text_box_26.BackColor = System.Drawing.Color.White;
            this.text_box_26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_box_26.Location = new System.Drawing.Point(413, 41);
            this.text_box_26.Multiline = true;
            this.text_box_26.Name = "text_box_26";
            this.text_box_26.ReadOnly = true;
            this.text_box_26.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_box_26.Size = new System.Drawing.Size(375, 188);
            this.text_box_26.TabIndex = 42;
            // 
            // matris_size
            // 
            this.matris_size.AutoSize = true;
            this.matris_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.matris_size.Location = new System.Drawing.Point(150, 29);
            this.matris_size.Name = "matris_size";
            this.matris_size.Size = new System.Drawing.Size(37, 20);
            this.matris_size.TabIndex = 50;
            this.matris_size.Text = "1x1";
            // 
            // tb_0_0
            // 
            this.tb_0_0.Location = new System.Drawing.Point(203, 64);
            this.tb_0_0.Name = "tb_0_0";
            this.tb_0_0.Size = new System.Drawing.Size(30, 20);
            this.tb_0_0.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(150, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Satır";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(199, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Sütun";
            // 
            // sutun_arttir
            // 
            this.sutun_arttir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sutun_arttir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sutun_arttir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sutun_arttir.Location = new System.Drawing.Point(262, 25);
            this.sutun_arttir.Name = "sutun_arttir";
            this.sutun_arttir.Size = new System.Drawing.Size(32, 29);
            this.sutun_arttir.TabIndex = 49;
            this.sutun_arttir.Text = "+";
            this.sutun_arttir.UseVisualStyleBackColor = false;
            this.sutun_arttir.Click += new System.EventHandler(this.Sutun_arttir_Click);
            // 
            // satir_azalt
            // 
            this.satir_azalt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.satir_azalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satir_azalt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.satir_azalt.Location = new System.Drawing.Point(154, 126);
            this.satir_azalt.Name = "satir_azalt";
            this.satir_azalt.Size = new System.Drawing.Size(32, 29);
            this.satir_azalt.TabIndex = 46;
            this.satir_azalt.Text = "-";
            this.satir_azalt.UseVisualStyleBackColor = false;
            this.satir_azalt.Click += new System.EventHandler(this.Satir_azalt_Click);
            // 
            // sutun_azalt
            // 
            this.sutun_azalt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sutun_azalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sutun_azalt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sutun_azalt.Location = new System.Drawing.Point(300, 25);
            this.sutun_azalt.Name = "sutun_azalt";
            this.sutun_azalt.Size = new System.Drawing.Size(32, 29);
            this.sutun_azalt.TabIndex = 48;
            this.sutun_azalt.Text = "-";
            this.sutun_azalt.UseVisualStyleBackColor = false;
            this.sutun_azalt.Click += new System.EventHandler(this.Sutun_azalt_Click);
            // 
            // satir_arttir
            // 
            this.satir_arttir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.satir_arttir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satir_arttir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.satir_arttir.Location = new System.Drawing.Point(154, 91);
            this.satir_arttir.Name = "satir_arttir";
            this.satir_arttir.Size = new System.Drawing.Size(32, 29);
            this.satir_arttir.TabIndex = 47;
            this.satir_arttir.Text = "+";
            this.satir_arttir.UseVisualStyleBackColor = false;
            this.satir_arttir.Click += new System.EventHandler(this.Satir_arttir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pnl);
            this.panel1.Controls.Add(this.manuel);
            this.panel1.Controls.Add(this.auto_button);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 242);
            this.panel1.TabIndex = 51;
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.IndianRed;
            this.pnl.Location = new System.Drawing.Point(0, 29);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(14, 55);
            this.pnl.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 241);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.matris_size);
            this.Controls.Add(this.tb_0_0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sutun_arttir);
            this.Controls.Add(this.satir_azalt);
            this.Controls.Add(this.sutun_azalt);
            this.Controls.Add(this.satir_arttir);
            this.Controls.Add(this.text_box_26);
            this.Controls.Add(this.hesaplaBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manuel;
        private System.Windows.Forms.Button auto_button;
        private System.Windows.Forms.Button hesaplaBtn;
        private System.Windows.Forms.TextBox text_box_26;
        private System.Windows.Forms.Label matris_size;
        private System.Windows.Forms.TextBox tb_0_0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sutun_arttir;
        private System.Windows.Forms.Button satir_azalt;
        private System.Windows.Forms.Button sutun_azalt;
        private System.Windows.Forms.Button satir_arttir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl;
    }
}

