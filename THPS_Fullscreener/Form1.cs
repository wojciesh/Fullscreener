using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Fullscreener
{
    public partial class Form1 : Form
    {
        // This static method is required because legacy OSes do not support SetWindowLongPtr
        public static IntPtr SetWindowLongPtr(HandleRef hWnd, int nIndex, UIntPtr dwNewLong)
        {
            if (IntPtr.Size == 8)
                return SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
            else
                return new IntPtr(SetWindowLong32(hWnd, nIndex, dwNewLong.ToUInt32()));
        }

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLong32(HandleRef hWnd, int nIndex, uint dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
        private static extern IntPtr SetWindowLongPtr64(HandleRef hWnd, int nIndex, UIntPtr dwNewLong);



        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);


        public static void ResizeWin(string wintitle, int x, int y, int w, int h, bool isNoborders)
        {
            bool ok = false;

            Process[] processes = Process.GetProcesses();

            IntPtr hMe;
            using (var p = Process.GetCurrentProcess())
            {
                hMe = p.MainWindowHandle;
            }

            foreach (var process in processes)
            {
                IntPtr handle = process.MainWindowHandle;

                if (hMe == handle)
                    continue;

                var hWin = FindWindowEx(handle, IntPtr.Zero, null, wintitle);

                if (hWin != IntPtr.Zero)
                {
                    DoNoborders(hWin, isNoborders);
                    DoResize(hWin, x, y, w, h);
                    ok = true;
                    break;
                }
            }

            foreach (var process in processes)
            {
                process.Dispose();
            }

            if (!ok)
                throw new Exception("Window not found");
        }

        public static void DoResize(IntPtr hWin, int x, int y, int w, int h)
        {
            //const short SWP_NOSIZE = 0x1;
            //const short SWP_NOMOVE = 0x2;
            const short SWP_NOZORDER = 0x4;
            const int SWP_SHOWWINDOW = 0x0040;
            const int HWND_NOTOPMOST = -2;   // Places the window above all non-topmost windows(that is, behind all topmost windows).This flag has no effect if the window is already a non - topmost window.

            SetWindowPos(hWin, HWND_NOTOPMOST, x, y, w, h, SWP_NOZORDER | SWP_SHOWWINDOW);
        }

        private static void DoNoborders(IntPtr hWin, bool isNoborders)
        {
            const int GWL_STYLE = -16;              //hex constant for style changing
            const uint WS_BORDER = 0x00800000;       //window with border
            const uint WS_CAPTION = 0x00C00000;      //window with a title bar
            const uint WS_MINIMIZEBOX = 0x00020000;  //window with minimizebox
            const uint WS_MAXIMIZEBOX = 0x00010000;
            const uint WS_SYSMENU = 0x00080000;      //window with no borders etc.
            const uint WS_POPUP = 0x80000000;       // removes the border and remains only its client


            //if (isNoborders)
            SetWindowLongPtr(
                new HandleRef(null, hWin),
                GWL_STYLE,
                //new UIntPtr(WS_POPUP)
                new UIntPtr(
                    isNoborders
                    ? WS_SYSMENU | WS_POPUP
                    : WS_SYSMENU | WS_BORDER | WS_CAPTION | WS_MINIMIZEBOX | WS_MAXIMIZEBOX)

                );
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ResizeWin(wintitle.Text,
                    (int)numX.Value, (int)numY.Value,
                    (int)numW.Value, (int)numH.Value,
                    cbNoborder.Checked);
                sts.Text = "OK";
            }
            catch (Exception ex)
            {
                sts.Text = ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numW.Value = Screen.PrimaryScreen.Bounds.Width;
            numH.Value = Screen.PrimaryScreen.Bounds.Height;
            numX.Value = Screen.PrimaryScreen.Bounds.X;
            numY.Value = Screen.PrimaryScreen.Bounds.Y;
        }
    }
}
