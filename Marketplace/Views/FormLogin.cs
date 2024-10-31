using Marketplace.Entities;
using Marketplace.Repository;

namespace Marketplace.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            (bool successfullLogin, Member member) = MemberRepository.CheckCredentialsForLogin(username, password);

            if (successfullLogin)
            {
                this.Hide();
                FormMember formMember = new(member);
                formMember.ShowDialog();
            }
            else
            {
                MessageBox.Show("Felaktigt användarnamn eller lösenord. Försök igen.");
            }
        }

        private void buttonCancelLogin_Click(object sender, EventArgs e) 
        {
            this.Hide();
            FormKlumpen formKlumpen = new();
            formKlumpen.ShowDialog();
        }
    }
}
