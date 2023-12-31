using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IDE_Project {
    public partial class StatisticsPage : Form {

        SqlConnection connection = new SqlConnection(@"Data Source = ABDULLAH\SQLEXPRESS; Initial Catalog = IDE_PROJECT_DB; Integrated Security = True; Encrypt = False");
        string username;
        string password;

        public StatisticsPage(string username, string password) {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.username = username;
            this.password = password;
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    
    
    }
}
