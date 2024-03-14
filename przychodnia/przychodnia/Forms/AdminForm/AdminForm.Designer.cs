namespace przychodnia.Forms.AdminForm
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFiltruj = new System.Windows.Forms.Button();
            this.numericUpDownFiltrujIlośćDO = new System.Windows.Forms.NumericUpDown();
            this.textBoxFiltrujAutor = new System.Windows.Forms.TextBox();
            this.numericUpDownFiltrujIlośćOD = new System.Windows.Forms.NumericUpDown();
            this.textBoxFiltrujWydawnictwo = new System.Windows.Forms.TextBox();
            this.numericUpDownFiltrujRok = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIlośćsztukOD = new System.Windows.Forms.CheckBox();
            this.checkBoxKsiazka = new System.Windows.Forms.CheckBox();
            this.checkBoxIlośćSztukDO = new System.Windows.Forms.CheckBox();
            this.checkBoxAutor = new System.Windows.Forms.CheckBox();
            this.checkBoxRokWydaniaOD = new System.Windows.Forms.CheckBox();
            this.checkBoxCzasopismo = new System.Windows.Forms.CheckBox();
            this.checkBoxWydawnictwo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.checkBoxImieNazwisko = new System.Windows.Forms.CheckBox();
            this.textBoxImieNazwisko = new System.Windows.Forms.TextBox();
            this.checkBoxLogin = new System.Windows.Forms.CheckBox();
            this.checkBoxPlec = new System.Windows.Forms.CheckBox();
            this.checkBoxRola = new System.Windows.Forms.CheckBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.comboBoxPlec = new System.Windows.Forms.ComboBox();
            this.comboBoxRola = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltrujIlośćDO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltrujIlośćOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltrujRok)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witaj w panelu Admina !";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(47, 21);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Wyloguj";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 309);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1439, 306);
            this.dataGridView2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownFiltrujIlośćDO);
            this.groupBox1.Controls.Add(this.textBoxFiltrujAutor);
            this.groupBox1.Controls.Add(this.numericUpDownFiltrujIlośćOD);
            this.groupBox1.Controls.Add(this.textBoxFiltrujWydawnictwo);
            this.groupBox1.Controls.Add(this.numericUpDownFiltrujRok);
            this.groupBox1.Controls.Add(this.checkBoxIlośćsztukOD);
            this.groupBox1.Controls.Add(this.checkBoxKsiazka);
            this.groupBox1.Controls.Add(this.checkBoxIlośćSztukDO);
            this.groupBox1.Controls.Add(this.checkBoxAutor);
            this.groupBox1.Controls.Add(this.checkBoxRokWydaniaOD);
            this.groupBox1.Controls.Add(this.checkBoxCzasopismo);
            this.groupBox1.Controls.Add(this.checkBoxWydawnictwo);
            this.groupBox1.Location = new System.Drawing.Point(409, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 238);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROWANIE";
            // 
            // buttonFiltruj
            // 
            this.buttonFiltruj.Location = new System.Drawing.Point(35, 203);
            this.buttonFiltruj.Name = "buttonFiltruj";
            this.buttonFiltruj.Size = new System.Drawing.Size(304, 29);
            this.buttonFiltruj.TabIndex = 35;
            this.buttonFiltruj.Text = "FILTRUJ";
            this.buttonFiltruj.UseVisualStyleBackColor = true;
            this.buttonFiltruj.Click += new System.EventHandler(this.buttonFiltruj_Click);
            // 
            // numericUpDownFiltrujIlośćDO
            // 
            this.numericUpDownFiltrujIlośćDO.Location = new System.Drawing.Point(260, 63);
            this.numericUpDownFiltrujIlośćDO.Name = "numericUpDownFiltrujIlośćDO";
            this.numericUpDownFiltrujIlośćDO.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownFiltrujIlośćDO.TabIndex = 36;
            this.numericUpDownFiltrujIlośćDO.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxFiltrujAutor
            // 
            this.textBoxFiltrujAutor.Location = new System.Drawing.Point(167, 138);
            this.textBoxFiltrujAutor.Name = "textBoxFiltrujAutor";
            this.textBoxFiltrujAutor.Size = new System.Drawing.Size(109, 20);
            this.textBoxFiltrujAutor.TabIndex = 22;
            // 
            // numericUpDownFiltrujIlośćOD
            // 
            this.numericUpDownFiltrujIlośćOD.Location = new System.Drawing.Point(99, 63);
            this.numericUpDownFiltrujIlośćOD.Name = "numericUpDownFiltrujIlośćOD";
            this.numericUpDownFiltrujIlośćOD.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownFiltrujIlośćOD.TabIndex = 25;
            this.numericUpDownFiltrujIlośćOD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxFiltrujWydawnictwo
            // 
            this.textBoxFiltrujWydawnictwo.Location = new System.Drawing.Point(9, 138);
            this.textBoxFiltrujWydawnictwo.Name = "textBoxFiltrujWydawnictwo";
            this.textBoxFiltrujWydawnictwo.Size = new System.Drawing.Size(109, 20);
            this.textBoxFiltrujWydawnictwo.TabIndex = 26;
            // 
            // numericUpDownFiltrujRok
            // 
            this.numericUpDownFiltrujRok.Location = new System.Drawing.Point(110, 28);
            this.numericUpDownFiltrujRok.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDownFiltrujRok.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownFiltrujRok.Name = "numericUpDownFiltrujRok";
            this.numericUpDownFiltrujRok.Size = new System.Drawing.Size(108, 20);
            this.numericUpDownFiltrujRok.TabIndex = 34;
            this.numericUpDownFiltrujRok.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // checkBoxIlośćsztukOD
            // 
            this.checkBoxIlośćsztukOD.AutoSize = true;
            this.checkBoxIlośćsztukOD.Location = new System.Drawing.Point(8, 67);
            this.checkBoxIlośćsztukOD.Name = "checkBoxIlośćsztukOD";
            this.checkBoxIlośćsztukOD.Size = new System.Drawing.Size(94, 17);
            this.checkBoxIlośćsztukOD.TabIndex = 40;
            this.checkBoxIlośćsztukOD.Text = "Ilość sztuk od:";
            this.checkBoxIlośćsztukOD.UseVisualStyleBackColor = true;
            // 
            // checkBoxKsiazka
            // 
            this.checkBoxKsiazka.AutoSize = true;
            this.checkBoxKsiazka.Location = new System.Drawing.Point(9, 174);
            this.checkBoxKsiazka.Name = "checkBoxKsiazka";
            this.checkBoxKsiazka.Size = new System.Drawing.Size(63, 17);
            this.checkBoxKsiazka.TabIndex = 38;
            this.checkBoxKsiazka.Text = "Książka";
            this.checkBoxKsiazka.UseVisualStyleBackColor = true;
            // 
            // checkBoxIlośćSztukDO
            // 
            this.checkBoxIlośćSztukDO.AutoSize = true;
            this.checkBoxIlośćSztukDO.Location = new System.Drawing.Point(169, 67);
            this.checkBoxIlośćSztukDO.Name = "checkBoxIlośćSztukDO";
            this.checkBoxIlośćSztukDO.Size = new System.Drawing.Size(94, 17);
            this.checkBoxIlośćSztukDO.TabIndex = 36;
            this.checkBoxIlośćSztukDO.Text = "Ilość sztuk do:";
            this.checkBoxIlośćSztukDO.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutor
            // 
            this.checkBoxAutor.AutoSize = true;
            this.checkBoxAutor.Location = new System.Drawing.Point(164, 115);
            this.checkBoxAutor.Name = "checkBoxAutor";
            this.checkBoxAutor.Size = new System.Drawing.Size(54, 17);
            this.checkBoxAutor.TabIndex = 42;
            this.checkBoxAutor.Text = "Autor:";
            this.checkBoxAutor.UseVisualStyleBackColor = true;
            // 
            // checkBoxRokWydaniaOD
            // 
            this.checkBoxRokWydaniaOD.AutoSize = true;
            this.checkBoxRokWydaniaOD.Location = new System.Drawing.Point(8, 31);
            this.checkBoxRokWydaniaOD.Name = "checkBoxRokWydaniaOD";
            this.checkBoxRokWydaniaOD.Size = new System.Drawing.Size(106, 17);
            this.checkBoxRokWydaniaOD.TabIndex = 39;
            this.checkBoxRokWydaniaOD.Text = "Rok wydania od:";
            this.checkBoxRokWydaniaOD.UseVisualStyleBackColor = true;
            // 
            // checkBoxCzasopismo
            // 
            this.checkBoxCzasopismo.AutoSize = true;
            this.checkBoxCzasopismo.Location = new System.Drawing.Point(167, 174);
            this.checkBoxCzasopismo.Name = "checkBoxCzasopismo";
            this.checkBoxCzasopismo.Size = new System.Drawing.Size(82, 17);
            this.checkBoxCzasopismo.TabIndex = 39;
            this.checkBoxCzasopismo.Text = "Czasopismo";
            this.checkBoxCzasopismo.UseVisualStyleBackColor = true;
            // 
            // checkBoxWydawnictwo
            // 
            this.checkBoxWydawnictwo.AutoSize = true;
            this.checkBoxWydawnictwo.Location = new System.Drawing.Point(9, 115);
            this.checkBoxWydawnictwo.Name = "checkBoxWydawnictwo";
            this.checkBoxWydawnictwo.Size = new System.Drawing.Size(96, 17);
            this.checkBoxWydawnictwo.TabIndex = 41;
            this.checkBoxWydawnictwo.Text = "Wydawnictwo:";
            this.checkBoxWydawnictwo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFiltruj);
            this.groupBox2.Controls.Add(this.checkBoxEmail);
            this.groupBox2.Controls.Add(this.textBoxEmail);
            this.groupBox2.Controls.Add(this.checkBoxImieNazwisko);
            this.groupBox2.Controls.Add(this.textBoxImieNazwisko);
            this.groupBox2.Controls.Add(this.checkBoxLogin);
            this.groupBox2.Controls.Add(this.checkBoxPlec);
            this.groupBox2.Controls.Add(this.checkBoxRola);
            this.groupBox2.Controls.Add(this.textBoxLogin);
            this.groupBox2.Controls.Add(this.comboBoxPlec);
            this.groupBox2.Controls.Add(this.comboBoxRola);
            this.groupBox2.Location = new System.Drawing.Point(835, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 238);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTROWANIE";

            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(21, 141);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(57, 17);
            this.checkBoxEmail.TabIndex = 47;
            this.checkBoxEmail.Text = "E-mail:";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(23, 164);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 39;
            // 
            // checkBoxImieNazwisko
            // 
            this.checkBoxImieNazwisko.AutoSize = true;
            this.checkBoxImieNazwisko.Location = new System.Drawing.Point(21, 86);
            this.checkBoxImieNazwisko.Name = "checkBoxImieNazwisko";
            this.checkBoxImieNazwisko.Size = new System.Drawing.Size(102, 17);
            this.checkBoxImieNazwisko.TabIndex = 44;
            this.checkBoxImieNazwisko.Text = "Imię i Nazwisko:";
            this.checkBoxImieNazwisko.UseVisualStyleBackColor = true;
            // 
            // textBoxImieNazwisko
            // 
            this.textBoxImieNazwisko.Location = new System.Drawing.Point(21, 109);
            this.textBoxImieNazwisko.Name = "textBoxImieNazwisko";
            this.textBoxImieNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxImieNazwisko.TabIndex = 38;
            // 
            // checkBoxLogin
            // 
            this.checkBoxLogin.AutoSize = true;
            this.checkBoxLogin.Location = new System.Drawing.Point(23, 29);
            this.checkBoxLogin.Name = "checkBoxLogin";
            this.checkBoxLogin.Size = new System.Drawing.Size(55, 17);
            this.checkBoxLogin.TabIndex = 45;
            this.checkBoxLogin.Text = "Login:";
            this.checkBoxLogin.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlec
            // 
            this.checkBoxPlec.AutoSize = true;
            this.checkBoxPlec.Location = new System.Drawing.Point(231, 86);
            this.checkBoxPlec.Name = "checkBoxPlec";
            this.checkBoxPlec.Size = new System.Drawing.Size(49, 17);
            this.checkBoxPlec.TabIndex = 46;
            this.checkBoxPlec.Text = "Płeć";
            this.checkBoxPlec.UseVisualStyleBackColor = true;
            // 
            // checkBoxRola
            // 
            this.checkBoxRola.AutoSize = true;
            this.checkBoxRola.Location = new System.Drawing.Point(231, 29);
            this.checkBoxRola.Name = "checkBoxRola";
            this.checkBoxRola.Size = new System.Drawing.Size(51, 17);
            this.checkBoxRola.TabIndex = 43;
            this.checkBoxRola.Text = "Rola:";
            this.checkBoxRola.UseVisualStyleBackColor = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(23, 52);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 40;
            // 
            // comboBoxPlec
            // 
            this.comboBoxPlec.FormattingEnabled = true;
            this.comboBoxPlec.Items.AddRange(new object[] {
            "M",
            "K"});
            this.comboBoxPlec.Location = new System.Drawing.Point(231, 109);
            this.comboBoxPlec.Name = "comboBoxPlec";
            this.comboBoxPlec.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlec.TabIndex = 42;
            // 
            // comboBoxRola
            // 
            this.comboBoxRola.FormattingEnabled = true;
            this.comboBoxRola.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBoxRola.Location = new System.Drawing.Point(231, 52);
            this.comboBoxRola.Name = "comboBoxRola";
            this.comboBoxRola.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRola.TabIndex = 41;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltrujIlośćDO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltrujIlośćOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltrujRok)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFiltruj;
        private System.Windows.Forms.NumericUpDown numericUpDownFiltrujIlośćDO;
        private System.Windows.Forms.TextBox textBoxFiltrujAutor;
        private System.Windows.Forms.NumericUpDown numericUpDownFiltrujIlośćOD;
        private System.Windows.Forms.TextBox textBoxFiltrujWydawnictwo;
        private System.Windows.Forms.NumericUpDown numericUpDownFiltrujRok;
        private System.Windows.Forms.CheckBox checkBoxIlośćsztukOD;
        private System.Windows.Forms.CheckBox checkBoxKsiazka;
        private System.Windows.Forms.CheckBox checkBoxIlośćSztukDO;
        private System.Windows.Forms.CheckBox checkBoxAutor;
        private System.Windows.Forms.CheckBox checkBoxRokWydaniaOD;
        private System.Windows.Forms.CheckBox checkBoxCzasopismo;
        private System.Windows.Forms.CheckBox checkBoxWydawnictwo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxImieNazwisko;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.ComboBox comboBoxRola;
        private System.Windows.Forms.CheckBox checkBoxLogin;
        private System.Windows.Forms.CheckBox checkBoxPlec;
        private System.Windows.Forms.CheckBox checkBoxRola;
        private System.Windows.Forms.ComboBox comboBoxPlec;
        private System.Windows.Forms.CheckBox checkBoxImieNazwisko;
        private System.Windows.Forms.CheckBox checkBoxEmail;
    }
}