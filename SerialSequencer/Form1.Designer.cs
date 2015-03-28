namespace SerialSequencer
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Byte1 = new System.Windows.Forms.TextBox();
            this.Byte2 = new System.Windows.Forms.TextBox();
            this.Byte3 = new System.Windows.Forms.TextBox();
            this.Byte4 = new System.Windows.Forms.TextBox();
            this.Byte5 = new System.Windows.Forms.TextBox();
            this.Byte6 = new System.Windows.Forms.TextBox();
            this.Byte7 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Delay = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Ports = new System.Windows.Forms.ComboBox();
            this.Rate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Stopper = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Init_Ports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Init";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bytes";
            // 
            // Byte1
            // 
            this.Byte1.Location = new System.Drawing.Point(12, 106);
            this.Byte1.Name = "Byte1";
            this.Byte1.Size = new System.Drawing.Size(36, 20);
            this.Byte1.TabIndex = 4;
            // 
            // Byte2
            // 
            this.Byte2.Location = new System.Drawing.Point(54, 106);
            this.Byte2.Name = "Byte2";
            this.Byte2.Size = new System.Drawing.Size(36, 20);
            this.Byte2.TabIndex = 6;
            // 
            // Byte3
            // 
            this.Byte3.Location = new System.Drawing.Point(96, 106);
            this.Byte3.Name = "Byte3";
            this.Byte3.Size = new System.Drawing.Size(36, 20);
            this.Byte3.TabIndex = 7;
            // 
            // Byte4
            // 
            this.Byte4.Location = new System.Drawing.Point(138, 106);
            this.Byte4.Name = "Byte4";
            this.Byte4.Size = new System.Drawing.Size(36, 20);
            this.Byte4.TabIndex = 8;
            // 
            // Byte5
            // 
            this.Byte5.Location = new System.Drawing.Point(180, 106);
            this.Byte5.Name = "Byte5";
            this.Byte5.Size = new System.Drawing.Size(36, 20);
            this.Byte5.TabIndex = 9;
            // 
            // Byte6
            // 
            this.Byte6.Location = new System.Drawing.Point(222, 106);
            this.Byte6.Name = "Byte6";
            this.Byte6.Size = new System.Drawing.Size(36, 20);
            this.Byte6.TabIndex = 10;
            // 
            // Byte7
            // 
            this.Byte7.Location = new System.Drawing.Point(264, 106);
            this.Byte7.Name = "Byte7";
            this.Byte7.Size = new System.Drawing.Size(36, 20);
            this.Byte7.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Delay (ms)";
            // 
            // Delay
            // 
            this.Delay.Location = new System.Drawing.Point(12, 155);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(100, 20);
            this.Delay.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ports
            // 
            this.Ports.FormattingEnabled = true;
            this.Ports.Location = new System.Drawing.Point(12, 21);
            this.Ports.Name = "Ports";
            this.Ports.Size = new System.Drawing.Size(121, 21);
            this.Ports.TabIndex = 15;
            this.Ports.SelectedIndexChanged += new System.EventHandler(this.Ports_SelectedIndexChanged);
            // 
            // Rate
            // 
            this.Rate.FormattingEnabled = true;
            this.Rate.Location = new System.Drawing.Point(148, 21);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(121, 21);
            this.Rate.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rate";
            // 
            // Stopper
            // 
            this.Stopper.Location = new System.Drawing.Point(255, 206);
            this.Stopper.Name = "Stopper";
            this.Stopper.Size = new System.Drawing.Size(75, 23);
            this.Stopper.TabIndex = 18;
            this.Stopper.Text = "Stop";
            this.Stopper.UseVisualStyleBackColor = true;
            this.Stopper.Click += new System.EventHandler(this.Stopper_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "MessageLength";
            // 
            // mLength
            // 
            this.mLength.Location = new System.Drawing.Point(12, 61);
            this.mLength.Name = "mLength";
            this.mLength.Size = new System.Drawing.Size(36, 20);
            this.mLength.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 262);
            this.Controls.Add(this.mLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Stopper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Ports);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Byte7);
            this.Controls.Add(this.Byte6);
            this.Controls.Add(this.Byte5);
            this.Controls.Add(this.Byte4);
            this.Controls.Add(this.Byte3);
            this.Controls.Add(this.Byte2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Byte1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Byte1;
        private System.Windows.Forms.TextBox Byte2;
        private System.Windows.Forms.TextBox Byte3;
        private System.Windows.Forms.TextBox Byte4;
        private System.Windows.Forms.TextBox Byte5;
        private System.Windows.Forms.TextBox Byte6;
        private System.Windows.Forms.TextBox Byte7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Delay;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Ports;
        private System.Windows.Forms.ComboBox Rate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Stopper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mLength;
    }
}

