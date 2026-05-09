namespace 簡易電子琴
{
    partial class frmBeepPlayer
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
            this.palMain = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.palMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // palMain
            // 
            this.palMain.Controls.Add(this.button8);
            this.palMain.Controls.Add(this.button7);
            this.palMain.Controls.Add(this.button6);
            this.palMain.Controls.Add(this.button5);
            this.palMain.Controls.Add(this.button4);
            this.palMain.Controls.Add(this.button3);
            this.palMain.Controls.Add(this.button2);
            this.palMain.Controls.Add(this.button1);
            this.palMain.Location = new System.Drawing.Point(30, 24);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(636, 150);
            this.palMain.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 111);
            this.button1.TabIndex = 0;
            this.button1.Text = "Do";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 111);
            this.button2.TabIndex = 1;
            this.button2.Text = "Re";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 111);
            this.button3.TabIndex = 2;
            this.button3.Text = "Mi";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(240, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 111);
            this.button4.TabIndex = 3;
            this.button4.Text = "Fa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(315, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 111);
            this.button5.TabIndex = 4;
            this.button5.Text = "So";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(390, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 111);
            this.button6.TabIndex = 5;
            this.button6.Text = "La";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(465, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 111);
            this.button7.TabIndex = 6;
            this.button7.Text = "Si";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Location = new System.Drawing.Point(540, 18);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 111);
            this.button8.TabIndex = 7;
            this.button8.Text = "Do";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // frmBeepPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 209);
            this.Controls.Add(this.palMain);
            this.Name = "frmBeepPlayer";
            this.Text = "簡易電子琴";
            this.Load += new System.EventHandler(this.frmBeepPlayer_Load);
            this.SizeChanged += new System.EventHandler(this.frmBeepPlayer_SizeChanged);
            this.palMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
    }
}

