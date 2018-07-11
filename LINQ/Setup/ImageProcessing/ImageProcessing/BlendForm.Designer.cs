namespace ImageProcessing
{
    partial class BlendForm
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
            this.picImage1 = new System.Windows.Forms.PictureBox();
            this.picImage2 = new System.Windows.Forms.PictureBox();
            this.picBlended = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChoose1 = new System.Windows.Forms.Button();
            this.btnChoose2 = new System.Windows.Forms.Button();
            this.tmParallel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tmNonParallel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNonParallel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnParallel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlended)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage1
            // 
            this.picImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage1.Location = new System.Drawing.Point(7, 61);
            this.picImage1.Name = "picImage1";
            this.picImage1.Size = new System.Drawing.Size(301, 301);
            this.picImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage1.TabIndex = 0;
            this.picImage1.TabStop = false;
            // 
            // picImage2
            // 
            this.picImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage2.Location = new System.Drawing.Point(314, 61);
            this.picImage2.Name = "picImage2";
            this.picImage2.Size = new System.Drawing.Size(301, 301);
            this.picImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage2.TabIndex = 0;
            this.picImage2.TabStop = false;
            // 
            // picBlended
            // 
            this.picBlended.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBlended.Location = new System.Drawing.Point(621, 61);
            this.picBlended.Name = "picBlended";
            this.picBlended.Size = new System.Drawing.Size(301, 301);
            this.picBlended.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlended.TabIndex = 0;
            this.picBlended.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "第一個圖";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "第二個圖";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(869, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "合成圖";
            // 
            // btnChoose1
            // 
            this.btnChoose1.Location = new System.Drawing.Point(12, 31);
            this.btnChoose1.Name = "btnChoose1";
            this.btnChoose1.Size = new System.Drawing.Size(75, 23);
            this.btnChoose1.TabIndex = 0;
            this.btnChoose1.Text = "選圖";
            this.btnChoose1.UseVisualStyleBackColor = true;
            this.btnChoose1.Click += new System.EventHandler(this.btnChoose1_Click);
            // 
            // btnChoose2
            // 
            this.btnChoose2.Location = new System.Drawing.Point(325, 32);
            this.btnChoose2.Name = "btnChoose2";
            this.btnChoose2.Size = new System.Drawing.Size(75, 23);
            this.btnChoose2.TabIndex = 2;
            this.btnChoose2.Text = "選圖";
            this.btnChoose2.UseVisualStyleBackColor = true;
            this.btnChoose2.Click += new System.EventHandler(this.btnChoose2_Click);
            // 
            // tmParallel
            // 
            this.tmParallel.Location = new System.Drawing.Point(225, 414);
            this.tmParallel.Name = "tmParallel";
            this.tmParallel.Size = new System.Drawing.Size(100, 22);
            this.tmParallel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "耗時: ";
            // 
            // tmNonParallel
            // 
            this.tmNonParallel.Location = new System.Drawing.Point(225, 377);
            this.tmNonParallel.Name = "tmNonParallel";
            this.tmNonParallel.Size = new System.Drawing.Size(100, 22);
            this.tmNonParallel.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "毫秒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "毫秒";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "耗時: ";
            // 
            // btnNonParallel
            // 
            this.btnNonParallel.Location = new System.Drawing.Point(7, 377);
            this.btnNonParallel.Name = "btnNonParallel";
            this.btnNonParallel.Size = new System.Drawing.Size(176, 26);
            this.btnNonParallel.TabIndex = 5;
            this.btnNonParallel.Text = "非平行運算";
            this.btnNonParallel.Click += new System.EventHandler(this.btnNonParallel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "圖檔(*.jpg;*.png)|*.jpg;*.png";
            // 
            // btnParallel
            // 
            this.btnParallel.Location = new System.Drawing.Point(7, 414);
            this.btnParallel.Name = "btnParallel";
            this.btnParallel.Size = new System.Drawing.Size(176, 26);
            this.btnParallel.TabIndex = 6;
            this.btnParallel.Click += new System.EventHandler(this.btnParallel_Click);
            // 
            // BlendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 452);
            this.Controls.Add(this.tmParallel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnParallel);
            this.Controls.Add(this.tmNonParallel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNonParallel);
            this.Controls.Add(this.btnChoose2);
            this.Controls.Add(this.btnChoose1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBlended);
            this.Controls.Add(this.picImage2);
            this.Controls.Add(this.picImage1);
            this.Name = "BlendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BlendForm";
            this.Load += new System.EventHandler(this.BlendForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlended)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage1;
        private System.Windows.Forms.PictureBox picImage2;
        private System.Windows.Forms.PictureBox picBlended;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChoose1;
        private System.Windows.Forms.Button btnChoose2;
        private System.Windows.Forms.TextBox tmParallel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tmNonParallel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNonParallel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnParallel;
    }
}