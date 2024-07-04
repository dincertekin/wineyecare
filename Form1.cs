using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dtEyeCare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addToStartup();

            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem exitToolStripMenuItem = new ToolStripMenuItem("Exit");
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            contextMenuStrip.Items.Add(exitToolStripMenuItem);
            notifyIcon.ContextMenuStrip = contextMenuStrip;
        }

        private void addToStartup()
        {
            string appName = "dtEyeCare";
            string appPath = Application.ExecutablePath;

            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.SetValue(appName, appPath);
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            notifyIcon.ShowBalloonTip(30000, "dtEyeCare", "The application is still running in the system tray.", ToolTipIcon.Info);
        }

        private void shortBreakTimer_Tick(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipTitle = "Short Break Time!";
            notifyIcon.BalloonTipText = "20 minutes have passed! Take a 20-second break and look at something 20 feet away.";
            notifyIcon.ShowBalloonTip(30000);

            shortBreakTimer.Interval = 1200000;
            shortBreakTimer.Start();
        }

        private void longBreakTimer_Tick(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipTitle = "Long Break Time!";
            notifyIcon.BalloonTipText = "2 hours have passed! Take a 15-minute break away from the screen.";
            notifyIcon.ShowBalloonTip(30000);

            longBreakTimer.Interval = 7200000;
            longBreakTimer.Start();
        }

        private void twoHoursCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            longBreakTimer.Enabled = twoHoursCheckBox.Checked;
        }

        private void twentyMinutesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            shortBreakTimer.Enabled = twentyMinutesCheckBox.Checked;
        }

        private void runAtStartupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string appName = "dtEyeCare";
            string appPath = Application.ExecutablePath;

            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            try
            {
                if (runAtStartupCheckBox.Checked)
                {
                    rk.SetValue(appName, appPath);
                }
                else
                {
                    if (rk.GetValue(appName) != null)
                    {
                        rk.DeleteValue(appName, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing registry: {ex.Message}", "Registry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
