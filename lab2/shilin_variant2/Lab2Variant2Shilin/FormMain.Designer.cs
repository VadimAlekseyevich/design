namespace Lab2Variant2Shilin
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label LabelCaption;
        private System.Windows.Forms.Label LabelSample;
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
            this.LabelSample = new System.Windows.Forms.Label();
            this.ButtonConfigure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelCaption
            // 
            this.LabelCaption.AutoSize = true;
            this.LabelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCaption.Location = new System.Drawing.Point(179, 39);
            this.LabelCaption.Name = "LabelCaption";
            this.LabelCaption.Size = new System.Drawing.Size(261, 18);
            this.LabelCaption.TabIndex = 0;
            this.LabelCaption.Text = "Настраиваемый компонент Label";
            // 
            // LabelSample
            // 
            this.LabelSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSample.Location = new System.Drawing.Point(160, 92);
            this.LabelSample.Name = "LabelSample";
            this.LabelSample.Size = new System.Drawing.Size(300, 92);
            this.LabelSample.TabIndex = 1;
            this.LabelSample.Text = "Пример метки";
            this.LabelSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonConfigure
            // 
            this.ButtonConfigure.Location = new System.Drawing.Point(222, 224);
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
            this.Controls.Add(this.LabelSample);
            this.Controls.Add(this.LabelCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2 — вариант 2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
