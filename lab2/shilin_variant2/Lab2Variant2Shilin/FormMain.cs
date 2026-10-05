using System;
using System.Windows.Forms;

namespace Lab2Variant2Shilin
{
    public partial class FormMain : Form
    {
        // Единственный экземпляр модального окна сохраняет состояние настроек до закрытия приложения.
        private readonly FormConfig _formConfig;

        public FormMain()
        {
            InitializeComponent();
            _formConfig = new FormConfig();
        }

        /// <summary>
        /// Открывает модальное окно настройки метки и применяет подтвержденные пользователем значения.
        /// </summary>
        private void ButtonConfigure_Click(object sender, EventArgs e)
        {
            // Перед открытием передаем в окно настройки текущее состояние метки.
            _formConfig.LabelText = LabelSample.Text;
            _formConfig.LabelBorderStyle = LabelSample.BorderStyle;
            _formConfig.LabelTextAlign = LabelSample.TextAlign;
            _formConfig.LabelEnabled = LabelSample.Enabled;

            // Открываем форму настройки как модальное окно относительно главной формы.
            DialogResult dialogResult = _formConfig.ShowDialog(this);

            // Изменения применяются только после подтверждения кнопкой «ОК».
            if (dialogResult == DialogResult.OK)
            {
                LabelSample.Text = _formConfig.LabelText;
                LabelSample.BorderStyle = _formConfig.LabelBorderStyle;
                LabelSample.TextAlign = _formConfig.LabelTextAlign;
                LabelSample.Enabled = _formConfig.LabelEnabled;
            }
        }
    }
}
