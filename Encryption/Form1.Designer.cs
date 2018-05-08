namespace Encryption
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlainText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.cbHide = new System.Windows.Forms.CheckBox();
            this.cbIsShowingX = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(99, 38);
            this.tbKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(211, 25);
            this.tbKey.TabIndex = 0;
            this.tbKey.TextChanged += new System.EventHandler(this.tbKey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key";
            // 
            // tbPlainText
            // 
            this.tbPlainText.Location = new System.Drawing.Point(99, 75);
            this.tbPlainText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPlainText.Multiline = true;
            this.tbPlainText.Name = "tbPlainText";
            this.tbPlainText.Size = new System.Drawing.Size(211, 90);
            this.tbPlainText.TabIndex = 2;
            this.tbPlainText.TextChanged += new System.EventHandler(this.tbPlainText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "PlainText";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(97, 175);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 15);
            this.lbResult.TabIndex = 6;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(18, 284);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(144, 29);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(166, 282);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(144, 31);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(100, 172);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(211, 93);
            this.tbResult.TabIndex = 8;
            this.tbResult.Click += new System.EventHandler(this.tbResult_Click);
            this.tbResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbResult_MouseClick);
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // cbHide
            // 
            this.cbHide.AutoSize = true;
            this.cbHide.Location = new System.Drawing.Point(223, 12);
            this.cbHide.Name = "cbHide";
            this.cbHide.Size = new System.Drawing.Size(92, 19);
            this.cbHide.TabIndex = 9;
            this.cbHide.Text = "Hide Text";
            this.cbHide.UseVisualStyleBackColor = true;
            this.cbHide.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbIsShowingX
            // 
            this.cbIsShowingX.AutoSize = true;
            this.cbIsShowingX.Location = new System.Drawing.Point(9, 12);
            this.cbIsShowingX.Name = "cbIsShowingX";
            this.cbIsShowingX.Size = new System.Drawing.Size(208, 19);
            this.cbIsShowingX.TabIndex = 10;
            this.cbIsShowingX.Text = "Include X of Decrypt Result";
            this.cbIsShowingX.UseVisualStyleBackColor = true;
            this.cbIsShowingX.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 326);
            this.Controls.Add(this.cbIsShowingX);
            this.Controls.Add(this.cbHide);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPlainText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKey);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPlainText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.CheckBox cbHide;
        private System.Windows.Forms.CheckBox cbIsShowingX;
    }
}

