namespace LINQDemo
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
            this.btnLINQtoObject = new System.Windows.Forms.Button();
            this.btnLinqtoXML = new System.Windows.Forms.Button();
            this.btnLINQtoDataSet = new System.Windows.Forms.Button();
            this.btnLinqtoSQL = new System.Windows.Forms.Button();
            this.btnLinqtoEntity = new System.Windows.Forms.Button();
            this.btnLINQtoJSON = new System.Windows.Forms.Button();
            this.btnLinqToWiki = new System.Windows.Forms.Button();
            this.btnLinqtoExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLINQtoObject
            // 
            this.btnLINQtoObject.Location = new System.Drawing.Point(137, 44);
            this.btnLINQtoObject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLINQtoObject.Name = "btnLINQtoObject";
            this.btnLINQtoObject.Size = new System.Drawing.Size(175, 29);
            this.btnLINQtoObject.TabIndex = 0;
            this.btnLINQtoObject.Text = "LINQ to Object";
            this.btnLINQtoObject.UseVisualStyleBackColor = true;
            this.btnLINQtoObject.Click += new System.EventHandler(this.btnLINQtoObject_Click);
            // 
            // btnLinqtoXML
            // 
            this.btnLinqtoXML.Location = new System.Drawing.Point(137, 98);
            this.btnLinqtoXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLinqtoXML.Name = "btnLinqtoXML";
            this.btnLinqtoXML.Size = new System.Drawing.Size(175, 29);
            this.btnLinqtoXML.TabIndex = 1;
            this.btnLinqtoXML.Text = "LINQ to XML";
            this.btnLinqtoXML.UseVisualStyleBackColor = true;
            this.btnLinqtoXML.Click += new System.EventHandler(this.btnLinqtoXML_Click);
            // 
            // btnLINQtoDataSet
            // 
            this.btnLINQtoDataSet.Location = new System.Drawing.Point(137, 206);
            this.btnLINQtoDataSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLINQtoDataSet.Name = "btnLINQtoDataSet";
            this.btnLINQtoDataSet.Size = new System.Drawing.Size(175, 29);
            this.btnLINQtoDataSet.TabIndex = 2;
            this.btnLINQtoDataSet.Text = "LINQ to DataSet";
            this.btnLINQtoDataSet.UseVisualStyleBackColor = true;
            this.btnLINQtoDataSet.Click += new System.EventHandler(this.btnLINQtoDataSet_Click);
            // 
            // btnLinqtoSQL
            // 
            this.btnLinqtoSQL.Location = new System.Drawing.Point(137, 260);
            this.btnLinqtoSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLinqtoSQL.Name = "btnLinqtoSQL";
            this.btnLinqtoSQL.Size = new System.Drawing.Size(175, 29);
            this.btnLinqtoSQL.TabIndex = 3;
            this.btnLinqtoSQL.Text = "LINQ to SQL";
            this.btnLinqtoSQL.UseVisualStyleBackColor = true;
            this.btnLinqtoSQL.Click += new System.EventHandler(this.btnLinqtoSQL_Click);
            // 
            // btnLinqtoEntity
            // 
            this.btnLinqtoEntity.Location = new System.Drawing.Point(137, 314);
            this.btnLinqtoEntity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLinqtoEntity.Name = "btnLinqtoEntity";
            this.btnLinqtoEntity.Size = new System.Drawing.Size(175, 29);
            this.btnLinqtoEntity.TabIndex = 4;
            this.btnLinqtoEntity.Text = "LINQ to Entity";
            this.btnLinqtoEntity.UseVisualStyleBackColor = true;
            this.btnLinqtoEntity.Click += new System.EventHandler(this.btnLinqtoEntity_Click);
            // 
            // btnLINQtoJSON
            // 
            this.btnLINQtoJSON.Location = new System.Drawing.Point(137, 152);
            this.btnLINQtoJSON.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLINQtoJSON.Name = "btnLINQtoJSON";
            this.btnLINQtoJSON.Size = new System.Drawing.Size(175, 29);
            this.btnLINQtoJSON.TabIndex = 5;
            this.btnLINQtoJSON.Text = "LINQ to JSON";
            this.btnLINQtoJSON.UseVisualStyleBackColor = true;
            this.btnLINQtoJSON.Click += new System.EventHandler(this.btnLINQtoJSON_Click);
            // 
            // btnLinqToWiki
            // 
            this.btnLinqToWiki.Location = new System.Drawing.Point(137, 422);
            this.btnLinqToWiki.Name = "btnLinqToWiki";
            this.btnLinqToWiki.Size = new System.Drawing.Size(175, 29);
            this.btnLinqToWiki.TabIndex = 6;
            this.btnLinqToWiki.Text = "LINQ to Wiki";
            this.btnLinqToWiki.UseVisualStyleBackColor = true;
            this.btnLinqToWiki.Click += new System.EventHandler(this.btnLinqToWiki_Click);
            // 
            // btnLinqtoExcel
            // 
            this.btnLinqtoExcel.Location = new System.Drawing.Point(137, 368);
            this.btnLinqtoExcel.Name = "btnLinqtoExcel";
            this.btnLinqtoExcel.Size = new System.Drawing.Size(175, 29);
            this.btnLinqtoExcel.TabIndex = 7;
            this.btnLinqtoExcel.Text = "LINQ To Excel";
            this.btnLinqtoExcel.UseVisualStyleBackColor = true;
            this.btnLinqtoExcel.Click += new System.EventHandler(this.btnLinqtoExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 481);
            this.Controls.Add(this.btnLinqtoExcel);
            this.Controls.Add(this.btnLinqToWiki);
            this.Controls.Add(this.btnLINQtoJSON);
            this.Controls.Add(this.btnLinqtoEntity);
            this.Controls.Add(this.btnLinqtoSQL);
            this.Controls.Add(this.btnLINQtoDataSet);
            this.Controls.Add(this.btnLinqtoXML);
            this.Controls.Add(this.btnLINQtoObject);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLINQtoObject;
        private System.Windows.Forms.Button btnLinqtoXML;
        private System.Windows.Forms.Button btnLINQtoDataSet;
        private System.Windows.Forms.Button btnLinqtoSQL;
        private System.Windows.Forms.Button btnLinqtoEntity;
        private System.Windows.Forms.Button btnLINQtoJSON;
        private System.Windows.Forms.Button btnLinqToWiki;
        private System.Windows.Forms.Button btnLinqtoExcel;
    }
}

