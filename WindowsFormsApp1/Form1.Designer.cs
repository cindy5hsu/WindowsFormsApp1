namespace WindowsFormsApp1
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generalbutton = new System.Windows.Forms.Button();
            this.generalbutton01 = new System.Windows.Forms.Button();
            this.generalbutton02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(161, 35);
            this.rowsTextBox.MaxLength = 3;
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(100, 29);
            this.rowsTextBox.TabIndex = 0;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultTextBox.Location = new System.Drawing.Point(96, 186);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(697, 281);
            this.resultTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "列數：";
            // 
            // generalbutton
            // 
            this.generalbutton.Location = new System.Drawing.Point(268, 38);
            this.generalbutton.Name = "generalbutton";
            this.generalbutton.Size = new System.Drawing.Size(107, 26);
            this.generalbutton.TabIndex = 3;
            this.generalbutton.Text = " 顯示左邊";
            this.generalbutton.UseVisualStyleBackColor = true;
            this.generalbutton.Click += new System.EventHandler(this.generalbutton_Click);
            // 
            // generalbutton01
            // 
            this.generalbutton01.Location = new System.Drawing.Point(268, 70);
            this.generalbutton01.Name = "generalbutton01";
            this.generalbutton01.Size = new System.Drawing.Size(107, 29);
            this.generalbutton01.TabIndex = 4;
            this.generalbutton01.Text = "顯示右邊";
            this.generalbutton01.UseVisualStyleBackColor = true;
            this.generalbutton01.Click += new System.EventHandler(this.generalbutton01_Click);
            // 
            // generalbutton02
            // 
            this.generalbutton02.Location = new System.Drawing.Point(268, 105);
            this.generalbutton02.Name = "generalbutton02";
            this.generalbutton02.Size = new System.Drawing.Size(107, 26);
            this.generalbutton02.TabIndex = 5;
            this.generalbutton02.Text = "等腰三角形";
            this.generalbutton02.UseVisualStyleBackColor = true;
            this.generalbutton02.Click += new System.EventHandler(this.generalbutton02_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 505);
            this.Controls.Add(this.generalbutton02);
            this.Controls.Add(this.generalbutton01);
            this.Controls.Add(this.generalbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.rowsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generalbutton;
        private System.Windows.Forms.Button generalbutton01;
        private System.Windows.Forms.Button generalbutton02;
    }
}

