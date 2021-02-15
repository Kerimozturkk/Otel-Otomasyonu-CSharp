
namespace GP_1170505031_Kerim_Öztürk
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label5 = new System.Windows.Forms.Label();
            this.musteri_sec = new System.Windows.Forms.ComboBox();
            this.musteri_adi = new System.Windows.Forms.Label();
            this.oda_numarasi = new System.Windows.Forms.Label();
            this.sil_btn = new System.Windows.Forms.Button();
            this.aaa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(169, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(436, 63);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rezervasyon Iptal";
            // 
            // musteri_sec
            // 
            this.musteri_sec.FormattingEnabled = true;
            this.musteri_sec.Location = new System.Drawing.Point(189, 125);
            this.musteri_sec.Name = "musteri_sec";
            this.musteri_sec.Size = new System.Drawing.Size(401, 21);
            this.musteri_sec.TabIndex = 5;
            this.musteri_sec.SelectedIndexChanged += new System.EventHandler(this.musteri_sec_SelectedIndexChanged);
            // 
            // musteri_adi
            // 
            this.musteri_adi.AutoSize = true;
            this.musteri_adi.BackColor = System.Drawing.Color.Transparent;
            this.musteri_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteri_adi.ForeColor = System.Drawing.Color.White;
            this.musteri_adi.Location = new System.Drawing.Point(329, 194);
            this.musteri_adi.Name = "musteri_adi";
            this.musteri_adi.Size = new System.Drawing.Size(144, 29);
            this.musteri_adi.TabIndex = 6;
            this.musteri_adi.Text = "Müsteri Adı";
            // 
            // oda_numarasi
            // 
            this.oda_numarasi.AutoSize = true;
            this.oda_numarasi.BackColor = System.Drawing.Color.Transparent;
            this.oda_numarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oda_numarasi.ForeColor = System.Drawing.Color.White;
            this.oda_numarasi.Location = new System.Drawing.Point(321, 247);
            this.oda_numarasi.Name = "oda_numarasi";
            this.oda_numarasi.Size = new System.Drawing.Size(175, 29);
            this.oda_numarasi.TabIndex = 7;
            this.oda_numarasi.Text = "Oda numarası";
            // 
            // sil_btn
            // 
            this.sil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_btn.Location = new System.Drawing.Point(321, 308);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(152, 54);
            this.sil_btn.TabIndex = 8;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.BackColor = System.Drawing.Color.Transparent;
            this.aaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aaa.ForeColor = System.Drawing.Color.Red;
            this.aaa.Location = new System.Drawing.Point(15, 16);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(28, 15);
            this.aaa.TabIndex = 9;
            this.aaa.Text = "oda";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(776, 435);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.oda_numarasi);
            this.Controls.Add(this.musteri_adi);
            this.Controls.Add(this.musteri_sec);
            this.Controls.Add(this.label5);
            this.Name = "Form4";
            this.Text = "Rezevasyon_Sil";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox musteri_sec;
        private System.Windows.Forms.Label musteri_adi;
        private System.Windows.Forms.Label oda_numarasi;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Label aaa;
    }
}