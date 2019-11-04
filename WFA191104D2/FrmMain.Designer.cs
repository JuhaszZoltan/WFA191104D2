namespace WFA191104D2
{
    partial class FrmMain
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
            this.tbKeres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSzul = new System.Windows.Forms.DateTimePicker();
            this.cbOrszag = new System.Windows.Forms.ComboBox();
            this.btnRogzit = new System.Windows.Forms.Button();
            this.rbIos = new System.Windows.Forms.RadioButton();
            this.lblOs = new System.Windows.Forms.Label();
            this.lblOrszag = new System.Windows.Forms.Label();
            this.lblDbTalalat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNev = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSzul = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbWin = new System.Windows.Forms.RadioButton();
            this.rbAnd = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbKeres
            // 
            this.tbKeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKeres.Location = new System.Drawing.Point(12, 59);
            this.tbKeres.Name = "tbKeres";
            this.tbKeres.Size = new System.Drawing.Size(352, 26);
            this.tbKeres.TabIndex = 0;
            this.tbKeres.TextChanged += new System.EventHandler(this.tbKeres_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(96, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "még";
            // 
            // dtpSzul
            // 
            this.dtpSzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpSzul.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSzul.Location = new System.Drawing.Point(228, 337);
            this.dtpSzul.Name = "dtpSzul";
            this.dtpSzul.Size = new System.Drawing.Size(136, 26);
            this.dtpSzul.TabIndex = 2;
            // 
            // cbOrszag
            // 
            this.cbOrszag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrszag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbOrszag.FormattingEnabled = true;
            this.cbOrszag.Location = new System.Drawing.Point(228, 385);
            this.cbOrszag.Name = "cbOrszag";
            this.cbOrszag.Size = new System.Drawing.Size(136, 28);
            this.cbOrszag.TabIndex = 3;
            // 
            // btnRogzit
            // 
            this.btnRogzit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRogzit.Location = new System.Drawing.Point(12, 432);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.Size = new System.Drawing.Size(352, 51);
            this.btnRogzit.TabIndex = 4;
            this.btnRogzit.Text = "RÖGZÍT";
            this.btnRogzit.UseVisualStyleBackColor = true;
            this.btnRogzit.Click += new System.EventHandler(this.btnRogzit_Click);
            // 
            // rbIos
            // 
            this.rbIos.AutoSize = true;
            this.rbIos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbIos.Location = new System.Drawing.Point(12, 386);
            this.rbIos.Name = "rbIos";
            this.rbIos.Size = new System.Drawing.Size(58, 24);
            this.rbIos.TabIndex = 5;
            this.rbIos.TabStop = true;
            this.rbIos.Text = "IOS";
            this.rbIos.UseVisualStyleBackColor = true;
            // 
            // lblOs
            // 
            this.lblOs.AutoSize = true;
            this.lblOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOs.Location = new System.Drawing.Point(214, 235);
            this.lblOs.Name = "lblOs";
            this.lblOs.Size = new System.Drawing.Size(69, 20);
            this.lblOs.TabIndex = 1;
            this.lblOs.Text = "##OS##";
            // 
            // lblOrszag
            // 
            this.lblOrszag.AutoSize = true;
            this.lblOrszag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOrszag.Location = new System.Drawing.Point(33, 235);
            this.lblOrszag.Name = "lblOrszag";
            this.lblOrszag.Size = new System.Drawing.Size(114, 20);
            this.lblOrszag.TabIndex = 1;
            this.lblOrszag.Text = "##ORSZAG##";
            // 
            // lblDbTalalat
            // 
            this.lblDbTalalat.AutoSize = true;
            this.lblDbTalalat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDbTalalat.Location = new System.Drawing.Point(143, 110);
            this.lblDbTalalat.Name = "lblDbTalalat";
            this.lblDbTalalat.Size = new System.Drawing.Size(27, 20);
            this.lblDbTalalat.TabIndex = 1;
            this.lblDbTalalat.Text = "##";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "kereséshez kezdje el begépelni a nevet!";
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNev.Location = new System.Drawing.Point(33, 166);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(79, 20);
            this.lblNev.TabIndex = 1;
            this.lblNev.Text = "##NEV##";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(176, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "találat van!";
            // 
            // lblSzul
            // 
            this.lblSzul.AutoSize = true;
            this.lblSzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzul.Location = new System.Drawing.Point(214, 166);
            this.lblSzul.Name = "lblSzul";
            this.lblSzul.Size = new System.Drawing.Size(87, 20);
            this.lblSzul.TabIndex = 1;
            this.lblSzul.Text = "##SZUL##";
            // 
            // tbNev
            // 
            this.tbNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNev.Location = new System.Drawing.Point(12, 337);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(194, 26);
            this.tbNev.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Új alkalmazott:";
            // 
            // rbWin
            // 
            this.rbWin.AutoSize = true;
            this.rbWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbWin.Location = new System.Drawing.Point(76, 386);
            this.rbWin.Name = "rbWin";
            this.rbWin.Size = new System.Drawing.Size(59, 24);
            this.rbWin.TabIndex = 5;
            this.rbWin.TabStop = true;
            this.rbWin.Text = "Win";
            this.rbWin.UseVisualStyleBackColor = true;
            // 
            // rbAnd
            // 
            this.rbAnd.AutoSize = true;
            this.rbAnd.Checked = true;
            this.rbAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbAnd.Location = new System.Drawing.Point(141, 386);
            this.rbAnd.Name = "rbAnd";
            this.rbAnd.Size = new System.Drawing.Size(59, 24);
            this.rbAnd.TabIndex = 5;
            this.rbAnd.TabStop = true;
            this.rbAnd.Text = "And";
            this.rbAnd.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 503);
            this.Controls.Add(this.rbAnd);
            this.Controls.Add(this.rbWin);
            this.Controls.Add(this.rbIos);
            this.Controls.Add(this.btnRogzit);
            this.Controls.Add(this.cbOrszag);
            this.Controls.Add(this.dtpSzul);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.lblDbTalalat);
            this.Controls.Add(this.lblOrszag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSzul);
            this.Controls.Add(this.lblOs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.tbKeres);
            this.Name = "FrmMain";
            this.Text = "Asd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKeres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSzul;
        private System.Windows.Forms.ComboBox cbOrszag;
        private System.Windows.Forms.Button btnRogzit;
        private System.Windows.Forms.RadioButton rbIos;
        private System.Windows.Forms.Label lblOs;
        private System.Windows.Forms.Label lblOrszag;
        private System.Windows.Forms.Label lblDbTalalat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSzul;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbWin;
        private System.Windows.Forms.RadioButton rbAnd;
    }
}

