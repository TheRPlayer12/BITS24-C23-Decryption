namespace BITS24_C23
{
    partial class Decryption
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SubmitBtn = new Button();
            label3 = new Label();
            InputTxt = new TextBox();
            OutputTxt = new TextBox();
            label4 = new Label();
            label1 = new Label();
            RsaKeyTxt = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(426, 279);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(133, 36);
            SubmitBtn.TabIndex = 0;
            SubmitBtn.Text = "Decrypt";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(296, 46);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 3;
            label3.Text = "Decrypted Text";
            // 
            // InputTxt
            // 
            InputTxt.Location = new Point(12, 79);
            InputTxt.Multiline = true;
            InputTxt.Name = "InputTxt";
            InputTxt.Size = new Size(278, 187);
            InputTxt.TabIndex = 4;
            // 
            // OutputTxt
            // 
            OutputTxt.Location = new Point(296, 79);
            OutputTxt.Multiline = true;
            OutputTxt.Name = "OutputTxt";
            OutputTxt.ReadOnly = true;
            OutputTxt.Size = new Size(263, 187);
            OutputTxt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(12, 46);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 6;
            label4.Text = "Text to decrypt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 7;
            label1.Text = "RSA Text Decryption";
            // 
            // RsaKeyTxt
            // 
            RsaKeyTxt.Location = new Point(12, 292);
            RsaKeyTxt.Name = "RsaKeyTxt";
            RsaKeyTxt.Size = new Size(408, 23);
            RsaKeyTxt.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 269);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 9;
            label2.Text = "RSA Private Key";
            // 
            // Decryption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 327);
            Controls.Add(label2);
            Controls.Add(RsaKeyTxt);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(OutputTxt);
            Controls.Add(InputTxt);
            Controls.Add(label3);
            Controls.Add(SubmitBtn);
            Name = "Decryption";
            Text = "RSA Encryptor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitBtn;
        private Label label3;
        private TextBox InputTxt;
        private TextBox OutputTxt;
        private Label label4;
        private Label label1;
        private TextBox RsaKeyTxt;
        private Label label2;
    }
}
