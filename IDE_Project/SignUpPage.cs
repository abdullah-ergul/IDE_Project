using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace IDE_Project {
    public partial class SignUpPage : Form {
        public SignUpPage() {
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
            SignInPage signInPage = new SignInPage();
            signInPage.Show();
            this.Close();
        }

        private void signUpButton_Click(object sender, EventArgs e) {
            String username, user_password, user_password_again;

            username = unameTextBox.Text;
            user_password = passwordTextBox.Text;
            user_password_again = passwordAgainTextBox.Text;

            try {
                connection.Open();
                String query = "SELECT * FROM USERS WHERE user_name = '" + username + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (String.Equals(user_password_again, user_password) && dtbl.Rows.Count == 0) {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO USERS(user_name, password) VALUES(@user_name, @password)";
                    cmd.Parameters.AddWithValue("@user_name", unameTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                    cmd.ExecuteNonQuery();

                    SignInPage signInPage = new SignInPage();
                    signInPage.Show();
                    this.Close();
                }
                else if (dtbl.Rows.Count > 0) {
                    MessageBox.Show("User name is already used! Please enter a different user name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    unameTextBox.Clear();
                    passwordTextBox.Clear();
                    passwordAgainTextBox.Clear();
                    unameTextBox.Focus();
                }
                else {
                    MessageBox.Show("The two passwords you entered are not the same!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTextBox.Clear();
                    passwordAgainTextBox.Clear();
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
    }
}
