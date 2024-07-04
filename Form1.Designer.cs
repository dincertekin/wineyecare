namespace dtEyeCare
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            notifyIcon = new NotifyIcon(components);
            shortBreakTimer = new System.Windows.Forms.Timer(components);
            longBreakTimer = new System.Windows.Forms.Timer(components);
            twentyMinutesCheckBox = new CheckBox();
            twoHoursCheckBox = new CheckBox();
            remindMeLabel = new Label();
            runAtStartupCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "dtEyeCare";
            notifyIcon.Visible = true;
            notifyIcon.DoubleClick += notifyIcon_DoubleClick;
            // 
            // shortBreakTimer
            // 
            shortBreakTimer.Interval = 1200000;
            shortBreakTimer.Tick += shortBreakTimer_Tick;
            // 
            // longBreakTimer
            // 
            longBreakTimer.Interval = 7200000;
            longBreakTimer.Tick += longBreakTimer_Tick;
            // 
            // twentyMinutesCheckBox
            // 
            twentyMinutesCheckBox.AutoSize = true;
            twentyMinutesCheckBox.Checked = true;
            twentyMinutesCheckBox.CheckState = CheckState.Checked;
            twentyMinutesCheckBox.Location = new Point(58, 95);
            twentyMinutesCheckBox.Name = "twentyMinutesCheckBox";
            twentyMinutesCheckBox.Size = new Size(116, 19);
            twentyMinutesCheckBox.TabIndex = 0;
            twentyMinutesCheckBox.Text = "20 minutes break";
            twentyMinutesCheckBox.UseVisualStyleBackColor = true;
            twentyMinutesCheckBox.CheckedChanged += twentyMinutesCheckBox_CheckedChanged;
            // 
            // twoHoursCheckBox
            // 
            twoHoursCheckBox.AutoSize = true;
            twoHoursCheckBox.Checked = true;
            twoHoursCheckBox.CheckState = CheckState.Checked;
            twoHoursCheckBox.Location = new Point(58, 70);
            twoHoursCheckBox.Name = "twoHoursCheckBox";
            twoHoursCheckBox.Size = new Size(97, 19);
            twoHoursCheckBox.TabIndex = 0;
            twoHoursCheckBox.Text = "2 hours break";
            twoHoursCheckBox.UseVisualStyleBackColor = true;
            twoHoursCheckBox.CheckedChanged += twoHoursCheckBox_CheckedChanged;
            // 
            // remindMeLabel
            // 
            remindMeLabel.AutoSize = true;
            remindMeLabel.Location = new Point(55, 52);
            remindMeLabel.Name = "remindMeLabel";
            remindMeLabel.Size = new Size(103, 15);
            remindMeLabel.TabIndex = 1;
            remindMeLabel.Text = "Remind me when:";
            // 
            // runAtStartupCheckBox
            // 
            runAtStartupCheckBox.AutoSize = true;
            runAtStartupCheckBox.Checked = true;
            runAtStartupCheckBox.CheckState = CheckState.Checked;
            runAtStartupCheckBox.Location = new Point(55, 21);
            runAtStartupCheckBox.Name = "runAtStartupCheckBox";
            runAtStartupCheckBox.Size = new Size(100, 19);
            runAtStartupCheckBox.TabIndex = 2;
            runAtStartupCheckBox.Text = "Run at startup";
            runAtStartupCheckBox.UseVisualStyleBackColor = true;
            runAtStartupCheckBox.CheckedChanged += runAtStartupCheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 138);
            Controls.Add(runAtStartupCheckBox);
            Controls.Add(remindMeLabel);
            Controls.Add(twoHoursCheckBox);
            Controls.Add(twentyMinutesCheckBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dtEyeCare";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer shortBreakTimer;
        private System.Windows.Forms.Timer longBreakTimer;
        private CheckBox twentyMinutesCheckBox;
        private CheckBox twoHoursCheckBox;
        private Label remindMeLabel;
        private CheckBox runAtStartupCheckBox;
    }
}