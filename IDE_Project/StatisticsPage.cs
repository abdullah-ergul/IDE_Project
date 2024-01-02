using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IDE_Project {
    public partial class StatisticsPage : Form {

        SqlConnection connection = new SqlConnection(@"Data Source = ABDULLAH\SQLEXPRESS; Initial Catalog = IDE_PROJECT_DB; Integrated Security = True; Encrypt = False; MultipleActiveResultSets=true");
        string username;
        string password;
        int userid;

        public StatisticsPage(string username, string password) {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.MouseDown += new MouseEventHandler(move_window);
            this.username = username;
            this.password = password;
            this.userid = 0;
        }

        private void StatisticsPage_Load(object sender, EventArgs e) {
            try {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                String query = "SELECT * FROM USERS WHERE user_name = '" + username + "' AND password = '" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count > 0) {
                    this.userid = Convert.ToInt32(dtbl.Rows[0]["id"].ToString());
                    label1.Text = username + "'s Statistics";
                }
                else {
                    MessageBox.Show("Please login first if you want to see your statistics.");
                    this.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
                Graphics g = this.CreateGraphics();
            }
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

        private void exitButton_Click(object sender, EventArgs e) => this.Close();

        private void DrawChart(Graphics g) {
            try {
                connection.Open();
                string query = "SELECT * FROM CODING WHERE user_id = '" + this.userid  + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                SqlDataAdapter sdaCoding = new SqlDataAdapter(query, connection);
                DataTable dtblCoding = new DataTable();
                sdaCoding.Fill(dtblCoding);

                if (dtblCoding.Rows.Count == 0) {
                    MessageBox.Show("You have not written any code yet.");
                    this.Close();
                }

                int x = 77;
                int y = 360;
                int width = 30; // 560;
                int gap = 40; // 357;
                dr.Read();

                Brush brush = Brushes.PowderBlue;

                int height = Convert.ToInt32(dr["lang_c"]);
                g.FillRectangle(brush, x, y - height, width, height);
                g.DrawRectangle(Pens.White, x, y - height, width, height);
                string label = "lang_c";
                g.DrawString(label, this.Font, Brushes.LightGray, x + (width / 2) - 16, y + 5);
                g.DrawString(height.ToString(), this.Font, Brushes.LightGray, x + 5, y - height - 15);
                x += width + gap;

                height = Convert.ToInt32(dr["lang_cpp"]);
                g.FillRectangle(brush, x, y - height, width, height);
                g.DrawRectangle(Pens.White, x, y - height, width, height);
                label = "lang_cpp";
                g.DrawString(label, this.Font, Brushes.LightGray, x + (width / 2) - 16, y + 5);
                g.DrawString(height.ToString(), this.Font, Brushes.LightGray, x + 5, y - height - 15);
                x += width + gap;

                height = Convert.ToInt32(dr["lang_cs"]);
                g.FillRectangle(brush, x, y - height, width, height);
                g.DrawRectangle(Pens.White, x, y - height, width, height);
                label = "lang_cs";
                g.DrawString(label, this.Font, Brushes.LightGray, x + (width / 2) - 16, y + 5);
                g.DrawString(height.ToString(), this.Font, Brushes.LightGray, x + 5, y - height - 15);
                x += width + gap;

                height = Convert.ToInt32(dr["lang_java"]);
                g.FillRectangle(brush, x, y - height, width, height);
                g.DrawRectangle(Pens.White, x, y - height, width, height);
                label = "lang_java";
                g.DrawString(label, this.Font, Brushes.LightGray, x + (width / 2) - 16, y + 5);
                g.DrawString(height.ToString(), this.Font, Brushes.LightGray, x + 5, y - height - 15);
                x += width + gap;

                height = Convert.ToInt32(dr["lang_js"]);
                g.FillRectangle(brush, x, y - height, width, height);
                g.DrawRectangle(Pens.White, x, y - height, width, height);
                label = "lang_js";
                g.DrawString(label, this.Font, Brushes.LightGray, x + (width / 2) - 16, y + 5);
                g.DrawString(height.ToString(), this.Font, Brushes.LightGray, x + 5, y - height - 15);
                x += width + gap;

                height = Convert.ToInt32(dr["lang_php"]);
                g.FillRectangle(brush, x, y - height, width, height);
                g.DrawRectangle(Pens.White, x, y - height, width, height);
                label = "lang_php";
                g.DrawString(label, this.Font, Brushes.LightGray, x + (width / 2) - 16, y + 5);
                g.DrawString(height.ToString(), this.Font, Brushes.LightGray, x + 5, y - height - 15);
                x += width + gap;

                height = Convert.ToInt32(dr["lang_py"]);
                g.FillRectangle(brush, x, y - height, width, height);
                g.DrawRectangle(Pens.White, x, y - height, width, height);
                label = "lang_py";
                g.DrawString(label, this.Font, Brushes.LightGray, x + (width / 2) - 16, y + 5);
                g.DrawString(height.ToString(), this.Font, Brushes.LightGray, x + 5, y - height - 15);
                x += width + gap;

                height = Convert.ToInt32(dr["lang_sql"]);
                g.FillRectangle(brush, x, y - height, width, height);
                g.DrawRectangle(Pens.White, x, y - height, width, height);
                label = "lang_sql";
                g.DrawString(label, this.Font, Brushes.LightGray, x + (width / 2) - 16, y + 5);
                g.DrawString(height.ToString(), this.Font, Brushes.LightGray, x + 5, y - height - 15);
                x += width + gap;

                height = Convert.ToInt32(dr["lang_other"]);
                g.FillRectangle(brush, x, y - height, width, height);
                g.DrawRectangle(Pens.White, x, y - height, width, height);
                label = "lang_other";
                g.DrawString(label, this.Font, Brushes.LightGray, x + (width / 2) - 16, y + 5);
                g.DrawString(height.ToString(), this.Font, Brushes.LightGray, x + 5, y - height - 15);
                //x += width + gap;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }
        }

        private void StatisticsPage_Paint(object sender, PaintEventArgs e) {
            DrawChart(e.Graphics);
        }
    }
}
