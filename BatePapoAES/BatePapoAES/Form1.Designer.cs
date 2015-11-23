namespace BatePapoAES
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
            this.txtConversa = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerLog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeakAText = new System.Windows.Forms.TextBox();
            this.SpeakBText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConversa
            // 
            this.txtConversa.Location = new System.Drawing.Point(12, 42);
            this.txtConversa.Name = "txtConversa";
            this.txtConversa.Size = new System.Drawing.Size(435, 164);
            this.txtConversa.TabIndex = 0;
            this.txtConversa.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversa Secreta";
            // 
            // ServerLog
            // 
            this.ServerLog.Location = new System.Drawing.Point(494, 42);
            this.ServerLog.Name = "ServerLog";
            this.ServerLog.Size = new System.Drawing.Size(197, 164);
            this.ServerLog.TabIndex = 2;
            this.ServerLog.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server Log";
            // 
            // SpeakAText
            // 
            this.SpeakAText.Location = new System.Drawing.Point(15, 252);
            this.SpeakAText.Name = "SpeakAText";
            this.SpeakAText.Size = new System.Drawing.Size(190, 20);
            this.SpeakAText.TabIndex = 4;
            // 
            // SpeakBText
            // 
            this.SpeakBText.Location = new System.Drawing.Point(15, 305);
            this.SpeakBText.Name = "SpeakBText";
            this.SpeakBText.Size = new System.Drawing.Size(190, 20);
            this.SpeakBText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "João";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maria";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 365);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpeakBText);
            this.Controls.Add(this.SpeakAText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConversa);
            this.Name = "Form1";
            this.Text = "Conversa Secreta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtConversa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ServerLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SpeakAText;
        private System.Windows.Forms.TextBox SpeakBText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

