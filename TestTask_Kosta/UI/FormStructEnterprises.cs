using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestTask_Kosta.Database;

namespace TestTask_Kosta
{
    public partial class FormStructEnterprises : Form
    {
        private string _textBtnShowDataEmployee_Standart = "Показать подробные данные\nо выбранном сотруднике >>";
        private string _textBtnShowDataEmployee_Extend = "<< Скрыть подробные данные";
        private bool _statusShowFormStandart = true;

        private Size _sizeFormStandart = new Size(784, 560);
        private Size _sizeFormExpand = new Size(1157, 560);


        public FormStructEnterprises()
        {
            InitializeComponent();
            UIIneractions.StatusShowMessage = cbx_ShowMessage.Checked;
        }

        private void FormStructEnterprises_Load(object sender, EventArgs e)
        {
            DatabaseQueryes.DataBase_Kosta = dB_Kosta;
            LoadTreeStructEnterprises();
        }

        /// <summary>
        /// Загрузить данные в поле "Структура предприятия".
        /// </summary>
        private void LoadTreeStructEnterprises ()
        {
            DataTable tableDepartment = DatabaseQueryes.DataBase_Kosta.Tables[Database_DataName.NAME_TABLE_DEPARTMENT];

            //т.к. проверка на null осуществляется с помощью фразы "is null" не удалось полностью 
            // объеденить дублирующую логику добавления узла в список.
            DataRow[] dataRowsDepartment = tableDepartment.Select("ParentDepartmentID is null");


            //!!! Для оптимизации кода можно попытаться удалять добавленные узлы из списка строк (dataRowsDepartment),
            // но для этого необходимо обойти исключение изменения коллекции во время перебора.
            foreach (var row in dataRowsDepartment)
            {
                treeStructEnterprises.Nodes.Add(LoadTreeNode(row, ref tableDepartment));
            }
        }

        /// <summary>
        /// Поиск и добавление подотделов предприятия в родительский узел.
        /// </summary>
        /// <param name="rowNode">Строка из таблицы с данными отдела</param>
        /// <param name="tableDepartment">Таблица в которой осуществляется поиск</param>
        /// <returns></returns>
        private TreeNode LoadTreeNode(DataRow rowNode, ref DataTable tableDepartment)
        {
            TreeNode node = new TreeNode();
            node.Text = $"{rowNode["Name"]} [{rowNode["Code"]}]";
            node.Name = rowNode["ID"].ToString();

            DataRow[] dataRowsDepartment = tableDepartment.Select($"ParentDepartmentID = '{ node.Name}'");
            foreach (var row in dataRowsDepartment)
            {
                node.Nodes.Add(LoadTreeNode(row, ref tableDepartment));
            }
            return node;
        }

        /// <summary>
        /// Обработка выбора узла в списке отделов фирмы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeStructEnterprises_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateListWorkers();
        }

        /// <summary>
        /// Обновление списка сотрудников отдела
        /// </summary>
        private void UpdateListWorkers()
        {
            dataGrid_workers.Rows.Clear();

            string idCrntDepartment = treeStructEnterprises.SelectedNode.Name;

            DataTable dataTableWorkes = DatabaseQueryes.DataBase_Kosta.Tables[Database_DataName.NAME_TABLE_EMPOYEE];
            DataRow[] rowsWorkersInDeportment = dataTableWorkes.Select($"DepartmentID ='{idCrntDepartment}'");

            int indexRow = 0;
            foreach (var row in rowsWorkersInDeportment)
            {
                dataGrid_workers.Rows.Add();
                dataGrid_workers["Position", indexRow].Value = rowsWorkersInDeportment[indexRow]["Position"].ToString();

                string firstName = rowsWorkersInDeportment[indexRow]["FirstName"].ToString();
                string secondName = rowsWorkersInDeportment[indexRow]["SurName"].ToString();
                string patronymic = rowsWorkersInDeportment[indexRow]["Patronymic"].ToString();

                string fullName = $"{secondName} {firstName[0]}.";
                if (patronymic != "")
                {
                    fullName += $"{patronymic[0]}.";
                }
                dataGrid_workers["FullName", indexRow].Value = fullName;

                //Поле id заполняется для возможности дальнейшего пойска данных сотрудника в базе данных
                //т.к. ФИО могут быть одинаковыми
                dataGrid_workers["ID", indexRow].Value = rowsWorkersInDeportment[indexRow]["ID"].ToString();
                indexRow++;
            }

            //т.к. при смене выборе отдела из списка происходит смена списка сотрудников, 
            //следовательно меняяется выбранный сотрудник. 
            //Осуществляем отображение данных нового сотрудника
            UpdateDateEmployeeOnForm();
        }

