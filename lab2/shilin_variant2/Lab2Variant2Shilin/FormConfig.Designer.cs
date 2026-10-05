namespace Lab2Variant2Shilin
{
    partial class FormConfig
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label LabelTextCaption;
        private System.Windows.Forms.TextBox TextBoxLabelText;
        private System.Windows.Forms.GroupBox GroupBoxBorderStyle;
        private System.Windows.Forms.RadioButton RadioButtonBorderNone;
        private System.Windows.Forms.RadioButton RadioButtonBorderFixedSingle;
        private System.Windows.Forms.RadioButton RadioButtonBorderFixed3D;
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
            this.TextBoxLabelText = new System.Windows.Forms.TextBox();
            this.GroupBoxBorderStyle = new System.Windows.Forms.GroupBox();
            this.RadioButtonBorderFixed3D = new System.Windows.Forms.RadioButton();
            this.RadioButtonBorderFixedSingle = new System.Windows.Forms.RadioButton();
            this.RadioButtonBorderNone = new System.Windows.Forms.RadioButton();
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
            this.GroupBoxBorderStyle.SuspendLayout();
            this.GroupBoxTextAlign.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTextCaption
            // 
            this.LabelTextCaption.AutoSize = true;
            this.LabelTextCaption.Location = new System.Drawing.Point(24, 26);
            this.LabelTextCaption.Name = "LabelTextCaption";
            this.LabelTextCaption.Size = new System.Drawing.Size(79, 13);
            this.LabelTextCaption.TabIndex = 0;
            this.LabelTextCaption.Text = "Текст метки:";
            // 
            // TextBoxLabelText
            // 
            this.TextBoxLabelText.Location = new System.Drawing.Point(27, 46);
            this.TextBoxLabelText.Name = "TextBoxLabelText";
            this.TextBoxLabelText.Size = new System.Drawing.Size(526, 20);
            this.TextBoxLabelText.TabIndex = 1;
            this.TextBoxLabelText.Text = "Пример метки";
            // 
            // GroupBoxBorderStyle
            // 
            this.GroupBoxBorderStyle.Controls.Add(this.RadioButtonBorderFixed3D);
            this.GroupBoxBorderStyle.Controls.Add(this.RadioButtonBorderFixedSingle);
            this.GroupBoxBorderStyle.Controls.Add(this.RadioButtonBorderNone);
            this.GroupBoxBorderStyle.Location = new System.Drawing.Point(27, 86);
            this.GroupBoxBorderStyle.Name = "GroupBoxBorderStyle";
            this.GroupBoxBorderStyle.Size = new System.Drawing.Size(526, 75);
            this.GroupBoxBorderStyle.TabIndex = 2;
            this.GroupBoxBorderStyle.TabStop = false;
            this.GroupBoxBorderStyle.Text = "BorderStyle";
            // 
            // RadioButtonBorderFixed3D
            // 
            this.RadioButtonBorderFixed3D.AutoSize = true;
            this.RadioButtonBorderFixed3D.Location = new System.Drawing.Point(357, 31);
            this.RadioButtonBorderFixed3D.Name = "RadioButtonBorderFixed3D";
            this.RadioButtonBorderFixed3D.Size = new System.Drawing.Size(74, 17);
            this.RadioButtonBorderFixed3D.TabIndex = 2;
            this.RadioButtonBorderFixed3D.TabStop = true;
            this.RadioButtonBorderFixed3D.Tag = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RadioButtonBorderFixed3D.Text = "Объемная";
            this.RadioButtonBorderFixed3D.UseVisualStyleBackColor = true;
            // 
            // RadioButtonBorderFixedSingle
            // 
            this.RadioButtonBorderFixedSingle.AutoSize = true;
            this.RadioButtonBorderFixedSingle.Checked = true;
            this.RadioButtonBorderFixedSingle.Location = new System.Drawing.Point(184, 31);
            this.RadioButtonBorderFixedSingle.Name = "RadioButtonBorderFixedSingle";
            this.RadioButtonBorderFixedSingle.Size = new System.Drawing.Size(86, 17);
            this.RadioButtonBorderFixedSingle.TabIndex = 1;
            this.RadioButtonBorderFixedSingle.TabStop = true;
            this.RadioButtonBorderFixedSingle.Tag = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RadioButtonBorderFixedSingle.Text = "Одинарная";
            this.RadioButtonBorderFixedSingle.UseVisualStyleBackColor = true;
            // 
            // RadioButtonBorderNone
            // 
            this.RadioButtonBorderNone.AutoSize = true;
            this.RadioButtonBorderNone.Location = new System.Drawing.Point(23, 31);
            this.RadioButtonBorderNone.Name = "RadioButtonBorderNone";
            this.RadioButtonBorderNone.Size = new System.Drawing.Size(81, 17);
            this.RadioButtonBorderNone.TabIndex = 0;
            this.RadioButtonBorderNone.Tag = System.Windows.Forms.BorderStyle.None;
            this.RadioButtonBorderNone.Text = "Без рамки";
            this.RadioButtonBorderNone.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.GroupBoxBorderStyle);
            this.Controls.Add(this.TextBoxLabelText);
            this.Controls.Add(this.LabelTextCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка компонента Label";
            this.GroupBoxBorderStyle.ResumeLayout(false);
            this.GroupBoxBorderStyle.PerformLayout();
            this.GroupBoxTextAlign.ResumeLayout(false);
            this.GroupBoxTextAlign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
