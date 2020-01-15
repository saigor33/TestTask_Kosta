using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask_Kosta.DB_KostaTableAdapters;

namespace TestTask_Kosta.Database
{
    public class DatabaseQueryes
    {
        private static DB_Kosta _dB_Kosta;
        private static EmpoyeeTableAdapter _empoyeeTableAdapter = new EmpoyeeTableAdapter();
        private static DepartmentTableAdapter _departmentTableAdapter = new DepartmentTableAdapter();

        public static DB_Kosta DataBase_Kosta 
        {
            get
            {
                return _dB_Kosta;
            }
            set
            {
                _dB_Kosta = value;
                UpdateTableEmpoyee();
                UpdateTableDepartment();
            }
        }

        /// <summary>
        /// Обновить данные таблицы "Сотрудники"
        /// </summary>
        public static void UpdateTableEmpoyee()
        {
            _empoyeeTableAdapter.Fill(DataBase_Kosta.Empoyee);
        }

        /// <summary>
        /// Обновить данные таблицы "Отделы"
        /// </summary>
        public static void UpdateTableDepartment()
        {
            _departmentTableAdapter.Fill(DataBase_Kosta.Department);
        }

        /// <summary>
        /// Удаление работника из таблицы базы данных
        /// </summary>
        /// <param name="dataRow"></param>
        public static void DeleteEmployeeFromDatabase(DataRow dataRow)
        {

            try
            {
                _empoyeeTableAdapter.Delete(
                    (decimal)dataRow["ID"],
                    dataRow["FirstName"].ToString(),
                    dataRow["SurName"].ToString(),
                    dataRow["Patronymic"].ToString(),
                    (DateTime)dataRow["DateOfBirth"],
                    dataRow["DocSeries"].ToString(),
                    dataRow["DocNumber"].ToString(),
                    dataRow["Position"].ToString(),
                   (Guid)dataRow["DepartmentID"]
                    );
                //_empoyeeTableAdapter.Fill(DataBase_Kosta.Empoyee);
                UpdateTableEmpoyee();
               UIIneractions.ShowMessage("Данные удалены!", "Уведомление", UIIneractions.TypeMessage.Information);
            }
            catch (Exception ex)
            {
                UIIneractions.ShowMessage("В процессе удаление данных произошла ошибка. Повторите операцию позднее.",
                    "Ошибка удаления данных.", UIIneractions.TypeMessage.Error);
            }

        }

        /// <summary>
        /// Обновить данные сотрудника в базе данных.
        /// </summary>
        /// <param name="original_row"></param>
        /// <param name="firstName"></param>
        /// <param name="surName"></param>
        /// <param name="patronymic"></param>
        /// <param name="dateOfBirch"></param>
        /// <param name="docSeries"></param>
        /// <param name="docNumber"></param>
        /// <param name="position"></param>
        /// <param name="departamentID"></param>
        public static void UpdateDateEmployeeInDateBase (DataRow original_row, string firstName, string surName, string patronymic,
            DateTime dateOfBirch, string docSeries, string docNumber, string position, string departamentID)
        {
            try
            {
                _empoyeeTableAdapter.Update(
                    firstName,
                    surName,
                    patronymic,
                    dateOfBirch,
                    docSeries,
                    docNumber,
                    position,
                    Guid.Parse(departamentID),

                    (decimal)original_row["ID"],
                    original_row["FirstName"].ToString(),
                    original_row["SurName"].ToString(),
                    original_row["Patronymic"].ToString(),
                    (DateTime)original_row["DateOfBirth"],
                    original_row["DocSeries"].ToString(),
                    original_row["DocNumber"].ToString(),
                    original_row["Position"].ToString(),
                    (Guid)original_row["DepartmentID"]
                    );

                //_empoyeeTableAdapter.Fill(DataBase_Kosta.Empoyee);
                UpdateTableEmpoyee();
                UIIneractions.ShowMessage("Данные успешно обновлены!", 
                    "Обновление данных в базе данных", UIIneractions.TypeMessage.Information);
            }
            catch (Exception ex)
            {
                UIIneractions.ShowMessage("В процессе обнавления данных произошла ошибка!",
                    "Обновление в базе данных", UIIneractions.TypeMessage.Error);
            }
        }

        /// <summary>
        /// Добавить нового сотрудника в базу данных.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="surName"></param>
        /// <param name="patronymic"></param>
        /// <param name="dateOfBirch"></param>
        /// <param name="docSeries"></param>
        /// <param name="docNumber"></param>
        /// <param name="position"></param>
        /// <param name="departamentID"></param>
        public static void AddEmployeeInDatebase(string firstName, string surName, string patronymic,
            DateTime dateOfBirch, string docSeries, string docNumber, string position, string departamentID)
        {
            try
            {
                _empoyeeTableAdapter.Insert(
                    firstName,
                    surName,
                    patronymic,
                    dateOfBirch,
                    docSeries,
                    docNumber,
                    position,
                    Guid.Parse(departamentID)
                    );

                // _empoyeeTableAdapter.Fill(DataBase_Kosta.Empoyee);
                UpdateTableEmpoyee();
                UIIneractions.ShowMessage("Данные успешно добавлены!",
                    "Добавление данных в базу данных", UIIneractions.TypeMessage.Information);
            }
            catch (Exception ex)
            {
                UIIneractions.ShowMessage("В процессе добавления произошла ошибка!",
                    "Добавление данных в базу данных", UIIneractions.TypeMessage.Information);
            }
        }
    }
}
