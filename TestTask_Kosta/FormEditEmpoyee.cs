using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using TestTask_Kosta.Database;

namespace TestTask_Kosta
{
    public partial class FormEditEmpoyee : Form
    {
        private DataRow _rowEmpoyee;
        private List<Department> _listDepartments = new List<Department>();

        private string _textBtnUpdateEmployeeData = "Изменить данные";
        private string _textBtnAddEmployee = "Добавить сотрудника";

        private enum TypeFild { OnlyLatter, LatterDash, LatterDashSpace, Numbers, LatterDashSpaceNumbers }

        /// <summary>
        /// Форма для вставки новых данных в базу данных.
        /// </summary>
        public FormEditEmpoyee()
        {
            InitializeComponent();
            this.Text = "Добавление нового сотрудника";
            cbx_CloseForm.Visible = true;
            btn_UpdateDataEmpoyee.Text = _textBtnAddEmployee;
            btn_UpdateDataEmpoyee.Click += AddNewEmployeeInDataBase;
            LoadListDepartment();

        }

        /// <summary>
        /// Форма для изменения данных сорудника
        /// </summary>
        /// <param name="rowEmpoyee"></param>
        public FormEditEmpoyee(DataRow rowEmpoyee)
        {
            InitializeComponent();
            this.Text = "Редактирование данных сотрудника";
            _rowEmpoyee = rowEmpoyee;
            btn_UpdateDataEmpoyee.Text = _textBtnUpdateEmployeeData;
            btn_UpdateDataEmpoyee.Click += UpdateDataEmpoyee_Click;

            //при редактировании данных нужно перезапускать форму т.к. при загрузке передаются
            //оригинал изменяемых данных, которые в дальнейшем использутся для обновления
            cbx_CloseForm.Visible = false; 
            LoadDataEmployee(_rowEmpoyee);
        }


        /// <summary>
        /// Загрузить данные в компоненты формы
        /// </summary>
        /// <param name="rowEmpoyee"></param>
        private void LoadDataEmployee(DataRow rowEmpoyee)
        {
            tbx_NameEmpoyee.Text = rowEmpoyee["FirstName"].ToString();
            tbx_SurNameEmpoyee.Text = rowEmpoyee["SurName"].ToString();
            tbx_PatronymicEmpoyee.Text = rowEmpoyee["Patronymic"].ToString();
            tbx_DateOfBirthEmpoyee.Value = (DateTime)rowEmpoyee["DateOfBirth"];
            tbx_DocSeriesEmpoyee.Text = rowEmpoyee["DocSeries"].ToString();
            tbx_DocNumberEmployee.Text = rowEmpoyee["DocNumber"].ToString();
            tbx_PositionEmpoyee.Text = rowEmpoyee["Position"].ToString();

            LoadListDepartment();
            DataRow dataRowDepartment = DatabaseQueryes.DataBase_Kosta.Department
                .Select($"ID='{rowEmpoyee["DepartmentID"]}'").FirstOrDefault();

            cbox_CodeDepartmentEmpoyee.Text = dataRowDepartment["Code"].ToString();
        }

        /// <summary>
        /// Обновить список отделов 
        /// </summary>
        private void LoadListDepartment()
        {
            //!!! Не известно может ли два разных отдела иметь одинаковое значение поля Code. 
            //В базе данных ограничение не стоит. Данное решение выполнено основываясь на том, что может.
            //Для использования условия "не может" в аргументах необходимо изменить false на true.
            DataTable tableListDeportmant = DatabaseQueryes.DataBase_Kosta.Tables[Database_DataName.NAME_TABLE_DEPARTMENT]
               .DefaultView.ToTable(false, new string[] { "Code", "ID", "Name" });

            for (int i = 0; i < tableListDeportmant.Rows.Count; i++)
            {
                _listDepartments.Add(
                    new Department
                    {
                        ID = tableListDeportmant.Rows[i]["ID"].ToString(),
                        Name = tableListDeportmant.Rows[i]["Name"].ToString(),
                        Code = tableListDeportmant.Rows[i]["Code"].ToString(),
                    });
            }
            cbox_CodeDepartmentEmpoyee.DataSource = _listDepartments;
            cbox_CodeDepartmentEmpoyee.DisplayMember = "Code";
            cbox_CodeDepartmentEmpoyee.ValueMember = "ID";
        }

        private void cbox_CodeDepartmentEmpoyee_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_NameDeportmantValue.Text = ((Department)cbox_CodeDepartmentEmpoyee.SelectedItem).Name;
        }

        private void btn_Cansel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        private void CloseForm()
        {
            if (cbx_CloseForm.Checked)
            this.Close();
        }

