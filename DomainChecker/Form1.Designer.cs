namespace DomainChecker
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
            groupBox1 = new GroupBox();
            lblSpeed = new Label();
            SpeedScrol = new TrackBar();
            label3 = new Label();
            checkAi = new CheckBox();
            label2 = new Label();
            checkio = new CheckBox();
            checkCom = new CheckBox();
            checkGov = new CheckBox();
            checkOrg = new CheckBox();
            checkNet = new CheckBox();
            label1 = new Label();
            btnStart = new Button();
            progressBar = new ProgressBar();
            btnThema = new Button();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpeedScrol).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSpeed);
            groupBox1.Controls.Add(SpeedScrol);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkAi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(checkio);
            groupBox1.Controls.Add(checkCom);
            groupBox1.Controls.Add(checkGov);
            groupBox1.Controls.Add(checkOrg);
            groupBox1.Controls.Add(checkNet);
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 344);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Auto TLDs";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Font = new Font("Segoe UI", 9F);
            lblSpeed.Location = new Point(6, 313);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(136, 20);
            lblSpeed.TabIndex = 10;
            lblSpeed.Text = "Speed: 1.0 Seconds";
            // 
            // SpeedScrol
            // 
            SpeedScrol.BackColor = SystemColors.Control;
            SpeedScrol.LargeChange = 1;
            SpeedScrol.Location = new Point(6, 268);
            SpeedScrol.Minimum = 1;
            SpeedScrol.Name = "SpeedScrol";
            SpeedScrol.Size = new Size(234, 56);
            SpeedScrol.TabIndex = 9;
            SpeedScrol.Value = 3;
            SpeedScrol.Scroll += SpeedScrol_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(6, 242);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 8;
            label3.Text = "Check Frequency:";
            // 
            // checkAi
            // 
            checkAi.AutoSize = true;
            checkAi.Font = new Font("Segoe UI", 9F);
            checkAi.Location = new Point(6, 210);
            checkAi.Name = "checkAi";
            checkAi.Size = new Size(46, 24);
            checkAi.TabIndex = 7;
            checkAi.Text = ".ai";
            checkAi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 2;
            label2.Text = "Include TLDs:";
            // 
            // checkio
            // 
            checkio.AutoSize = true;
            checkio.Font = new Font("Segoe UI", 9F);
            checkio.Location = new Point(6, 180);
            checkio.Name = "checkio";
            checkio.Size = new Size(47, 24);
            checkio.TabIndex = 6;
            checkio.Text = ".io";
            checkio.UseVisualStyleBackColor = true;
            // 
            // checkCom
            // 
            checkCom.AutoSize = true;
            checkCom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkCom.Location = new Point(6, 60);
            checkCom.Name = "checkCom";
            checkCom.Size = new Size(63, 24);
            checkCom.TabIndex = 2;
            checkCom.Text = ".com";
            checkCom.UseVisualStyleBackColor = true;
            // 
            // checkGov
            // 
            checkGov.AutoSize = true;
            checkGov.Font = new Font("Segoe UI", 9F);
            checkGov.Location = new Point(6, 150);
            checkGov.Name = "checkGov";
            checkGov.Size = new Size(59, 24);
            checkGov.TabIndex = 5;
            checkGov.Text = ".gov";
            checkGov.UseVisualStyleBackColor = true;
            // 
            // checkOrg
            // 
            checkOrg.AutoSize = true;
            checkOrg.Font = new Font("Segoe UI", 9F);
            checkOrg.Location = new Point(6, 90);
            checkOrg.Name = "checkOrg";
            checkOrg.Size = new Size(57, 24);
            checkOrg.TabIndex = 3;
            checkOrg.Text = ".org";
            checkOrg.UseVisualStyleBackColor = true;
            // 
            // checkNet
            // 
            checkNet.AutoSize = true;
            checkNet.Font = new Font("Segoe UI", 9F);
            checkNet.Location = new Point(6, 120);
            checkNet.Name = "checkNet";
            checkNet.Size = new Size(55, 24);
            checkNet.TabIndex = 4;
            checkNet.Text = ".net";
            checkNet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 1;
            label1.Text = "Domain Hunter V0.1";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LawnGreen;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnStart.ForeColor = SystemColors.ControlLightLight;
            btnStart.Location = new Point(12, 403);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(246, 66);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start Checking";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            progressBar.BackColor = SystemColors.Control;
            progressBar.Location = new Point(12, 481);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(246, 29);
            progressBar.TabIndex = 3;
            progressBar.UseWaitCursor = true;
            progressBar.Value = 10;
            // 
            // btnThema
            // 
            btnThema.FlatStyle = FlatStyle.Flat;
            btnThema.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            btnThema.ForeColor = SystemColors.GrayText;
            btnThema.Location = new Point(12, 535);
            btnThema.Name = "btnThema";
            btnThema.Size = new Size(246, 66);
            btnThema.TabIndex = 4;
            btnThema.Text = "Change Dark Mode";
            btnThema.UseVisualStyleBackColor = false;
            btnThema.Click += btnThema_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox2.Location = new Point(279, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 344);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Doamin List (input)";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(6, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 309);
            textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox3.Location = new Point(279, 403);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 198);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Processing Queue (Active)";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(234, 163);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox4.Location = new Point(542, 35);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(672, 566);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Results";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 29);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(660, 531);
            dataGridView2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 629);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnThema);
            Controls.Add(progressBar);
            Controls.Add(btnStart);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SpeedScrol).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private CheckBox checkCom;
        private CheckBox checkOrg;
        private CheckBox checkNet;
        private CheckBox checkGov;
        private CheckBox checkio;
        private CheckBox checkAi;
        private Label label3;
        private TrackBar SpeedScrol;
        private Label lblSpeed;
        private Button btnStart;
        private ProgressBar progressBar;
        private Button btnThema;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
    }
}
