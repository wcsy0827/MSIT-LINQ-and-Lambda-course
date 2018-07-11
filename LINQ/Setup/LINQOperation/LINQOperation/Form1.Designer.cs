namespace LINQOperation
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
            this.btnGroupByCount = new System.Windows.Forms.Button();
            this.btnDistinct = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMinMaxAverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGroupByCount
            // 
            this.btnGroupByCount.Location = new System.Drawing.Point(30, 134);
            this.btnGroupByCount.Name = "btnGroupByCount";
            this.btnGroupByCount.Size = new System.Drawing.Size(100, 23);
            this.btnGroupByCount.TabIndex = 3;
            this.btnGroupByCount.Text = "GroupBy/Count";
            this.btnGroupByCount.UseVisualStyleBackColor = true;
            this.btnGroupByCount.Click += new System.EventHandler(this.btnGroupByCount_Click);
            // 
            // btnDistinct
            // 
            this.btnDistinct.Location = new System.Drawing.Point(44, 12);
            this.btnDistinct.Name = "btnDistinct";
            this.btnDistinct.Size = new System.Drawing.Size(75, 23);
            this.btnDistinct.TabIndex = 0;
            this.btnDistinct.Text = "Distinct";
            this.btnDistinct.UseVisualStyleBackColor = true;
            this.btnDistinct.Click += new System.EventHandler(this.btnDistinct_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(44, 50);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMinMaxAverage
            // 
            this.btnMinMaxAverage.Location = new System.Drawing.Point(30, 92);
            this.btnMinMaxAverage.Name = "btnMinMaxAverage";
            this.btnMinMaxAverage.Size = new System.Drawing.Size(100, 23);
            this.btnMinMaxAverage.TabIndex = 2;
            this.btnMinMaxAverage.Text = "Min/Max/Average";
            this.btnMinMaxAverage.UseVisualStyleBackColor = true;
            this.btnMinMaxAverage.Click += new System.EventHandler(this.btnMinMaxAverage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 185);
            this.Controls.Add(this.btnMinMaxAverage);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnDistinct);
            this.Controls.Add(this.btnGroupByCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGroupByCount;
        private System.Windows.Forms.Button btnDistinct;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMinMaxAverage;
    }
}

