namespace RapidApiCurrency
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            lbldollar = new Label();
            lblEuro = new Label();
            label1 = new Label();
            txtBirimFiyat = new TextBox();
            rddolar = new RadioButton();
            rdeuro = new RadioButton();
            rdsterlin = new RadioButton();
            button1 = new Button();
            label2 = new Label();
            txtTutar = new TextBox();
            panel1 = new Panel();
            lblSterlin = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbldollar
            // 
            lbldollar.AutoSize = true;
            lbldollar.Location = new Point(107, 20);
            lbldollar.Name = "lbldollar";
            lbldollar.Size = new Size(0, 31);
            lbldollar.TabIndex = 0;
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Location = new Point(107, 70);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(0, 31);
            lblEuro.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 260);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 1;
            label1.Text = "Birim Tutar:";
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(239, 260);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(182, 38);
            txtBirimFiyat.TabIndex = 2;
            // 
            // rddolar
            // 
            rddolar.AutoSize = true;
            rddolar.Location = new Point(85, 203);
            rddolar.Name = "rddolar";
            rddolar.Size = new Size(90, 35);
            rddolar.TabIndex = 3;
            rddolar.TabStop = true;
            rddolar.Text = "Dolar";
            rddolar.UseVisualStyleBackColor = true;
            // 
            // rdeuro
            // 
            rdeuro.AutoSize = true;
            rdeuro.Location = new Point(211, 203);
            rdeuro.Name = "rdeuro";
            rdeuro.Size = new Size(81, 35);
            rdeuro.TabIndex = 3;
            rdeuro.TabStop = true;
            rdeuro.Text = "Euro";
            rdeuro.UseVisualStyleBackColor = true;
            // 
            // rdsterlin
            // 
            rdsterlin.AutoSize = true;
            rdsterlin.Location = new Point(322, 203);
            rdsterlin.Name = "rdsterlin";
            rdsterlin.Size = new Size(99, 35);
            rdsterlin.TabIndex = 3;
            rdsterlin.TabStop = true;
            rdsterlin.Text = "Sterlin";
            rdsterlin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(239, 373);
            button1.Name = "button1";
            button1.Size = new Size(182, 47);
            button1.TabIndex = 4;
            button1.Text = "İşlemi Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 304);
            label2.Name = "label2";
            label2.Size = new Size(180, 31);
            label2.TabIndex = 1;
            label2.Text = "Ödenecek Tutar:";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(239, 304);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(182, 38);
            txtTutar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(lblSterlin);
            panel1.Controls.Add(lblEuro);
            panel1.Controls.Add(lbldollar);
            panel1.Location = new Point(127, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 166);
            panel1.TabIndex = 5;
            // 
            // lblSterlin
            // 
            lblSterlin.AutoSize = true;
            lblSterlin.Location = new Point(107, 117);
            lblSterlin.Name = "lblSterlin";
            lblSterlin.Size = new Size(0, 31);
            lblSterlin.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(571, 479);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(rdsterlin);
            Controls.Add(rdeuro);
            Controls.Add(rddolar);
            Controls.Add(txtTutar);
            Controls.Add(label2);
            Controls.Add(txtBirimFiyat);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Label lbldollar;
        private Label lblEuro;
        private Label label1;
        private TextBox txtBirimFiyat;
        private RadioButton rddolar;
        private RadioButton rdeuro;
        private RadioButton rdsterlin;
        private Button button1;
        private Label label2;
        private TextBox txtTutar;
        private Panel panel1;
        private Label lblSterlin;
    }
}
