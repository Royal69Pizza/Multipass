using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Multipass
{

    public partial class Main : Form
    {
        /**| Fichier à serializer |**/
        private string filePath = "passwords.bin";

        /**| Liste de tous les MDP |**/
        private List<Password> passwordList;

        public Main()
        {
            InitializeComponent();

            /**| Deserialize le fichier de sauvegarde |**/
            passwordList = ClientSerialization.Open(filePath);

            /**| Affiche tous les mots de passe dans la ListBox |**/
            GetAllPasswords();

            /**| Préremplit le path de sauvegarde |**/
            inputPath.Text = "C:\\";

            /**| Auto-check la generation rage |**/
            RAGE.Checked = true;

            /**| Auto-check l'export en BIN |**/
            BIN.Checked = true;


            /**| Collection des Polices |**/
            PrivateFontCollection AllFonts = new PrivateFontCollection();

            /**| Chemin du projet |**/
            string rootPath = Environment.CurrentDirectory;

            /**| Ajout des polices|**/
            AllFonts.AddFontFile(rootPath + "\\praetorian.ttf");
            AllFonts.AddFontFile(rootPath + "\\omegaflighttitle.ttf");

            /**| Applique les polices|**/
            labelLogo.Font = new Font(AllFonts.Families[1], 13, FontStyle.Regular);

            searchBox.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            infoBox.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            createBox.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            editBox.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            generateBox.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            exportBox.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            optionsBox.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);

            ButtonCreate.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            ButtonEdit.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            ButtonDelete.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            ButtonGenerate.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            ButtonExport.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            ButtonExit.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
        }

        /**| Affiche tous les mots de passe dans la ListBox |**/
        private void GetAllPasswords()
        {
            ListBoxOfPWD.Items.Clear();

            foreach (Password pwd in passwordList)
            {
                /**| String de l'objet à afficher |**/
                ListBoxOfPWD.DisplayMember = "name";

                /**| Ajoute à la ListBox l'objet |**/
                ListBoxOfPWD.Items.Add(new Password(pwd.Name, pwd.ID, pwd.PWD));
            }
        }

        /**| Créer un MDP |**/
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string name = inputCreateName.Text;
            string id = inputCreateID.Text;
            string pwd = inputCreatePWD.Text;

            if (name != "" && id != "" && pwd != "")
            {
                Password newPassword = new Password(name, id, pwd);
                passwordList.Add(newPassword);

                ListBoxOfPWD.Items.Add(newPassword.Name);

                /**| Suavegarde le nouveau password |**/
                ClientSerialization.Save(passwordList, filePath);

                /**| Affiche tous les mots de passe dans la ListBox |**/
                GetAllPasswords();

                MessageBox.Show("Password created.", "Multipass", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Enter the informations for create the password.", "Multipass", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /**| Affiche les infos du MDP quand il est séléctionné |**/
        private void ListBoxOfPWD_SelectedIndexChanged(object sender, EventArgs e)
        {
            /**| Récupère l'objet séléctionné |**/
            Password password = (Password)ListBoxOfPWD.SelectedItem;

            if (password != null)
            {
                InputSearchID.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                InputSearchPWD.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);

                textCopy.Text = "Click on inputs to copy";

                InputSearchID.Text = password.ID;
                InputSearchPWD.Text = password.PWD;

                inputEditID.Text = password.ID;
                inputEditPWD.Text = password.PWD;
            }
        }

        /**| Supprime un MDP |**/
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Password password = (Password)ListBoxOfPWD.SelectedItem;

            /**| boite de dialogue pour supprimer le mdp |**/
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete the password for " + password.Name + " ?", "Cheddar Tsunami", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (password != null)
            {
                if (dialogResult == DialogResult.Yes)
                {
                    /**| On delete le password |**/
                    ClientSerialization.Delete(password, filePath);

                    /**| on recharge la collection des password |**/
                    passwordList = ClientSerialization.Open(filePath);

                    /**| Affiche tous les mots de passe dans la ListBox |**/
                    GetAllPasswords();

                    MessageBox.Show("Password deleted.", "Multipass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                MessageBox.Show("Select a password to delete.", "Multipass", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /**| Modifie un MDP |**/
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            Password password = (Password)ListBoxOfPWD.SelectedItem;

            if (password != null)
            {
                string aNewID = inputEditID.Text;
                string aNewPwd = inputEditPWD.Text;

                if (aNewID != "" && aNewPwd != "")
                {
                    Password aNewPassword = new Password(password.Name, aNewID, aNewPwd);

                    ClientSerialization.Edit(password, aNewPassword, filePath);

                    /**| on recharge la collection des password |**/
                    passwordList = ClientSerialization.Open(filePath);

                    /**| Affiche tous les mots de passe dans la ListBox |**/
                    GetAllPasswords();

                    MessageBox.Show("Password edited.", "Multipass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show("Enter the informations for edit the password.", "Multipass", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else {
                MessageBox.Show("Select a password to edit.", "Multipass", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            if (RAGE.Checked)
            {
                inputGenPwd.Text = "your generator";
            }
            if (MetalMatrix.Checked)
            {
                inputGenPwd.Text = "your generator";
            }
            if (PSEC.Checked)
            {
                inputGenPwd.Text = "your generator";
            }
            if (RoyalPass.Checked)
            {
                inputGenPwd.Text = "your generator";
            }
        }

        /**| Bouton de selection du path |**/
        private void ButtonSelectPath_Click(object sender, EventArgs e)
        {
            inputPath.Clear();

            string Date = DateTime.Now.ToString("dd-MM-yyyy");

            string format = ".bin";

            if (BIN.Checked)
            {
                format = ".bin";
            }
            if (TXT.Checked)
            {
                format = ".txt";
            }

            /**| Dialogue de dossier ou se trouvera la backup |**/
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                inputPath.Text = Path.Combine(dialog.SelectedPath, Path.GetFileName(inputPath.Text)) + "\\password-backup-" + Date + "" + format;
            }
        }

        /**| Execute une backup |**/
        private void ButtonExport_Click(object sender, EventArgs e)
        {
            string pathForBackup = inputPath.Text;

            textExport.Text = "Wait a few seconds...";

            try
            {
                if (inputPath.Text != "")
                {
                    /**| Backup TXT |**/
                    if (TXT.Checked)
                    {
                        using (FileStream fileManager = File.Create(pathForBackup))
                        {
                            foreach (Password password in passwordList)
                            {
                                /**| Ecriture dans le fichier |**/
                                byte[] infoPwd = new UTF8Encoding(true).GetBytes(
                                    "" + password.Name + ": [ ID : " + password.ID + " | PWD : " + password.PWD + "]\n"
                                    );
                                fileManager.Write(infoPwd, 0, infoPwd.Length);
                            }
                        }

                        textExport.Text = "Done !";

                        MessageBox.Show("Backup generated at " + pathForBackup, "Multipass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (BIN.Checked)
                    {
                        /**| Création et ouverture du fichier |**/
                        FileStream file = File.Create(pathForBackup);

                        /**| Permet de sérialiser un objet |**/
                        BinaryFormatter serealizer = new BinaryFormatter();

                        /**| Serealization |**/
                        serealizer.Serialize(file, passwordList);

                        /**| Fermeture du fichier |**/
                        file.Close();

                        textExport.Text = "Done !";

                        MessageBox.Show("Backup generated at " + pathForBackup, "Multipass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    MessageBox.Show("Enter a path.", "Multipass", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying to create a backup. " + ex.Message, "Multipass", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**| Button exit |**/
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**| Ctrl C sur ID |**/
        private void InputSearchID_Click(object sender, EventArgs e)
        {
            if (InputSearchID.Text != "")
            {
                Clipboard.SetText(InputSearchID.Text);
                InputSearchID.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);
                textCopy.Text = "ID copied !";
            }
        }

        /**| Ctrl C sur PWD |**/
        private void InputSearchPWD_Click(object sender, EventArgs e)
        {
            if (InputSearchPWD.Text != "")
            {
                Clipboard.SetText(InputSearchPWD.Text);
                InputSearchPWD.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);
                textCopy.Text = "Password copied !";
            }
        }

        /**| Checkbox qui montre les mdp |**/
        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPassword.Checked == true)
            {
                InputSearchPWD.PasswordChar = '\0';
                inputEditPWD.PasswordChar = '\0';
            } else {
                InputSearchPWD.PasswordChar = '∎';
                inputEditPWD.PasswordChar = '∎';
            }
        }

        private void InputSearch_TextChanged(object sender, EventArgs e)
        {
            /*for (int i = 0; i < ListBoxOfPWD.Items.Count; ++i)
            {
                string lbString = ListBoxOfPWD.Items[i].ToString();
                if (lbString.Contains(InputSearch.Text))
                    return i;
            }
            return -1;*/

            ListBoxOfPWD.Items.Clear();

            foreach (Password pwd in passwordList)
            {
                /**| String de l'objet à afficher |**/
                ListBoxOfPWD.DisplayMember = "name";

                if (pwd.Name.Contains(InputSearch.Text))
                {
                    /**| Ajoute à la ListBox l'objet |**/
                    ListBoxOfPWD.Items.Add(new Password(pwd.Name, pwd.ID, pwd.PWD));
                }
            }
        }
    }
}
