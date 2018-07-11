namespace LINQDemo
{
    partial class frmLinqtoObject
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
            this.btnQueryFileLength = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnQueryFileContent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQueryFileLength
            // 
            this.btnQueryFileLength.Location = new System.Drawing.Point(12, 12);
            this.btnQueryFileLength.Name = "btnQueryFileLength";
            this.btnQueryFileLength.Size = new System.Drawing.Size(128, 23);
            this.btnQueryFileLength.TabIndex = 0;
            this.btnQueryFileLength.Text = "依據檔案大小搜尋";
            this.btnQueryFileLength.UseVisualStyleBackColor = true;
            this.btnQueryFileLength.Click += new System.EventHandler(this.btnQueryFileLength_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(951, 231);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnQueryFileContent
            // 
            this.btnQueryFileContent.Location = new System.Drawing.Point(155, 12);
            this.btnQueryFileContent.Name = "btnQueryFileContent";
            this.btnQueryFileContent.Size = new System.Drawing.Size(128, 23);
            this.btnQueryFileContent.TabIndex = 0;
            this.btnQueryFileContent.Text = "依據檔案內容搜尋";
            this.btnQueryFileContent.UseVisualStyleBackColor = true;
            this.btnQueryFileContent.Click += new System.EventHandler(this.btnQueryFileContent_Click);
            // 
            // frmLinqtoObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 289);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQueryFileContent);
            this.Controls.Add(this.btnQueryFileLength);
            this.Name = "frmLinqtoObject";
            this.Text = "frmLinqtoObject";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQueryFileLength;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnQueryFileContent;
    }
}