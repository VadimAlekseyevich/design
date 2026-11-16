using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab3Variant2Shilin
{
    public partial class FormMain : Form
    {
        // Список динамически созданных флажков.
        private readonly List<CheckBox> _checkBoxes = new List<CheckBox>();

        // Один генератор случайных координат на всё время работы приложения.
        private Random _random;

        // Порядковый номер нового флажка не зависит от последующих удалений.
        private int _nextCheckBoxNumber = 1;

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализирует генератор случайных чисел при загрузке главной формы.
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Генератор создаётся только один раз.
            _random = new Random();
            UpdateCheckBoxCount();
        }

        /// <summary>
        /// Создаёт один флажок при щелчке левой кнопкой мыши по панели.
        /// </summary>
        private void PanelCheckBoxes_MouseClick(object sender, MouseEventArgs e)
        {
            // Правый щелчок не создаёт новые элементы.
            if (e.Button == MouseButtons.Left)
            {
                CreateCheckBox();
            }
        }

        /// <summary>
        /// Создаёт один флажок при щелчке по свободной части главной формы.
        /// </summary>
        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {
            // Все флажки независимо от места щелчка помещаются на PanelCheckBoxes.
            if (e.Button == MouseButtons.Left)
            {
                CreateCheckBox();
            }
        }

        /// <summary>
        /// Создаёт два новых флажка при щелчке по существующему флажку.
        /// </summary>
        private void DynamicCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Открытие контекстного меню правой кнопкой не должно создавать флажки.
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            // Каждому щелчку соответствует ровно два новых элемента.
            CreateCheckBox();
            CreateCheckBox();
        }

        /// <summary>
        /// Создаёт один флажок по команде меню или кнопке панели инструментов.
        /// </summary>
        private void CreateCheckBoxCommand_Click(object sender, EventArgs e)
        {
            // Меню и ToolStrip используют одно действие.
            CreateCheckBox();
        }

        /// <summary>
        /// Удаляет указанный флажок через принадлежащее ему контекстное меню.
        /// </summary>
        private void DeleteCheckBoxMenuItem_Click(object sender, EventArgs e)
        {
            // В Tag пункта «Удалить» хранится конкретный флажок.
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            CheckBox checkBox = (CheckBox)menuItem.Tag;
            RemoveCheckBox(checkBox);
        }

        /// <summary>
        /// Удаляет все флажки после подтверждения пользователя.
        /// </summary>
        private void RemoveAllCommand_Click(object sender, EventArgs e)
        {
            // Пустой список не требует действий.
            if (_checkBoxes.Count == 0)
            {
                return;
            }

            // Открываем модальный запрос подтверждения относительно главного окна.
            DialogResult answer = MessageBox.Show(
                this,
                "Удалить все созданные флажки?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            // Удаляем по копии списка, потому что RemoveCheckBox изменяет оригинал.
            foreach (CheckBox checkBox in _checkBoxes.ToArray())
            {
                RemoveCheckBox(checkBox);
            }
        }

        /// <summary>
        /// Закрывает приложение командой главного меню.
        /// </summary>
        private void ExitCommand_Click(object sender, EventArgs e)
        {
            // Закрытие главной формы завершает выполнение приложения.
            Close();
        }

        /// <summary>
        /// Отображает краткую справку по действиям с флажками.
        /// </summary>
        private void AboutCommand_Click(object sender, EventArgs e)
        {
            // Справка выводится в модальном окне с владельцем FormMain.
            MessageBox.Show(
                this,
                "Лабораторная работа №3, вариант 2.\n" +
                "Щелчок по свободной области создаёт один флажок.\n" +
                "Левый щелчок по флажку создаёт ещё два флажка.\n" +
                "Правый щелчок по флажку открывает меню «Удалить».",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Создаёт флажок в случайных координатах панели с собственным контекстным меню.
        /// </summary>
        private void CreateCheckBox()
        {
            // Номер присваивается один раз и не повторяется после удаления элементов.
            int number = _nextCheckBoxNumber;
            _nextCheckBoxNumber++;

            CheckBox checkBox = new CheckBox
            {
                Name = "CheckBoxDynamic" + number,
                Text = "флажок" + number,
                AutoSize = false,
                Size = new Size(124, 28),
                UseVisualStyleBackColor = true,
                TabIndex = number
            };

            // Каждому флажку соответствует отдельный экземпляр контекстного меню.
            ContextMenuStrip contextMenu = new ContextMenuStrip(components)
            {
                Name = "ContextMenuCheckBox" + number
            };

            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("&Удалить")
            {
                Name = "MenuItemDeleteCheckBox" + number,
                Tag = checkBox
            };

            // Назначаем обработчики событий создаваемым объектам динамически.
            deleteMenuItem.Click += DeleteCheckBoxMenuItem_Click;
            contextMenu.Items.Add(deleteMenuItem);
            checkBox.ContextMenuStrip = contextMenu;
            checkBox.MouseClick += DynamicCheckBox_MouseClick;

            // Учитываем размеры флажка, чтобы он целиком находился внутри панели.
            int maxX = Math.Max(0, PanelCheckBoxes.ClientSize.Width - checkBox.Width);
            int maxY = Math.Max(0, PanelCheckBoxes.ClientSize.Height - checkBox.Height);
            checkBox.Location = new Point(_random.Next(maxX + 1), _random.Next(maxY + 1));

            // Добавляем новый объект и в коллекцию визуальных элементов, и в список.
            PanelCheckBoxes.Controls.Add(checkBox);
            _checkBoxes.Add(checkBox);
            UpdateCheckBoxCount();
        }

        /// <summary>
        /// Удаляет конкретный флажок с панели и из динамического списка.
        /// </summary>
        private void RemoveCheckBox(CheckBox checkBox)
        {
            // Повторное удаление объекта не изменяет состояние приложения.
            if (!_checkBoxes.Remove(checkBox))
            {
                return;
            }

            // Удаляем обработчик, сам элемент и принадлежащее ему контекстное меню.
            ContextMenuStrip contextMenu = checkBox.ContextMenuStrip;
            checkBox.MouseClick -= DynamicCheckBox_MouseClick;
            checkBox.ContextMenuStrip = null;
            PanelCheckBoxes.Controls.Remove(checkBox);
            checkBox.Dispose();

            if (contextMenu != null)
            {
                contextMenu.Dispose();
            }

            UpdateCheckBoxCount();
        }

        /// <summary>
        /// Показывает текущее количество созданных флажков в строке состояния.
        /// </summary>
        private void UpdateCheckBoxCount()
        {
            // Количество берётся из списка актуальных элементов, а не из счётчика имён.
            StatusLabelCount.Text = "Количество флажков: " + _checkBoxes.Count;
        }
    }
}
