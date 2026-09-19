using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using Microsoft.Win32;

namespace beeble_install
{
    public partial class baseWindow : Form
    {
        public baseWindow()
        {
            InitializeComponent();

            txtPath.ReadOnly = true;
            txtPath.Cursor = Cursors.Hand;
            txtPath.Click += txtPath_Click;


            txtPath.Text = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                "ROBLOX-beeble");

            RefreshButtons();
            txtPath.TextChanged += (s, e) => RefreshButtons();
        }

        void RefreshButtons()
        {
            bool installed = File.Exists(Path.Combine(txtPath.Text.Trim(), "08launcher.exe"));
            btnInstall.Enabled = !installed;
            btnRepair.Enabled = installed;
            btnUninstall.Enabled = installed;
        }

        void SetStatus(int pct)
        {
            progress.Value = Math.Max(0, Math.Min(100, pct));
            Application.DoEvents();
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            Run(() => Install(txtPath.Text.Trim()), "sucessfully installed");
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            Run(() => Install(txtPath.Text.Trim()), "sucessfully reapaired files");
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("uninstall client?", "bebl setoop",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            Run(() => Uninstall(txtPath.Text.Trim()), "sucessfully uninstalled");
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://beeble.top");
        }

        private void txtPath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtPath.Text))
                folderBrowserDialog1.SelectedPath = txtPath.Text;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
                RefreshButtons();
            }
        }

        private void captionInstall_Click(object sender, EventArgs e) { }
        private void captionRepair_Click(object sender, EventArgs e) { }
        private void label1_Click_2(object sender, EventArgs e) { }
        private void promoBanner_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }

        void Run(Action work, string ok)
        {
            btnInstall.Enabled = btnRepair.Enabled = btnUninstall.Enabled = false;
            try
            {
                work();
                SetStatus(100);
                MessageBox.Show(ok, "bebl setoop");
            }
            catch (Exception ex)
            {
                SetStatus(0);
                MessageBox.Show(ex.Message, "bebl setoop");
            }
            RefreshButtons();
        }

        void Install(string app)
        {
            SetStatus(5);
            if (Directory.Exists(app)) Directory.Delete(app, true);
            Directory.CreateDirectory(app);

            string zip = Path.Combine(Path.GetTempPath(), "beeble-client.zip");
            var asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resName = null;
            foreach (string n in asm.GetManifestResourceNames())
            {
                if (n.EndsWith("client.zip")) { resName = n; break; }
            }
            if (resName == null)
                throw new Exception("cannot find client build");

            using (var input = asm.GetManifestResourceStream(resName))
            using (var output = File.Create(zip))
                input.CopyTo(output);

            SetStatus(25);
            ZipFile.ExtractToDirectory(zip, app);
            try { File.Delete(zip); } catch { }

            string launcher = Path.Combine(app, "08launcher.exe");
            string dll = Path.Combine(app, "RobloxLauncher.dll");

            SetStatus(70);
            using (var k = Registry.LocalMachine.CreateSubKey(@"Software\Classes\r08"))
            {
                k.SetValue("", "URL:beeble uri");
                k.SetValue("URL Protocol", "");
            }
            using (var k = Registry.LocalMachine.CreateSubKey(@"Software\Classes\r08\shell\open\command"))
            {
                k.SetValue("", "\"" + launcher + "\" \"%1\"");
            }

            SetStatus(85);
            Regsvr(dll, false);
            SetStatus(100);
        }

        void Uninstall(string app)
        {
            SetStatus(20);
            Regsvr(Path.Combine(app, "RobloxLauncher.dll"), true);

            SetStatus(50);
            try { Registry.LocalMachine.DeleteSubKeyTree(@"Software\Classes\r08", false); } catch { }
            try { Registry.CurrentUser.DeleteSubKeyTree(@"Software\Classes\r08", false); } catch { }

            SetStatus(80);
            if (Directory.Exists(app)) Directory.Delete(app, true);
            SetStatus(100);
        }

        static void Regsvr(string dll, bool uninstall)
        {
            string reg = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Windows),
                Environment.Is64BitOperatingSystem ? @"SysWOW64\regsvr32.exe" : @"System32\regsvr32.exe");
            var p = Process.Start(new ProcessStartInfo
            {
                FileName = File.Exists(reg) ? reg : "regsvr32.exe",
                Arguments = (uninstall ? "/s /u " : "/s ") + "\"" + dll + "\"",
                UseShellExecute = false,
                WorkingDirectory = Path.GetDirectoryName(dll)
            });
            if (p != null) p.WaitForExit();
        }

        private void progress_Click(object sender, EventArgs e)
        {

        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}