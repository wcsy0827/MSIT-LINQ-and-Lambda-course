namespace ImageProcessing
{
    partial class GreyScaleForm
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
            this.tmParallel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnParallel = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tmNonParallel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNonParallel = new System.Windows.Forms.Button();
            this.picGreyScale = new System.Windows.Forms.PictureBox();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // tmParallel
            // 
            this.tmParallel.Location = new System.Drawing.Point(231, 381);
            this.tmParallel.Name = "tmParallel";
            this.tmParallel.Size = new System.Drawing.Size(100, 22);
            this.tmParallel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "耗時: ";
            // 
            // btnParallel
            // 
            this.btnParallel.Location = new System.Drawing.Point(13, 381);
            this.btnParallel.Name = "btnParallel";
            this.btnParallel.Size = new System.Drawing.Size(176, 26);
            this.btnParallel.TabIndex = 2;
            this.btnParallel.Click += new System.EventHandler(this.btnParallel_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(13, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 26);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "開啟舊檔";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tmNonParallel
            // 
            this.tmNonParallel.Location = new System.Drawing.Point(231, 344);
            this.tmNonParallel.Name = "tmNonParallel";
            this.tmNonParallel.Size = new System.Drawing.Size(100, 22);
            this.tmNonParallel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "耗時: ";
            // 
            // btnNonParallel
            // 
            this.btnNonParallel.Location = new System.Drawing.Point(13, 344);
            this.btnNonParallel.Name = "btnNonParallel";
            this.btnNonParallel.Size = new System.Drawing.Size(176, 26);
            this.btnNonParallel.TabIndex = 1;
            this.btnNonParallel.Text = "非平行運算";
            this.btnNonParallel.Click += new System.EventHandler(this.btnNonParallel_Click);
            // 
            // picGreyScale
            // 
            this.picGreyScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGreyScale.Location = new System.Drawing.Point(365, 49);
            this.picGreyScale.Name = "picGreyScale";
            this.picGreyScale.Size = new System.Drawing.Size(288, 277);
            this.picGreyScale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreyScale.TabIndex = 13;
            this.picGreyScale.TabStop = false;
            // 
            // picOriginal
            // 
            this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOriginal.Location = new System.Drawing.Point(13, 49);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(312, 277);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 12;
            this.picOriginal.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "原圖";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "灰階";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "毫秒";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "毫秒";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "圖檔(*.jpg;*.png)|*.jpg;*.png";
            // 
            // GreyScaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 422);
            this.Controls.Add(this.tmParallel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnParallel);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tmNonParallel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNonParallel);
            this.Controls.Add(this.picGreyScale);
            this.Controls.Add(this.picOriginal);
            this.Name = "GreyScaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GreyScaleForm";
            this.Load += new System.EventHandler(this.GreyScaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGreyScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tmParallel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnParallel;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tmNonParallel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNonParallel;
        private System.Windows.Forms.PictureBox picGreyScale;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}