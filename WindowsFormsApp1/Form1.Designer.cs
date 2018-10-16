namespace WindowsFormsApp1
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
            this.input = new System.Windows.Forms.TextBox();
            this.encrypt1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.encrypt2 = new System.Windows.Forms.Button();
            this.encrypt3 = new System.Windows.Forms.Button();
            this.decrypt3 = new System.Windows.Forms.Button();
            this.decrypt2 = new System.Windows.Forms.Button();
            this.decrypt1 = new System.Windows.Forms.Button();
            this.encryption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decryption = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(83, 45);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(115, 20);
            this.input.TabIndex = 0;
            // 
            // encrypt1
            // 
            this.encrypt1.Location = new System.Drawing.Point(7, 71);
            this.encrypt1.Name = "encrypt1";
            this.encrypt1.Size = new System.Drawing.Size(127, 23);
            this.encrypt1.TabIndex = 1;
            this.encrypt1.Text = "encrypt (Reversal)";
            this.encrypt1.UseVisualStyleBackColor = true;
            this.encrypt1.Click += new System.EventHandler(this.encrypt1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encrypt / Decrypt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // encrypt2
            // 
            this.encrypt2.Location = new System.Drawing.Point(7, 100);
            this.encrypt2.Name = "encrypt2";
            this.encrypt2.Size = new System.Drawing.Size(127, 23);
            this.encrypt2.TabIndex = 3;
            this.encrypt2.Text = "encrypt  (Replacement)";
            this.encrypt2.UseVisualStyleBackColor = true;
            this.encrypt2.Click += new System.EventHandler(this.encrypt2_Click);
            // 
            // encrypt3
            // 
            this.encrypt3.Location = new System.Drawing.Point(7, 129);
            this.encrypt3.Name = "encrypt3";
            this.encrypt3.Size = new System.Drawing.Size(127, 23);
            this.encrypt3.TabIndex = 4;
            this.encrypt3.Text = "encrypt  (Mixed)";
            this.encrypt3.UseVisualStyleBackColor = true;
            this.encrypt3.Click += new System.EventHandler(this.encrypt3_Click);
            // 
            // decrypt3
            // 
            this.decrypt3.Location = new System.Drawing.Point(140, 129);
            this.decrypt3.Name = "decrypt3";
            this.decrypt3.Size = new System.Drawing.Size(132, 23);
            this.decrypt3.TabIndex = 7;
            this.decrypt3.Text = "decrypt (Mixed)";
            this.decrypt3.UseVisualStyleBackColor = true;
            this.decrypt3.Click += new System.EventHandler(this.decrypt3_Click);
            // 
            // decrypt2
            // 
            this.decrypt2.Location = new System.Drawing.Point(140, 100);
            this.decrypt2.Name = "decrypt2";
            this.decrypt2.Size = new System.Drawing.Size(132, 23);
            this.decrypt2.TabIndex = 6;
            this.decrypt2.Text = "decrypt  (Replacement)";
            this.decrypt2.UseVisualStyleBackColor = true;
            this.decrypt2.Click += new System.EventHandler(this.decrypt2_Click);
            // 
            // decrypt1
            // 
            this.decrypt1.Location = new System.Drawing.Point(140, 71);
            this.decrypt1.Name = "decrypt1";
            this.decrypt1.Size = new System.Drawing.Size(132, 23);
            this.decrypt1.TabIndex = 5;
            this.decrypt1.Text = "decrypt  (Reversal)";
            this.decrypt1.UseVisualStyleBackColor = true;
            this.decrypt1.Click += new System.EventHandler(this.decrypt1_Click);
            // 
            // encryption
            // 
            this.encryption.Location = new System.Drawing.Point(83, 158);
            this.encryption.Name = "encryption";
            this.encryption.Size = new System.Drawing.Size(115, 20);
            this.encryption.TabIndex = 8;
            this.encryption.TextChanged += new System.EventHandler(this.encryption_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Encryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Decryption";
            // 
            // decryption
            // 
            this.decryption.Location = new System.Drawing.Point(83, 184);
            this.decryption.Name = "decryption";
            this.decryption.Size = new System.Drawing.Size(115, 20);
            this.decryption.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Input";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decryption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryption);
            this.Controls.Add(this.decrypt3);
            this.Controls.Add(this.decrypt2);
            this.Controls.Add(this.decrypt1);
            this.Controls.Add(this.encrypt3);
            this.Controls.Add(this.encrypt2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encrypt1);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button encrypt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encrypt2;
        private System.Windows.Forms.Button encrypt3;
        private System.Windows.Forms.Button decrypt3;
        private System.Windows.Forms.Button decrypt2;
        private System.Windows.Forms.Button decrypt1;
        private System.Windows.Forms.TextBox encryption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decryption;
        private System.Windows.Forms.Label label4;
    }
}

