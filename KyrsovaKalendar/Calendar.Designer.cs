namespace KyrsovaKalendar
{
    partial class Calendar
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.dayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.EventShowButton = new System.Windows.Forms.Button();
            this.FindEventTextBox = new System.Windows.Forms.TextBox();
            this.FindEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayPanel
            // 
            this.dayPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dayPanel.Location = new System.Drawing.Point(24, 243);
            this.dayPanel.Name = "dayPanel";
            this.dayPanel.Size = new System.Drawing.Size(1024, 480);
            this.dayPanel.TabIndex = 0;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.nextButton.Location = new System.Drawing.Point(988, 728);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(60, 60);
            this.nextButton.TabIndex = 0;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prevButton.BackgroundImage")));
            this.prevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.prevButton.Location = new System.Drawing.Point(922, 728);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(60, 60);
            this.prevButton.TabIndex = 1;
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Понеділок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(198, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вівторок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(352, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Середа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(500, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Четвер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(637, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "П\'ятниця";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(794, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Субота";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(941, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Неділя";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.Location = new System.Drawing.Point(450, 156);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(173, 35);
            this.date.TabIndex = 9;
            this.date.Text = "РІК МІСЯЦЬ";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventShowButton
            // 
            this.EventShowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EventShowButton.BackgroundImage")));
            this.EventShowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EventShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventShowButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EventShowButton.Location = new System.Drawing.Point(24, 12);
            this.EventShowButton.Name = "EventShowButton";
            this.EventShowButton.Size = new System.Drawing.Size(60, 60);
            this.EventShowButton.TabIndex = 15;
            this.EventShowButton.UseVisualStyleBackColor = true;
            this.EventShowButton.Click += new System.EventHandler(this.buttonEventShow_Click);
            // 
            // FindEventTextBox
            // 
            this.FindEventTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FindEventTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FindEventTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FindEventTextBox.Location = new System.Drawing.Point(283, 34);
            this.FindEventTextBox.Name = "FindEventTextBox";
            this.FindEventTextBox.Size = new System.Drawing.Size(150, 20);
            this.FindEventTextBox.TabIndex = 16;
            // 
            // FindEventButton
            // 
            this.FindEventButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FindEventButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindEventButton.BackgroundImage")));
            this.FindEventButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FindEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindEventButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FindEventButton.Location = new System.Drawing.Point(439, 17);
            this.FindEventButton.Name = "FindEventButton";
            this.FindEventButton.Size = new System.Drawing.Size(50, 50);
            this.FindEventButton.TabIndex = 17;
            this.FindEventButton.UseVisualStyleBackColor = false;
            this.FindEventButton.Click += new System.EventHandler(this.FindEventButton_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1080, 1024);
            this.Controls.Add(this.FindEventButton);
            this.Controls.Add(this.FindEventTextBox);
            this.Controls.Add(this.EventShowButton);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.dayPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel dayPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button EventShowButton;
        private System.Windows.Forms.TextBox FindEventTextBox;
        private System.Windows.Forms.Button FindEventButton;
    }
}

