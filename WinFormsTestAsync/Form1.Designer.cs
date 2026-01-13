namespace WinFormsTestAsync
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            button4 = new Button();
            buttonStopServiceInvoke = new Button();
            buttonStartServiceInvoke = new Button();
            buttonStartIProgress = new Button();
            buttonStopIProgress = new Button();
            buttonStartThreadTimer = new Button();
            buttonStopThreadTimer = new Button();
            buttonTask3run = new Button();
            buttonTask4run = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(12, 41);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(399, 162);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Task 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(93, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Task 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Interval = 3700;
            timer1.Tick += timer1_Tick;
            // 
            // button3
            // 
            button3.Location = new Point(12, 228);
            button3.Name = "button3";
            button3.Size = new Size(156, 23);
            button3.TabIndex = 2;
            button3.Text = "Start WinForms timer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(174, 228);
            button4.Name = "button4";
            button4.Size = new Size(156, 23);
            button4.TabIndex = 2;
            button4.Text = "Stop WinForms timer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonStopServiceInvoke
            // 
            buttonStopServiceInvoke.Location = new Point(174, 257);
            buttonStopServiceInvoke.Name = "buttonStopServiceInvoke";
            buttonStopServiceInvoke.Size = new Size(156, 23);
            buttonStopServiceInvoke.TabIndex = 3;
            buttonStopServiceInvoke.Text = "Stop service Invoke";
            buttonStopServiceInvoke.UseVisualStyleBackColor = true;
            buttonStopServiceInvoke.Click += buttonStopServiceInvoke_Click;
            // 
            // buttonStartServiceInvoke
            // 
            buttonStartServiceInvoke.Location = new Point(12, 257);
            buttonStartServiceInvoke.Name = "buttonStartServiceInvoke";
            buttonStartServiceInvoke.Size = new Size(156, 23);
            buttonStartServiceInvoke.TabIndex = 3;
            buttonStartServiceInvoke.Text = "Start service Invoke";
            buttonStartServiceInvoke.UseVisualStyleBackColor = true;
            buttonStartServiceInvoke.Click += buttonStartServiceInvoke_Click;
            // 
            // buttonStartIProgress
            // 
            buttonStartIProgress.Location = new Point(12, 286);
            buttonStartIProgress.Name = "buttonStartIProgress";
            buttonStartIProgress.Size = new Size(156, 23);
            buttonStartIProgress.TabIndex = 3;
            buttonStartIProgress.Text = "Start service IProgress";
            buttonStartIProgress.UseVisualStyleBackColor = true;
            buttonStartIProgress.Click += buttonStartIProgress_Click;
            // 
            // buttonStopIProgress
            // 
            buttonStopIProgress.Location = new Point(174, 286);
            buttonStopIProgress.Name = "buttonStopIProgress";
            buttonStopIProgress.Size = new Size(156, 23);
            buttonStopIProgress.TabIndex = 3;
            buttonStopIProgress.Text = "Stop service IProgress";
            buttonStopIProgress.UseVisualStyleBackColor = true;
            buttonStopIProgress.Click += buttonStopIProgress_Click;
            // 
            // buttonStartThreadTimer
            // 
            buttonStartThreadTimer.Location = new Point(12, 315);
            buttonStartThreadTimer.Name = "buttonStartThreadTimer";
            buttonStartThreadTimer.Size = new Size(156, 23);
            buttonStartThreadTimer.TabIndex = 4;
            buttonStartThreadTimer.Text = "Start Thread Timer";
            buttonStartThreadTimer.UseVisualStyleBackColor = true;
            buttonStartThreadTimer.Click += buttonStartThreadTimer_Click;
            // 
            // buttonStopThreadTimer
            // 
            buttonStopThreadTimer.Location = new Point(174, 315);
            buttonStopThreadTimer.Name = "buttonStopThreadTimer";
            buttonStopThreadTimer.Size = new Size(156, 23);
            buttonStopThreadTimer.TabIndex = 4;
            buttonStopThreadTimer.Text = "Stop Thread Timer";
            buttonStopThreadTimer.UseVisualStyleBackColor = true;
            buttonStopThreadTimer.Click += buttonStopThreadTimer_Click;
            // 
            // buttonTask3run
            // 
            buttonTask3run.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTask3run.Location = new Point(12, 344);
            buttonTask3run.Name = "buttonTask3run";
            buttonTask3run.Size = new Size(257, 23);
            buttonTask3run.TabIndex = 1;
            buttonTask3run.Text = "Task3 Run (new thread + Lambda)";
            buttonTask3run.UseVisualStyleBackColor = true;
            buttonTask3run.Click += buttonTask3run_Click;
            // 
            // buttonTask4run
            // 
            buttonTask4run.Location = new Point(12, 373);
            buttonTask4run.Name = "buttonTask4run";
            buttonTask4run.Size = new Size(257, 23);
            buttonTask4run.TabIndex = 5;
            buttonTask4run.Text = "Task4 Run (new thread + delegate)";
            buttonTask4run.UseVisualStyleBackColor = true;
            buttonTask4run.Click += buttonTask4run_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 407);
            Controls.Add(buttonTask4run);
            Controls.Add(buttonStopThreadTimer);
            Controls.Add(buttonStartThreadTimer);
            Controls.Add(buttonStartIProgress);
            Controls.Add(buttonStartServiceInvoke);
            Controls.Add(buttonStopIProgress);
            Controls.Add(buttonStopServiceInvoke);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(buttonTask3run);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form async";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Button button3;
        private Button button4;
        private Button buttonStopServiceInvoke;
        private Button buttonStartServiceInvoke;
        private Button buttonStartIProgress;
        private Button buttonStopIProgress;
        private Button buttonStartThreadTimer;
        private Button buttonStopThreadTimer;
        private Button buttonTask3run;
        private Button buttonTask4run;
    }
}
