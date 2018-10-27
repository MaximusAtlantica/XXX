using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Gma.System.MouseKeyHook;
using Microsoft.Win32;

namespace XXX
{
    public partial class YYY : Form
    {
        #region variables
        
        uint
            SW_SHOW = 0x0005,
            WM_NCLBUTTONDOWN = 0x000000A1,
            HT_CAPTION = 0x00000002,
            WM_KEYDOWN = 0x00000100,
            WM_CHAR = 0x00000102,
            WM_KEYUP = 0x00000101,
            w_down = 0x00000058,
            w_ch = 0x00000078,
            w_up = 0x00000058,
            l_down = 0x002D0001,
            l_ch = 0x002D0001,
            l_up = 0xC02D0001;
        Timer t1 = new Timer();
        Timer t2 = new Timer();
        IntPtr RFWindowHandle = IntPtr.Zero;
        IKeyboardMouseEvents hook;
                        
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out Rectangle rect);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint uMsg, uint wParam, uint lParam);

        [DllImport("User32.dll")]
        public static extern int PostMessage(IntPtr hWnd, uint uMsg, uint wParam, uint lParam);

        #endregion variables

        public YYY()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(250, 1, 2, 3);
            this.TransparencyKey = Color.FromArgb(250, 1, 2, 3);
            this.AllowTransparency = true;
            t1.Interval = Convert.ToInt32(num_delay.Value * (decimal)1000);
            t1.Enabled = false;
            t1.Tick += (s, e) => { dowork(RFWindowHandle); };
            t2.Interval = 1000;
            t2.Tick += (s, e) => { checkRFWindow(); };
        }

        private void YYY_Shown(object sender, EventArgs e)
        {
            checkRFWindow();
            if (RFWindowHandle != IntPtr.Zero)
            {
                ShowWindow(RFWindowHandle, SW_SHOW);
                SetForegroundWindow(RFWindowHandle);
                Rectangle wRect = new Rectangle();
                GetWindowRect(RFWindowHandle, out wRect);
                this.Location = new Point(wRect.X, wRect.Y);
            }
            hook = Hook.GlobalEvents();
            hook.KeyDown += hook_KeyDown;
            t2.Enabled = true;
            t2.Start();
        }

        void hook_KeyDown(object sender, KeyEventArgs e)
        {
            if (GetForegroundWindow() == RFWindowHandle)
            {
                if (e.KeyCode == Keys.X)
                {
                    if (t1.Enabled)
                    {
                        t1.Enabled = false;
                        t1.Stop();
                        check_pick.Checked = false;
                    }
                    else
                    {
                        t1.Enabled = true;
                        t1.Start();
                        check_pick.Checked = true;
                    }
                }
                else if (e.KeyCode == Keys.F11)
                {
                    if (num_delay.Value < num_delay.Maximum)
                        num_delay.Value += (decimal)0.1;
                }
                else if (e.KeyCode == Keys.F12)
                {
                    if (num_delay.Value > num_delay.Minimum)
                        num_delay.Value -= (decimal)0.1;
                }
            }
        }

        void dowork(IntPtr hwnd)
        {
            if (RFWindowHandle != IntPtr.Zero)
            {
                SendMessage(hwnd, WM_KEYDOWN, (uint)Keys.X, 0);
                //SendMessage(hwnd, WM_CHAR, (uint)Keys.Z, l_ch);
                //SendMessage(hwnd, WM_KEYUP, (uint)Keys.Z, l_up);

                //SendMessage(hwnd, WM_KEYDOWN, (uint)Keys.Z, 0);

                //PostMessage(hwnd, WM_KEYDOWN, (uint)Keys.X, 0);
            }
            else
            {
                t1.Enabled = false;
                t1.Stop();
                check_pick.Checked = false;
            }
        }

        void checkRFWindow()
        {
            try
            {
                RFWindowHandle = Process.GetProcessesByName("RF_Online.bin").FirstOrDefault().MainWindowHandle;
                panel_utama.BackColor = Color.FromArgb(192, 255, 192);
            }
            catch
            {
                RFWindowHandle = IntPtr.Zero;
                panel_utama.BackColor = Color.FromArgb(255, 192, 255);
            }
        }

        private void num_delay_ValueChanged(object sender, EventArgs e)
        {
            t1.Interval = Convert.ToInt32(num_delay.Value * 1000);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_utama_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        private void btn_help_Click(object sender, EventArgs e)
        {
            string message = 
                "F11 = Delay ngepick bertambah 0.1 Detik\n"+
                "F12 = Delay ngepick berkurang 0.1 Detik\n"+
                "X = On/Off ngepick";
            MessageBox.Show(message, "Informasi", MessageBoxButtons.OK);
        }

    }
}
