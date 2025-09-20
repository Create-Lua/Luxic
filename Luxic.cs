using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WeAreDevs_API
{
    public partial class Luxic : Form
    {
        // ---------- Win32 constants + imports for dragging ----------
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

        [DllImport("wearedevs_exploit_api.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte initialize();

        [DllImport("wearedevs_exploit_api.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool isAttached();

        [DllImport("wearedevs_exploit_api.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void execute([MarshalAs(UnmanagedType.LPStr)] string script);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // ---------- Constructor ----------
        public Luxic()
        {
            InitializeComponent();

            // optional console window
            AllocConsole();

            // call the native DLL initialize
            initialize();

            // Wire panel3 MouseDown to make window draggable
            if (panel3 != null)
                panel3.MouseDown += Panel3_MouseDown;

            // Start attach-check timer if present
            if (timerAttachChecker != null)
                timerAttachChecker.Start();
        }

        // ---------- Event handlers ----------

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string script = txtScript.Text;
            execute(script);
        }

        private void timerAttachChecker_Tick(object sender, EventArgs e)
        {
            bool attached = isAttached();
            if (labelStatus != null)
            {
                if (attached)
                {
                    labelStatus.Text = "Injected = True";
                    labelStatus.ForeColor = Color.Green;
                }
                else
                {
                    labelStatus.Text = "Injected = False";
                    labelStatus.ForeColor = Color.Red;
                }
            }
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {
            // original empty
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // original empty
        }

        // ---------- Dragging logic ----------
        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
