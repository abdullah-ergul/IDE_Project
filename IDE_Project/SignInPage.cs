using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace IDE_Project {
    public partial class SignInPage : Form {
        public SignInPage() {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.MouseDown += new MouseEventHandler(move_window);
        }

        SqlConnection connection = new SqlConnection(@"Data Source = ABDULLAH\SQLEXPRESS; Initial Catalog = IDE_PROJECT_DB; Integrated Security = True; Encrypt = False");

        private void exitButton_Click(object sender, EventArgs e) {
            CodeEditor homePage = new CodeEditor("", "");
            homePage.Show();
            this.Close();
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;


        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x84) {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption) {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip) {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void signInButton_Click(object sender, EventArgs e) {
            String username, user_password;

            username = unameTextBox.Text;
            user_password = passwordTextBox.Text;

            try {
                connection.Open();
                String query = "SELECT * FROM USERS WHERE user_name = '" + username + "' AND password = '" + user_password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count > 0) {
                    CodeEditor codeEditor = new CodeEditor(username, user_password);
                    codeEditor.Show();
                    this.Close();
                }
                else {
                    MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTextBox.Clear();
                    passwordTextBox.Focus();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }
        }

        private void signUpButton_Click(object sender, EventArgs e) {
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.Show();
            this.Close();
        }
    }
}
