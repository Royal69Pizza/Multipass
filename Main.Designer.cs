namespace Multipass
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ListBoxOfPWD = new System.Windows.Forms.ListBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.createBox = new System.Windows.Forms.GroupBox();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.inputCreateName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputCreatePWD = new System.Windows.Forms.TextBox();
            this.inputCreateID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editBox = new System.Windows.Forms.GroupBox();
            this.inputEditPWD = new System.Windows.Forms.TextBox();
            this.inputEditID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.generateBox = new System.Windows.Forms.GroupBox();
            this.RAGE = new System.Windows.Forms.RadioButton();
            this.RoyalPass = new System.Windows.Forms.RadioButton();
            this.PSEC = new System.Windows.Forms.RadioButton();
            this.MetalMatrix = new System.Windows.Forms.RadioButton();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.inputGenPwd = new System.Windows.Forms.TextBox();
            this.exportBox = new System.Windows.Forms.GroupBox();
            this.textExport = new System.Windows.Forms.Label();
            this.TXT = new System.Windows.Forms.RadioButton();
            this.BIN = new System.Windows.Forms.RadioButton();
            this.ButtonSelectPath = new System.Windows.Forms.Button();
            this.ButtonExport = new System.Windows.Forms.Button();
            this.inputPath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.textCopy = new System.Windows.Forms.Label();
            this.InputSearchPWD = new System.Windows.Forms.TextBox();
            this.InputSearchID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.CheckBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.optionsBox = new System.Windows.Forms.GroupBox();
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.InputSearch = new System.Windows.Forms.TextBox();
            this.createBox.SuspendLayout();
            this.editBox.SuspendLayout();
            this.generateBox.SuspendLayout();
            this.exportBox.SuspendLayout();
            this.infoBox.SuspendLayout();
            this.optionsBox.SuspendLayout();
            this.searchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxOfPWD
            // 
            this.ListBoxOfPWD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ListBoxOfPWD.ForeColor = System.Drawing.Color.White;
            this.ListBoxOfPWD.FormattingEnabled = true;
            this.ListBoxOfPWD.ItemHeight = 18;
            this.ListBoxOfPWD.Location = new System.Drawing.Point(12, 112);
            this.ListBoxOfPWD.Name = "ListBoxOfPWD";
            this.ListBoxOfPWD.Size = new System.Drawing.Size(284, 364);
            this.ListBoxOfPWD.TabIndex = 0;
            this.ListBoxOfPWD.SelectedIndexChanged += new System.EventHandler(this.ListBoxOfPWD_SelectedIndexChanged);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Praetorian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.Location = new System.Drawing.Point(7, 9);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(178, 27);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "MULTIPASS";
            // 
            // createBox
            // 
            this.createBox.Controls.Add(this.ButtonCreate);
            this.createBox.Controls.Add(this.inputCreateName);
            this.createBox.Controls.Add(this.label7);
            this.createBox.Controls.Add(this.inputCreatePWD);
            this.createBox.Controls.Add(this.inputCreateID);
            this.createBox.Controls.Add(this.label5);
            this.createBox.Controls.Add(this.label6);
            this.createBox.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBox.ForeColor = System.Drawing.Color.White;
            this.createBox.Location = new System.Drawing.Point(302, 157);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(284, 149);
            this.createBox.TabIndex = 5;
            this.createBox.TabStop = false;
            this.createBox.Text = "Create";
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackColor = System.Drawing.Color.Green;
            this.ButtonCreate.Location = new System.Drawing.Point(6, 117);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(272, 26);
            this.ButtonCreate.TabIndex = 16;
            this.ButtonCreate.Text = "CREATE";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // inputCreateName
            // 
            this.inputCreateName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputCreateName.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCreateName.ForeColor = System.Drawing.Color.White;
            this.inputCreateName.Location = new System.Drawing.Point(84, 21);
            this.inputCreateName.Name = "inputCreateName";
            this.inputCreateName.Size = new System.Drawing.Size(194, 26);
            this.inputCreateName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Name";
            // 
            // inputCreatePWD
            // 
            this.inputCreatePWD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputCreatePWD.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCreatePWD.ForeColor = System.Drawing.Color.White;
            this.inputCreatePWD.Location = new System.Drawing.Point(84, 85);
            this.inputCreatePWD.Name = "inputCreatePWD";
            this.inputCreatePWD.Size = new System.Drawing.Size(194, 26);
            this.inputCreatePWD.TabIndex = 9;
            // 
            // inputCreateID
            // 
            this.inputCreateID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputCreateID.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCreateID.ForeColor = System.Drawing.Color.White;
            this.inputCreateID.Location = new System.Drawing.Point(84, 53);
            this.inputCreateID.Name = "inputCreateID";
            this.inputCreateID.Size = new System.Drawing.Size(194, 26);
            this.inputCreateID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID";
            // 
            // editBox
            // 
            this.editBox.Controls.Add(this.inputEditPWD);
            this.editBox.Controls.Add(this.inputEditID);
            this.editBox.Controls.Add(this.label4);
            this.editBox.Controls.Add(this.label8);
            this.editBox.Controls.Add(this.ButtonEdit);
            this.editBox.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBox.ForeColor = System.Drawing.Color.White;
            this.editBox.Location = new System.Drawing.Point(302, 312);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(284, 118);
            this.editBox.TabIndex = 9;
            this.editBox.TabStop = false;
            this.editBox.Text = "EDIT";
            // 
            // inputEditPWD
            // 
            this.inputEditPWD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputEditPWD.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEditPWD.ForeColor = System.Drawing.Color.White;
            this.inputEditPWD.Location = new System.Drawing.Point(84, 53);
            this.inputEditPWD.Name = "inputEditPWD";
            this.inputEditPWD.PasswordChar = '∎';
            this.inputEditPWD.Size = new System.Drawing.Size(194, 26);
            this.inputEditPWD.TabIndex = 24;
            // 
            // inputEditID
            // 
            this.inputEditID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputEditID.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEditID.ForeColor = System.Drawing.Color.White;
            this.inputEditID.Location = new System.Drawing.Point(84, 21);
            this.inputEditID.Name = "inputEditID";
            this.inputEditID.Size = new System.Drawing.Size(194, 26);
            this.inputEditID.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID";
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.Color.Olive;
            this.ButtonEdit.Location = new System.Drawing.Point(6, 86);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(272, 26);
            this.ButtonEdit.TabIndex = 20;
            this.ButtonEdit.Text = "EDIT";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // generateBox
            // 
            this.generateBox.Controls.Add(this.RAGE);
            this.generateBox.Controls.Add(this.RoyalPass);
            this.generateBox.Controls.Add(this.PSEC);
            this.generateBox.Controls.Add(this.MetalMatrix);
            this.generateBox.Controls.Add(this.ButtonGenerate);
            this.generateBox.Controls.Add(this.inputGenPwd);
            this.generateBox.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBox.ForeColor = System.Drawing.Color.White;
            this.generateBox.Location = new System.Drawing.Point(592, 42);
            this.generateBox.Name = "generateBox";
            this.generateBox.Size = new System.Drawing.Size(284, 192);
            this.generateBox.TabIndex = 11;
            this.generateBox.TabStop = false;
            this.generateBox.Text = "GENERATE";
            // 
            // RAGE
            // 
            this.RAGE.AutoSize = true;
            this.RAGE.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAGE.Location = new System.Drawing.Point(9, 53);
            this.RAGE.Name = "RAGE";
            this.RAGE.Size = new System.Drawing.Size(89, 22);
            this.RAGE.TabIndex = 23;
            this.RAGE.TabStop = true;
            this.RAGE.Text = "RAGE ☢";
            this.RAGE.UseVisualStyleBackColor = true;
            // 
            // RoyalPass
            // 
            this.RoyalPass.AutoSize = true;
            this.RoyalPass.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoyalPass.Location = new System.Drawing.Point(9, 128);
            this.RoyalPass.Name = "RoyalPass";
            this.RoyalPass.Size = new System.Drawing.Size(116, 22);
            this.RoyalPass.TabIndex = 22;
            this.RoyalPass.TabStop = true;
            this.RoyalPass.Text = "RoyalPass ♛";
            this.RoyalPass.UseVisualStyleBackColor = true;
            // 
            // PSEC
            // 
            this.PSEC.AutoSize = true;
            this.PSEC.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSEC.Location = new System.Drawing.Point(9, 103);
            this.PSEC.Name = "PSEC";
            this.PSEC.Size = new System.Drawing.Size(87, 22);
            this.PSEC.TabIndex = 21;
            this.PSEC.TabStop = true;
            this.PSEC.Text = "PSEC 🔒";
            this.PSEC.UseVisualStyleBackColor = true;
            // 
            // MetalMatrix
            // 
            this.MetalMatrix.AutoSize = true;
            this.MetalMatrix.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetalMatrix.Location = new System.Drawing.Point(9, 78);
            this.MetalMatrix.Name = "MetalMatrix";
            this.MetalMatrix.Size = new System.Drawing.Size(128, 22);
            this.MetalMatrix.TabIndex = 20;
            this.MetalMatrix.TabStop = true;
            this.MetalMatrix.Text = "Metal Matrix ◈";
            this.MetalMatrix.UseVisualStyleBackColor = true;
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.BackColor = System.Drawing.Color.Green;
            this.ButtonGenerate.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerate.Location = new System.Drawing.Point(6, 160);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(272, 26);
            this.ButtonGenerate.TabIndex = 19;
            this.ButtonGenerate.Text = "GENERATE";
            this.ButtonGenerate.UseVisualStyleBackColor = false;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // inputGenPwd
            // 
            this.inputGenPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputGenPwd.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGenPwd.ForeColor = System.Drawing.Color.White;
            this.inputGenPwd.Location = new System.Drawing.Point(9, 21);
            this.inputGenPwd.Name = "inputGenPwd";
            this.inputGenPwd.Size = new System.Drawing.Size(269, 26);
            this.inputGenPwd.TabIndex = 17;
            // 
            // exportBox
            // 
            this.exportBox.Controls.Add(this.textExport);
            this.exportBox.Controls.Add(this.TXT);
            this.exportBox.Controls.Add(this.BIN);
            this.exportBox.Controls.Add(this.ButtonSelectPath);
            this.exportBox.Controls.Add(this.ButtonExport);
            this.exportBox.Controls.Add(this.inputPath);
            this.exportBox.Controls.Add(this.label12);
            this.exportBox.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBox.ForeColor = System.Drawing.Color.White;
            this.exportBox.Location = new System.Drawing.Point(592, 240);
            this.exportBox.Name = "exportBox";
            this.exportBox.Size = new System.Drawing.Size(284, 163);
            this.exportBox.TabIndex = 12;
            this.exportBox.TabStop = false;
            this.exportBox.Text = "EXPORT";
            // 
            // textExport
            // 
            this.textExport.AutoSize = true;
            this.textExport.BackColor = System.Drawing.Color.Green;
            this.textExport.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textExport.Location = new System.Drawing.Point(6, 169);
            this.textExport.Name = "textExport";
            this.textExport.Size = new System.Drawing.Size(0, 18);
            this.textExport.TabIndex = 28;
            // 
            // TXT
            // 
            this.TXT.AutoSize = true;
            this.TXT.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT.Location = new System.Drawing.Point(9, 46);
            this.TXT.Name = "TXT";
            this.TXT.Size = new System.Drawing.Size(50, 22);
            this.TXT.TabIndex = 27;
            this.TXT.TabStop = true;
            this.TXT.Text = ".txt";
            this.TXT.UseVisualStyleBackColor = true;
            // 
            // BIN
            // 
            this.BIN.AutoSize = true;
            this.BIN.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIN.Location = new System.Drawing.Point(9, 21);
            this.BIN.Name = "BIN";
            this.BIN.Size = new System.Drawing.Size(52, 22);
            this.BIN.TabIndex = 26;
            this.BIN.TabStop = true;
            this.BIN.Text = ".bin";
            this.BIN.UseVisualStyleBackColor = true;
            // 
            // ButtonSelectPath
            // 
            this.ButtonSelectPath.BackColor = System.Drawing.Color.Teal;
            this.ButtonSelectPath.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSelectPath.Location = new System.Drawing.Point(253, 96);
            this.ButtonSelectPath.Name = "ButtonSelectPath";
            this.ButtonSelectPath.Size = new System.Drawing.Size(25, 22);
            this.ButtonSelectPath.TabIndex = 25;
            this.ButtonSelectPath.Text = "◢";
            this.ButtonSelectPath.UseVisualStyleBackColor = false;
            this.ButtonSelectPath.Click += new System.EventHandler(this.ButtonSelectPath_Click);
            // 
            // ButtonExport
            // 
            this.ButtonExport.BackColor = System.Drawing.Color.Green;
            this.ButtonExport.Location = new System.Drawing.Point(6, 128);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(272, 26);
            this.ButtonExport.TabIndex = 24;
            this.ButtonExport.Text = "EXPORT";
            this.ButtonExport.UseVisualStyleBackColor = false;
            this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // inputPath
            // 
            this.inputPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputPath.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPath.ForeColor = System.Drawing.Color.White;
            this.inputPath.Location = new System.Drawing.Point(50, 96);
            this.inputPath.Name = "inputPath";
            this.inputPath.Size = new System.Drawing.Size(197, 26);
            this.inputPath.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Path";
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.textCopy);
            this.infoBox.Controls.Add(this.InputSearchPWD);
            this.infoBox.Controls.Add(this.InputSearchID);
            this.infoBox.Controls.Add(this.label3);
            this.infoBox.Controls.Add(this.label9);
            this.infoBox.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.ForeColor = System.Drawing.Color.White;
            this.infoBox.Location = new System.Drawing.Point(302, 42);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(284, 109);
            this.infoBox.TabIndex = 13;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Info";
            // 
            // textCopy
            // 
            this.textCopy.AutoSize = true;
            this.textCopy.BackColor = System.Drawing.Color.Green;
            this.textCopy.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCopy.Location = new System.Drawing.Point(6, 82);
            this.textCopy.Name = "textCopy";
            this.textCopy.Size = new System.Drawing.Size(156, 18);
            this.textCopy.TabIndex = 10;
            this.textCopy.Text = "Click on inputs to copy";
            // 
            // InputSearchPWD
            // 
            this.InputSearchPWD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.InputSearchPWD.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSearchPWD.ForeColor = System.Drawing.Color.White;
            this.InputSearchPWD.Location = new System.Drawing.Point(84, 53);
            this.InputSearchPWD.Name = "InputSearchPWD";
            this.InputSearchPWD.PasswordChar = '∎';
            this.InputSearchPWD.ReadOnly = true;
            this.InputSearchPWD.Size = new System.Drawing.Size(194, 26);
            this.InputSearchPWD.TabIndex = 9;
            this.InputSearchPWD.Click += new System.EventHandler(this.InputSearchPWD_Click);
            // 
            // InputSearchID
            // 
            this.InputSearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.InputSearchID.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSearchID.ForeColor = System.Drawing.Color.White;
            this.InputSearchID.Location = new System.Drawing.Point(84, 21);
            this.InputSearchID.Name = "InputSearchID";
            this.InputSearchID.ReadOnly = true;
            this.InputSearchID.Size = new System.Drawing.Size(194, 26);
            this.InputSearchID.TabIndex = 8;
            this.InputSearchID.Click += new System.EventHandler(this.InputSearchID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "ID";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Maroon;
            this.ButtonDelete.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(308, 436);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(272, 26);
            this.ButtonDelete.TabIndex = 20;
            this.ButtonDelete.Text = "DELETE";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Maroon;
            this.ButtonExit.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(812, 12);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(64, 26);
            this.ButtonExit.TabIndex = 21;
            this.ButtonExit.Text = "EXIT";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // CheckBoxShowPassword
            // 
            this.CheckBoxShowPassword.AutoSize = true;
            this.CheckBoxShowPassword.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxShowPassword.Location = new System.Drawing.Point(12, 21);
            this.CheckBoxShowPassword.Name = "CheckBoxShowPassword";
            this.CheckBoxShowPassword.Size = new System.Drawing.Size(145, 22);
            this.CheckBoxShowPassword.TabIndex = 22;
            this.CheckBoxShowPassword.Text = "Show passwords";
            this.CheckBoxShowPassword.UseVisualStyleBackColor = true;
            this.CheckBoxShowPassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowPassword_CheckedChanged);
            // 
            // optionsBox
            // 
            this.optionsBox.Controls.Add(this.CheckBoxShowPassword);
            this.optionsBox.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsBox.ForeColor = System.Drawing.Color.White;
            this.optionsBox.Location = new System.Drawing.Point(592, 409);
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.Size = new System.Drawing.Size(284, 53);
            this.optionsBox.TabIndex = 23;
            this.optionsBox.TabStop = false;
            this.optionsBox.Text = "Options";
            // 
            // searchBox
            // 
            this.searchBox.Controls.Add(this.InputSearch);
            this.searchBox.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(12, 42);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(284, 57);
            this.searchBox.TabIndex = 24;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Search";
            // 
            // InputSearch
            // 
            this.InputSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.InputSearch.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSearch.ForeColor = System.Drawing.Color.White;
            this.InputSearch.Location = new System.Drawing.Point(6, 21);
            this.InputSearch.Name = "InputSearch";
            this.InputSearch.Size = new System.Drawing.Size(272, 26);
            this.InputSearch.TabIndex = 8;
            this.InputSearch.TextChanged += new System.EventHandler(this.InputSearch_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(887, 471);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.optionsBox);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.exportBox);
            this.Controls.Add(this.generateBox);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.createBox);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.ListBoxOfPWD);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MULTIPASS";
            this.createBox.ResumeLayout(false);
            this.createBox.PerformLayout();
            this.editBox.ResumeLayout(false);
            this.editBox.PerformLayout();
            this.generateBox.ResumeLayout(false);
            this.generateBox.PerformLayout();
            this.exportBox.ResumeLayout(false);
            this.exportBox.PerformLayout();
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.optionsBox.ResumeLayout(false);
            this.optionsBox.PerformLayout();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxOfPWD;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.GroupBox createBox;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.TextBox inputCreateName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputCreatePWD;
        private System.Windows.Forms.TextBox inputCreateID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox editBox;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.GroupBox generateBox;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.TextBox inputGenPwd;
        private System.Windows.Forms.GroupBox exportBox;
        private System.Windows.Forms.TextBox inputPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.TextBox InputSearchPWD;
        private System.Windows.Forms.TextBox InputSearchID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonExport;
        private System.Windows.Forms.TextBox inputEditPWD;
        private System.Windows.Forms.TextBox inputEditID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonSelectPath;
        private System.Windows.Forms.RadioButton PSEC;
        private System.Windows.Forms.RadioButton MetalMatrix;
        private System.Windows.Forms.RadioButton RoyalPass;
        private System.Windows.Forms.RadioButton TXT;
        private System.Windows.Forms.RadioButton BIN;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label textCopy;
        private System.Windows.Forms.Label textExport;
        private System.Windows.Forms.CheckBox CheckBoxShowPassword;
        private System.Windows.Forms.GroupBox optionsBox;
        private System.Windows.Forms.RadioButton RAGE;
        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.TextBox InputSearch;
    }
}

