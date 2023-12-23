using System.Text.RegularExpressions;

namespace IDE_Project {
    public partial class Login_Page : Form {
        public Login_Page() {
            InitializeComponent();
        }

        //private Rectangle codeRichTextBoxOriginalRectangle;
        //private Rectangle originalFormsSize;
        //private Rectangle treeOriginalRectangle;

        private void Login_Page_Load(object sender, EventArgs e) {
            //originalFormsSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);

            //codeRichTextBoxOriginalRectangle = new Rectangle(codeRichTextBox.Location.X, codeRichTextBox.Location.Y, codeRichTextBox.Width, codeRichTextBox.Height);
            //resizeControl(codeRichTextBoxOriginalRectangle, codeRichTextBox);

            //treeOriginalRectangle = new Rectangle(tree.Location.X, tree.Location.Y, tree.Width, tree.Height);
            //resizeControl(treeOriginalRectangle, tree);
        }

        //private void resizeControl(Rectangle r, Control c) {
        //    float xRatio = (float)(this.Width) / (float)(originalFormsSize.Width);
        //    float yRatio = (float)(this.Height) / (float)(originalFormsSize.Height);

        //    int newX = (int)(r.Width * xRatio);
        //    int newY = (int)(r.Height * yRatio);

        //    int newWidth = (int)(r.Width * xRatio);
        //    int newHeight = (int)(r.Height * yRatio);

        //    c.Location = new Point(newX, newY);
        //    c.Size = new Size(newWidth, newHeight);
        //}

        //private void Login_Page_Resize(object sender, EventArgs e) {
        //    resizeControl(codeRichTextBoxOriginalRectangle, codeRichTextBox);
        //    resizeControl(treeOriginalRectangle, tree);
        //}

        private void codeRichTextBox_TextChanged(object sender, EventArgs e) {
            string keywords = @"\b(public|private|partial|static|namespace|class|using|void|foreach|in)\b";
            MatchCollection keywordMatches = Regex.Matches(codeRichTextBox.Text, keywords);

            string types = @"\b(Console)\b";
            MatchCollection typeMatches = Regex.Matches(codeRichTextBox.Text, types);

            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(codeRichTextBox.Text, comments, RegexOptions.Multiline);

            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(codeRichTextBox.Text, strings);

            int originalIndex = codeRichTextBox.Text.Length;
            int originalLength = codeRichTextBox.SelectionLength;
            Color originalColor = Color.LightGray;

            tree.Focus();

            codeRichTextBox.SelectionStart = 0;
            codeRichTextBox.SelectionLength = codeRichTextBox.Text.Length;
            codeRichTextBox.SelectionColor = originalColor;

            foreach (Match m in keywordMatches) {
                codeRichTextBox.SelectionStart = m.Index;
                codeRichTextBox.SelectionLength = m.Length;
                codeRichTextBox.SelectionColor = Color.FromArgb(45, 122, 214);
            }

            foreach (Match m in typeMatches) {
                codeRichTextBox.SelectionStart = m.Index;
                codeRichTextBox.SelectionLength = m.Length;
                codeRichTextBox.SelectionColor = Color.FromArgb(53, 177, 152);
            }

            foreach (Match m in commentMatches) {
                codeRichTextBox.SelectionStart = m.Index;
                codeRichTextBox.SelectionLength = m.Length;
                codeRichTextBox.SelectionColor = Color.FromArgb(67, 138, 85);
            }

            foreach (Match m in stringMatches) {
                codeRichTextBox.SelectionStart = m.Index;
                codeRichTextBox.SelectionLength = m.Length;
                codeRichTextBox.SelectionColor = Color.FromArgb(206, 118, 75);
            }

            codeRichTextBox.SelectionStart = originalIndex;
            codeRichTextBox.SelectionLength = originalLength;
            codeRichTextBox.SelectionColor = originalColor;

            codeRichTextBox.Focus();
            codeRichTextBox.ScrollToCaret();
        }

        private void newWindowItem_Click(object sender, EventArgs e) {
            new Login_Page().Show();
        }

        private void exitItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

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

        private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Node.Tag == null) {
                // return
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
                codeRichTextBox.Text = File.ReadAllText(((FileInfo)e.Node.Tag).FullName);
            }
        }
    }
}
