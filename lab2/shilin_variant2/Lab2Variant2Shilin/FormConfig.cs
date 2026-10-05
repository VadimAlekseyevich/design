using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab2Variant2Shilin
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Текст настраиваемого компонента Label.
        /// </summary>
        public string LabelText
        {
            get
            {
                return TextBoxLabelText.Text;
            }
            set
            {
                TextBoxLabelText.Text = value;
            }
        }

        /// <summary>
        /// Стиль рамки настраиваемого компонента Label.
        /// </summary>
        public BorderStyle LabelBorderStyle
        {
            get
            {
                return (BorderStyle)GroupBoxBorderStyle.Controls
                    .OfType<RadioButton>()
                    .First(radioButton => radioButton.Checked)
                    .Tag;
            }
            set
            {
                foreach (RadioButton radioButton in GroupBoxBorderStyle.Controls.OfType<RadioButton>())
                {
                    radioButton.Checked = object.Equals(radioButton.Tag, value);
                }
            }
        }

        /// <summary>
        /// Выравнивание текста настраиваемого компонента Label.
        /// </summary>
        public ContentAlignment LabelTextAlign
        {
            get
            {
                return (ContentAlignment)GroupBoxTextAlign.Controls
                    .OfType<RadioButton>()
                    .First(radioButton => radioButton.Checked)
                    .Tag;
            }
            set
            {
                foreach (RadioButton radioButton in GroupBoxTextAlign.Controls.OfType<RadioButton>())
                {
                    radioButton.Checked = object.Equals(radioButton.Tag, value);
                }
            }
        }

        /// <summary>
        /// Доступность настраиваемого компонента Label.
        /// </summary>
        public bool LabelEnabled
        {
            get
            {
                return CheckBoxEnabled.Checked;
            }
            set
            {
                CheckBoxEnabled.Checked = value;
            }
        }
    }
}
