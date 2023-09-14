namespace chatClient
{
    partial class Form1
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
            txtNickname = new TextBox();
            txtPort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIP = new TextBox();
            btnSend = new Button();
            txtMsg = new TextBox();
            panel1 = new Panel();
            txtMessages = new TextBox();
            label5 = new Label();
            listClients = new ListBox();
            btnConnect = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNickname
            // 
            txtNickname.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNickname.Location = new Point(104, 15);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(170, 25);
            txtNickname.TabIndex = 0;
            // 
            // txtPort
            // 
            txtPort.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPort.Location = new Point(104, 75);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(170, 25);
            txtPort.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Nickname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 49);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "IP Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 78);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "PORT";
            // 
            // txtIP
            // 
            txtIP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtIP.Location = new Point(104, 45);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(170, 25);
            txtIP.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.DarkSlateGray;
            btnSend.FlatAppearance.BorderColor = Color.White;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Popup;
            btnSend.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(491, 413);
            btnSend.Margin = new Padding(0);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(56, 35);
            btnSend.TabIndex = 9;
            btnSend.Text = ">";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtMsg
            // 
            txtMsg.Location = new Point(21, 420);
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(467, 23);
            txtMsg.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMessages);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(21, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 303);
            panel1.TabIndex = 9;
            // 
            // txtMessages
            // 
            txtMessages.Location = new Point(3, 18);
            txtMessages.Multiline = true;
            txtMessages.Name = "txtMessages";
            txtMessages.Size = new Size(520, 282);
            txtMessages.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 12;
            label5.Text = "MESSAGES";
            // 
            // listClients
            // 
            listClients.FormattingEnabled = true;
            listClients.ItemHeight = 15;
            listClients.Location = new Point(567, 107);
            listClients.Name = "listClients";
            listClients.Size = new Size(221, 304);
            listClients.TabIndex = 13;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(280, 45);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(82, 55);
            btnConnect.TabIndex = 14;
            btnConnect.Text = "CONNECT";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConnect);
            Controls.Add(listClients);
            Controls.Add(panel1);
            Controls.Add(txtMsg);
            Controls.Add(btnSend);
            Controls.Add(txtIP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPort);
            Controls.Add(txtNickname);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNickname;
        private TextBox txtPort;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIP;
        private Button btnSend;
        private TextBox txtMsg;
        private Panel panel1;
        private Label label5;
        private ListBox listClients;
        private Button btnConnect;
        private TextBox txtMessages;
    }
}