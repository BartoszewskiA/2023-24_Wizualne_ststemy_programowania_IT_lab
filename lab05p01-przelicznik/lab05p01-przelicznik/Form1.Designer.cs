namespace lab05p01_przelicznik
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.la_in = new System.Windows.Forms.Label();
            this.la_out = new System.Windows.Forms.Label();
            this.tb_in = new System.Windows.Forms.TextBox();
            this.tb_out = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_in_pln = new System.Windows.Forms.RadioButton();
            this.rb_in_euro = new System.Windows.Forms.RadioButton();
            this.rb_in_usd = new System.Windows.Forms.RadioButton();
            this.rb_ou_pln = new System.Windows.Forms.RadioButton();
            this.rb_ou_euro = new System.Windows.Forms.RadioButton();
            this.rb_ou_usd = new System.Windows.Forms.RadioButton();
            this.hs_in = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // la_in
            // 
            this.la_in.AutoSize = true;
            this.la_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.la_in.Location = new System.Drawing.Point(27, 25);
            this.la_in.Name = "la_in";
            this.la_in.Size = new System.Drawing.Size(55, 25);
            this.la_in.TabIndex = 0;
            this.la_in.Text = "W_Z";
            // 
            // la_out
            // 
            this.la_out.AutoSize = true;
            this.la_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.la_out.Location = new System.Drawing.Point(27, 62);
            this.la_out.Name = "la_out";
            this.la_out.Size = new System.Drawing.Size(57, 25);
            this.la_out.TabIndex = 1;
            this.la_out.Text = "W_D";
            // 
            // tb_in
            // 
            this.tb_in.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_in.Location = new System.Drawing.Point(111, 22);
            this.tb_in.Name = "tb_in";
            this.tb_in.ReadOnly = true;
            this.tb_in.Size = new System.Drawing.Size(301, 30);
            this.tb_in.TabIndex = 2;
            // 
            // tb_out
            // 
            this.tb_out.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_out.Location = new System.Drawing.Point(111, 62);
            this.tb_out.Name = "tb_out";
            this.tb_out.Size = new System.Drawing.Size(301, 30);
            this.tb_out.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_in_usd);
            this.groupBox1.Controls.Add(this.rb_in_euro);
            this.groupBox1.Controls.Add(this.rb_in_pln);
            this.groupBox1.Location = new System.Drawing.Point(32, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waluta źródłowa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_ou_usd);
            this.groupBox2.Controls.Add(this.rb_ou_euro);
            this.groupBox2.Controls.Add(this.rb_ou_pln);
            this.groupBox2.Location = new System.Drawing.Point(240, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 155);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Waluta docelowa";
            // 
            // rb_in_pln
            // 
            this.rb_in_pln.AutoSize = true;
            this.rb_in_pln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_in_pln.Location = new System.Drawing.Point(16, 32);
            this.rb_in_pln.Name = "rb_in_pln";
            this.rb_in_pln.Size = new System.Drawing.Size(63, 24);
            this.rb_in_pln.TabIndex = 0;
            this.rb_in_pln.Text = "PLN";
            this.rb_in_pln.UseVisualStyleBackColor = true;
            this.rb_in_pln.CheckedChanged += new System.EventHandler(this.rb_in_pln_CheckedChanged);
            // 
            // rb_in_euro
            // 
            this.rb_in_euro.AutoSize = true;
            this.rb_in_euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_in_euro.Location = new System.Drawing.Point(16, 69);
            this.rb_in_euro.Name = "rb_in_euro";
            this.rb_in_euro.Size = new System.Drawing.Size(78, 24);
            this.rb_in_euro.TabIndex = 1;
            this.rb_in_euro.Text = "EURO";
            this.rb_in_euro.UseVisualStyleBackColor = true;
            this.rb_in_euro.CheckedChanged += new System.EventHandler(this.rb_in_euro_CheckedChanged);
            // 
            // rb_in_usd
            // 
            this.rb_in_usd.AutoSize = true;
            this.rb_in_usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_in_usd.Location = new System.Drawing.Point(16, 107);
            this.rb_in_usd.Name = "rb_in_usd";
            this.rb_in_usd.Size = new System.Drawing.Size(66, 24);
            this.rb_in_usd.TabIndex = 2;
            this.rb_in_usd.Text = "USD";
            this.rb_in_usd.UseVisualStyleBackColor = true;
            this.rb_in_usd.CheckedChanged += new System.EventHandler(this.rb_in_usd_CheckedChanged);
            // 
            // rb_ou_pln
            // 
            this.rb_ou_pln.AutoSize = true;
            this.rb_ou_pln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_ou_pln.Location = new System.Drawing.Point(7, 32);
            this.rb_ou_pln.Name = "rb_ou_pln";
            this.rb_ou_pln.Size = new System.Drawing.Size(63, 24);
            this.rb_ou_pln.TabIndex = 0;
            this.rb_ou_pln.Text = "PLN";
            this.rb_ou_pln.UseVisualStyleBackColor = true;
            this.rb_ou_pln.CheckedChanged += new System.EventHandler(this.rb_ou_pln_CheckedChanged);
            // 
            // rb_ou_euro
            // 
            this.rb_ou_euro.AutoSize = true;
            this.rb_ou_euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_ou_euro.Location = new System.Drawing.Point(7, 69);
            this.rb_ou_euro.Name = "rb_ou_euro";
            this.rb_ou_euro.Size = new System.Drawing.Size(78, 24);
            this.rb_ou_euro.TabIndex = 1;
            this.rb_ou_euro.Text = "EURO";
            this.rb_ou_euro.UseVisualStyleBackColor = true;
            this.rb_ou_euro.CheckedChanged += new System.EventHandler(this.rb_ou_euro_CheckedChanged);
            // 
            // rb_ou_usd
            // 
            this.rb_ou_usd.AutoSize = true;
            this.rb_ou_usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_ou_usd.Location = new System.Drawing.Point(7, 107);
            this.rb_ou_usd.Name = "rb_ou_usd";
            this.rb_ou_usd.Size = new System.Drawing.Size(66, 24);
            this.rb_ou_usd.TabIndex = 2;
            this.rb_ou_usd.Text = "USD";
            this.rb_ou_usd.UseVisualStyleBackColor = true;
            this.rb_ou_usd.CheckedChanged += new System.EventHandler(this.rb_ou_usd_CheckedChanged);
            // 
            // hs_in
            // 
            this.hs_in.LargeChange = 1;
            this.hs_in.Location = new System.Drawing.Point(32, 309);
            this.hs_in.Maximum = 10000;
            this.hs_in.Name = "hs_in";
            this.hs_in.Size = new System.Drawing.Size(380, 24);
            this.hs_in.TabIndex = 6;
            this.hs_in.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hs_in_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(65, 352);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(347, 24);
            this.hScrollBar1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(43, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = ",";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.hs_in);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_out);
            this.Controls.Add(this.tb_in);
            this.Controls.Add(this.la_out);
            this.Controls.Add(this.la_in);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Przelicznik walut";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label la_in;
        private System.Windows.Forms.Label la_out;
        private System.Windows.Forms.TextBox tb_in;
        private System.Windows.Forms.TextBox tb_out;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_in_usd;
        private System.Windows.Forms.RadioButton rb_in_euro;
        private System.Windows.Forms.RadioButton rb_in_pln;
        private System.Windows.Forms.RadioButton rb_ou_usd;
        private System.Windows.Forms.RadioButton rb_ou_euro;
        private System.Windows.Forms.RadioButton rb_ou_pln;
        private System.Windows.Forms.HScrollBar hs_in;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
    }
}

