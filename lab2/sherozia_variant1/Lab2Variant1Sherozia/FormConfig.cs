using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab2Variant1Sherozia
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Текст настраиваемого компонента Button.
        /// </summary>
        public string ButtonText
        {
            get
            {
                return TextBoxButtonText.Text;
            }
            set
            {
                TextBoxButtonText.Text = value;
            }
        }

        /// <summary>
        /// Курсор настраиваемого компонента Button. В работе используются варианты Default и Hand.
        /// </summary>
        public Cursor ButtonCursor
        {
            get
            {
                return (Cursor)GroupBoxCursor.Controls
                    .OfType<RadioButton>()
                    .First(radioButton => radioButton.Checked)
                    .Tag;
            }
            set
            {
                foreach (RadioButton radioButton in GroupBoxCursor.Controls.OfType<RadioButton>())
                {
                    radioButton.Checked = object.Equals(radioButton.Tag, value);
                }

                RadioButtonCursorDefault.Checked = GroupBoxCursor.Controls
                    .OfType<RadioButton>()
                    .All(radioButton => !radioButton.Checked);
            }
        }

        /// <summary>
        /// Доступность настраиваемого компонента Button.
        /// </summary>
        public bool ButtonEnabled
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

        /// <summary>
        /// Выравнивание текста настраиваемого компонента Button.
        /// </summary>
        public ContentAlignment ButtonTextAlign
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
    }
}
