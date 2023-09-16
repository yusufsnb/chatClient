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
            txtMessages = new RichTextBox();
            label5 = new Label();
            listClients = new ListBox();
            btnConnect = new Button();
            label4 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            checkSend = new CheckBox();
            checkLastFilter = new CheckBox();
            checkContainFolder = new CheckBox();
            txtContains = new TextBox();
            radioButton1 = new RadioButton();
            numLast = new NumericUpDown();
            radioButton2 = new RadioButton();
            btnFilterMode = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLast).BeginInit();
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
            btnSend.Location = new Point(465, 352);
            btnSend.Margin = new Padding(0);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(171, 35);
            btnSend.TabIndex = 9;
            btnSend.Text = ">";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtMsg
            // 
            txtMsg.Location = new Point(21, 361);
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(438, 23);
            txtMsg.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMessages);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(21, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 248);
            panel1.TabIndex = 9;
            // 
            // txtMessages
            // 
            txtMessages.Location = new Point(2, 18);
            txtMessages.Name = "txtMessages";
            txtMessages.Size = new Size(434, 225);
            txtMessages.TabIndex = 16;
            txtMessages.Text = "";
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
            listClients.Location = new Point(465, 106);
            listClients.Name = "listClients";
            listClients.Size = new Size(171, 244);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(395, 50);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 15;
            label4.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(443, 50);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 16;
            label6.Text = "-";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(650, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(422, 262);
            dataGridView1.TabIndex = 17;
            // 
            // checkSend
            // 
            checkSend.AutoSize = true;
            checkSend.Location = new Point(678, 13);
            checkSend.Name = "checkSend";
            checkSend.Size = new Size(102, 19);
            checkSend.TabIndex = 18;
            checkSend.Text = "By me / To me";
            checkSend.UseVisualStyleBackColor = true;
            // 
            // checkLastFilter
            // 
            checkLastFilter.AutoSize = true;
            checkLastFilter.Location = new Point(678, 43);
            checkLastFilter.Name = "checkLastFilter";
            checkLastFilter.Size = new Size(68, 19);
            checkLastFilter.TabIndex = 19;
            checkLastFilter.Text = "Get Last";
            checkLastFilter.UseVisualStyleBackColor = true;
            // 
            // checkContainFolder
            // 
            checkContainFolder.AutoSize = true;
            checkContainFolder.Location = new Point(678, 73);
            checkContainFolder.Name = "checkContainFolder";
            checkContainFolder.Size = new Size(73, 19);
            checkContainFolder.TabIndex = 20;
            checkContainFolder.Text = "Contains";
            checkContainFolder.UseVisualStyleBackColor = true;
            // 
            // txtContains
            // 
            txtContains.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtContains.Location = new Point(789, 67);
            txtContains.Name = "txtContains";
            txtContains.Size = new Size(170, 25);
            txtContains.TabIndex = 23;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(789, 13);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 19);
            radioButton1.TabIndex = 24;
            radioButton1.TabStop = true;
            radioButton1.Text = "To me";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // numLast
            // 
            numLast.Location = new Point(789, 38);
            numLast.Name = "numLast";
            numLast.Size = new Size(37, 23);
            numLast.TabIndex = 25;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(852, 13);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(58, 19);
            radioButton2.TabIndex = 26;
            radioButton2.TabStop = true;
            radioButton2.Text = "By me";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnFilterMode
            // 
            btnFilterMode.Location = new Point(789, 94);
            btnFilterMode.Name = "btnFilterMode";
            btnFilterMode.Size = new Size(170, 25);
            btnFilterMode.TabIndex = 27;
            btnFilterMode.Text = "FILTER";
            btnFilterMode.UseVisualStyleBackColor = true;
            btnFilterMode.Click += btnFilterMode_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1084, 392);
            Controls.Add(btnFilterMode);
            Controls.Add(radioButton2);
            Controls.Add(numLast);
            Controls.Add(radioButton1);
            Controls.Add(txtContains);
            Controls.Add(checkContainFolder);
            Controls.Add(checkLastFilter);
            Controls.Add(checkSend);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label4);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLast).EndInit();
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
        private RichTextBox txtMessages;
        private Label label4;
        private Label label6;
        private DataGridView dataGridView1;
        private CheckBox checkSend;
        private CheckBox checkLastFilter;
        private CheckBox checkContainFolder;
        private TextBox txtContains;
        private RadioButton radioButton1;
        private NumericUpDown numLast;
        private RadioButton radioButton2;
        private Button btnFilterMode;
    }
}