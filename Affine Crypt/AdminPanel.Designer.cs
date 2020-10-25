
namespace Affine_Crypt
{
    partial class AdminPanel
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
            this.BtnCrypt = new System.Windows.Forms.Button();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCrypt
            // 
            this.BtnCrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCrypt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCrypt.Location = new System.Drawing.Point(56, 28);
            this.BtnCrypt.Name = "BtnCrypt";
            this.BtnCrypt.Size = new System.Drawing.Size(136, 30);
            this.BtnCrypt.TabIndex = 0;
            this.BtnCrypt.Text = "Metin Şifrele";
            this.BtnCrypt.UseVisualStyleBackColor = true;
            this.BtnCrypt.Click += new System.EventHandler(this.BtnCrypt_Click);
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDecrypt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDecrypt.Location = new System.Drawing.Point(56, 64);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(136, 30);
            this.BtnDecrypt.TabIndex = 1;
            this.BtnDecrypt.Text = "Şifreli Metni Oku";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 123);
            this.Controls.Add(this.BtnDecrypt);
            this.Controls.Add(this.BtnCrypt);
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCrypt;
        private System.Windows.Forms.Button BtnDecrypt;
    }
}

