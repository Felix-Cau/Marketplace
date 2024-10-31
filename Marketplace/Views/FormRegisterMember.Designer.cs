namespace Marketplace.Views
{
    partial class FormRegisterMember
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
            label1 = new Label();
            textBoxAddress = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxPostalCode = new TextBox();
            textBoxCity = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxPasswordController = new TextBox();
            labelPasswordController = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelAddress = new Label();
            labelPostalCode = new Label();
            labelEmail = new Label();
            labelPhoneNumber = new Label();
            labelCity = new Label();
            labelPassword = new Label();
            labelUsername = new Label();
            buttonRegisterNewMember = new Button();
            buttonResetFields = new Button();
            buttonCancelRegistration = new Button();
            buttonLogin = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(308, 15);
            label1.TabIndex = 0;
            label1.Text = "Ange följande information för att registrera medlemskap.";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(12, 191);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(300, 23);
            textBoxAddress.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(12, 61);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(137, 23);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 105);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(137, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(12, 147);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(137, 23);
            textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(175, 147);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(137, 23);
            textBoxLastName.TabIndex = 5;
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(12, 235);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(137, 23);
            textBoxPostalCode.TabIndex = 6;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(12, 279);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(137, 23);
            textBoxCity.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 323);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(137, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(12, 367);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(137, 23);
            textBoxPhoneNumber.TabIndex = 9;
            // 
            // textBoxPasswordController
            // 
            textBoxPasswordController.Location = new Point(175, 105);
            textBoxPasswordController.Name = "textBoxPasswordController";
            textBoxPasswordController.Size = new Size(137, 23);
            textBoxPasswordController.TabIndex = 10;
            // 
            // labelPasswordController
            // 
            labelPasswordController.AutoSize = true;
            labelPasswordController.Location = new Point(175, 87);
            labelPasswordController.Name = "labelPasswordController";
            labelPasswordController.Size = new Size(120, 15);
            labelPasswordController.TabIndex = 11;
            labelPasswordController.Text = "Ange lösenordet igen";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(12, 131);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(55, 15);
            labelFirstName.TabIndex = 12;
            labelFirstName.Text = "Förnamn";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(175, 131);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(62, 15);
            labelLastName.TabIndex = 13;
            labelLastName.Text = "Efternamn";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(12, 173);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(42, 15);
            labelAddress.TabIndex = 14;
            labelAddress.Text = "Adress";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(12, 217);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(76, 15);
            labelPostalCode.TabIndex = 15;
            labelPostalCode.Text = "Postnummer";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 305);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(41, 15);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "E-mail";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(12, 349);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(91, 15);
            labelPhoneNumber.TabIndex = 17;
            labelPhoneNumber.Text = "Telefonnummer";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(12, 261);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(45, 15);
            labelCity.TabIndex = 18;
            labelCity.Text = "Postort";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(12, 87);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(84, 15);
            labelPassword.TabIndex = 19;
            labelPassword.Text = "Ange lösenord";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(12, 43);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(89, 15);
            labelUsername.TabIndex = 20;
            labelUsername.Text = "Användarnamn";
            // 
            // buttonRegisterNewMember
            // 
            buttonRegisterNewMember.Location = new Point(12, 396);
            buttonRegisterNewMember.Name = "buttonRegisterNewMember";
            buttonRegisterNewMember.Size = new Size(145, 23);
            buttonRegisterNewMember.TabIndex = 21;
            buttonRegisterNewMember.Text = "Registrera medlemskap";
            buttonRegisterNewMember.UseVisualStyleBackColor = true;
            buttonRegisterNewMember.Click += buttonRegisterNewMember_Click;
            // 
            // buttonResetFields
            // 
            buttonResetFields.Location = new Point(163, 396);
            buttonResetFields.Name = "buttonResetFields";
            buttonResetFields.Size = new Size(92, 23);
            buttonResetFields.TabIndex = 22;
            buttonResetFields.Text = "Nollställ fälten";
            buttonResetFields.UseVisualStyleBackColor = true;
            buttonResetFields.Click += buttonResetFields_Click;
            // 
            // buttonCancelRegistration
            // 
            buttonCancelRegistration.Location = new Point(163, 426);
            buttonCancelRegistration.Name = "buttonCancelRegistration";
            buttonCancelRegistration.Size = new Size(92, 23);
            buttonCancelRegistration.TabIndex = 23;
            buttonCancelRegistration.Text = "Avbryt";
            buttonCancelRegistration.UseVisualStyleBackColor = true;
            buttonCancelRegistration.Click += buttonCancelRegistration_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(12, 425);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(145, 23);
            buttonLogin.TabIndex = 24;
            buttonLogin.Text = "Gå till inloggningssidan";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 25;
            label2.Text = "Alla fält är obligatoriska.";
            // 
            // FormRegisterMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 461);
            Controls.Add(label2);
            Controls.Add(buttonLogin);
            Controls.Add(buttonCancelRegistration);
            Controls.Add(buttonResetFields);
            Controls.Add(buttonRegisterNewMember);
            Controls.Add(labelUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelCity);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelEmail);
            Controls.Add(labelPostalCode);
            Controls.Add(labelAddress);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelPasswordController);
            Controls.Add(textBoxPasswordController);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxPostalCode);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxAddress);
            Controls.Add(label1);
            Name = "FormRegisterMember";
            Text = "Registrera medlem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAddress;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxPostalCode;
        private TextBox textBoxCity;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxPasswordController;
        private Label labelPasswordController;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelAddress;
        private Label labelPostalCode;
        private Label labelEmail;
        private Label labelPhoneNumber;
        private Label labelCity;
        private Label labelPassword;
        private Label labelUsername;
        private Button buttonRegisterNewMember;
        private Button buttonResetFields;
        private Button buttonCancelRegistration;
        private Button buttonLogin;
        private Label label2;
    }
}