        private void UpdateDataEmpoyee_Click(object sender, EventArgs e)
        {
            if (!CheckAllFieldsOnCorrectDate())
                return;

            DialogResult dr = MessageBox.Show(
                "Данный будут обновлены в базе данных!\nПродолжить?",
                "Изменение в базе данных",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Cancel)
                return;

            DatabaseQueryes.UpdateDateEmployeeInDateBase(
                 _rowEmpoyee,
                 tbx_NameEmpoyee.Text,
                 tbx_SurNameEmpoyee.Text,
                 tbx_PatronymicEmpoyee.Text,
                 tbx_DateOfBirthEmpoyee.Value,
                tbx_DocSeriesEmpoyee.Text,
                 tbx_DocNumberEmployee.Text,
                 tbx_PositionEmpoyee.Text,
                 ((Department)cbox_CodeDepartmentEmpoyee.SelectedItem).ID
                );

            CloseForm();
        }

        /// <summary>
        /// Добавление данных в базу данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewEmployeeInDataBase(object sender, EventArgs e)
        {
            if (!CheckAllFieldsOnCorrectDate())
                return;

            DialogResult dr = MessageBox.Show(
                "Данный будут добавлены в базе данных!\nПродолжить?",
                "Добавление данных",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Cancel)
                return;

            DatabaseQueryes.AddEmployeeInDatebase(
                 tbx_NameEmpoyee.Text,
                 tbx_SurNameEmpoyee.Text,
                 tbx_PatronymicEmpoyee.Text,
                 tbx_DateOfBirthEmpoyee.Value,
                 tbx_DocSeriesEmpoyee.Text,
                 tbx_DocNumberEmployee.Text,
                 tbx_PositionEmpoyee.Text,
                 ((Department)cbox_CodeDepartmentEmpoyee.SelectedItem).ID
                );
            CloseForm();
        }

        private bool CheckAllFieldsOnCorrectDate()
        {

            if (tbx_NameEmpoyee.Text == "")
            {
                UIIneractions.ShowMessage("Поле \"Имя\" не может быть пустым",
                    "Не корректные данные", UIIneractions.TypeMessage.Error);
                return false;
            }

            if (tbx_SurNameEmpoyee.Text == "")
            {
                UIIneractions.ShowMessage("Поле \"Фамилия\" не может быть пустым",
                    "Не корректные данные", UIIneractions.TypeMessage.Error);
                return false;
            }

            if (tbx_DocSeriesEmpoyee.Text != "")
            {
                if (tbx_DocSeriesEmpoyee.Text.Length != 4)
                {
                    UIIneractions.ShowMessage("Поле \"Серия\" должно содержать 4 цифры или быть пустым",
                        "Не корректные данные", UIIneractions.TypeMessage.Error);
                    return false;
                }
            }

            if (tbx_DocNumberEmployee.Text != "")
            {
                if (tbx_DocNumberEmployee.Text.Length != 6)
                {
                    UIIneractions.ShowMessage("Поле \"Серия\" должно содержать 6 цифры или быть пустым",
                        "Не корректные данные", UIIneractions.TypeMessage.Error);
                    return false;
                }
            }

            return true;
        }

        private void tbx_NameEmpoyee_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            textBox.Text = CheckText(text, TypeFild.LatterDash);
        }

        /// <summary>
        /// Проверка текста на наличие только букв и дифиса
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string CheckText (string text, TypeFild typeFild)
        {
            Regex regex;
            switch (typeFild)
            {
                case TypeFild.LatterDash:
                    {
                        regex = new Regex(@"^[a-zA-Zа-яА-Я-]*$"); 
                        break;
                    }
                case TypeFild.LatterDashSpace:
                    {
                        regex = new Regex(@"^[a-zA-Zа-яА-Я- ]*$"); 
                        break;
                    }
                case TypeFild.OnlyLatter:
                    {
                        regex = new Regex(@"^[a-zA-Zа-яА-Я]*$"); 
                        break;
                    }
                case TypeFild.Numbers:
                    {
                        regex = new Regex(@"^[0-9]*$");
                        break;
                    }
                case TypeFild.LatterDashSpaceNumbers:
                    {
                        regex = new Regex(@"^[a-zA-Zа-яА-Я0-9- ]*$");
                        break;
                    }
                default:
                    {
                        regex = new Regex("*");
                        break;
                    }
            }

            string tmp_string = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (regex.IsMatch(text[i].ToString()))
                {
                    tmp_string += text[i];
                }
            }
            return tmp_string;
        }


        private void tbx_SurNameEmpoyee_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            textBox.Text = CheckText(text, TypeFild.LatterDash);
        }

        private void tbx_PatronymicEmpoyee_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            textBox.Text = CheckText(text, TypeFild.LatterDash);

        }

        private void tbx_DocSeriesEmpoyee_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            textBox.Text = CheckText(text, TypeFild.Numbers);
        }

        private void tbx_DocNumberEmployee_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            textBox.Text = CheckText(text, TypeFild.Numbers);
        }

        private void tbx_PositionEmpoyee_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            textBox.Text = CheckText(text, TypeFild.LatterDashSpaceNumbers);
        }

    }

    public class Department
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
