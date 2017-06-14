namespace InstallTWRP
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
            this.components = new System.ComponentModel.Container();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.rdoNonFastboot = new System.Windows.Forms.RadioButton();
            this.rdoFastboot = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMiflash = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnInstallRec = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAccessRec = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnNonFbInstallRec = new System.Windows.Forms.Button();
            this.btnNonFbBack = new System.Windows.Forms.Button();
            this.btnAccessFast = new System.Windows.Forms.Button();
            this.btnNonFbAccessRec = new System.Windows.Forms.Button();
            this.ofdTWRP = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.tabPage1);
            this.tabContainer.Controls.Add(this.tabPage2);
            this.tabContainer.Controls.Add(this.tabPage3);
            this.tabContainer.ItemSize = new System.Drawing.Size(0, 1);
            this.tabContainer.Location = new System.Drawing.Point(-4, -5);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(425, 291);
            this.tabContainer.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabContainer.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnMiflash);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDevice);
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.rdoNonFastboot);
            this.groupBox1.Controls.Add(this.rdoFastboot);
            this.groupBox1.Location = new System.Drawing.Point(14, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flash TWRP";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(107, 24);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(23, 13);
            this.lblDevice.TabIndex = 12;
            this.lblDevice.Text = "null";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(20, 24);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 13);
            this.lblColor.TabIndex = 11;
            this.lblColor.Text = "Device";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(107, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tìm Recovery";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(90, 132);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(296, 132);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Xác Nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // rdoNonFastboot
            // 
            this.rdoNonFastboot.AutoSize = true;
            this.rdoNonFastboot.Location = new System.Drawing.Point(23, 107);
            this.rdoNonFastboot.Name = "rdoNonFastboot";
            this.rdoNonFastboot.Size = new System.Drawing.Size(153, 17);
            this.rdoNonFastboot.TabIndex = 5;
            this.rdoNonFastboot.TabStop = true;
            this.rdoNonFastboot.Text = "Máy chưa đưa về Fastboot";
            this.rdoNonFastboot.UseVisualStyleBackColor = true;
            // 
            // rdoFastboot
            // 
            this.rdoFastboot.AutoSize = true;
            this.rdoFastboot.Location = new System.Drawing.Point(23, 78);
            this.rdoFastboot.Name = "rdoFastboot";
            this.rdoFastboot.Size = new System.Drawing.Size(142, 17);
            this.rdoFastboot.TabIndex = 4;
            this.rdoFastboot.TabStop = true;
            this.rdoFastboot.Text = "Máy đã đưa về Fastboot";
            this.rdoFastboot.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nếu máy tính của bác chưa có MiFlash thì nên tải và cài đặt MiFlash trước";
            // 
            // btnMiflash
            // 
            this.btnMiflash.Enabled = false;
            this.btnMiflash.Location = new System.Drawing.Point(190, 12);
            this.btnMiflash.Name = "btnMiflash";
            this.btnMiflash.Size = new System.Drawing.Size(216, 23);
            this.btnMiflash.TabIndex = 1;
            this.btnMiflash.Text = "Tải MiFlash bản mới nhất";
            this.btnMiflash.UseVisualStyleBackColor = true;
            this.btnMiflash.Click += new System.EventHandler(this.btnMiflash_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Tôi muốn tải MiFlash";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnInstallRec);
            this.tabPage2.Controls.Add(this.btnBack);
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.btnAccessRec);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInstallRec
            // 
            this.btnInstallRec.Location = new System.Drawing.Point(129, 40);
            this.btnInstallRec.Name = "btnInstallRec";
            this.btnInstallRec.Size = new System.Drawing.Size(157, 23);
            this.btnInstallRec.TabIndex = 0;
            this.btnInstallRec.Text = "Cài đặt TWRP Recovery";
            this.btnInstallRec.UseVisualStyleBackColor = true;
            this.btnInstallRec.Click += new System.EventHandler(this.btnInstallRec_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(129, 175);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(157, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(129, 129);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(157, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset lại máy";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAccessRec
            // 
            this.btnAccessRec.Location = new System.Drawing.Point(129, 82);
            this.btnAccessRec.Name = "btnAccessRec";
            this.btnAccessRec.Size = new System.Drawing.Size(157, 23);
            this.btnAccessRec.TabIndex = 0;
            this.btnAccessRec.Text = "Reset vào TWRP Recovery";
            this.btnAccessRec.UseVisualStyleBackColor = true;
            this.btnAccessRec.Click += new System.EventHandler(this.btnAccessRec_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnNonFbInstallRec);
            this.tabPage3.Controls.Add(this.btnNonFbBack);
            this.tabPage3.Controls.Add(this.btnAccessFast);
            this.tabPage3.Controls.Add(this.btnNonFbAccessRec);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 255);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnNonFbInstallRec
            // 
            this.btnNonFbInstallRec.Location = new System.Drawing.Point(130, 40);
            this.btnNonFbInstallRec.Name = "btnNonFbInstallRec";
            this.btnNonFbInstallRec.Size = new System.Drawing.Size(157, 23);
            this.btnNonFbInstallRec.TabIndex = 1;
            this.btnNonFbInstallRec.Text = "Cài đặt TWRP Recovery";
            this.btnNonFbInstallRec.UseVisualStyleBackColor = true;
            this.btnNonFbInstallRec.Click += new System.EventHandler(this.btnNonFbInstallRec_Click);
            // 
            // btnNonFbBack
            // 
            this.btnNonFbBack.Location = new System.Drawing.Point(130, 175);
            this.btnNonFbBack.Name = "btnNonFbBack";
            this.btnNonFbBack.Size = new System.Drawing.Size(157, 23);
            this.btnNonFbBack.TabIndex = 2;
            this.btnNonFbBack.Text = "Back";
            this.btnNonFbBack.UseVisualStyleBackColor = true;
            this.btnNonFbBack.Click += new System.EventHandler(this.btnNonFbBack_Click);
            // 
            // btnAccessFast
            // 
            this.btnAccessFast.Location = new System.Drawing.Point(130, 129);
            this.btnAccessFast.Name = "btnAccessFast";
            this.btnAccessFast.Size = new System.Drawing.Size(157, 23);
            this.btnAccessFast.TabIndex = 3;
            this.btnAccessFast.Text = "Vào Fastboot";
            this.btnAccessFast.UseVisualStyleBackColor = true;
            this.btnAccessFast.Click += new System.EventHandler(this.btnAccessFast_Click);
            // 
            // btnNonFbAccessRec
            // 
            this.btnNonFbAccessRec.Location = new System.Drawing.Point(130, 82);
            this.btnNonFbAccessRec.Name = "btnNonFbAccessRec";
            this.btnNonFbAccessRec.Size = new System.Drawing.Size(157, 23);
            this.btnNonFbAccessRec.TabIndex = 4;
            this.btnNonFbAccessRec.Text = "Reset vào TWRP Recovery";
            this.btnNonFbAccessRec.UseVisualStyleBackColor = true;
            this.btnNonFbAccessRec.Click += new System.EventHandler(this.btnNonFbAccessRec_Click);
            // 
            // ofdTWRP
            // 
            this.ofdTWRP.Filter = "twrp file |*.img|All files|*.*";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 255);
            this.Controls.Add(this.tabContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install TWRP (by Hoài Thy)";
            this.TopMost = true;
            this.tabContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMiflash;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton rdoNonFastboot;
        private System.Windows.Forms.RadioButton rdoFastboot;
        private System.Windows.Forms.Button btnInstallRec;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAccessRec;
        private System.Windows.Forms.Button btnNonFbInstallRec;
        private System.Windows.Forms.Button btnNonFbBack;
        private System.Windows.Forms.Button btnAccessFast;
        private System.Windows.Forms.Button btnNonFbAccessRec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofdTWRP;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Timer timer1;

    }
}

