using System.Diagnostics;
using System.IO;
using Timer = System.Windows.Forms.Timer;

namespace WSJTKillerGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer2 = new Timer
            {
                Interval = 300
            };
            timer2.Enabled = true;
            timer2.Tick += new System.EventHandler(OnTimerEvent);

            var processCollection = Process.GetProcesses();
            foreach (Process p in processCollection)
            {
                //Console.WriteLine(p.ProcessName);
                listBox1.Items.Add(p.ProcessName);
            }
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            foreach (Process process in Process.GetProcessesByName("wsjtx"))
            {
                label1.Text = "WSJTX Running!";
                label1.BackColor = Color.Yellow;
                label1.ForeColor = Color.Red;
            }
            foreach (Process process1 in Process.GetProcessesByName("jt9"))
            {
                label2.Text = "JT9 Running!";
                label2.BackColor = Color.Yellow;
                label2.ForeColor = Color.Red;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox1.Items.Clear();

            Process[] processCollection = Process.GetProcesses();
            foreach (Process p in processCollection)
            {
                listBox1.Items.Add(p.ProcessName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WSJTKillerGUI - 2023 NiriniumLabs - Colt Wills N1RIP ");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach (var process in Process.GetProcessesByName("wsjtx"))
                {
                    process.Kill();
                }
                foreach (var process in Process.GetProcessesByName("jt9"))
                {
                    process.Kill();
                }
            }

            if (checkBox2.Checked)
            {
                foreach (var process in Process.GetProcessesByName("wsjtx"))
                {
                    process.Kill();
                }
                foreach (var process in Process.GetProcessesByName("jt9"))
                {
                    process.Kill();
                }
            }

            listBox1.Items.Clear();

            Process[] processCollection = Process.GetProcesses();
            foreach (Process p in processCollection)
            {
                listBox1.Items.Add(p.ProcessName);
            }
        }
    }
}