namespace AccessControl_VISIR
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDBConnection = new System.Windows.Forms.Label();
            this.txtSqlConParameter = new System.Windows.Forms.TextBox();
            this.btnCheckConnection = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSqlResponse = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnGenerateCode = new System.Windows.Forms.Button();
            this.dtpValid = new System.Windows.Forms.DateTimePicker();
            this.txtAccessCode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFacultyID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdateAccessCode = new System.Windows.Forms.Button();
            this.dtpValidEdit = new System.Windows.Forms.DateTimePicker();
            this.txtAccessCodeEdit = new System.Windows.Forms.TextBox();
            this.txtEmailEdit = new System.Windows.Forms.TextBox();
            this.txtFacultyIDEdit = new System.Windows.Forms.TextBox();
            this.txtLastNameEdit = new System.Windows.Forms.TextBox();
            this.txtFirstNameEdit = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnRefreshGrid = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visir_3dDataSet = new AccessControl_VISIR.visir_3dDataSet();
            this.userTableAdapter = new AccessControl_VISIR.visir_3dDataSetTableAdapters.userTableAdapter();
            this.label25 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visir_3dDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDBConnection
            // 
            this.lblDBConnection.AutoSize = true;
            this.lblDBConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBConnection.Location = new System.Drawing.Point(277, 13);
            this.lblDBConnection.Name = "lblDBConnection";
            this.lblDBConnection.Size = new System.Drawing.Size(268, 25);
            this.lblDBConnection.TabIndex = 2;
            this.lblDBConnection.Text = "Data Source Connection";
            // 
            // txtSqlConParameter
            // 
            this.txtSqlConParameter.Location = new System.Drawing.Point(194, 57);
            this.txtSqlConParameter.Name = "txtSqlConParameter";
            this.txtSqlConParameter.Size = new System.Drawing.Size(363, 20);
            this.txtSqlConParameter.TabIndex = 3;
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.Location = new System.Drawing.Point(603, 56);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(136, 20);
            this.btnCheckConnection.TabIndex = 4;
            this.btnCheckConnection.Text = "Check Connection";
            this.btnCheckConnection.UseVisualStyleBackColor = true;
            this.btnCheckConnection.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1255, 598);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSqlResponse);
            this.tabPage1.Controls.Add(this.lblResponse);
            this.tabPage1.Controls.Add(this.lblConnectionString);
            this.tabPage1.Controls.Add(this.lblDBConnection);
            this.tabPage1.Controls.Add(this.btnCheckConnection);
            this.tabPage1.Controls.Add(this.txtSqlConParameter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1247, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQL Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtSqlResponse
            // 
            this.txtSqlResponse.Location = new System.Drawing.Point(49, 145);
            this.txtSqlResponse.Multiline = true;
            this.txtSqlResponse.Name = "txtSqlResponse";
            this.txtSqlResponse.Size = new System.Drawing.Size(508, 159);
            this.txtSqlResponse.TabIndex = 7;
            this.txtSqlResponse.Text = "Press Check connection to verify if the connection to the database can be establi" +
    "shed";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(46, 129);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(55, 13);
            this.lblResponse.TabIndex = 6;
            this.lblResponse.Text = "Response";
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(46, 60);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(91, 13);
            this.lblConnectionString.TabIndex = 5;
            this.lblConnectionString.Text = "Connection String";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lblID);
            this.tabPage2.Controls.Add(this.btnClearForm);
            this.tabPage2.Controls.Add(this.btnSaveUser);
            this.tabPage2.Controls.Add(this.btnGenerateCode);
            this.tabPage2.Controls.Add(this.dtpValid);
            this.tabPage2.Controls.Add(this.txtAccessCode);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.txtFacultyID);
            this.tabPage2.Controls.Add(this.txtLastName);
            this.tabPage2.Controls.Add(this.txtFirstName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1247, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "E-Mail";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "AccessCode";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "ValidUntil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "FacultyID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "First Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 21;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(161, 236);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(128, 34);
            this.btnClearForm.TabIndex = 20;
            this.btnClearForm.Text = "Clear";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(22, 236);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(119, 34);
            this.btnSaveUser.TabIndex = 19;
            this.btnSaveUser.Text = "Save User";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.Location = new System.Drawing.Point(314, 153);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(128, 21);
            this.btnGenerateCode.TabIndex = 18;
            this.btnGenerateCode.Text = "Generate Access Code";
            this.btnGenerateCode.UseVisualStyleBackColor = true;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // dtpValid
            // 
            this.dtpValid.CustomFormat = " dd.MM.yyyy";
            this.dtpValid.Enabled = false;
            this.dtpValid.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpValid.Location = new System.Drawing.Point(161, 187);
            this.dtpValid.Name = "dtpValid";
            this.dtpValid.Size = new System.Drawing.Size(147, 20);
            this.dtpValid.TabIndex = 17;
            this.dtpValid.ValueChanged += new System.EventHandler(this.dtpValid_ValueChanged);
            // 
            // txtAccessCode
            // 
            this.txtAccessCode.Location = new System.Drawing.Point(161, 153);
            this.txtAccessCode.Name = "txtAccessCode";
            this.txtAccessCode.ReadOnly = true;
            this.txtAccessCode.Size = new System.Drawing.Size(147, 20);
            this.txtAccessCode.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(161, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtFacultyID
            // 
            this.txtFacultyID.Location = new System.Drawing.Point(161, 86);
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.Size = new System.Drawing.Size(147, 20);
            this.txtFacultyID.TabIndex = 14;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(161, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(147, 20);
            this.txtLastName.TabIndex = 13;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(161, 11);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(147, 20);
            this.txtFirstName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtID);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.btnUpdateAccessCode);
            this.tabPage3.Controls.Add(this.dtpValidEdit);
            this.tabPage3.Controls.Add(this.txtAccessCodeEdit);
            this.tabPage3.Controls.Add(this.txtEmailEdit);
            this.tabPage3.Controls.Add(this.txtFacultyIDEdit);
            this.tabPage3.Controls.Add(this.txtLastNameEdit);
            this.tabPage3.Controls.Add(this.txtFirstNameEdit);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.btnRefreshGrid);
            this.tabPage3.Controls.Add(this.datagrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1247, 572);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit User";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "E-Mail";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "AccessCode";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 51;
            this.label15.Text = "ValidUntil";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "FacultyID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Last Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "First Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(162, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 34);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(23, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 34);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update User";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdateAccessCode
            // 
            this.btnUpdateAccessCode.Location = new System.Drawing.Point(315, 187);
            this.btnUpdateAccessCode.Name = "btnUpdateAccessCode";
            this.btnUpdateAccessCode.Size = new System.Drawing.Size(128, 21);
            this.btnUpdateAccessCode.TabIndex = 45;
            this.btnUpdateAccessCode.Text = "Update Access Code";
            this.btnUpdateAccessCode.UseVisualStyleBackColor = true;
            this.btnUpdateAccessCode.Click += new System.EventHandler(this.btnUpdateAccessCode_Click);
            // 
            // dtpValidEdit
            // 
            this.dtpValidEdit.CustomFormat = " dd.MM.yyyy";
            this.dtpValidEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpValidEdit.Location = new System.Drawing.Point(162, 221);
            this.dtpValidEdit.Name = "dtpValidEdit";
            this.dtpValidEdit.Size = new System.Drawing.Size(147, 20);
            this.dtpValidEdit.TabIndex = 44;
            // 
            // txtAccessCodeEdit
            // 
            this.txtAccessCodeEdit.Location = new System.Drawing.Point(162, 187);
            this.txtAccessCodeEdit.Name = "txtAccessCodeEdit";
            this.txtAccessCodeEdit.Size = new System.Drawing.Size(147, 20);
            this.txtAccessCodeEdit.TabIndex = 43;
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Location = new System.Drawing.Point(162, 154);
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.Size = new System.Drawing.Size(147, 20);
            this.txtEmailEdit.TabIndex = 42;
            // 
            // txtFacultyIDEdit
            // 
            this.txtFacultyIDEdit.Location = new System.Drawing.Point(162, 120);
            this.txtFacultyIDEdit.Name = "txtFacultyIDEdit";
            this.txtFacultyIDEdit.Size = new System.Drawing.Size(147, 20);
            this.txtFacultyIDEdit.TabIndex = 41;
            // 
            // txtLastNameEdit
            // 
            this.txtLastNameEdit.Location = new System.Drawing.Point(162, 81);
            this.txtLastNameEdit.Name = "txtLastNameEdit";
            this.txtLastNameEdit.Size = new System.Drawing.Size(147, 20);
            this.txtLastNameEdit.TabIndex = 40;
            // 
            // txtFirstNameEdit
            // 
            this.txtFirstNameEdit.Location = new System.Drawing.Point(162, 45);
            this.txtFirstNameEdit.Name = "txtFirstNameEdit";
            this.txtFirstNameEdit.Size = new System.Drawing.Size(147, 20);
            this.txtFirstNameEdit.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 229);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 38;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 194);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 37;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 161);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 36;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 13);
            this.label22.TabIndex = 35;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 88);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 13);
            this.label23.TabIndex = 34;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 52);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 13);
            this.label24.TabIndex = 33;
            // 
            // btnRefreshGrid
            // 
            this.btnRefreshGrid.Location = new System.Drawing.Point(446, 268);
            this.btnRefreshGrid.Name = "btnRefreshGrid";
            this.btnRefreshGrid.Size = new System.Drawing.Size(128, 34);
            this.btnRefreshGrid.TabIndex = 26;
            this.btnRefreshGrid.Text = "Refresh";
            this.btnRefreshGrid.UseVisualStyleBackColor = true;
            this.btnRefreshGrid.Click += new System.EventHandler(this.btnRefreshGrid_Click_1);
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(446, 6);
            this.datagrid.MultiSelect = false;
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.Size = new System.Drawing.Size(795, 256);
            this.datagrid.TabIndex = 25;
            this.datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellClick_1);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.visir_3dDataSet;
            // 
            // visir_3dDataSet
            // 
            this.visir_3dDataSet.DataSetName = "visir_3dDataSet";
            this.visir_3dDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(27, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(18, 13);
            this.label25.TabIndex = 54;
            this.label25.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(162, 15);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(147, 20);
            this.txtID.TabIndex = 55;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 622);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "VISIR 3D Access Control";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visir_3dDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDBConnection;
        private System.Windows.Forms.TextBox txtSqlConParameter;
        private System.Windows.Forms.Button btnCheckConnection;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtSqlResponse;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label lblConnectionString;
        private visir_3dDataSet visir_3dDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private visir_3dDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnGenerateCode;
        private System.Windows.Forms.DateTimePicker dtpValid;
        private System.Windows.Forms.TextBox txtAccessCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFacultyID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRefreshGrid;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateAccessCode;
        private System.Windows.Forms.DateTimePicker dtpValidEdit;
        private System.Windows.Forms.TextBox txtAccessCodeEdit;
        private System.Windows.Forms.TextBox txtEmailEdit;
        private System.Windows.Forms.TextBox txtFacultyIDEdit;
        private System.Windows.Forms.TextBox txtLastNameEdit;
        private System.Windows.Forms.TextBox txtFirstNameEdit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label25;
    }
}

