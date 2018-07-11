namespace LINQDemo
{
    partial class frmLinqtoWiki
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOpenSearch = new System.Windows.Forms.Button();
            this.btnKeywordSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 298);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnOpenSearch
            // 
            this.btnOpenSearch.Location = new System.Drawing.Point(13, 22);
            this.btnOpenSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenSearch.Name = "btnOpenSearch";
            this.btnOpenSearch.Size = new System.Drawing.Size(185, 29);
            this.btnOpenSearch.TabIndex = 2;
            this.btnOpenSearch.Text = "查詢(OpenSearch)";
            this.btnOpenSearch.UseVisualStyleBackColor = true;
            this.btnOpenSearch.Click += new System.EventHandler(this.btnOpenSearch_Click);
            // 
            // btnKeywordSearch
            // 
            this.btnKeywordSearch.Location = new System.Drawing.Point(206, 22);
            this.btnKeywordSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeywordSearch.Name = "btnKeywordSearch";
            this.btnKeywordSearch.Size = new System.Drawing.Size(185, 29);
            this.btnKeywordSearch.TabIndex = 4;
            this.btnKeywordSearch.Text = "查詢(KeywordSearch)";
            this.btnKeywordSearch.UseVisualStyleBackColor = true;
            this.btnKeywordSearch.Click += new System.EventHandler(this.btnKeywordSearch_Click);
            // 
            // frmLinqtoWiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 382);
            this.Controls.Add(this.btnKeywordSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOpenSearch);
            this.Name = "frmLinqtoWiki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLinqtoWiki";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOpenSearch;
        private System.Windows.Forms.Button btnKeywordSearch;
    }
}