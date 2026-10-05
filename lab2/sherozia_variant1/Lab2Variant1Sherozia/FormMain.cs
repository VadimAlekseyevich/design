using System;
using System.Windows.Forms;

namespace Lab2Variant1Sherozia
{
    public partial class FormMain : Form
    {
        // Единственный экземпляр формы настроек сохраняет состояние до закрытия приложения.
        private readonly FormConfig _formConfig;

        public FormMain()
        {
            InitializeComponent();
            _formConfig = new FormConfig();
        }

        /// <summary>
        /// Открывает модальное окно настройки кнопки и применяет подтвержденные пользователем значения.
        /// </summary>
        private void ButtonConfigure_Click(object sender, EventArgs e)
        {
            // Перед открытием передаем в окно настройки текущее состояние кнопки.
            _formConfig.ButtonText = ButtonSample.Text;
            _formConfig.ButtonCursor = ButtonSample.Cursor;
            _formConfig.ButtonEnabled = ButtonSample.Enabled;
            _formConfig.ButtonTextAlign = ButtonSample.TextAlign;

            // Открываем форму настройки как модальное окно относительно главной формы.
            DialogResult dialogResult = _formConfig.ShowDialog(this);

            // Изменения применяются только после подтверждения кнопкой «ОК».
            if (dialogResult == DialogResult.OK)
            {
                ButtonSample.Text = _formConfig.ButtonText;
                ButtonSample.Cursor = _formConfig.ButtonCursor;
                ButtonSample.Enabled = _formConfig.ButtonEnabled;
                ButtonSample.TextAlign = _formConfig.ButtonTextAlign;
            }
        }
    }
}
