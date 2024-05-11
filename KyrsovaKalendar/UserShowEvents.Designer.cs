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
            this.eventList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // eventList
            // 
            this.eventList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventList.FormattingEnabled = true;
            this.eventList.ItemHeight = 16;
            this.eventList.Location = new System.Drawing.Point(3, 152);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(94, 212);
            this.eventList.TabIndex = 3;
            this.eventList.SelectedIndexChanged += new System.EventHandler(this.eventList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "---Події---";
            // 
            // UserShowEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Controls.Add(this.dayOfWeek);
            this.Name = "UserShowEvents";
            this.Size = new System.Drawing.Size(100, 370);
            this.Click += new System.EventHandler(this.UserShowEvents_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOfWeek;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.ListBox eventList;
        private System.Windows.Forms.Label label1;
    }
}
