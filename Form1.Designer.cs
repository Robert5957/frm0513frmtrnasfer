
namespace frm0513frmtrnasfer
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
            this.button_Form2 = new System.Windows.Forms.Button();
            this.button_Message = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Form2
            // 
            this.button_Form2.Location = new System.Drawing.Point(125, 112);
            this.button_Form2.Name = "button_Form2";
            this.button_Form2.Size = new System.Drawing.Size(218, 147);
            this.button_Form2.TabIndex = 0;
            this.button_Form2.Text = "button_Form2";
            this.button_Form2.UseVisualStyleBackColor = true;
            this.button_Form2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Message
            // 
            this.button_Message.Location = new System.Drawing.Point(466, 112);
            this.button_Message.Name = "button_Message";
            this.button_Message.Size = new System.Drawing.Size(218, 147);
            this.button_Message.TabIndex = 1;
            this.button_Message.Text = "button_Message";
            this.button_Message.UseVisualStyleBackColor = true;
            this.button_Message.Click += new System.EventHandler(this.button_Message_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Message);
            this.Controls.Add(this.button_Form2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Form2;
        private System.Windows.Forms.Button button_Message;
    }
}

