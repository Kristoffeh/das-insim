namespace Das_Insim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "30000";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(196, 16);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(11, 302);
            this.message.MaxLength = 95;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(401, 20);
            this.message.TabIndex = 3;
            this.message.TextChanged += new System.EventHandler(this.message_TextChanged);
            this.message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.message_KeyDown);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(418, 302);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 39);
            this.send.TabIndex = 5;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(11, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "95";
            // 
            // textBox2
            // 
            this.textBox2.FormattingEnabled = true;
            this.textBox2.Location = new System.Drawing.Point(11, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(482, 251);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(501, 360);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.send);
            this.Controls.Add(this.message);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Text = "Local InSim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button connect;
        public System.Windows.Forms.TextBox message;
        public System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox textBox2;
    }
}

