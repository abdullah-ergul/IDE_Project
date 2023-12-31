using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IDE_Project {

    public partial class CodeEditor : Form {

        SqlConnection connection = new SqlConnection(@"Data Source = ABDULLAH\SQLEXPRESS; Initial Catalog = IDE_PROJECT_DB; Integrated Security = True; Encrypt = False");
        private string username;
        private string password;
        private int userid;
        private DateTime start = DateTime.MinValue;

        public CodeEditor(string username, string password) {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            panel1.MouseDown += new MouseEventHandler(move_window);
            this.username = username;
            this.password = password;
            this.userid = 0;
        }

        private void CodeEditor_Load(object sender, EventArgs e) {
            //originalFormsSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            //originalFormsSize = new Rectangle(0, 0, 1024, 576);
            //exitButtonOriginalRectangle = new Rectangle(exitButton.Location.X, exitButton.Location.Y, exitButton.Width, exitButton.Height);
            //exitButtonOriginalRectangle = new Rectangle(987, 4, 24, 25);
            //panel1OriginalRectangle = new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width, panel1.Height); //new Rectangle(0, 0, 1024, 34);
                                                                                                                        //resizeControl(exitButtonOriginalRectangle, exitButton);
            try {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                string query = "SELECT * FROM USERS WHERE user_name = '" + username + "' AND password = '" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count > 0) {
                    this.userid = Convert.ToInt32(dtbl.Rows[0]["id"].ToString());
                    accountToolStripMenuItem.Text = dtbl.Rows[0]["user_name"].ToString();
                }
                else {
                    accountToolStripMenuItem.Text = "Sign In";
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
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

        //private Rectangle originalFormsSize;
        //private Rectangle exitButtonOriginalRectangle;
        //private Rectangle panel1OriginalRectangle;

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

        //private void resizeControl(Rectangle r, Control c) {
        //    float xRatio = (float)(this.Width) / (float)(originalFormsSize.Width);
        //    float yRatio = (float)(this.Height) / (float)(originalFormsSize.Height);

        //    int newX = (int)(r.Location.X * xRatio);
        //    int newY = (int)(r.Location.Y * yRatio);

        //    int newWidth = (int)(r.Width * xRatio);
        //    int newHeight = (int)(r.Height * yRatio);

        //    c.Location = new Point(newX, newY);
        //    c.Size = new Size(newWidth, newHeight);
        //}

        private void CodeEditor_Resize(object sender, EventArgs e) {
            //resizeControl(exitButtonOriginalRectangle, exitButton);
            //resizeControl(panel1OriginalRectangle, panel1);
        }

        private void exitButton_Click(object sender, EventArgs e) => this.Close();

        private void maxButton_Click(object sender, EventArgs e) {

            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            }
            else {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minButton_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        //private void CheckKeyword(List<string> words, Color color, int startIndex) {
        //    foreach (string word in words) {
        //        if (this.codeRichTextBox.Text.Contains(word)) {
        //            int index = -1;
        //            int selectStart = this.codeRichTextBox.SelectionStart;

        //            while ((index = this.codeRichTextBox.Text.IndexOf(word, (index + 1))) != -1) {
        //                this.codeRichTextBox.Select((index + startIndex), word.Length);
        //                this.codeRichTextBox.SelectionColor = color;
        //                this.codeRichTextBox.Select(selectStart, 0);
        //                this.codeRichTextBox.SelectionColor = Color.LightGray;
        //            }
        //        }
        //    }
        //}

        private void codeRichTextBox_TextChanged(object sender, EventArgs e) {

            string keywords = @"\b(include|while|for|if|else|static|switch|case|return|break|continue)\b";
            MatchCollection keywordMatches = Regex.Matches(codeRichTextBox.Text, keywords);

            string types = @"\b(void|int|float|double|char|struct|enum|NULL)\b";
            MatchCollection typeMatches = Regex.Matches(codeRichTextBox.Text, types);

            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(codeRichTextBox.Text, comments, RegexOptions.Multiline);

            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(codeRichTextBox.Text, strings);

            int originalIndex = codeRichTextBox.SelectionStart;
            int originalLength = codeRichTextBox.SelectionLength;
            Color originalColor = Color.LightGray;

            tree.Focus();

            codeRichTextBox.SelectionStart = 0;
            codeRichTextBox.SelectionLength = codeRichTextBox.Text.Length;
            codeRichTextBox.SelectionColor = originalColor;

            foreach (Match m in keywordMatches) {
                codeRichTextBox.SelectionStart = m.Index;
                codeRichTextBox.SelectionLength = m.Length;
                codeRichTextBox.SelectionColor = Color.FromArgb(197, 134, 192);
            }

            foreach (Match m in typeMatches) {
                codeRichTextBox.SelectionStart = m.Index;
                codeRichTextBox.SelectionLength = m.Length;
                codeRichTextBox.SelectionColor = Color.FromArgb(63, 156, 203);
            }

            foreach (Match m in commentMatches) {
                codeRichTextBox.SelectionStart = m.Index;
                codeRichTextBox.SelectionLength = m.Length;
                codeRichTextBox.SelectionColor = Color.FromArgb(94, 153, 85);
            }

            foreach (Match m in stringMatches) {
                codeRichTextBox.SelectionStart = m.Index;
                codeRichTextBox.SelectionLength = m.Length;
                codeRichTextBox.SelectionColor = Color.FromArgb(206, 145, 120);
            }

            codeRichTextBox.SelectionStart = originalIndex;
            codeRichTextBox.SelectionLength = originalLength;
            codeRichTextBox.SelectionColor = originalColor;

            codeRichTextBox.Focus();
            //codeRichTextBox.ScrollToCaret();
        }

        private void newWindowItem_Click(object sender, EventArgs e) {
            var form = new CodeEditor(username, password);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Width / 2, this.Height / 2);
            form.Show();
        }

        private void exitItem_Click(object sender, EventArgs e) => this.Close();

        private void openFolderItem_Click(object sender, EventArgs e) {
            folderBrowserDialog1.ShowDialog();
            Cursor.Current = Cursors.WaitCursor;
            tree.Nodes.Clear();

            foreach (var item in Directory.GetDirectories(folderBrowserDialog1.SelectedPath)) {
                DirectoryInfo di = new DirectoryInfo(item);
                var node = tree.Nodes.Add(di.Name, di.Name, 0, 0);
                node.Tag = di;
            }

            foreach (var item in Directory.GetFiles(folderBrowserDialog1.SelectedPath)) {
                FileInfo fi = new FileInfo(item);
                var node = tree.Nodes.Add(fi.Name, fi.Name, 1, 1);
                node.Tag = fi;
            }
            Cursor.Current = Cursors.Default;
        }

        private void tree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Node.Tag == null) {
                return;
            }
            else if (e.Node.Tag.GetType() == typeof(DirectoryInfo)) {
                e.Node.Nodes.Clear();
                foreach (var item in Directory.GetDirectories(((DirectoryInfo)e.Node.Tag).FullName)) {
                    DirectoryInfo directoryInfo = new DirectoryInfo(item);
                    var node = e.Node.Nodes.Add(directoryInfo.Name, directoryInfo.Name, 0, 0);
                    node.Tag = directoryInfo;
                }

                foreach (var item in Directory.GetFiles(((DirectoryInfo)e.Node.Tag).FullName)) {
                    FileInfo fileInfo = new FileInfo(item);
                    var node = e.Node.Nodes.Add(fileInfo.Name, fileInfo.Name, 1, 1);
                    node.Tag = fileInfo;
                }
                e.Node.Expand();
            }
            else {
                // open file
                try {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();
                    string query = "SELECT * FROM USERS WHERE user_name = '" + username + "' AND password = '" + password + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataTable dtblUsr = new DataTable();
                    sda.Fill(dtblUsr);

                    if (dtblUsr.Rows.Count > 0) {
                        query = "SELECT * FROM CODING WHERE user_id = '" + this.userid + "'";
                        SqlCommand cmdLang = new SqlCommand(query, connection);
                        sda = new SqlDataAdapter(query, connection);
                        DataTable dtblLang = new DataTable();
                        sda.Fill(dtblLang);

                        if (dtblLang.Rows.Count > 0) {
                            if (start == DateTime.MinValue)
                                start = DateTime.Now;
                            else {
                                int pointIndex = ((FileInfo)e.Node.Tag).Name.IndexOf("."); //.IndexOf(".");
                                if (pointIndex != -1) {
                                    string extention = ((FileInfo)e.Node.Tag).Name.Substring(pointIndex);
                                    TimeSpan span = (DateTime.Now - start);
                                    double unixTime = span.TotalSeconds;

                                    if (extention == ".c") {
                                        //query = "UPDATE CODING SET lang_c = lang_c + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        query = "UPDATE CODING SET lang_c = lang_c + 1 WHERE user_id = '" + this.userid + "'";
                                        SqlCommand cmd = new SqlCommand(query, connection);
                                        cmd.ExecuteNonQuery();
                                        //cmdLang.CommandText = "UPDATE CODING SET lang_c = lang_c + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        //cmdLang.ExecuteNonQuery();
                                    }
                                    else if (extention == ".cpp") {
                                        //query = "UPDATE CODING SET lang_cpp = lang_cpp + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        query = "UPDATE CODING SET lang_cpp = lang_cpp + 1 WHERE user_id = '" + this.userid + "'";
                                        SqlCommand cmd = new SqlCommand(query, connection);
                                        cmd.ExecuteNonQuery();
                                        //cmdLang.CommandText = "UPDATE CODING SET lang_cpp = lang_cpp + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        //cmdLang.ExecuteNonQuery();
                                    }
                                    else if ((extention == ".cs")) {
                                        //query = "UPDATE CODING SET lang_cs = lang_cs + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        query = "UPDATE CODING SET lang_cs = lang_cs + 1 WHERE user_id = '" + this.userid + "'";
                                        SqlCommand cmd = new SqlCommand(query, connection);
                                        cmd.ExecuteNonQuery();
                                        //cmdLang.CommandText = "UPDATE CODING SET lang_cs = lang_cs + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        //cmdLang.ExecuteNonQuery();
                                    }
                                    else if ((extention == ".java")) {
                                        //query = "UPDATE CODING SET lang_java = lang_java + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        query = "UPDATE CODING SET lang_java = lang_java + 1 WHERE user_id = '" + this.userid + "'";
                                        SqlCommand cmd = new SqlCommand(query, connection);
                                        cmd.ExecuteNonQuery();
                                        //cmdLang.CommandText = "UPDATE CODING SET lang_java = lang_java + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        //cmdLang.ExecuteNonQuery();
                                    }
                                    else if ((extention == ".js")) {
                                        //query = "UPDATE CODING SET lang_js = lang_js + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        query = "UPDATE CODING SET lang_js = lang_js + 1 WHERE user_id = '" + this.userid + "'";
                                        SqlCommand cmd = new SqlCommand(query, connection);
                                        cmd.ExecuteNonQuery();
                                        //cmdLang.CommandText = "UPDATE CODING SET lang_js = lang_js + " + Convert.ToString(unixTime) + " WHERE user_id =   
                                    }
                                    else if ((extention == ".php")) {
                                        //query = "UPDATE CODING SET lang_php = lang_php + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        query = "UPDATE CODING SET lang_php = lang_php + 1 WHERE user_id = '" + this.userid + "'";
                                        SqlCommand cmd = new SqlCommand(query, connection);
                                        cmd.ExecuteNonQuery();
                                        //cmdLang.CommandText = "UPDATE CODING SET lang_php = lang_php + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        //cmdLang.ExecuteNonQuery();
                                    }
                                    else if ((extention == ".py")) {
                                        //query = "UPDATE CODING SET lang_py = lang_py + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        query = "UPDATE CODING SET lang_py = lang_py + 1 WHERE user_id = '" + this.userid + "'";
                                        SqlCommand cmd = new SqlCommand(query, connection);
                                        cmd.ExecuteNonQuery();
                                        //cmdLang.CommandText = "UPDATE CODING SET lang_py = lang_py + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        //cmdLang.ExecuteNonQuery();
                                    }
                                    else if ((extention == ".sql")) {
                                        //query = "UPDATE CODING SET lang_sql = lang_sql + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        query = "UPDATE CODING SET lang_sql = lang_sql + 1 WHERE user_id = '" + this.userid + "'";
                                        SqlCommand cmd = new SqlCommand(query, connection);
                                        cmd.ExecuteNonQuery();
                                        //cmdLang.CommandText = "UPDATE CODING SET lang_sql = lang_sql + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        //cmdLang.ExecuteNonQuery();
                                    }
                                    else {
                                        //query = "UPDATE CODING SET lang_other = lang_other + " + Convert.ToString(unixTime) + " WHERE user_id = '" + this.userid + "'";
                                        query = "UPDATE CODING SET lang_other = lang_other + 1 WHERE user_id = '" + this.userid + "'";
                                        SqlCommand cmd = new SqlCommand(query, connection);
                                        cmd.ExecuteNonQuery();
                                        //cmdLang.CommandText = "UPDATE CODING SET lang_other = lang_other + " + Convert.ToString(unixTime) + " WHERE
                                    }
                                }
                            }
                        }

                        else {
                            query = "INSERT INTO CODING (user_id, lang_c, lang_cpp, lang_cs, lang_java, lang_js, lang_php, lang_py, lang_sql, lang_other) VALUES ('" + this.userid + "', 0, 0, 0, 0, 0, 0, 0, 0, 0)";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.ExecuteNonQuery();

                            if (start == DateTime.MinValue)
                                start = DateTime.Now;
                            else {
                                int pointIndex = ((FileInfo)e.Node.Tag).FullName.IndexOf(".");
                                TimeSpan span = (DateTime.Now - start);
                                double unixTime = span.TotalSeconds;
                                if (pointIndex != -1) {
                                    string extention = ((FileInfo)e.Node.Tag).FullName.Substring(pointIndex + 1);
                                    if (extention == ".c") {
                                        cmdLang.CommandText = "UPDATE CODING SET lang_c = lang_c + 1 WHERE user_id = '" + this.userid + "'";
                                        cmdLang.ExecuteNonQuery();
                                    }
                                    else if (extention == ".cpp") {
                                        cmdLang.CommandText = "UPDATE CODING SET lang_cpp = lang_cpp + 1 WHERE user_id = '" + this.userid + "'";
                                        cmdLang.ExecuteNonQuery();
                                    }
                                    else if ((extention == ".cs")) {
                                        cmdLang.CommandText = "UPDATE CODING SET lang_cs = lang_cs + 1 WHERE user_id = '" + this.userid + "'";
                                        cmdLang.ExecuteNonQuery();
                                    }
                                    else if ((extention == ".java")) {
                                        cmdLang.CommandText = "UPDATE CODING SET lang_java = lang_java + 1 WHERE user_id = '" + this.userid + "'";
                                        cmdLang.ExecuteNonQuery();
                                    }
                                    else if ((extention == ".js")) {
                                        cmdLang.CommandText = "UPDATE CODING SET lang_js = lang_js + 1 WHERE user_id = '" + this.userid + "'";
                                        cmdLang.ExecuteNonQuery();
                                    }
                                    else if ((extention == ".php")) {
                                        cmdLang.CommandText = "UPDATE CODING SET lang_php = lang_php + 1 WHERE user_id = '" + this.userid + "'";
                                        cmdLang.ExecuteNonQuery();
                                    }
                                    else if ((extention == ".py")) {
                                        cmdLang.CommandText = "UPDATE CODING SET lang_py = lang_py + 1 WHERE user_id = '" + this.userid + "'";
                                        cmdLang.ExecuteNonQuery();
                                    }
                                    else if ((extention == ".sql")) {
                                        cmdLang.CommandText = "UPDATE CODING SET lang_sql = lang_sql + 1 WHERE user_id = '" + this.userid + "'";
                                        cmdLang.ExecuteNonQuery();
                                    }
                                    else {
                                        cmdLang.CommandText = "UPDATE CODING SET lang_other = lang_other + 1 WHERE user_id = '" + this.userid + "'";
                                        cmdLang.ExecuteNonQuery();
                                    }
                                }
                                else
                                    MessageBox.Show("File type is not supported.");
                                this.start = DateTime.Now;
                            }
                        }

                        codeRichTextBox.Text = File.ReadAllText(((FileInfo)e.Node.Tag).FullName);
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

        private void runCFileToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void runPythonFileToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => File.WriteAllText(((FileInfo)tree.SelectedNode.Tag).FullName, codeRichTextBox.Text);

        private void accountToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                if (connection.State != ConnectionState.Open)
                connection.Open();
                string query = "SELECT * FROM USERS WHERE user_name = '" + username + "' AND password = '" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count > 0) {
                    DialogResult dialogResult = MessageBox.Show("Do you want to sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes) {
                        SignInPage signInPage = new SignInPage();
                        signInPage.Show();
                        this.Close();
                    }
                    else {
                        this.Show();
                    }
                }
                else {
                    SignInPage signInPage = new SignInPage();
                    signInPage.Show();
                    this.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e) {
            var form = new StatisticsPage(username, password);
            form.Show();
        }
    }
}
