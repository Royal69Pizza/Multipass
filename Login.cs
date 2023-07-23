using System;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;

namespace Multipass
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

            /**| Votre MDP |**/
            inputLogin.Text = "I love cupcakes";

            /**| Collection des Polices |**/
            PrivateFontCollection AllFonts = new PrivateFontCollection();

            /**| Chemin du projet |**/
            string rootPath = Environment.CurrentDirectory;

            /**| Ajout des polices|**/
            AllFonts.AddFontFile(rootPath + "\\praetorian.ttf");
            AllFonts.AddFontFile(rootPath + "\\omegaflighttitle.ttf");

            /**| Applique les polices|**/
            labelLogo.Font = new Font(AllFonts.Families[1], 13, FontStyle.Regular);
            ButtonLogin.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            ButtonExitBeforeLogin.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
        }

        /**| Login |**/
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (inputLogin.Text == "I love cupcakes")
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
