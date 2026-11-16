namespace Lab3Variant2Shilin
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemActions;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCreateCheckBox;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRemoveAll;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.ToolStripButton ToolStripButtonCreateCheckBox;
        private System.Windows.Forms.ToolStripButton ToolStripButtonRemoveAll;
        private System.Windows.Forms.Label LabelInstruction;
        private System.Windows.Forms.Panel PanelCheckBoxes;
        private System.Windows.Forms.StatusStrip StatusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemActions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCreateCheckBox = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonCreateCheckBox = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonRemoveAll = new System.Windows.Forms.ToolStripButton();
            this.LabelInstruction = new System.Windows.Forms.Label();
            this.PanelCheckBoxes = new System.Windows.Forms.Panel();
            this.StatusStripMain = new System.Windows.Forms.StatusStrip();
            this.StatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStripMain.SuspendLayout();
            this.ToolStripMain.SuspendLayout();
            this.StatusStripMain.SuspendLayout();
            this.SuspendLayout();
            //
            // MenuStripMain
            //
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.MenuItemFile,
                this.MenuItemActions,
                this.MenuItemHelp});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Size = new System.Drawing.Size(900, 24);
            this.MenuStripMain.TabIndex = 0;
            this.MenuStripMain.Text = "Главное меню";
            //
            // MenuItemFile
            //
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.MenuItemExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Text = "&Файл";
            //
            // MenuItemExit
            //
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q;
            this.MenuItemExit.Text = "&Выход";
            this.MenuItemExit.ToolTipText = "Завершить работу приложения";
            this.MenuItemExit.Click += new System.EventHandler(this.ExitCommand_Click);
            //
            // MenuItemActions
            //
            this.MenuItemActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.MenuItemCreateCheckBox,
                this.MenuItemRemoveAll});
            this.MenuItemActions.Name = "MenuItemActions";
            this.MenuItemActions.Text = "&Действия";
            //
            // MenuItemCreateCheckBox
            //
            this.MenuItemCreateCheckBox.Name = "MenuItemCreateCheckBox";
            this.MenuItemCreateCheckBox.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            this.MenuItemCreateCheckBox.Text = "&Создать флажок";
            this.MenuItemCreateCheckBox.ToolTipText = "Добавить один флажок в случайной позиции";
            this.MenuItemCreateCheckBox.Click += new System.EventHandler(this.CreateCheckBoxCommand_Click);
            //
            // MenuItemRemoveAll
            //
            this.MenuItemRemoveAll.Name = "MenuItemRemoveAll";
            this.MenuItemRemoveAll.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete;
            this.MenuItemRemoveAll.Text = "&Удалить все флажки";
            this.MenuItemRemoveAll.ToolTipText = "Удалить все созданные элементы после подтверждения";
            this.MenuItemRemoveAll.Click += new System.EventHandler(this.RemoveAllCommand_Click);
            //
            // MenuItemHelp
            //
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.MenuItemAbout});
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Text = "С&правка";
            //
            // MenuItemAbout
            //
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.MenuItemAbout.Text = "&О программе...";
            this.MenuItemAbout.ToolTipText = "Показать правила работы с динамическими флажками";
            this.MenuItemAbout.Click += new System.EventHandler(this.AboutCommand_Click);
            //
            // ToolStripMain
            //
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.ToolStripButtonCreateCheckBox,
                this.ToolStripButtonRemoveAll});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 24);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new System.Drawing.Size(900, 25);
            this.ToolStripMain.TabIndex = 1;
            this.ToolStripMain.Text = "Панель инструментов";
            //
            // ToolStripButtonCreateCheckBox
            //
            this.ToolStripButtonCreateCheckBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButtonCreateCheckBox.Name = "ToolStripButtonCreateCheckBox";
            this.ToolStripButtonCreateCheckBox.Text = "Создать флажок";
            this.ToolStripButtonCreateCheckBox.ToolTipText = "Создать флажок (Ctrl+N)";
            this.ToolStripButtonCreateCheckBox.Click += new System.EventHandler(this.CreateCheckBoxCommand_Click);
            //
            // ToolStripButtonRemoveAll
            //
            this.ToolStripButtonRemoveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButtonRemoveAll.Name = "ToolStripButtonRemoveAll";
            this.ToolStripButtonRemoveAll.Text = "Удалить все";
            this.ToolStripButtonRemoveAll.ToolTipText = "Удалить все флажки (Ctrl+Shift+Del)";
            this.ToolStripButtonRemoveAll.Click += new System.EventHandler(this.RemoveAllCommand_Click);
            //
            // LabelInstruction
            //
            this.LabelInstruction.Anchor = System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.LabelInstruction.Location = new System.Drawing.Point(16, 59);
            this.LabelInstruction.Name = "LabelInstruction";
            this.LabelInstruction.Size = new System.Drawing.Size(868, 34);
            this.LabelInstruction.TabIndex = 2;
            this.LabelInstruction.Text = "Щелчок по свободной области — один новый флажок. " +
                "Щелчок по флажку — ещё два. Правая кнопка мыши — удалить флажок.";
            //
            // PanelCheckBoxes
            //
            this.PanelCheckBoxes.Anchor = System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.PanelCheckBoxes.BackColor = System.Drawing.SystemColors.Window;
            this.PanelCheckBoxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCheckBoxes.Location = new System.Drawing.Point(16, 98);
            this.PanelCheckBoxes.Name = "PanelCheckBoxes";
            this.PanelCheckBoxes.Size = new System.Drawing.Size(868, 454);
            this.PanelCheckBoxes.TabIndex = 3;
            this.PanelCheckBoxes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelCheckBoxes_MouseClick);
            //
            // StatusStripMain
            //
            this.StatusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.StatusLabelCount});
            this.StatusStripMain.Location = new System.Drawing.Point(0, 568);
            this.StatusStripMain.Name = "StatusStripMain";
            this.StatusStripMain.Size = new System.Drawing.Size(900, 22);
            this.StatusStripMain.TabIndex = 4;
            this.StatusStripMain.Text = "Строка состояния";
            //
            // StatusLabelCount
            //
            this.StatusLabelCount.Name = "StatusLabelCount";
            this.StatusLabelCount.Text = "Количество флажков: 0";
            //
            // FormMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.Controls.Add(this.PanelCheckBoxes);
            this.Controls.Add(this.LabelInstruction);
            this.Controls.Add(this.StatusStripMain);
            this.Controls.Add(this.ToolStripMain);
            this.Controls.Add(this.MenuStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.MenuStripMain;
            this.MinimumSize = new System.Drawing.Size(700, 460);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №3 — вариант 2";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseClick);
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.StatusStripMain.ResumeLayout(false);
            this.StatusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
