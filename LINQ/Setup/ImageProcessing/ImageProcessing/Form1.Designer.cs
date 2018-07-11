namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGreyScale = new System.Windows.Forms.Button();
            this.btnBlend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGreyScale
            // 
            this.btnGreyScale.Location = new System.Drawing.Point(115, 33);
            this.btnGreyScale.Name = "btnGreyScale";
            this.btnGreyScale.Size = new System.Drawing.Size(75, 23);
            this.btnGreyScale.TabIndex = 0;
            this.btnGreyScale.Text = "灰階";
            this.btnGreyScale.UseVisualStyleBackColor = true;
            this.btnGreyScale.Click += new System.EventHandler(this.btnGreyScale_Click);
            // 
            // btnBlend
            // 
            this.btnBlend.Location = new System.Drawing.Point(115, 72);
            this.btnBlend.Name = "btnBlend";
            this.btnBlend.Size = new System.Drawing.Size(75, 23);
            this.btnBlend.TabIndex = 1;
            this.btnBlend.Text = "合成";
            this.btnBlend.UseVisualStyleBackColor = true;
            this.btnBlend.Click += new System.EventHandler(this.btnBlend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 199);
            this.Controls.Add(this.btnBlend);
            this.Controls.Add(this.btnGreyScale);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "平行運算程式設計";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGreyScale;
        private System.Windows.Forms.Button btnBlend;
    }
}

