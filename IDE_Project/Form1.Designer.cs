namespace IDE_Project {
    partial class Login_Page {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            codeRichTextBox = new RichTextBox();
            tree = new TreeView();
            ımageList1 = new ImageList(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newWindowItem = new ToolStripMenuItem();
            openFolderItem = new ToolStripMenuItem();
            exitItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            wievToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            folderBrowserDialog1 = new FolderBrowserDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // codeRichTextBox
            // 
            codeRichTextBox.AcceptsTab = true;
            codeRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            codeRichTextBox.BackColor = Color.FromArgb(31, 31, 31);
            codeRichTextBox.BorderStyle = BorderStyle.None;
            codeRichTextBox.Font = new Font("Consolas", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            codeRichTextBox.ForeColor = Color.White;
            codeRichTextBox.Location = new Point(227, 41);
            codeRichTextBox.Name = "codeRichTextBox";
            codeRichTextBox.Size = new Size(769, 484);
            codeRichTextBox.TabIndex = 1;
            codeRichTextBox.Text = "";
            codeRichTextBox.WordWrap = false;
            codeRichTextBox.TextChanged += codeRichTextBox_TextChanged;
            // 
            // tree
            // 
            tree.BackColor = Color.FromArgb(24, 24, 24);
            tree.BorderStyle = BorderStyle.None;
            tree.ForeColor = Color.LightGray;
            tree.Location = new Point(12, 41);
            tree.Name = "tree";
            tree.Size = new Size(209, 484);
            tree.TabIndex = 2;
            tree.NodeMouseClick += tree_NodeMouseClick;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "folder-1484.png");
            ımageList1.Images.SetKeyName(1, "document-64.png");
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, wievToolStripMenuItem, runToolStripMenuItem, helpToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1008, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newWindowItem, openFolderItem, exitItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newWindowItem
            // 
            newWindowItem.Name = "newWindowItem";
            newWindowItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            newWindowItem.Size = new Size(220, 22);
            newWindowItem.Text = "New Window";
            newWindowItem.Click += newWindowItem_Click;
            // 
            // openFolderItem
            // 
            openFolderItem.Name = "openFolderItem";
            openFolderItem.ShortcutKeys = Keys.Control | Keys.K;
            openFolderItem.Size = new Size(220, 22);
            openFolderItem.Text = "Open Folder";
            openFolderItem.Click += openFolderItem_Click;
            // 
            // exitItem
            // 
            exitItem.Name = "exitItem";
            exitItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitItem.Size = new Size(220, 22);
            exitItem.Text = "Exit";
            exitItem.Click += exitItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // wievToolStripMenuItem
            // 
            wievToolStripMenuItem.Name = "wievToolStripMenuItem";
            wievToolStripMenuItem.Size = new Size(44, 20);
            wievToolStripMenuItem.Text = "View";
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(40, 20);
            runToolStripMenuItem.Text = "Run";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(1008, 537);
            Controls.Add(tree);
            Controls.Add(codeRichTextBox);
            Controls.Add(menuStrip1);
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox codeRichTextBox;
        private TreeView tree;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem wievToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem newWindowItem;
        private ToolStripMenuItem exitItem;
        private ToolStripMenuItem openFolderItem;
        private FolderBrowserDialog folderBrowserDialog1;
        private ImageList ımageList1;
        private ToolStripMenuItem runToolStripMenuItem;
    }
}
