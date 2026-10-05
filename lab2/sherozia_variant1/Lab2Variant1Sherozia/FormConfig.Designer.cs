namespace Lab2Variant1Sherozia
{
    partial class FormConfig
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label LabelTextCaption;
        private System.Windows.Forms.TextBox TextBoxButtonText;
        private System.Windows.Forms.GroupBox GroupBoxCursor;
        private System.Windows.Forms.RadioButton RadioButtonCursorDefault;
        private System.Windows.Forms.RadioButton RadioButtonCursorHand;
        private System.Windows.Forms.GroupBox GroupBoxTextAlign;
        private System.Windows.Forms.RadioButton RadioButtonAlignTopLeft;
        private System.Windows.Forms.RadioButton RadioButtonAlignTopCenter;
        private System.Windows.Forms.RadioButton RadioButtonAlignTopRight;
        private System.Windows.Forms.RadioButton RadioButtonAlignMiddleLeft;
        private System.Windows.Forms.RadioButton RadioButtonAlignMiddleCenter;
        private System.Windows.Forms.RadioButton RadioButtonAlignMiddleRight;
        private System.Windows.Forms.RadioButton RadioButtonAlignBottomLeft;
        private System.Windows.Forms.RadioButton RadioButtonAlignBottomCenter;
        private System.Windows.Forms.RadioButton RadioButtonAlignBottomRight;
        private System.Windows.Forms.CheckBox CheckBoxEnabled;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;

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
            this.LabelTextCaption = new System.Windows.Forms.Label();
            this.TextBoxButtonText = new System.Windows.Forms.TextBox();
            this.GroupBoxCursor = new System.Windows.Forms.GroupBox();
            this.RadioButtonCursorHand = new System.Windows.Forms.RadioButton();
            this.RadioButtonCursorDefault = new System.Windows.Forms.RadioButton();
            this.GroupBoxTextAlign = new System.Windows.Forms.GroupBox();
            this.RadioButtonAlignBottomRight = new System.Windows.Forms.RadioButton();
            this.RadioButtonAlignBottomCenter = new System.Windows.Forms.RadioButton();
            this.RadioButtonAlignBottomLeft = new System.Windows.Forms.RadioButton();
            this.RadioButtonAlignMiddleRight = new System.Windows.Forms.RadioButton();
            this.RadioButtonAlignMiddleCenter = new System.Windows.Forms.RadioButton();
            this.RadioButtonAlignMiddleLeft = new System.Windows.Forms.RadioButton();
            this.RadioButtonAlignTopRight = new System.Windows.Forms.RadioButton();
            this.RadioButtonAlignTopCenter = new System.Windows.Forms.RadioButton();
            this.RadioButtonAlignTopLeft = new System.Windows.Forms.RadioButton();
            this.CheckBoxEnabled = new System.Windows.Forms.CheckBox();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.GroupBoxCursor.SuspendLayout();
            this.GroupBoxTextAlign.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTextCaption
            // 
            this.LabelTextCaption.AutoSize = true;
            this.LabelTextCaption.Location = new System.Drawing.Point(24, 26);
            this.LabelTextCaption.Name = "LabelTextCaption";
            this.LabelTextCaption.Size = new System.Drawing.Size(84, 13);
            this.LabelTextCaption.TabIndex = 0;
            this.LabelTextCaption.Text = "Текст кнопки:";
            // 
            // TextBoxButtonText
            // 
            this.TextBoxButtonText.Location = new System.Drawing.Point(27, 46);
            this.TextBoxButtonText.Name = "TextBoxButtonText";
            this.TextBoxButtonText.Size = new System.Drawing.Size(526, 20);
            this.TextBoxButtonText.TabIndex = 1;
            this.TextBoxButtonText.Text = "Пример кнопки";
            // 
            // GroupBoxCursor
            // 
            this.GroupBoxCursor.Controls.Add(this.RadioButtonCursorHand);
            this.GroupBoxCursor.Controls.Add(this.RadioButtonCursorDefault);
            this.GroupBoxCursor.Location = new System.Drawing.Point(27, 86);
            this.GroupBoxCursor.Name = "GroupBoxCursor";
            this.GroupBoxCursor.Size = new System.Drawing.Size(526, 75);
            this.GroupBoxCursor.TabIndex = 2;
            this.GroupBoxCursor.TabStop = false;
            this.GroupBoxCursor.Text = "Cursor";
            // 
            // RadioButtonCursorHand
            // 
            this.RadioButtonCursorHand.AutoSize = true;
            this.RadioButtonCursorHand.Location = new System.Drawing.Point(281, 31);
            this.RadioButtonCursorHand.Name = "RadioButtonCursorHand";
            this.RadioButtonCursorHand.Size = new System.Drawing.Size(121, 17);
            this.RadioButtonCursorHand.TabIndex = 1;
            this.RadioButtonCursorHand.Tag = System.Windows.Forms.Cursors.Hand;
            this.RadioButtonCursorHand.Text = "Hand (рука)";
            this.RadioButtonCursorHand.UseVisualStyleBackColor = true;
            // 
            // RadioButtonCursorDefault
            // 
            this.RadioButtonCursorDefault.AutoSize = true;
            this.RadioButtonCursorDefault.Checked = true;
            this.RadioButtonCursorDefault.Location = new System.Drawing.Point(23, 31);
            this.RadioButtonCursorDefault.Name = "RadioButtonCursorDefault";
            this.RadioButtonCursorDefault.Size = new System.Drawing.Size(146, 17);
            this.RadioButtonCursorDefault.TabIndex = 0;
            this.RadioButtonCursorDefault.TabStop = true;
            this.RadioButtonCursorDefault.Tag = System.Windows.Forms.Cursors.Default;
            this.RadioButtonCursorDefault.Text = "Default (обычный)";
            this.RadioButtonCursorDefault.UseVisualStyleBackColor = true;
            // 
            // GroupBoxTextAlign
            // 
            this.GroupBoxTextAlign.Controls.Add(this.RadioButtonAlignBottomRight);
            this.GroupBoxTextAlign.Controls.Add(this.RadioButtonAlignBottomCenter);
            this.GroupBoxTextAlign.Controls.Add(this.RadioButtonAlignBottomLeft);
            this.GroupBoxTextAlign.Controls.Add(this.RadioButtonAlignMiddleRight);
            this.GroupBoxTextAlign.Controls.Add(this.RadioButtonAlignMiddleCenter);
            this.GroupBoxTextAlign.Controls.Add(this.RadioButtonAlignMiddleLeft);
            this.GroupBoxTextAlign.Controls.Add(this.RadioButtonAlignTopRight);
            this.GroupBoxTextAlign.Controls.Add(this.RadioButtonAlignTopCenter);
            this.GroupBoxTextAlign.Controls.Add(this.RadioButtonAlignTopLeft);
            this.GroupBoxTextAlign.Location = new System.Drawing.Point(27, 181);
            this.GroupBoxTextAlign.Name = "GroupBoxTextAlign";
            this.GroupBoxTextAlign.Size = new System.Drawing.Size(526, 181);
            this.GroupBoxTextAlign.TabIndex = 3;
            this.GroupBoxTextAlign.TabStop = false;
            this.GroupBoxTextAlign.Text = "TextAlign";
            // 
            // RadioButtonAlignBottomRight
            // 
            this.RadioButtonAlignBottomRight.AutoSize = true;
            this.RadioButtonAlignBottomRight.Location = new System.Drawing.Point(357, 135);
            this.RadioButtonAlignBottomRight.Name = "RadioButtonAlignBottomRight";
            this.RadioButtonAlignBottomRight.Size = new System.Drawing.Size(103, 17);
            this.RadioButtonAlignBottomRight.TabIndex = 8;
            this.RadioButtonAlignBottomRight.Tag = System.Drawing.ContentAlignment.BottomRight;
            this.RadioButtonAlignBottomRight.Text = "Снизу справа";
            this.RadioButtonAlignBottomRight.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAlignBottomCenter
            // 
            this.RadioButtonAlignBottomCenter.AutoSize = true;
            this.RadioButtonAlignBottomCenter.Location = new System.Drawing.Point(184, 135);
            this.RadioButtonAlignBottomCenter.Name = "RadioButtonAlignBottomCenter";
            this.RadioButtonAlignBottomCenter.Size = new System.Drawing.Size(108, 17);
            this.RadioButtonAlignBottomCenter.TabIndex = 7;
            this.RadioButtonAlignBottomCenter.Tag = System.Drawing.ContentAlignment.BottomCenter;
            this.RadioButtonAlignBottomCenter.Text = "Снизу по центру";
            this.RadioButtonAlignBottomCenter.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAlignBottomLeft
            // 
            this.RadioButtonAlignBottomLeft.AutoSize = true;
            this.RadioButtonAlignBottomLeft.Location = new System.Drawing.Point(23, 135);
            this.RadioButtonAlignBottomLeft.Name = "RadioButtonAlignBottomLeft";
            this.RadioButtonAlignBottomLeft.Size = new System.Drawing.Size(97, 17);
            this.RadioButtonAlignBottomLeft.TabIndex = 6;
            this.RadioButtonAlignBottomLeft.Tag = System.Drawing.ContentAlignment.BottomLeft;
            this.RadioButtonAlignBottomLeft.Text = "Снизу слева";
            this.RadioButtonAlignBottomLeft.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAlignMiddleRight
            // 
            this.RadioButtonAlignMiddleRight.AutoSize = true;
            this.RadioButtonAlignMiddleRight.Location = new System.Drawing.Point(357, 84);
            this.RadioButtonAlignMiddleRight.Name = "RadioButtonAlignMiddleRight";
            this.RadioButtonAlignMiddleRight.Size = new System.Drawing.Size(119, 17);
            this.RadioButtonAlignMiddleRight.TabIndex = 5;
            this.RadioButtonAlignMiddleRight.Tag = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButtonAlignMiddleRight.Text = "По центру справа";
            this.RadioButtonAlignMiddleRight.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAlignMiddleCenter
            // 
            this.RadioButtonAlignMiddleCenter.AutoSize = true;
            this.RadioButtonAlignMiddleCenter.Checked = true;
            this.RadioButtonAlignMiddleCenter.Location = new System.Drawing.Point(184, 84);
            this.RadioButtonAlignMiddleCenter.Name = "RadioButtonAlignMiddleCenter";
            this.RadioButtonAlignMiddleCenter.Size = new System.Drawing.Size(125, 17);
            this.RadioButtonAlignMiddleCenter.TabIndex = 4;
            this.RadioButtonAlignMiddleCenter.TabStop = true;
            this.RadioButtonAlignMiddleCenter.Tag = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonAlignMiddleCenter.Text = "По центру";
            this.RadioButtonAlignMiddleCenter.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAlignMiddleLeft
            // 
            this.RadioButtonAlignMiddleLeft.AutoSize = true;
            this.RadioButtonAlignMiddleLeft.Location = new System.Drawing.Point(23, 84);
            this.RadioButtonAlignMiddleLeft.Name = "RadioButtonAlignMiddleLeft";
            this.RadioButtonAlignMiddleLeft.Size = new System.Drawing.Size(113, 17);
            this.RadioButtonAlignMiddleLeft.TabIndex = 3;
            this.RadioButtonAlignMiddleLeft.Tag = System.Drawing.ContentAlignment.MiddleLeft;
            this.RadioButtonAlignMiddleLeft.Text = "По центру слева";
            this.RadioButtonAlignMiddleLeft.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAlignTopRight
            // 
            this.RadioButtonAlignTopRight.AutoSize = true;
            this.RadioButtonAlignTopRight.Location = new System.Drawing.Point(357, 34);
            this.RadioButtonAlignTopRight.Name = "RadioButtonAlignTopRight";
            this.RadioButtonAlignTopRight.Size = new System.Drawing.Size(111, 17);
            this.RadioButtonAlignTopRight.TabIndex = 2;
            this.RadioButtonAlignTopRight.Tag = System.Drawing.ContentAlignment.TopRight;
            this.RadioButtonAlignTopRight.Text = "Сверху справа";
            this.RadioButtonAlignTopRight.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAlignTopCenter
            // 
            this.RadioButtonAlignTopCenter.AutoSize = true;
            this.RadioButtonAlignTopCenter.Location = new System.Drawing.Point(184, 34);
            this.RadioButtonAlignTopCenter.Name = "RadioButtonAlignTopCenter";
            this.RadioButtonAlignTopCenter.Size = new System.Drawing.Size(116, 17);
            this.RadioButtonAlignTopCenter.TabIndex = 1;
            this.RadioButtonAlignTopCenter.Tag = System.Drawing.ContentAlignment.TopCenter;
            this.RadioButtonAlignTopCenter.Text = "Сверху по центру";
            this.RadioButtonAlignTopCenter.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAlignTopLeft
            // 
            this.RadioButtonAlignTopLeft.AutoSize = true;
            this.RadioButtonAlignTopLeft.Location = new System.Drawing.Point(23, 34);
            this.RadioButtonAlignTopLeft.Name = "RadioButtonAlignTopLeft";
            this.RadioButtonAlignTopLeft.Size = new System.Drawing.Size(105, 17);
            this.RadioButtonAlignTopLeft.TabIndex = 0;
            this.RadioButtonAlignTopLeft.Tag = System.Drawing.ContentAlignment.TopLeft;
            this.RadioButtonAlignTopLeft.Text = "Сверху слева";
            this.RadioButtonAlignTopLeft.UseVisualStyleBackColor = true;
            // 
            // CheckBoxEnabled
            // 
            this.CheckBoxEnabled.AutoSize = true;
            this.CheckBoxEnabled.Checked = true;
            this.CheckBoxEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxEnabled.Location = new System.Drawing.Point(27, 384);
            this.CheckBoxEnabled.Name = "CheckBoxEnabled";
            this.CheckBoxEnabled.Size = new System.Drawing.Size(156, 17);
            this.CheckBoxEnabled.TabIndex = 4;
            this.CheckBoxEnabled.Text = "Компонент доступен";
            this.CheckBoxEnabled.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.Location = new System.Drawing.Point(366, 431);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(88, 30);
            this.ButtonOk.TabIndex = 5;
            this.ButtonOk.Text = "ОК";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(465, 431);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(88, 30);
            this.ButtonCancel.TabIndex = 6;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // FormConfig
            // 
            this.AcceptButton = this.ButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(580, 484);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.CheckBoxEnabled);
            this.Controls.Add(this.GroupBoxTextAlign);
            this.Controls.Add(this.GroupBoxCursor);
            this.Controls.Add(this.TextBoxButtonText);
            this.Controls.Add(this.LabelTextCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка компонента Button";
            this.GroupBoxCursor.ResumeLayout(false);
            this.GroupBoxCursor.PerformLayout();
            this.GroupBoxTextAlign.ResumeLayout(false);
            this.GroupBoxTextAlign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
