namespace EncryptionForm
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 149);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.outputBox.Location = new System.Drawing.Point(12, 73);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(419, 21);
            this.outputBox.TabIndex = 2;
            this.outputBox.Text = "Result";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 27);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(419, 23);
            this.inputBox.TabIndex = 3;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 149);
            this.button2.TabIndex = 4;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "MD5-Encryption/Decryption Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button button2;
    }
}

