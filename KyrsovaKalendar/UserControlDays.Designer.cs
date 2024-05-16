namespace KyrsovaKalendar
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.BackColor = System.Drawing.Color.Gray;
            this.labelDays.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDays.ForeColor = System.Drawing.Color.White;
            this.labelDays.Location = new System.Drawing.Point(100, 10);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(24, 26);
            this.labelDays.TabIndex = 0;
            this.labelDays.Text = "1";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.labelDays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(140, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDays;
    }
}
