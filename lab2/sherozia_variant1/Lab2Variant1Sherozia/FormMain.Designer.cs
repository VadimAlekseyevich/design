namespace Lab2Variant1Sherozia
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label LabelCaption;
        private System.Windows.Forms.Button ButtonSample;
        private System.Windows.Forms.Button ButtonConfigure;

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
            this.LabelCaption = new System.Windows.Forms.Label();
            this.ButtonSample = new System.Windows.Forms.Button();
            this.ButtonConfigure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelCaption
            // 
            this.LabelCaption.AutoSize = true;
            this.LabelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCaption.Location = new System.Drawing.Point(172, 39);
            this.LabelCaption.Name = "LabelCaption";
            this.LabelCaption.Size = new System.Drawing.Size(276, 18);
            this.LabelCaption.TabIndex = 0;
            this.LabelCaption.Text = "Настраиваемый компонент Button";
            // 
            // ButtonSample
            // 
            this.ButtonSample.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSample.Location = new System.Drawing.Point(160, 88);
            this.ButtonSample.Name = "ButtonSample";
            this.ButtonSample.Size = new System.Drawing.Size(300, 92);
            this.ButtonSample.TabIndex = 1;
            this.ButtonSample.Text = "Пример кнопки";
            this.ButtonSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonSample.UseVisualStyleBackColor = true;
            // 
            // ButtonConfigure
            // 
            this.ButtonConfigure.Location = new System.Drawing.Point(222, 222);
            this.ButtonConfigure.Name = "ButtonConfigure";
            this.ButtonConfigure.Size = new System.Drawing.Size(176, 42);
            this.ButtonConfigure.TabIndex = 2;
            this.ButtonConfigure.Text = "Настроить...";
            this.ButtonConfigure.UseVisualStyleBackColor = true;
            this.ButtonConfigure.Click += new System.EventHandler(this.ButtonConfigure_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 315);
            this.Controls.Add(this.ButtonConfigure);
            this.Controls.Add(this.ButtonSample);
            this.Controls.Add(this.LabelCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2 — вариант 1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
