namespace HRM.Forms
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            tbPgMain = new MaterialSkin.Controls.MaterialTabControl();
            tbPgHome = new TabPage();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            tbPgDepartment = new TabPage();
            dtgrdDepartments = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentBindingSource = new BindingSource(components);
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tbPgPositions = new TabPage();
            dtgrdPositions = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            departmentIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            positionBindingSource = new BindingSource(components);
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            tbPgEmployees = new TabPage();
            pctBxPhoto = new PictureBox();
            btnSearchPhoto = new MaterialSkin.Controls.MaterialButton();
            dtgrdEmployee = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            photoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            positionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeBindingSource = new BindingSource(components);
            cmBxPosition = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            cmBxGender = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            dtBirthYear = new DateTimePicker();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            txtbxName = new MaterialSkin.Controls.MaterialTextBox();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            txtbxSearch = new MaterialSkin.Controls.MaterialTextBox();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnCreate = new MaterialSkin.Controls.MaterialButton();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            imageList1 = new ImageList(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            employeesBindingSource = new BindingSource(components);
            employeesBindingSource1 = new BindingSource(components);
            tbPgMain.SuspendLayout();
            tbPgHome.SuspendLayout();
            tbPgDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrdDepartments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).BeginInit();
            tbPgPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrdPositions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)positionBindingSource).BeginInit();
            tbPgEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBxPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgrdEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeesBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tbPgMain
            // 
            tbPgMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbPgMain.Controls.Add(tbPgHome);
            tbPgMain.Controls.Add(tbPgDepartment);
            tbPgMain.Controls.Add(tbPgPositions);
            tbPgMain.Controls.Add(tbPgEmployees);
            tbPgMain.Depth = 0;
            tbPgMain.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbPgMain.ImageList = imageList1;
            tbPgMain.Location = new Point(1, 64);
            tbPgMain.Margin = new Padding(7);
            tbPgMain.MouseState = MaterialSkin.MouseState.HOVER;
            tbPgMain.Multiline = true;
            tbPgMain.Name = "tbPgMain";
            tbPgMain.SelectedIndex = 0;
            tbPgMain.Size = new Size(1285, 622);
            tbPgMain.SizeMode = TabSizeMode.FillToRight;
            tbPgMain.TabIndex = 0;
            // 
            // tbPgHome
            // 
            tbPgHome.BackColor = Color.White;
            tbPgHome.Controls.Add(materialLabel9);
            tbPgHome.ImageKey = "home.png";
            tbPgHome.Location = new Point(4, 39);
            tbPgHome.Margin = new Padding(7);
            tbPgHome.Name = "tbPgHome";
            tbPgHome.Padding = new Padding(7);
            tbPgHome.Size = new Size(1277, 579);
            tbPgHome.TabIndex = 0;
            tbPgHome.Text = "Главная страница";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(10, 16);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(312, 19);
            materialLabel9.TabIndex = 0;
            materialLabel9.Text = "Добро пожаловать на главную страницу!";
            // 
            // tbPgDepartment
            // 
            tbPgDepartment.BackColor = Color.White;
            tbPgDepartment.Controls.Add(dtgrdDepartments);
            tbPgDepartment.Controls.Add(materialLabel1);
            tbPgDepartment.ImageKey = "apps.png";
            tbPgDepartment.Location = new Point(4, 39);
            tbPgDepartment.Margin = new Padding(7);
            tbPgDepartment.Name = "tbPgDepartment";
            tbPgDepartment.Padding = new Padding(7);
            tbPgDepartment.Size = new Size(1277, 579);
            tbPgDepartment.TabIndex = 1;
            tbPgDepartment.Text = "Отделы";
            // 
            // dtgrdDepartments
            // 
            dtgrdDepartments.AllowUserToDeleteRows = false;
            dtgrdDepartments.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgrdDepartments.AutoGenerateColumns = false;
            dtgrdDepartments.BackgroundColor = SystemColors.Window;
            dtgrdDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrdDepartments.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dtgrdDepartments.DataSource = departmentBindingSource;
            dtgrdDepartments.Location = new Point(348, 93);
            dtgrdDepartments.Margin = new Padding(4);
            dtgrdDepartments.Name = "dtgrdDepartments";
            dtgrdDepartments.RowHeadersWidth = 51;
            dtgrdDepartments.Size = new Size(533, 397);
            dtgrdDepartments.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Название";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentBindingSource
            // 
            departmentBindingSource.DataSource = typeof(Entities.Department);
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(541, 28);
            materialLabel1.Margin = new Padding(7, 0, 7, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(121, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Список отделов";
            // 
            // tbPgPositions
            // 
            tbPgPositions.BackColor = Color.White;
            tbPgPositions.Controls.Add(dtgrdPositions);
            tbPgPositions.Controls.Add(materialLabel2);
            tbPgPositions.ImageKey = "case.png";
            tbPgPositions.Location = new Point(4, 39);
            tbPgPositions.Margin = new Padding(7);
            tbPgPositions.Name = "tbPgPositions";
            tbPgPositions.Size = new Size(1277, 579);
            tbPgPositions.TabIndex = 2;
            tbPgPositions.Text = "Должности";
            // 
            // dtgrdPositions
            // 
            dtgrdPositions.AutoGenerateColumns = false;
            dtgrdPositions.BackgroundColor = SystemColors.ControlLightLight;
            dtgrdPositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrdPositions.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, departmentIdDataGridViewTextBoxColumn });
            dtgrdPositions.DataSource = positionBindingSource;
            dtgrdPositions.Location = new Point(114, 123);
            dtgrdPositions.Margin = new Padding(4);
            dtgrdPositions.Name = "dtgrdPositions";
            dtgrdPositions.RowHeadersWidth = 51;
            dtgrdPositions.Size = new Size(946, 298);
            dtgrdPositions.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Название";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            departmentIdDataGridViewTextBoxColumn.HeaderText = "Id Отдела";
            departmentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            departmentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionBindingSource
            // 
            positionBindingSource.DataSource = typeof(Entities.Position);
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(499, 57);
            materialLabel2.Margin = new Padding(7, 0, 7, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(150, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Список должностей";
            // 
            // tbPgEmployees
            // 
            tbPgEmployees.BackColor = Color.White;
            tbPgEmployees.Controls.Add(pctBxPhoto);
            tbPgEmployees.Controls.Add(btnSearchPhoto);
            tbPgEmployees.Controls.Add(dtgrdEmployee);
            tbPgEmployees.Controls.Add(cmBxPosition);
            tbPgEmployees.Controls.Add(materialLabel8);
            tbPgEmployees.Controls.Add(materialLabel7);
            tbPgEmployees.Controls.Add(cmBxGender);
            tbPgEmployees.Controls.Add(materialLabel6);
            tbPgEmployees.Controls.Add(dtBirthYear);
            tbPgEmployees.Controls.Add(materialLabel5);
            tbPgEmployees.Controls.Add(materialLabel4);
            tbPgEmployees.Controls.Add(txtbxName);
            tbPgEmployees.Controls.Add(btnSearch);
            tbPgEmployees.Controls.Add(txtbxSearch);
            tbPgEmployees.Controls.Add(btnDelete);
            tbPgEmployees.Controls.Add(btnUpdate);
            tbPgEmployees.Controls.Add(btnCreate);
            tbPgEmployees.Controls.Add(materialLabel3);
            tbPgEmployees.ImageKey = "user.png";
            tbPgEmployees.Location = new Point(4, 39);
            tbPgEmployees.Margin = new Padding(7);
            tbPgEmployees.Name = "tbPgEmployees";
            tbPgEmployees.Size = new Size(1277, 579);
            tbPgEmployees.TabIndex = 3;
            tbPgEmployees.Text = "Сотрудники";
            // 
            // pctBxPhoto
            // 
            pctBxPhoto.Location = new Point(175, 310);
            pctBxPhoto.Name = "pctBxPhoto";
            pctBxPhoto.Size = new Size(115, 114);
            pctBxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBxPhoto.TabIndex = 20;
            pctBxPhoto.TabStop = false;
            // 
            // btnSearchPhoto
            // 
            btnSearchPhoto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearchPhoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearchPhoto.Depth = 0;
            btnSearchPhoto.HighEmphasis = true;
            btnSearchPhoto.Icon = null;
            btnSearchPhoto.Location = new Point(336, 350);
            btnSearchPhoto.Margin = new Padding(5, 8, 5, 8);
            btnSearchPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearchPhoto.Name = "btnSearchPhoto";
            btnSearchPhoto.NoAccentTextColor = Color.Empty;
            btnSearchPhoto.Size = new Size(79, 36);
            btnSearchPhoto.TabIndex = 19;
            btnSearchPhoto.Text = "Искать";
            btnSearchPhoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearchPhoto.UseAccentColor = false;
            btnSearchPhoto.UseVisualStyleBackColor = true;
            btnSearchPhoto.Click += btnSearchPhoto_Click;
            // 
            // dtgrdEmployee
            // 
            dtgrdEmployee.AllowUserToOrderColumns = true;
            dtgrdEmployee.AutoGenerateColumns = false;
            dtgrdEmployee.BackgroundColor = SystemColors.HighlightText;
            dtgrdEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrdEmployee.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, fullNameDataGridViewTextBoxColumn, birthYearDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, photoDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, positionIdDataGridViewTextBoxColumn });
            dtgrdEmployee.DataSource = employeeBindingSource;
            dtgrdEmployee.Location = new Point(480, 132);
            dtgrdEmployee.Margin = new Padding(4);
            dtgrdEmployee.Name = "dtgrdEmployee";
            dtgrdEmployee.RowHeadersWidth = 51;
            dtgrdEmployee.Size = new Size(677, 422);
            dtgrdEmployee.TabIndex = 18;
            dtgrdEmployee.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthYearDataGridViewTextBoxColumn
            // 
            birthYearDataGridViewTextBoxColumn.DataPropertyName = "BirthYear";
            birthYearDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            birthYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            birthYearDataGridViewTextBoxColumn.Name = "birthYearDataGridViewTextBoxColumn";
            birthYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            photoDataGridViewTextBoxColumn.HeaderText = "Фото";
            photoDataGridViewTextBoxColumn.MinimumWidth = 6;
            photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            photoDataGridViewTextBoxColumn.Width = 125;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            isDeletedDataGridViewCheckBoxColumn.HeaderText = "Уволен(-а)";
            isDeletedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            isDeletedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "Дата приема";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "Дата увольнения";
            endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionIdDataGridViewTextBoxColumn
            // 
            positionIdDataGridViewTextBoxColumn.DataPropertyName = "PositionId";
            positionIdDataGridViewTextBoxColumn.HeaderText = "Id должности";
            positionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            positionIdDataGridViewTextBoxColumn.Name = "positionIdDataGridViewTextBoxColumn";
            positionIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Entities.Employee);
            // 
            // cmBxPosition
            // 
            cmBxPosition.AutoResize = false;
            cmBxPosition.BackColor = Color.FromArgb(255, 255, 255);
            cmBxPosition.DataSource = positionBindingSource;
            cmBxPosition.Depth = 0;
            cmBxPosition.DrawMode = DrawMode.OwnerDrawVariable;
            cmBxPosition.DropDownHeight = 174;
            cmBxPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmBxPosition.DropDownWidth = 121;
            cmBxPosition.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmBxPosition.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmBxPosition.FormattingEnabled = true;
            cmBxPosition.IntegralHeight = false;
            cmBxPosition.ItemHeight = 43;
            cmBxPosition.Location = new Point(175, 431);
            cmBxPosition.Margin = new Padding(4);
            cmBxPosition.MaxDropDownItems = 4;
            cmBxPosition.MouseState = MaterialSkin.MouseState.OUT;
            cmBxPosition.Name = "cmBxPosition";
            cmBxPosition.Size = new Size(267, 49);
            cmBxPosition.StartIndex = 0;
            cmBxPosition.TabIndex = 17;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(32, 431);
            materialLabel8.Margin = new Padding(7, 0, 7, 0);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(86, 19);
            materialLabel8.TabIndex = 16;
            materialLabel8.Text = "Должность";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(32, 350);
            materialLabel7.Margin = new Padding(7, 0, 7, 0);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(39, 19);
            materialLabel7.TabIndex = 15;
            materialLabel7.Text = "Фото";
            // 
            // cmBxGender
            // 
            cmBxGender.AutoResize = false;
            cmBxGender.BackColor = Color.FromArgb(255, 255, 255);
            cmBxGender.Depth = 0;
            cmBxGender.DrawMode = DrawMode.OwnerDrawVariable;
            cmBxGender.DropDownHeight = 174;
            cmBxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmBxGender.DropDownWidth = 121;
            cmBxGender.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmBxGender.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmBxGender.FormattingEnabled = true;
            cmBxGender.IntegralHeight = false;
            cmBxGender.ItemHeight = 43;
            cmBxGender.Location = new Point(175, 254);
            cmBxGender.Margin = new Padding(4);
            cmBxGender.MaxDropDownItems = 4;
            cmBxGender.MouseState = MaterialSkin.MouseState.OUT;
            cmBxGender.Name = "cmBxGender";
            cmBxGender.Size = new Size(267, 49);
            cmBxGender.StartIndex = 0;
            cmBxGender.TabIndex = 14;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(32, 274);
            materialLabel6.Margin = new Padding(7, 0, 7, 0);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(30, 19);
            materialLabel6.TabIndex = 13;
            materialLabel6.Text = "Пол";
            // 
            // dtBirthYear
            // 
            dtBirthYear.Location = new Point(175, 184);
            dtBirthYear.Margin = new Padding(4);
            dtBirthYear.Name = "dtBirthYear";
            dtBirthYear.Size = new Size(267, 31);
            dtBirthYear.TabIndex = 12;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(32, 196);
            materialLabel5.Margin = new Padding(7, 0, 7, 0);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(119, 19);
            materialLabel5.TabIndex = 11;
            materialLabel5.Text = "Дата Рождения";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(32, 86);
            materialLabel4.Margin = new Padding(7, 0, 7, 0);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(35, 19);
            materialLabel4.TabIndex = 10;
            materialLabel4.Text = "ФИО";
            // 
            // txtbxName
            // 
            txtbxName.AnimateReadOnly = false;
            txtbxName.BorderStyle = BorderStyle.None;
            txtbxName.Depth = 0;
            txtbxName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbxName.LeadingIcon = null;
            txtbxName.Location = new Point(175, 74);
            txtbxName.Margin = new Padding(4);
            txtbxName.MaxLength = 50;
            txtbxName.MouseState = MaterialSkin.MouseState.OUT;
            txtbxName.Multiline = false;
            txtbxName.Name = "txtbxName";
            txtbxName.Size = new Size(267, 50);
            txtbxName.TabIndex = 9;
            txtbxName.Text = "";
            txtbxName.TrailingIcon = null;
            // 
            // btnSearch
            // 
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearch.Depth = 0;
            btnSearch.HighEmphasis = true;
            btnSearch.Icon = null;
            btnSearch.Location = new Point(1085, 86);
            btnSearch.Margin = new Padding(5, 8, 5, 8);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(72, 36);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Поиск";
            btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearch.UseAccentColor = false;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtbxSearch
            // 
            txtbxSearch.AnimateReadOnly = false;
            txtbxSearch.BorderStyle = BorderStyle.None;
            txtbxSearch.Depth = 0;
            txtbxSearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbxSearch.LeadingIcon = null;
            txtbxSearch.Location = new Point(715, 74);
            txtbxSearch.Margin = new Padding(4);
            txtbxSearch.MaxLength = 50;
            txtbxSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtbxSearch.Multiline = false;
            txtbxSearch.Name = "txtbxSearch";
            txtbxSearch.Size = new Size(361, 50);
            txtbxSearch.TabIndex = 7;
            txtbxSearch.Text = "";
            txtbxSearch.TrailingIcon = null;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(351, 518);
            btnDelete.Margin = new Padding(5, 8, 5, 8);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(91, 36);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Удалить";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(175, 518);
            btnUpdate.Margin = new Padding(5, 8, 5, 8);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(101, 36);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Изменить";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCreate.Depth = 0;
            btnCreate.HighEmphasis = true;
            btnCreate.Icon = null;
            btnCreate.Location = new Point(32, 518);
            btnCreate.Margin = new Padding(5, 8, 5, 8);
            btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreate.Name = "btnCreate";
            btnCreate.NoAccentTextColor = Color.Empty;
            btnCreate.Size = new Size(89, 36);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Создать";
            btnCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCreate.UseAccentColor = false;
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(520, 28);
            materialLabel3.Margin = new Padding(7, 0, 7, 0);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(156, 19);
            materialLabel3.TabIndex = 3;
            materialLabel3.Text = "Список сотрудников";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "apps.png");
            imageList1.Images.SetKeyName(1, "case.png");
            imageList1.Images.SetKeyName(2, "user.png");
            imageList1.Images.SetKeyName(3, "home.png");
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // employeesBindingSource
            // 
            employeesBindingSource.DataMember = "Employees";
            employeesBindingSource.DataSource = positionBindingSource;
            // 
            // employeesBindingSource1
            // 
            employeesBindingSource1.DataMember = "Employees";
            employeesBindingSource1.DataSource = positionBindingSource;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1300, 700);
            Controls.Add(tbPgMain);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tbPgMain;
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(7);
            Name = "MainMenu";
            Padding = new Padding(7, 131, 7, 7);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HRM SYSTEM";
            tbPgMain.ResumeLayout(false);
            tbPgHome.ResumeLayout(false);
            tbPgHome.PerformLayout();
            tbPgDepartment.ResumeLayout(false);
            tbPgDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrdDepartments).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).EndInit();
            tbPgPositions.ResumeLayout(false);
            tbPgPositions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrdPositions).EndInit();
            ((System.ComponentModel.ISupportInitialize)positionBindingSource).EndInit();
            tbPgEmployees.ResumeLayout(false);
            tbPgEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctBxPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgrdEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeesBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbPgMain;
        private TabPage tbPgHome;
        private TabPage tbPgDepartment;
        private ImageList imageList1;
        private TabPage tbPgPositions;
        private TabPage tbPgEmployees;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnCreate;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialTextBox txtbxSearch;
        private MaterialSkin.Controls.MaterialTextBox txtbxName;
        private MaterialSkin.Controls.MaterialComboBox cmBxPosition;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox cmBxGender;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private DateTimePicker dtBirthYear;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private BindingSource departmentBindingSource;
        private DataGridView dtgrdDepartments;
        private DataGridView dtgrdPositions;
        private BindingSource positionBindingSource;
        private DataGridView dtgrdEmployee;
        private BindingSource employeeBindingSource;
        private BindingSource employeesBindingSource;
        private BindingSource employeesBindingSource1;
        private MaterialSkin.Controls.MaterialButton btnSearchPhoto;
        private PictureBox pctBxPhoto;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionIdDataGridViewTextBoxColumn;
    }
}