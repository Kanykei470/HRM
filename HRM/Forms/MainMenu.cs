using HRM.Enums;
using HRM.Context;
using HRM.Entities;
using HRM.Connection;
using MaterialSkin.Controls;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;


namespace HRM.Forms
{
    public partial class MainMenu : MaterialForm
    {
        public readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public string filePath;//путь к файлу
        public Employee Employee;

        public MainMenu()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;//Настройка главной формы
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.LightGreen600,
                MaterialSkin.Primary.LightGreen800,
                MaterialSkin.Primary.LightGreen300,
                MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE
            );


            InitializeControls();
            LoadData();
        }

        private void InitializeControls()//Инициализация 
        {
            cmBxGender.DataSource = Enum.GetValues(typeof(Gender));

            dtgrdEmployee.SelectionChanged += new EventHandler(dataGridView2_SelectionChanged);
        }

        private void LoadData()//Заполнение GridView и ComboBox
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(ConnectionManager.ConnectionString);

            using (var dbContext = new ApplicationDbContext(optionsBuilder.Options))
            {
                dtgrdDepartments.DataSource = dbContext.Departments.ToList();
                cmBxPosition.DataSource = dbContext.Positions.ToList();
                cmBxPosition.DisplayMember = "Name";
                cmBxPosition.ValueMember = "Id";
                dtgrdPositions.DataSource = dbContext.Positions.ToList();
                dtgrdEmployee.DataSource = dbContext.Employees.ToList();
            }
        }

        private DbContextOptions<ApplicationDbContext> GetDbOptions()//Подключение
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(ConnectionManager.ConnectionString);
            return optionsBuilder.Options;
        }

        private void RefreshEmployeesDataGrid()//Обновление DataGrid
        {
            using (var dbContext = new ApplicationDbContext(GetDbOptions()))
            {
                dtgrdEmployee.DataSource = dbContext.Employees.ToList();
            }
        }

        private void ClearFormFields()//Очищение форм
        {
            txtbxName.Clear();
            dtBirthYear.Value = DateTime.Now;
            cmBxGender.SelectedIndex = -1;
            cmBxPosition.SelectedIndex = -1;
            pctBxPhoto.Image = null;
            filePath = string.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)//Создание сотрудника
        {
            if (!ValidateEmployeeFields())
            {
                return;
            }
            try
            {
                    var newEmployee = new Employee
                    {
                    FullName = txtbxName.Text,
                    BirthYear = dtBirthYear.Value,
                    Gender = (Gender)cmBxGender.SelectedItem,
                    Photo = filePath,
                    PositionId = ((Position)cmBxPosition.SelectedItem).Id,
                    StartDate = DateTime.Now
                    };

                using (var dbContext = new ApplicationDbContext(GetDbOptions()))
                {
                    dbContext.Employees.Add(newEmployee);
                    dbContext.SaveChanges();
                    RefreshEmployeesDataGrid();
                    MessageBox.Show("Сотрудник успешно создан.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            ClearFormFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)//Поиск сотрудника
        {
            try
            {
                using (var dbContext = new ApplicationDbContext(GetDbOptions()))
                {
                    string searchName = txtbxSearch.Text.Trim();
                    var filteredEmployees = dbContext.Employees
                                                     .Where(emp => emp.FullName.Contains(searchName))
                                                     .ToList();
                    dtgrdEmployee.DataSource = filteredEmployees;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)//Обновление сотрудника
        {
            try
            {
                if (dtgrdEmployee.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Пожалуйста, выберите строку для обновления.");
                    return;
                }

                if (!ValidateEmployeeFields())
                {
                    return;
                }

                var selectedEmployee = dtgrdEmployee.SelectedRows[0].DataBoundItem as Employee;

                if (selectedEmployee != null)
                {
                    using (var dbContext = new ApplicationDbContext(GetDbOptions()))
                    {
                        var existingEmployee = dbContext.Employees.FirstOrDefault(e => e.Id == selectedEmployee.Id);

                        if (existingEmployee != null)
                        {
                            existingEmployee.FullName = txtbxName.Text;
                            existingEmployee.BirthYear = dtBirthYear.Value;
                            existingEmployee.Gender = (Gender)cmBxGender.SelectedItem;
                            existingEmployee.Photo = filePath;
                            existingEmployee.PositionId = ((Position)cmBxPosition.SelectedItem).Id;

                            dbContext.SaveChanges();
                            RefreshEmployeesDataGrid();
                            ClearFormFields();
                            MessageBox.Show("Сотрудник успешно обновлен.");
                        }
                        else
                        {
                            MessageBox.Show("Сотрудник не найден.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выбранная строка не содержит действительного сотрудника.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)//Удаление сотрудника
        {

            if (dtgrdEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.");
                return;
            }
            

            var result = MessageBox.Show("Удалить запись -Да, Изменить статус - Нет.",
                            "Удаление",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);//Выбор, удаление строчки полностью, или проставление статуса "Уволен".


            try
            {
                var selectedEmployee = dtgrdEmployee.SelectedRows[0].DataBoundItem as Employee;

                if (selectedEmployee != null)
                {
                    using (var dbContext = new ApplicationDbContext(GetDbOptions()))
                    {
                        var existingEmployee = dbContext.Employees.FirstOrDefault(e => e.Id == selectedEmployee.Id);

                        if (existingEmployee != null)
                        {

                            if (result == DialogResult.Yes)
                            {
                                dbContext.Employees.Remove(existingEmployee);
                                MessageBox.Show("Сотрудник успешно удален.");
                            }
                            else
                            {
                                if (existingEmployee.IsDeleted != true)
                                {
                                    existingEmployee.EndDate = DateTime.Now;
                                    existingEmployee.IsDeleted = true;
                                    MessageBox.Show("Статус сотрудника изменен.");
                                }
                                else
                                {
                                    MessageBox.Show("Статус уже был изменен.");
                                    return ;
                                }
                            
                            }
                                dbContext.SaveChanges();
                                RefreshEmployeesDataGrid();
                               
                            
                        }
                        else
                        {
                            MessageBox.Show("Сотрудник не найден.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnSearchPhoto_Click(object sender, EventArgs e)//Выбор файла
        {
            try
            {
                using (OpenFileDialog fileDialog = new OpenFileDialog() { Filter = "Файлы изображений (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp" })
                {
                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = fileDialog.FileName;
                        pctBxPhoto.Image = Image.FromFile(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgrdEmployee.SelectedRows.Count > 0)
            {
                var selectedEmployee = dtgrdEmployee.SelectedRows[0].DataBoundItem as Employee;

                if (selectedEmployee != null)
                {
                    txtbxName.Text = selectedEmployee.FullName;
                    dtBirthYear.Value = selectedEmployee.BirthYear;
                    cmBxGender.SelectedItem = selectedEmployee.Gender;
                    cmBxPosition.SelectedValue = selectedEmployee.PositionId;
                    if (!string.IsNullOrEmpty(selectedEmployee.Photo))
                    {
                        pctBxPhoto.Image = Image.FromFile(selectedEmployee.Photo);
                        filePath = selectedEmployee.Photo;
                    }
                    else
                    {
                        pctBxPhoto.Image = null;
                    }
                }
            }
        }

        private bool ValidateEmployeeFields()//Валидация
        {
            // Проверка на заполненность имени
            if (string.IsNullOrWhiteSpace(txtbxName.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя сотрудника.");
                return false;
            }

            // Проверка на корректность года рождения
            if (dtBirthYear.Value > DateTime.Now)
            {
                MessageBox.Show("Дата рождения не может быть в будущем.");
                return false;
            }

            // Проверка на выбор пола
            if (cmBxGender.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите пол сотрудника.");
                return false;
            }

            // Проверка на выбор должности
            if (cmBxPosition.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите должность.");
                return false;
            }

            // Проверка на наличие фото
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Пожалуйста, выберите фото сотрудника.");
                return false;
            }

            return true;
        }

    }
}
