
namespace GP_1170505031_Kerim_Öztürk
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label5 = new System.Windows.Forms.Label();
            this.rez_listesi = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(150, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(479, 63);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rezervasyon Listesi";
            // 
            // rez_listesi
            // 
            this.rez_listesi.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rez_listesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rez_listesi.GridLines = true;
            this.rez_listesi.HideSelection = false;
            this.rez_listesi.Location = new System.Drawing.Point(12, 115);
            this.rez_listesi.Name = "rez_listesi";
            this.rez_listesi.Size = new System.Drawing.Size(756, 255);
            this.rez_listesi.TabIndex = 6;
            this.rez_listesi.UseCompatibleStateImageBehavior = false;
            this.rez_listesi.View = System.Windows.Forms.View.Details;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 435);
            this.Controls.Add(this.rez_listesi);
            this.Controls.Add(this.label5);
            this.Name = "Form5";
            this.Text = "Rezervasyon_Listesi";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView rez_listesi;
    }
}