        /// <summary>
        /// Отображение данных сотрудника на форме.
        /// </summary>
        private void UpdateDateEmployeeOnForm()
        {
            //не выгружаем данные пользователя, если форма открыта в режиме просмотра структуры предприятия
            if (_statusShowFormStandart)
                return;

            DataRow rowEmpoyee = GetCurrentSelecectEmpoyee();
            if (rowEmpoyee == null)
                return;

            lbl_FirstNameEmpoyeeValue.Text = rowEmpoyee["FirstName"].ToString();
            lbl_SurNameEmpoyeeValue.Text = rowEmpoyee["SurName"].ToString();
            lbl_PatronymicEmpoyeeValue.Text = rowEmpoyee["Patronymic"].ToString();

            DateTime dateOfBirth;
            if (DateTime.TryParse(rowEmpoyee["DateOfBirth"].ToString(), out dateOfBirth))
                lbl_DateOfBirthEmpoyeeValue.Text = $"{dateOfBirth.ToShortDateString()}, {YearsEmloyee(dateOfBirth)} лет";

            lbl_DocEmpoyeeValue.Text = $"{rowEmpoyee["DocSeries"]} {rowEmpoyee["DocNumber"]}";
            lbl_PositionValue.Text = rowEmpoyee["Position"].ToString();

            DataRow rowDepartment = DatabaseQueryes.DataBase_Kosta.Tables[Database_DataName.NAME_TABLE_DEPARTMENT]
                .Select($"ID= '{rowEmpoyee["DepartmentID"]}'")[0];
            lbl_CodeDepartmentValue.Text = $"{rowDepartment["Code"]} ({rowDepartment["Name"]})";
        }

        /// <summary>
        /// Получить данные текущего выбранного пользователя
        /// </summary>
        /// <returns></returns>
        private DataRow GetCurrentSelecectEmpoyee()
        {
            if (dataGrid_workers.CurrentRow == null)
                 return null;

            int indexRow = dataGrid_workers.CurrentRow.Index;
            string idEmpoyee = dataGrid_workers.Rows[indexRow].Cells["ID"].Value.ToString();
            DataRow rowEmpoyee = DatabaseQueryes.DataBase_Kosta.Tables[Database_DataName.NAME_TABLE_EMPOYEE]
                .Select($"ID ={idEmpoyee}")[0];

            return rowEmpoyee;
        }

        /// <summary>
        /// Расчтё возвраста сотрудника по дате рождения
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <returns></returns>
        private int YearsEmloyee (DateTime dateOfBirth)
        {
            DateTime crntDateTime = DateTime.Now;
            int years = crntDateTime.Year - dateOfBirth.Year;
           
            DateTime firstDate = new DateTime(1, crntDateTime.Month, crntDateTime.Day);
            DateTime secondDate = new DateTime(1, dateOfBirth.Month, dateOfBirth.Day);

            TimeSpan timeSpan = firstDate - secondDate;
            if (timeSpan.Days< 0)
                years--;

            return years;
        }

        private void dataGrid_workers_Click(object sender, EventArgs e)
        {
            UpdateDateEmployeeOnForm();
        }

        private void btn_ShowPanelEmpoyee_Click(object sender, EventArgs e)
        {
            SwapDesignForm();
        }

        /// <summary>
        /// Изменение макета формы (переход в режим отображения данных о сотруднике).
        /// </summary>
        private void SwapDesignForm()
        {
            if (_statusShowFormStandart)
                ShowExtendForm();
            else
                ShowStandartForm();
        }

        /// <summary>
        /// Отображение стандартного макета формы, без полного списка данных сотрудника.
        /// </summary>
        private void ShowStandartForm()
        {
            _statusShowFormStandart = true;
            pnl_DataInfoEmpoyee.Visible = false;
            this.Size = _sizeFormStandart;
            btn_ShowPanelEmpoyee.Text = _textBtnShowDataEmployee_Standart;
        }

        /// <summary>
        /// Отображение расширеного макета формы, с данными сотрудника
        /// </summary>
        private void ShowExtendForm()
        {
            _statusShowFormStandart = false;
            UpdateDateEmployeeOnForm();
            pnl_DataInfoEmpoyee.Visible = true;
            btn_ShowPanelEmpoyee.Text = _textBtnShowDataEmployee_Extend;
            this.Size = _sizeFormExpand;
        }

        private void btn_DeleteEmpolye_Click(object sender, EventArgs e)
        {
            DeleteEmployeeFromDatabase();
        }

        /// <summary>
        /// Удаление текущего работника из базы данных
        /// </summary>
        private void DeleteEmployeeFromDatabase()
        {
            if (dataGrid_workers.CurrentRow == null)
                return;

            DialogResult dr = MessageBox.Show(
                "Запись будет безвозвратно удалена из базы данных!\nПродолжить?",
                "Удаление данных из базы данных",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                DataRow rowEmplayee = GetCurrentSelecectEmpoyee();
                
                DatabaseQueryes.DeleteEmployeeFromDatabase(rowEmplayee);
                UpdateListWorkers();
            }
        }

        private void btn_EditEmployee_Click(object sender, EventArgs e)
        {
            DataRow dataRowEmployee = GetCurrentSelecectEmpoyee();
            if(dataRowEmployee == null)
            {
                UIIneractions.ShowMessage("Выберите сотрудника для редактирования", "Ошибка редактирования", UIIneractions.TypeMessage.Error);
                return;
            }

            FormEditEmpoyee formEditEmpoyee = new FormEditEmpoyee(dataRowEmployee);
            formEditEmpoyee.ShowDialog();
            UpdateListWorkers();
            UpdateDateEmployeeOnForm();
        }

        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            FormEditEmpoyee formEditEmpoyee = new FormEditEmpoyee();
            formEditEmpoyee.ShowDialog();
            UpdateListWorkers();
            UpdateDateEmployeeOnForm();
        }

        private void cbx_ShowMessage_CheckedChanged(object sender, EventArgs e)
        {
            UIIneractions.StatusShowMessage = cbx_ShowMessage.Checked;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
