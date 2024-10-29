namespace Marketplace
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogin = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            buttonCancelLogin = new Button();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(272, 178);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Logga in";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(137, 101);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(210, 23);
            textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(137, 149);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(210, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(137, 83);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(89, 15);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Användarnamn";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(137, 131);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(56, 15);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Lösenord";
            // 
            // buttonCancelLogin
            // 
            buttonCancelLogin.Location = new Point(191, 178);
            buttonCancelLogin.Name = "buttonCancelLogin";
            buttonCancelLogin.Size = new Size(75, 23);
            buttonCancelLogin.TabIndex = 5;
            buttonCancelLogin.Text = "Avbryt";
            buttonCancelLogin.UseVisualStyleBackColor = true;
            buttonCancelLogin.Click += buttonCancelLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 338);
            Controls.Add(buttonCancelLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonLogin);
            Name = "FormLogin";
            Text = "Logga in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelUsername;
        private Label labelPassword;
        private Button buttonCancelLogin;
    }
}