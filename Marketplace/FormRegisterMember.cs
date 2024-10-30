using Marketplace.Entities;
using Marketplace.Repository;

namespace Marketplace
{
    public partial class FormRegisterMember : Form
    {
        public FormRegisterMember()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new();
            formLogin.ShowDialog();
        }

        private void buttonCancelRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKlumpen formKlumpen = new();
            formKlumpen.ShowDialog();
        }

        private void buttonResetFields_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxPasswordController.Text = string.Empty;
            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            textBoxCity.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxPhoneNumber.Text = string.Empty;
        }

        private void buttonRegisterNewMember_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Trim() != string.Empty && textBoxPassword.Text.Trim() != string.Empty && textBoxPasswordController.Text.Trim() != string.Empty && textBoxFirstName.Text.Trim() != string.Empty &&
                textBoxLastName.Text.Trim() != string.Empty && textBoxAddress.Text.Trim() != string.Empty && textBoxPostalCode.Text.Trim() != string.Empty && textBoxCity.Text.Trim() != string.Empty && textBoxEmail.Text.Trim() 
                != string.Empty && textBoxPhoneNumber.Text.Trim() != string.Empty) 
            {
                if (string.Equals(textBoxPassword.Text.Trim(), textBoxPasswordController.Text.Trim()))
                {
                    string postalCodeInput = textBoxPostalCode.Text.Replace(" ", "");

                    if (int.TryParse(postalCodeInput, out int postalCode))
                    {
                        string phoneNumber = textBoxPhoneNumber.Text.Replace(" ", "");

                        Member newMember = new(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim(), textBoxFirstName.Text.Trim(), textBoxLastName.Text.Trim(),
                                               textBoxAddress.Text.Trim(), postalCode, textBoxCity.Text.Trim(), textBoxEmail.Text.Trim(), phoneNumber);

                        MemberRepository.Save(newMember);

                        MessageBox.Show("Registrering lyckades. Logga in för att fortsätta.");

                        buttonResetFields_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Du har inte angett ett postnummer med bara siffror. Försök igen.");
                    }
                }
                else
                {
                    MessageBox.Show("Du har inte angett samma lösenord två gånger. Försök igen.");
                }
            }
            else
            {
                MessageBox.Show("Se till att alla fält är ifyllda och försök igen.");
            }
        }
    }
}
