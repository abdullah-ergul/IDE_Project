namespace IDE_Project {
    partial class StatisticsPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            exitButton = new Button();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 24);
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.LightGray;
            exitButton.Location = new Point(772, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(30, 30);
            exitButton.TabIndex = 0;
            exitButton.Text = "x";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 1;
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // StatisticsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(exitButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StatisticsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StatisticsPage";
            Load += StatisticsPage_Load;
            Paint += StatisticsPage_Paint;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private BindingSource bindingSource1;
        private Label label1;
    }
}