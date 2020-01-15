using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask_Kosta
{
    public class UIIneractions
    {
        /// <summary>
        /// Выбор типа уведомления.
        /// </summary>
        public enum TypeMessage { Error, Information }

        /// <summary>
        /// Флаг отображения сообщений
        /// </summary>
        public static bool StatusShowMessage { get; set; }

        /// <summary>
        /// Отобразить сообщение пользователю
        /// </summary>
        /// <param name="textMessage"></param>
        /// <param name="headerMessage"></param>
        /// <param name="typeMessage"></param>
        public static void ShowMessage(string textMessage, string headerMessage, TypeMessage typeMessage)
        {
            if (!StatusShowMessage)
                return;

            switch (typeMessage)
            {
                case TypeMessage.Error:
                    {
                        MessageBox.Show(textMessage, headerMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case TypeMessage.Information:
                    {
                        MessageBox.Show(textMessage, headerMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
            }
        }

    }
}
