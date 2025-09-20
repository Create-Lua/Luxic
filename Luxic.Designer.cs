namespace WeAreDevs_API
{
    partial class Luxic
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
            components = new System.ComponentModel.Container();
            txtScript = new RichTextBox();
            btnExecute = new Button();
            labelStatus = new Label();
            timerAttachChecker = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            CREDS = new Label();
            TITLE = new Label();
            CREDS1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            Minimize = new Button();
            Close = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtScript
            // 
            txtScript.BackColor = Color.FromArgb(40, 40, 40);
            txtScript.Location = new Point(142, 80);
            txtScript.Margin = new Padding(2);
            txtScript.Name = "txtScript";
            txtScript.Size = new Size(512, 276);
            txtScript.TabIndex = 0;
            txtScript.Text = "-- Type A Script";
            // 
            // btnExecute
            // 
            btnExecute.BackColor = Color.Black;
            btnExecute.ForeColor = Color.Gold;
            btnExecute.Location = new Point(10, 13);
            btnExecute.Margin = new Padding(2);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(89, 40);
            btnExecute.TabIndex = 1;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = false;
            btnExecute.Click += btnExecute_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelStatus.ForeColor = Color.Gold;
            labelStatus.Location = new Point(142, 340);
            labelStatus.Margin = new Padding(2, 0, 2, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(75, 15);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Injected: null";
            labelStatus.Click += labelStatus_Click;
            // 
            // timerAttachChecker
            // 
            timerAttachChecker.Enabled = true;
            timerAttachChecker.Tick += timerAttachChecker_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(CREDS);
            panel1.Controls.Add(TITLE);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 62);
            panel1.TabIndex = 3;
            // 
            // CREDS
            // 
            CREDS.AutoSize = true;
            CREDS.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            CREDS.ForeColor = Color.Gold;
            CREDS.Location = new Point(574, 0);
            CREDS.Name = "CREDS";
            CREDS.Size = new Size(67, 28);
            CREDS.TabIndex = 1;
            CREDS.Text = "M1Lt";
            // 
            // TITLE
            // 
            TITLE.AutoSize = true;
            TITLE.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            TITLE.ForeColor = Color.Gold;
            TITLE.Location = new Point(0, 0);
            TITLE.Name = "TITLE";
            TITLE.Size = new Size(137, 54);
            TITLE.TabIndex = 0;
            TITLE.Text = "Luxic";
            // 
            // CREDS1
            // 
            CREDS1.AutoSize = true;
            CREDS1.Location = new Point(11, 340);
            CREDS1.Name = "CREDS1";
            CREDS1.Size = new Size(99, 16);
            CREDS1.TabIndex = 4;
            CREDS1.Text = "API=  WeAreDevs";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 40, 40);
            panel2.Controls.Add(btnExecute);
            panel2.Location = new Point(11, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 245);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(40, 40, 40);
            panel3.Controls.Add(Minimize);
            panel3.Controls.Add(Close);
            panel3.Location = new Point(668, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(61, 342);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // Minimize
            // 
            Minimize.BackColor = Color.FromArgb(30, 30, 30);
            Minimize.ForeColor = Color.Gold;
            Minimize.Location = new Point(19, 39);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(24, 23);
            Minimize.TabIndex = 1;
            Minimize.Text = "-";
            Minimize.UseVisualStyleBackColor = false;
            Minimize.Click += Minimize_Click;
            // 
            // Close
            // 
            Close.BackColor = Color.FromArgb(30, 30, 30);
            Close.ForeColor = Color.Gold;
            Close.Location = new Point(19, 6);
            Close.Name = "Close";
            Close.Size = new Size(24, 23);
            Close.TabIndex = 0;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // Luxic
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(741, 368);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(CREDS1);
            Controls.Add(panel1);
            Controls.Add(labelStatus);
            Controls.Add(txtScript);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Luxic";
            Text = "Luxic";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtScript;
        private Button btnExecute;
        private Button btnAttach;
        private Label labelStatus;
        private System.Windows.Forms.Timer timerAttachChecker;
        private Panel panel1;
        private Label CREDS;
        private Label TITLE;
        private Label CREDS1;
        private Panel panel2;
        private Panel panel3;
        private Button Minimize;
        private Button Close;
    }
}
