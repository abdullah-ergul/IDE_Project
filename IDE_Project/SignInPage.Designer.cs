namespace IDE_Project {
    partial class SignInPage {
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
            label1 = new Label();
            label2 = new Label();
            unameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label3 = new Label();
            signInButton = new Button();
            label4 = new Label();
            signUpButton = new Button();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 24);
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.LightGray;
            exitButton.Location = new Point(610, 0);
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
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(275, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 45);
            label1.TabIndex = 1;
            label1.Text = "Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(155, 177);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // unameTextBox
            // 
            unameTextBox.Location = new Point(260, 179);
            unameTextBox.Name = "unameTextBox";
            unameTextBox.Size = new Size(225, 23);
            unameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(260, 235);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(225, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(166, 233);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // signInButton
            // 
            signInButton.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            signInButton.FlatStyle = FlatStyle.Flat;
            signInButton.ForeColor = Color.LightGray;
            signInButton.Location = new Point(458, 284);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(83, 30);
            signInButton.TabIndex = 6;
            signInButton.Text = "Sign In";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(238, 348);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 7;
            label4.Text = "Don't have an account?";
            // 
            // signUpButton
            // 
            signUpButton.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 24);
            signUpButton.FlatStyle = FlatStyle.Flat;
            signUpButton.ForeColor = Color.DodgerBlue;
            signUpButton.Location = new Point(365, 340);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(60, 30);
            signUpButton.TabIndex = 8;
            signUpButton.Text = "&Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // SignInPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(640, 480);
            Controls.Add(signUpButton);
            Controls.Add(label4);
            Controls.Add(signInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(label3);
            Controls.Add(unameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exitButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignInPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Label label1;
        private Label label2;
        private TextBox unameTextBox;
        private TextBox passwordTextBox;
        private Label label3;
        private Button signInButton;
        private Label label4;
        private Button signUpButton;
    }
}