using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace InstallTWRP
{
    public partial class Form1 : Form
    {
        private Boolean isCopy = false;
        private string backupTwrpName = "";
        public Form1()
        {
            InitializeComponent();
            initDevice();
            timer1.Start();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                if (!isCopy)
                {
                    isCopy = true;
                    copyTWRP(textBox1.Text);
                }

            }
            if (rdoFastboot.Checked)
            {
                backToTab(1);
            }
            else
            {
                backToTab(2);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabContainer.SelectedIndex = 0;
        }

        private void btnNonFbBack_Click(object sender, EventArgs e)
        {
            tabContainer.SelectedIndex = 0;
        }



        private void btnAccessFast_Click(object sender, EventArgs e)
        {
            runCommand("adb reboot bootloader");
            backToTab(0);
        }

        private void runCommand(String command)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();

            process.StartInfo = getStartInfo(command);
            process.Start();
            process.WaitForExit();
            process.Dispose();
        }

        private void installTwrp(Boolean isFastboot)
        {
            if (!isFastboot)
            {
                runCommand("adb reboot bootloader");
            }
            runCommand("fastboot flash recovery twrp.img");
            runCommand("fastboot boot twrp.img");
            backToTab(0);
        }

        private void goToTwrp(Boolean isFastboot)
        {
            if (!isFastboot)
            {
                runCommand("adb reboot bootloader");
            }
            runCommand("fastboot boot twrp.img");
            backToTab(0);
        }

        private void backToTab(int tabId)
        {
            if (tabId == 0)
            {
                btnConfirm.Enabled = false;
                fastbootEnableControl();
            }
            tabContainer.SelectedIndex = tabId;
        }



        private ProcessStartInfo getStartInfo(string cmd)
        {
            cmd = "/C " + cmd;
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = cmd;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            return startInfo;
        }



        private string isDeviceAvailable(Process proc)
        {
            string output = proc.StandardOutput.ReadToEnd();
            string[] lines = output.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                if (!lines[i].Equals(""))
                    if (Regex.IsMatch(lines[i], "\\d+\\s+device") || Regex.IsMatch(lines[i], "\\d+\\s+fastboot"))
                    {
                        return lines[i];
                    }
            }

            return "";
        }

        private void initDevice()
        {
            Process proc = getProcess("adb devices");
            string device = isDeviceAvailable(proc);
            if (device.Equals(""))
            {
                proc = getProcess("fastboot devices");
                device = isDeviceAvailable(proc);
                if (device.Equals(""))
                {
                    refreshDevice(false, "");
                }
                else
                {
                    refreshDevice(true, device);
                }
            }
            else
            {
                refreshDevice(true, device);
            }

        }

        private Boolean isFastboot()
        {
            Process proc = getProcess("fastboot devices");
            string device = isDeviceAvailable(proc);
            return !device.Equals("");
        }

        private void fastbootEnableControl()
        {
            if (isFastboot())
            {
                rdoFastboot.Enabled = true;
                rdoFastboot.Checked = true;
                rdoNonFastboot.Enabled = false;
            }
            else
            {
                rdoNonFastboot.Enabled = true;
                rdoNonFastboot.Checked = true;
                rdoFastboot.Enabled = false;
            }
        }

        private Boolean refreshDevice(Boolean isStickUSBDebbug, string device)
        {
            if (!isStickUSBDebbug)
            {
                refreshLabel("null", Color.Red);
            }
            else
            {
                refreshLabel(device, Color.Green);
                fastbootEnableControl();
            }
            return isStickUSBDebbug;
        }

        private void refreshLabel(string str, Color color)
        {
            lblDevice.Text = str;
            //MessageBox.Show("Hãy mở USB Debbug (gỡ lỗi USB) trên điện thoại và cài đặt MiFlash", "Không tìm thấy thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblDevice.ForeColor = color;
            lblColor.ForeColor = color;
        }

        private Process getProcess(string cmd)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();

            process.StartInfo = getStartInfo(cmd);
            process.Start();
            return process;
        }

        private void btnInstallRec_Click(object sender, EventArgs e)
        {
            installTwrp(true);
        }

        private void btnAccessRec_Click(object sender, EventArgs e)
        {
            goToTwrp(true);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            runCommand("fastboot reboot");
            backToTab(0);
        }

        private void btnNonFbInstallRec_Click(object sender, EventArgs e)
        {
            installTwrp(false);
        }

        private void btnNonFbAccessRec_Click(object sender, EventArgs e)
        {
            goToTwrp(false);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            initDevice();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnMiflash.Enabled = true;
            }
            else
            {
                btnMiflash.Enabled = false;
            }
        }

        private void btnMiflash_Click(object sender, EventArgs e)
        {
            DownloadMiFlash();
        }

        private void DownloadMiFlash()
        {
            String url = "http://api.en.miui.com/url/MiFlashTool";

            System.Diagnostics.Process.Start(url);
        }

        private void btnConfirmEnabled()
        {
            if (lblColor.ForeColor == Color.Green && !textBox1.Text.Equals(""))
            {
                btnConfirm.Enabled = true;
            }
            else
            {
                btnConfirm.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdTWRP.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filenames = ofdTWRP.FileName;
                if (filenames.EndsWith(".img"))
                {
                    textBox1.Text = filenames;
                    if (!filenames.Equals(backupTwrpName))
                    {
                        backupTwrpName = filenames;
                        isCopy = false;
                    }
                    btnConfirmEnabled();
                }
                else
                {
                    textBox1.Text = "";
                    btnConfirm.Enabled = false;
                    MessageBox.Show("Chỉ được dùng file '.*img'", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void copyTWRP(string TwrpFilePath)
        {
            string currentPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string cmdDelFile = "del twrp.img";
            string cmdCopyFile = "copy \"" + TwrpFilePath + "\" \"" + currentPath + "/twrp.img\"";
            runCommand(cmdDelFile);
            runCommand(cmdCopyFile);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tabContainer.SelectedIndex != 0)
                return;
            btnConfirmEnabled();
            initDevice();
        }
    }
}
