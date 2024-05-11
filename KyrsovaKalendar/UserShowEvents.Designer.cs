namespace KyrsovaKalendar
{
    partial class UserShowEvents
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
            this.dayOfWeek = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.eventCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayOfWeek
            // 
            this.dayOfWeek.AutoSize = true;
            this.dayOfWeek.Location = new System.Drawing.Point(29, 17);
            this.dayOfWeek.Name = "dayOfWeek";
            this.dayOfWeek.Size = new System.Drawing.Size(35, 13);
            this.dayOfWeek.TabIndex = 0;
            this.dayOfWeek.Text = "label1";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Location = new System.Drawing.Point(29, 51);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(35, 13);
            this.day.TabIndex = 1;
            this.day.Text = "label2";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(29, 97);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(35, 13);
            this.month.TabIndex = 2;
            this.month.Text = "label3";
            // 
            // eventCount
            // 
            this.eventCount.AutoSize = true;
            this.eventCount.Location = new System.Drawing.Point(29, 165);
            this.eventCount.Name = "eventCount";
            this.eventCount.Size = new System.Drawing.Size(35, 13);
            this.eventCount.TabIndex = 3;
            this.eventCount.Text = "label4";
            // 
            // UserShowEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eventCount);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Controls.Add(this.dayOfWeek);
            this.Name = "UserShowEvents";
            this.Size = new System.Drawing.Size(100, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOfWeek;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label eventCount;
    }
}
