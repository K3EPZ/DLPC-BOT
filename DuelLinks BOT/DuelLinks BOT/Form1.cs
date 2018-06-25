using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Memory;

namespace DuelLinks_BOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TopMost = true;
        }

        private static IntPtr hWnd;
        public bool loaded = false;
        public Mem m = new Mem();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        // Check game status, if not, open it.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (m.OpenProcess("dlpc"))
                {
                    procStatus.Invoke(new MethodInvoker(delegate
                    {
                        procStatus.Text = "OPEN";
                        procStatus.ForeColor = Color.Green;
                    }));
                    int gameProcId = m.getProcIDFromName("dlpc");
                    {
                        if (gameProcId > 0)
                        {
                            procIDlabel.Invoke(new MethodInvoker(delegate
                            {
                                procIDlabel.Text = gameProcId.ToString();
                            }));
                            m.OpenProcess(gameProcId.ToString());
                            loaded = true;
                        }
                    }
                }
            }
        }

        // Run steam and open Duel Links.
        private void openGame_Click(object sender, EventArgs e)
        {
            Process.Start("steam://rungameid/601510");
        }

        private void screenshot_Click(object sender, EventArgs e)
        {
            // Takes snapshot of the screen.
            Bitmap bmpScreenshot = BitmapGraphics.Screenshot();
            Bitmap initialScrenshot = BitmapGraphics.Screenshot();

            // Replaces the background with the screenshot
            //this.BackgroundImage = bmpScreenshot;

            // Try to find "bmpLD"
            Point location;
            bool success = BitmapGraphics.FindBitMap(Properties.Resources.bmpLD, bmpScreenshot, out location);

            // If not found send message
            if (success == false)
            {
                MessageBox.Show("Not Found!");
                return;
            }

            // If found move mouse to location
            Cursor.Position = location;
            MouseActions.MouseClick();
            Thread.Sleep(2000);
            MouseActions.MouseClick();
        }

        public static IntPtr WinGetHandle(string wName)
        {
            IntPtr hwnd = IntPtr.Zero;
            foreach (Process pList in Process.GetProcesses())
            {
                if (pList.MainWindowTitle.Contains(wName))
                {
                    hWnd = pList.MainWindowHandle;
                }
            }
            return hWnd;
        }

        private void fastlevel_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}