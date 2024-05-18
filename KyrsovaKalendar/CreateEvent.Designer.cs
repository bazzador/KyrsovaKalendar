namespace KyrsovaKalendar
{
    partial class CreateEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEvent));
            this.name_1 = new System.Windows.Forms.Label();
            this.date_2 = new System.Windows.Forms.Label();
            this.start_5 = new System.Windows.Forms.Label();
            this.time_6 = new System.Windows.Forms.Label();
            this.cost_7 = new System.Windows.Forms.Label();
            this.limit_8 = new System.Windows.Forms.Label();
            this.saveEvent = new System.Windows.Forms.Button();
            this.exitCreateEvent = new System.Windows.Forms.Button();
            this.eventName = new System.Windows.Forms.TextBox();
            this.eventDate1 = new System.Windows.Forms.DateTimePicker();
            this.eventDate2 = new System.Windows.Forms.DateTimePicker();
            this.eventInfo = new System.Windows.Forms.RichTextBox();
            this.eventCost = new System.Windows.Forms.TextBox();
            this.eventLimit = new System.Windows.Forms.RichTextBox();
            this.eventTimeStart = new System.Windows.Forms.DateTimePicker();
            this.eventTimeLength = new System.Windows.Forms.DateTimePicker();
            this.eventLocation = new System.Windows.Forms.TextBox();
            this.location_3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.info_4 = new System.Windows.Forms.Label();
            this.eventAuthor = new System.Windows.Forms.TextBox();
            this.author_22 = new System.Windows.Forms.Label();
            this.goal_55 = new System.Windows.Forms.Label();
            this.eventGoal = new System.Windows.Forms.RichTextBox();
            this.eventTools = new System.Windows.Forms.RichTextBox();
            this.tools_55 = new System.Windows.Forms.Label();
            this.eventLink = new System.Windows.Forms.TextBox();
            this.link_9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_1
            // 
            this.name_1.AutoSize = true;
            this.name_1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_1.Location = new System.Drawing.Point(352, 43);
            this.name_1.Name = "name_1";
            this.name_1.Size = new System.Drawing.Size(234, 19);
            this.name_1.TabIndex = 0;
            this.name_1.Text = "Назва культурно-масового заходу:";
            this.name_1.Visible = false;
            // 
            // date_2
            // 
            this.date_2.AutoSize = true;
            this.date_2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.date_2.Location = new System.Drawing.Point(464, 105);
            this.date_2.Name = "date_2";
            this.date_2.Size = new System.Drawing.Size(123, 19);
            this.date_2.TabIndex = 1;
            this.date_2.Text = "Дата проведення:";
            this.date_2.Visible = false;
            // 
            // start_5
            // 
            this.start_5.AutoSize = true;
            this.start_5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.start_5.Location = new System.Drawing.Point(462, 440);
            this.start_5.Name = "start_5";
            this.start_5.Size = new System.Drawing.Size(124, 19);
            this.start_5.TabIndex = 2;
            this.start_5.Text = "Час початку події:";
            this.start_5.Visible = false;
            // 
            // time_6
            // 
            this.time_6.AutoSize = true;
            this.time_6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.time_6.Location = new System.Drawing.Point(394, 470);
            this.time_6.Name = "time_6";
            this.time_6.Size = new System.Drawing.Size(192, 19);
            this.time_6.TabIndex = 4;
            this.time_6.Text = "Орієнтовна тривалість події:";
            this.time_6.Visible = false;
            // 
            // cost_7
            // 
            this.cost_7.AutoSize = true;
            this.cost_7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.cost_7.Location = new System.Drawing.Point(475, 500);
            this.cost_7.Name = "cost_7";
            this.cost_7.Size = new System.Drawing.Size(111, 19);
            this.cost_7.TabIndex = 5;
            this.cost_7.Text = "Вартість квитка:";
            this.cost_7.Visible = false;
            // 
            // limit_8
            // 
            this.limit_8.AutoSize = true;
            this.limit_8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.limit_8.Location = new System.Drawing.Point(497, 530);
            this.limit_8.Name = "limit_8";
            this.limit_8.Size = new System.Drawing.Size(89, 19);
            this.limit_8.TabIndex = 6;
            this.limit_8.Text = "Обмеження:";
            this.limit_8.Visible = false;
            // 
            // saveEvent
            // 
            this.saveEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveEvent.BackgroundImage")));
            this.saveEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveEvent.Location = new System.Drawing.Point(24, 258);
            this.saveEvent.Name = "saveEvent";
            this.saveEvent.Size = new System.Drawing.Size(60, 60);
            this.saveEvent.TabIndex = 7;
            this.saveEvent.UseVisualStyleBackColor = true;
            this.saveEvent.Click += new System.EventHandler(this.saveEvent_Click);
            // 
            // exitCreateEvent
            // 
            this.exitCreateEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitCreateEvent.BackgroundImage")));
            this.exitCreateEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitCreateEvent.Location = new System.Drawing.Point(112, 258);
            this.exitCreateEvent.Name = "exitCreateEvent";
            this.exitCreateEvent.Size = new System.Drawing.Size(60, 60);
            this.exitCreateEvent.TabIndex = 8;
            this.exitCreateEvent.UseVisualStyleBackColor = true;
            this.exitCreateEvent.Click += new System.EventHandler(this.exitCreateEvent_Click);
            // 
            // eventName
            // 
            this.eventName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventName.Location = new System.Drawing.Point(592, 45);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(450, 21);
            this.eventName.TabIndex = 9;
            this.eventName.Visible = false;
            // 
            // eventDate1
            // 
            this.eventDate1.CalendarTitleForeColor = System.Drawing.SystemColors.ScrollBar;
            this.eventDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventDate1.Location = new System.Drawing.Point(593, 105);
            this.eventDate1.Name = "eventDate1";
            this.eventDate1.Size = new System.Drawing.Size(135, 22);
            this.eventDate1.TabIndex = 10;
            this.eventDate1.Visible = false;
            // 
            // eventDate2
            // 
            this.eventDate2.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.eventDate2.CalendarTitleForeColor = System.Drawing.SystemColors.ScrollBar;
            this.eventDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventDate2.Location = new System.Drawing.Point(742, 105);
            this.eventDate2.Name = "eventDate2";
            this.eventDate2.Size = new System.Drawing.Size(135, 22);
            this.eventDate2.TabIndex = 11;
            this.eventDate2.Visible = false;
            // 
            // eventInfo
            // 
            this.eventInfo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventInfo.Location = new System.Drawing.Point(592, 300);
            this.eventInfo.Name = "eventInfo";
            this.eventInfo.Size = new System.Drawing.Size(430, 120);
            this.eventInfo.TabIndex = 13;
            this.eventInfo.Text = "";
            this.eventInfo.Visible = false;
            // 
            // eventCost
            // 
            this.eventCost.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventCost.Location = new System.Drawing.Point(592, 500);
            this.eventCost.Name = "eventCost";
            this.eventCost.Size = new System.Drawing.Size(122, 21);
            this.eventCost.TabIndex = 14;
            this.eventCost.Visible = false;
            // 
            // eventLimit
            // 
            this.eventLimit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.eventLimit.Location = new System.Drawing.Point(592, 530);
            this.eventLimit.Name = "eventLimit";
            this.eventLimit.Size = new System.Drawing.Size(373, 80);
            this.eventLimit.TabIndex = 15;
            this.eventLimit.Text = "";
            this.eventLimit.Visible = false;
            // 
            // eventTimeStart
            // 
            this.eventTimeStart.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.eventTimeStart.CustomFormat = "HH:mm";
            this.eventTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventTimeStart.Location = new System.Drawing.Point(592, 440);
            this.eventTimeStart.Name = "eventTimeStart";
            this.eventTimeStart.ShowUpDown = true;
            this.eventTimeStart.Size = new System.Drawing.Size(122, 22);
            this.eventTimeStart.TabIndex = 16;
            this.eventTimeStart.Value = new System.DateTime(2024, 5, 5, 15, 56, 37, 0);
            this.eventTimeStart.Visible = false;
            // 
            // eventTimeLength
            // 
            this.eventTimeLength.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.eventTimeLength.CustomFormat = "HH:mm";
            this.eventTimeLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventTimeLength.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventTimeLength.Location = new System.Drawing.Point(592, 470);
            this.eventTimeLength.Name = "eventTimeLength";
            this.eventTimeLength.ShowUpDown = true;
            this.eventTimeLength.Size = new System.Drawing.Size(122, 22);
            this.eventTimeLength.TabIndex = 17;
            this.eventTimeLength.Value = new System.DateTime(2024, 5, 5, 0, 0, 0, 0);
            this.eventTimeLength.Visible = false;
            // 
            // eventLocation
            // 
            this.eventLocation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventLocation.Location = new System.Drawing.Point(592, 135);
            this.eventLocation.Name = "eventLocation";
            this.eventLocation.Size = new System.Drawing.Size(450, 21);
            this.eventLocation.TabIndex = 20;
            this.eventLocation.Visible = false;
            // 
            // location_3
            // 
            this.location_3.AutoSize = true;
            this.location_3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.location_3.Location = new System.Drawing.Point(454, 135);
            this.location_3.Name = "location_3";
            this.location_3.Size = new System.Drawing.Size(132, 19);
            this.location_3.TabIndex = 19;
            this.location_3.Text = "Місце проведення:";
            this.location_3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. Тематичні вечори",
            "2. Вечори запитань і відповідей",
            "3. Вечори-зустрічі",
            "4. Вечори гумору",
            "5. Конкурсно-розважальні програми"});
            this.comboBox1.Location = new System.Drawing.Point(24, 213);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // info_4
            // 
            this.info_4.AutoSize = true;
            this.info_4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.info_4.Location = new System.Drawing.Point(449, 300);
            this.info_4.Name = "info_4";
            this.info_4.Size = new System.Drawing.Size(137, 19);
            this.info_4.TabIndex = 24;
            this.info_4.Text = "Програма та ведучі:";
            this.info_4.Visible = false;
            // 
            // eventAuthor
            // 
            this.eventAuthor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventAuthor.Location = new System.Drawing.Point(593, 76);
            this.eventAuthor.Name = "eventAuthor";
            this.eventAuthor.Size = new System.Drawing.Size(450, 21);
            this.eventAuthor.TabIndex = 26;
            this.eventAuthor.Visible = false;
            // 
            // author_22
            // 
            this.author_22.AutoSize = true;
            this.author_22.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.author_22.Location = new System.Drawing.Point(535, 76);
            this.author_22.Name = "author_22";
            this.author_22.Size = new System.Drawing.Size(51, 19);
            this.author_22.TabIndex = 25;
            this.author_22.Text = "Автор:";
            this.author_22.Visible = false;
            // 
            // goal_55
            // 
            this.goal_55.AutoSize = true;
            this.goal_55.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.goal_55.Location = new System.Drawing.Point(541, 170);
            this.goal_55.Name = "goal_55";
            this.goal_55.Size = new System.Drawing.Size(45, 19);
            this.goal_55.TabIndex = 27;
            this.goal_55.Text = "Мета:";
            this.goal_55.Visible = false;
            // 
            // eventGoal
            // 
            this.eventGoal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventGoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventGoal.Location = new System.Drawing.Point(593, 170);
            this.eventGoal.Name = "eventGoal";
            this.eventGoal.Size = new System.Drawing.Size(430, 50);
            this.eventGoal.TabIndex = 28;
            this.eventGoal.Text = "";
            this.eventGoal.Visible = false;
            // 
            // eventTools
            // 
            this.eventTools.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventTools.Location = new System.Drawing.Point(593, 235);
            this.eventTools.Name = "eventTools";
            this.eventTools.Size = new System.Drawing.Size(430, 50);
            this.eventTools.TabIndex = 30;
            this.eventTools.Text = "";
            this.eventTools.Visible = false;
            // 
            // tools_55
            // 
            this.tools_55.AutoSize = true;
            this.tools_55.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.tools_55.Location = new System.Drawing.Point(495, 235);
            this.tools_55.Name = "tools_55";
            this.tools_55.Size = new System.Drawing.Size(92, 19);
            this.tools_55.TabIndex = 29;
            this.tools_55.Text = "Обладнання:";
            this.tools_55.Visible = false;
            // 
            // eventLink
            // 
            this.eventLink.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.eventLink.Location = new System.Drawing.Point(47, 590);
            this.eventLink.Name = "eventLink";
            this.eventLink.Size = new System.Drawing.Size(450, 22);
            this.eventLink.TabIndex = 32;
            this.eventLink.Visible = false;
            // 
            // link_9
            // 
            this.link_9.AutoSize = true;
            this.link_9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.link_9.Location = new System.Drawing.Point(-1, 590);
            this.link_9.Name = "link_9";
            this.link_9.Size = new System.Drawing.Size(42, 19);
            this.link_9.TabIndex = 31;
            this.link_9.Text = "Сайт:";
            this.link_9.Visible = false;
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1064, 985);
            this.Controls.Add(this.eventLink);
            this.Controls.Add(this.link_9);
            this.Controls.Add(this.eventTools);
            this.Controls.Add(this.tools_55);
            this.Controls.Add(this.eventGoal);
            this.Controls.Add(this.goal_55);
            this.Controls.Add(this.eventAuthor);
            this.Controls.Add(this.author_22);
            this.Controls.Add(this.info_4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.eventLocation);
            this.Controls.Add(this.location_3);
            this.Controls.Add(this.eventTimeLength);
            this.Controls.Add(this.eventTimeStart);
            this.Controls.Add(this.eventLimit);
            this.Controls.Add(this.eventCost);
            this.Controls.Add(this.eventInfo);
            this.Controls.Add(this.eventDate2);
            this.Controls.Add(this.eventDate1);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.exitCreateEvent);
            this.Controls.Add(this.saveEvent);
            this.Controls.Add(this.limit_8);
            this.Controls.Add(this.cost_7);
            this.Controls.Add(this.time_6);
            this.Controls.Add(this.start_5);
            this.Controls.Add(this.date_2);
            this.Controls.Add(this.name_1);
            this.Name = "CreateEvent";
            this.Text = "і";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateEvent_FormClosed);
            this.Load += new System.EventHandler(this.CreateEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_1;
        private System.Windows.Forms.Label date_2;
        private System.Windows.Forms.Label start_5;
        private System.Windows.Forms.Label time_6;
        private System.Windows.Forms.Label cost_7;
        private System.Windows.Forms.Label limit_8;
        private System.Windows.Forms.Button saveEvent;
        private System.Windows.Forms.Button exitCreateEvent;
        private System.Windows.Forms.TextBox eventName;
        private System.Windows.Forms.DateTimePicker eventDate1;
        private System.Windows.Forms.DateTimePicker eventDate2;
        private System.Windows.Forms.RichTextBox eventInfo;
        private System.Windows.Forms.TextBox eventCost;
        private System.Windows.Forms.RichTextBox eventLimit;
        private System.Windows.Forms.DateTimePicker eventTimeStart;
        private System.Windows.Forms.DateTimePicker eventTimeLength;
        private System.Windows.Forms.TextBox eventLocation;
        private System.Windows.Forms.Label location_3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label info_4;
        private System.Windows.Forms.TextBox eventAuthor;
        private System.Windows.Forms.Label author_22;
        private System.Windows.Forms.Label goal_55;
        private System.Windows.Forms.RichTextBox eventGoal;
        private System.Windows.Forms.RichTextBox eventTools;
        private System.Windows.Forms.Label tools_55;
        private System.Windows.Forms.TextBox eventLink;
        private System.Windows.Forms.Label link_9;
    }
}