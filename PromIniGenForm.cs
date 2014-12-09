using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace PromIniGen
{
    public partial class PromIniGenForm : Form
    {
        public PromIniGenForm()
        {
            InitializeComponent();
        }

        private void PromIniGenForm_Load(object sender, EventArgs e)
        {
            this.Text = "PROM ini generator - V" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            InjectionBaudRate(baudSel);
            baudSel.SelectedIndex = 1;
            FillToday();

            fullPath.Text = Environment.CurrentDirectory;
        }

        private void InjectionBaudRate(ComboBox c)
        {
            c.Items.AddRange(new object[] {
                4800, 9600, 19200, 38400, 57600,
                115200, 230400, 460800, 921600 });
        }

        private void SelectBaudRate(Int32 d)
        {
            int s = baudSel.SelectedIndex;

            for(int i = 0; i < baudSel.Items.Count; ++i)
            {
                String ss = baudSel.Items[i].ToString();
                if(d.ToString() == ss)
                {
                    baudSel.SelectedIndex = i;
                    return;
                }
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            if (PromIniGen.Properties.Settings.Default.LastFolder.Length > 0)
            {
                openFileDlg.InitialDirectory = PromIniGen.Properties.Settings.Default.LastFolder;
            }
            openFileDlg.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            openFileDlg.FilterIndex = 1;
            openFileDlg.RestoreDirectory = true;

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                //It will crash in Test PC (3F).
                //iniFileName.Text = openFileDlg.SafeFileName;
                promFilePath.Text = Path.GetFileName(openFileDlg.FileName);
                fullPath.Text = Path.GetDirectoryName(openFileDlg.FileName);
                FileInfo fInfo = new FileInfo(openFileDlg.FileName);
                AutoFill(promFilePath.Text, fInfo);

                PromIniGen.Properties.Settings.Default.LastFolder = fullPath.Text;
                PromIniGen.Properties.Settings.Default.Save();
            }
        }

        private void today_Click(object sender, EventArgs e)
        {
            FillToday();
        }

        private void FillToday()
        {
            rVer1.Text = DateTime.Now.Year.ToString("D4");
            rVer2.Text = DateTime.Now.Month.ToString("D2");
            rVer3.Text = DateTime.Now.Day.ToString("D2");
        }

        private void ParsePromOut(String promOutFile)
        {
            ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();

            try
            {
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.FileName = Environment.CurrentDirectory + "\\nm.exe"; 
                psi.Arguments = "-n " + promOutFile;

                Process p = Process.Start(psi);
                //outputString = p.StandardOutput.ReadToEnd();
                String l = p.StandardOutput.ReadLine();
                if (l == null)
                {
                    p.StandardOutput.Close();
                    promOutError.Text = "Parsing prom.out fail!";
                    return;
                }
                while (l != null)
                {
                    if (l.Contains("Isr_data"))
                    {
                        char[] delimiterChars = { ' ' };
                        String[] param = l.Split(delimiterChars);
                        UInt32 a = Convert.ToUInt32(param[0], 16);
                        dopplerAddress.Text = a.ToString("X8");

                        l = p.StandardOutput.ReadLine();
                        param = l.Split(delimiterChars);
                        UInt32 b = Convert.ToUInt32(param[0], 16);

                        UInt32 c = (b - a) / 12;
                        dopplerSize.Text = c.ToString("X");

                    }
                    l = p.StandardOutput.ReadLine();
                }
                p.StandardOutput.Close();
                promOutError.Text = "";

            }
            catch (Exception e)
            {
                promOutError.Text = "Parsing prom.out fail!";
                Console.WriteLine(e.Message);
            }
        }

        private void AutoFill(String s, FileInfo fInfo)
        {
            char[] dc1 = { '_' };
            String[] param = s.Split(dc1);
            if (param.Length < 7)
            {
                return;
            }
            //Get Version
            char[] dc2 = { '-', '.' };
            String[] verParam = param[1].Split(dc2);
            if (verParam.Length == 6)
            {
                try
                {
                    int d;
                    d = Convert.ToInt32(verParam[0]);
                    kVer1.Text = d.ToString("D2");
                    if (d >= 2)
                    {   //V8 Kernel
                        v6Doppler.Checked = false;
                        needTag.Checked = false;
                        tagAddress.Text = "000FCFFC";
                        tagContent.Text = "00000A01";
                    }
                    else if (d == 1)
                    {   //V6 Kernel
                        v6Doppler.Checked = true;
                        needTag.Checked = false;
                        tagAddress.Text = (fInfo.Length > 0x70000) ? "000F7FFC" : "00077FFC";
                        tagContent.Text = "00000A01";

                        promOutPath.Text = "prom.out";
                        ParsePromOut(fInfo.Directory.FullName + "\\prom.out");
                    }

                    d = Convert.ToInt32(verParam[1]);
                    kVer2.Text = d.ToString("D2");
                    d = Convert.ToInt32(verParam[2]);
                    kVer3.Text = d.ToString("D2");

                    d = Convert.ToInt32(verParam[3]);
                    sVer1.Text = d.ToString("D2");
                    d = Convert.ToInt32(verParam[4]);
                    sVer2.Text = d.ToString("D2");
                    d = Convert.ToInt32(verParam[5]);
                    sVer3.Text = d.ToString("D2");

                }
                catch
                {

                }
            }
            //Get Baudrate
            try
            {
                int d;
                d = Convert.ToInt32(param[param.Length - 2]);
                SelectBaudRate(d);
            }
            catch
            {

            }

            //Get Date
            char[] dc3 = { '.' };
            String[] dateParam = param[param.Length - 1].Split(dc3);
            if (dateParam.Length == 2)
            {
                try
                {
                    int d;
                    d = Convert.ToInt32(dateParam[0].Substring(0, 4));
                    if (d > 2000 && d < 2050)
                    {
                        rVer1.Text = d.ToString("D4");
                    }

                    d = Convert.ToInt32(dateParam[0].Substring(4, 2));
                    if (d >= 1 && d <= 12)
                    {
                        rVer2.Text = d.ToString("D2");
                    }

                    d = Convert.ToInt32(dateParam[0].Substring(6, 2));
                    if (d >= 1 && d <= 31)
                    {
                        rVer3.Text = d.ToString("D2");
                    } 
                }
                catch
                {

                }
            }

            //Get CRC
            if (param[param.Length - 3].Length == 4)
            {
                try
                {
                    int d;
                    d = Convert.ToUInt16(param[param.Length - 3], 16);
                    crc.Text = d.ToString("X4");
                }
                catch
                {

                }
            }
        }

        private void needTag_CheckedChanged(object sender, EventArgs e)
        {
            tagGroup.Enabled = (sender as CheckBox).Checked;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ok_Click(object sender, EventArgs e)
        {
            if (SaveIni())
            {
                this.Close();
            }
        }

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);

        private bool SaveIni()
        {
            if (promFilePath.Text.Length == 0)
            {
                MessageBox.Show("Please select Prom File first, or input a file name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Directory.Exists(fullPath.Text))
            {
                MessageBox.Show("Target folder is not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            UInt32 da = 0;
            UInt32 ds = 0;
            if (v6Doppler.Checked)
            {
                try
                {
                    da = Convert.ToUInt32(dopplerAddress.Text, 16);
                    ds = Convert.ToUInt32(dopplerSize.Text, 16);
                }
                catch
                {
                    MessageBox.Show("V6 Doppler Information is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            UInt32 ta = 0;
            UInt32 tc = 0;
            if (needTag.Checked)
            {
                try
                {
                    ta = Convert.ToUInt32(tagAddress.Text, 16) ^ 0xaaaaaaaa;
                    tc = Convert.ToUInt32(tagContent.Text, 16) ^ 0x55555555;
                }
                catch
                {
                    MessageBox.Show("Tag information is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            String iniFile = fullPath.Text + "\\" + Path.GetFileNameWithoutExtension(promFilePath.Text) + ".ini";
            WritePrivateProfileString("Firmware", "Prom", promFilePath.Text, iniFile);
            String kernelVersion = kVer1.Text + "." + kVer2.Text + "." + kVer3.Text;
            WritePrivateProfileString("Firmware", "K_Version", kernelVersion, iniFile);
            String softwareVersion = sVer1.Text + "." + sVer2.Text + "." + sVer3.Text;
            WritePrivateProfileString("Firmware", "S_Version", softwareVersion, iniFile);
            String revision = rVer1.Text + rVer2.Text + rVer3.Text;
            WritePrivateProfileString("Firmware", "Rev", revision, iniFile);
            WritePrivateProfileString("Firmware", "CRC", crc.Text.ToLower(), iniFile);
            WritePrivateProfileString("Firmware", "Baudrate", baudSel.Text, iniFile);
 
            WritePrivateProfileString("Firmware", "DopplerAddress", da.ToString("X8"), iniFile);
            WritePrivateProfileString("Firmware", "DopplerSize", ds.ToString("X8"), iniFile);

            WritePrivateProfileString("Firmware", "Address", ta.ToString("X8"), iniFile);
            WritePrivateProfileString("Firmware", "Value", tc.ToString("X8"), iniFile);

            if (v6Doppler.Checked)
            {
                WritePrivateProfileString("Firmware", "TagAddr", (ta ^ 0xaaaaaaaa).ToString("X8"), iniFile);
                WritePrivateProfileString("Firmware", "TagCustomerID", (((tc ^ 0x55555555) >> 8) & 0xFF).ToString("X2"), iniFile);
                WritePrivateProfileString("Firmware", "TagProductID", ((tc ^ 0x55555555) & 0xFF).ToString("X2"), iniFile);
            }

            string args = string.Format("/Select, {0}", iniFile);
            ProcessStartInfo pfi = new ProcessStartInfo("Explorer.exe", args);
            Process.Start(pfi);
            return true;
        }

        private void v6Doppler_CheckedChanged(object sender, EventArgs e)
        {
            dopplerGroup.Enabled = (sender as CheckBox).Checked;
        }

        private void browse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            if (PromIniGen.Properties.Settings.Default.LastFolder.Length > 0)
            {
                openFileDlg.InitialDirectory = PromIniGen.Properties.Settings.Default.LastFolder;
            }
            openFileDlg.Filter = "out files (*.out)|*.out|All files (*.*)|*.*";
            openFileDlg.FilterIndex = 1;
            openFileDlg.RestoreDirectory = true;

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                promOutPath.Text = Path.GetFileName(openFileDlg.FileName);
                ParsePromOut(openFileDlg.FileName);
            }
        }
    }
}
