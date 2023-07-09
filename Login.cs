using System;
using System.Windows.Forms;

namespace Multipass
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            /**| Votre MDP |**/
            inputLogin.Text = "Your master key";
        }

        /**| Login |**/
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (inputLogin.Text == "Your master key")
            {
                /**| Initialise le form |**/
                Main Main = new Main();

                /**| Ouvre cheddar tsunami |**/
                Main.Show();

                /**| Cache le form de login et se fermera lors de l'Application.Exit |**/
                this.Hide();
            } else {
                MessageBox.Show("Wrong password.", "Multipass", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /**| Exit |**/
        private void ButtonExitBeforeLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
