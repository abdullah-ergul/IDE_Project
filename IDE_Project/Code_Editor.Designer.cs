namespace IDE_Project {
    partial class Code_Editor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Code_Editor));
            codeRichTextBox = new RichTextBox();
            tree = new TreeView();
            ımageList1 = new ImageList(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newWindowItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            openFolderItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitItem = new ToolStripMenuItem();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            wievToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            runCFileToolStripMenuItem = new ToolStripMenuItem();
            runPythonFileToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            ındexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            folderBrowserDialog1 = new FolderBrowserDialog();
            toolStripContainer1 = new ToolStripContainer();
            minButton = new Button();
            maxButton = new Button();
            signInMenuStrip = new MenuStrip();
            signInToolStripMenuItem = new ToolStripMenuItem();
            exitButton = new Button();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            signInMenuStrip.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // codeRichTextBox
            // 
            codeRichTextBox.AcceptsTab = true;
            codeRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            codeRichTextBox.BackColor = Color.FromArgb(31, 31, 31);
            codeRichTextBox.BorderStyle = BorderStyle.None;
            codeRichTextBox.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            codeRichTextBox.ForeColor = Color.White;
            codeRichTextBox.Location = new Point(257, 41);
            codeRichTextBox.Name = "codeRichTextBox";
            codeRichTextBox.Size = new Size(755, 523);
            codeRichTextBox.TabIndex = 1;
            codeRichTextBox.Text = "";
            codeRichTextBox.WordWrap = false;
            codeRichTextBox.TextChanged += codeRichTextBox_TextChanged;
            // 
            // tree
            // 
            tree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tree.BackColor = Color.FromArgb(24, 24, 24);
            tree.BorderStyle = BorderStyle.None;
            tree.ForeColor = Color.LightGray;
            tree.Location = new Point(42, 41);
            tree.Name = "tree";
            tree.Size = new Size(209, 523);
            tree.TabIndex = 2;
            tree.NodeMouseDoubleClick += tree_NodeMouseDoubleClick;
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
            menuStrip1.BackColor = Color.FromArgb(24, 24, 24);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem1, wievToolStripMenuItem, runToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem1 });
            menuStrip1.Location = new Point(11, 4);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(258, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newWindowItem, toolStripSeparator2, openFolderItem, toolStripSeparator6, saveToolStripMenuItem, toolStripSeparator1, exitItem });
            fileToolStripMenuItem.ForeColor = Color.LightGray;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newWindowItem
            // 
            newWindowItem.BackColor = Color.FromArgb(24, 24, 24);
            newWindowItem.ForeColor = SystemColors.ControlText;
            newWindowItem.Name = "newWindowItem";
            newWindowItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            newWindowItem.Size = new Size(220, 22);
            newWindowItem.Text = "New Window";
            newWindowItem.Click += newWindowItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(217, 6);
            // 
            // openFolderItem
            // 
            openFolderItem.BackColor = Color.FromArgb(24, 24, 24);
            openFolderItem.ForeColor = SystemColors.ControlText;
            openFolderItem.Name = "openFolderItem";
            openFolderItem.ShortcutKeys = Keys.Control | Keys.K;
            openFolderItem.Size = new Size(220, 22);
            openFolderItem.Text = "Open Folder";
            openFolderItem.Click += openFolderItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(217, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(220, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(217, 6);
            // 
            // exitItem
            // 
            exitItem.BackColor = Color.FromArgb(24, 24, 24);
            exitItem.ForeColor = SystemColors.ControlText;
            exitItem.Name = "exitItem";
            exitItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitItem.Size = new Size(220, 22);
            exitItem.Text = "Exit Window";
            exitItem.Click += exitItem_Click;
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
            editToolStripMenuItem1.ForeColor = Color.LightGray;
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(39, 20);
            editToolStripMenuItem1.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(144, 22);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(144, 22);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(144, 22);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(144, 22);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(144, 22);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(144, 22);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // wievToolStripMenuItem
            // 
            wievToolStripMenuItem.ForeColor = Color.LightGray;
            wievToolStripMenuItem.Name = "wievToolStripMenuItem";
            wievToolStripMenuItem.Size = new Size(44, 20);
            wievToolStripMenuItem.Text = "&View";
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { runCFileToolStripMenuItem, runPythonFileToolStripMenuItem });
            runToolStripMenuItem.ForeColor = Color.LightGray;
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(40, 20);
            runToolStripMenuItem.Text = "&Run";
            // 
            // runCFileToolStripMenuItem
            // 
            runCFileToolStripMenuItem.Name = "runCFileToolStripMenuItem";
            runCFileToolStripMenuItem.Size = new Size(157, 22);
            runCFileToolStripMenuItem.Text = "&Run C File";
            runCFileToolStripMenuItem.Click += runCFileToolStripMenuItem_Click;
            // 
            // runPythonFileToolStripMenuItem
            // 
            runPythonFileToolStripMenuItem.Name = "runPythonFileToolStripMenuItem";
            runPythonFileToolStripMenuItem.Size = new Size(157, 22);
            runPythonFileToolStripMenuItem.Text = "&Run Python File";
            runPythonFileToolStripMenuItem.Click += runPythonFileToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
            toolsToolStripMenuItem.ForeColor = Color.LightGray;
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(130, 22);
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(130, 22);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, ındexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem1 });
            helpToolStripMenuItem1.ForeColor = Color.LightGray;
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(44, 20);
            helpToolStripMenuItem1.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(122, 22);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // ındexToolStripMenuItem
            // 
            ındexToolStripMenuItem.Name = "ındexToolStripMenuItem";
            ındexToolStripMenuItem.Size = new Size(122, 22);
            ındexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(122, 22);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(119, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(122, 22);
            aboutToolStripMenuItem1.Text = "&About...";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(255, 0);
            toolStripContainer1.Location = new Point(14, 4);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(255, 24);
            toolStripContainer1.TabIndex = 4;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // minButton
            // 
            minButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minButton.AutoSize = true;
            minButton.BackColor = Color.FromArgb(24, 24, 24);
            minButton.Location = new Point(926, 4);
            minButton.Name = "minButton";
            minButton.Size = new Size(24, 25);
            minButton.TabIndex = 6;
            minButton.Text = "_";
            minButton.UseVisualStyleBackColor = false;
            minButton.Click += minButton_Click;
            // 
            // maxButton
            // 
            maxButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxButton.AutoSize = true;
            maxButton.BackColor = Color.FromArgb(24, 24, 24);
            maxButton.Location = new Point(956, 4);
            maxButton.Name = "maxButton";
            maxButton.Size = new Size(24, 24);
            maxButton.TabIndex = 5;
            maxButton.UseVisualStyleBackColor = false;
            maxButton.Click += maxButton_Click;
            // 
            // signInMenuStrip
            // 
            signInMenuStrip.BackColor = Color.FromArgb(24, 24, 24);
            signInMenuStrip.Dock = DockStyle.None;
            signInMenuStrip.Items.AddRange(new ToolStripItem[] { signInToolStripMenuItem });
            signInMenuStrip.Location = new Point(828, 4);
            signInMenuStrip.Name = "signInMenuStrip";
            signInMenuStrip.Size = new Size(63, 24);
            signInMenuStrip.TabIndex = 0;
            signInMenuStrip.Text = "menuStrip2";
            // 
            // signInToolStripMenuItem
            // 
            signInToolStripMenuItem.ForeColor = Color.LightGray;
            signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            signInToolStripMenuItem.Size = new Size(55, 20);
            signInToolStripMenuItem.Text = "Sign In";
            signInToolStripMenuItem.Click += signInToolStripMenuItem_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.AutoSize = true;
            exitButton.BackColor = Color.FromArgb(24, 24, 24);
            exitButton.Location = new Point(986, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(24, 25);
            exitButton.TabIndex = 1;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(toolStripContainer1);
            panel1.Controls.Add(signInMenuStrip);
            panel1.Controls.Add(minButton);
            panel1.Controls.Add(maxButton);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1023, 34);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // Code_Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(1024, 576);
            Controls.Add(panel1);
            Controls.Add(tree);
            Controls.Add(codeRichTextBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Code_Editor";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Code_Editor_Load;
            Resize += Code_Editor_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            signInMenuStrip.ResumeLayout(false);
            signInMenuStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox codeRichTextBox;
        private TreeView tree;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem wievToolStripMenuItem;
        private ToolStripMenuItem newWindowItem;
        private ToolStripMenuItem exitItem;
        private ToolStripMenuItem openFolderItem;
        private FolderBrowserDialog folderBrowserDialog1;
        private ImageList ımageList1;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem runCFileToolStripMenuItem;
        private ToolStripMenuItem runPythonFileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem ındexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private Button maxButton;
        private MenuStrip signInMenuStrip;
        private ToolStripMenuItem signInToolStripMenuItem;
        private Button exitButton;
        private Button minButton;
        private Panel panel1;
    }
}
