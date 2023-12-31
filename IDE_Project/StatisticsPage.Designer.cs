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
            exitButton = new Button();
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
            // 
            // StatisticsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StatisticsPage";
            Text = "StatisticsPage";
            ResumeLayout(false);
        }

        #endregion

        private Button exitButton;
    }
}