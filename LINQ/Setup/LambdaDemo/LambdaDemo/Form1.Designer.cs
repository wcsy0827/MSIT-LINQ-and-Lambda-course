﻿namespace LambdaDemo
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
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.btnControlArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(99, 34);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(105, 23);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Circle Area";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(99, 74);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(105, 23);
            this.btnClickMe.TabIndex = 1;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            // 
            // btnControlArray
            // 
            this.btnControlArray.Location = new System.Drawing.Point(99, 113);
            this.btnControlArray.Name = "btnControlArray";
            this.btnControlArray.Size = new System.Drawing.Size(105, 23);
            this.btnControlArray.TabIndex = 2;
            this.btnControlArray.Text = " Control Array";
            this.btnControlArray.UseVisualStyleBackColor = true;
            this.btnControlArray.Click += new System.EventHandler(this.btnControlArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 233);
            this.Controls.Add(this.btnControlArray);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.btnCircle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Button btnControlArray;
    }
}
