namespace KyrsovaKalendar
{
    partial class DayInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayInfo));
            this.createEventButton = new System.Windows.Forms.Button();
            this.EventComboBox = new System.Windows.Forms.ComboBox();
            this.eventName = new System.Windows.Forms.Label();
            this.eventDate1 = new System.Windows.Forms.Label();
            this.eventDate2 = new System.Windows.Forms.Label();
            this.eventTimeStart = new System.Windows.Forms.Label();
            this.eventTimeLength = new System.Windows.Forms.Label();
            this.eventCost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tools_55 = new System.Windows.Forms.Label();
            this.goal_55 = new System.Windows.Forms.Label();
            this.author_22 = new System.Windows.Forms.Label();
            this.info_4 = new System.Windows.Forms.Label();
            this.location_3 = new System.Windows.Forms.Label();
            this.limit_8 = new System.Windows.Forms.Label();
            this.cost_7 = new System.Windows.Forms.Label();
            this.time_6 = new System.Windows.Forms.Label();
            this.start_5 = new System.Windows.Forms.Label();
            this.date_2 = new System.Windows.Forms.Label();
            this.name_1 = new System.Windows.Forms.Label();
            this.eventAuthor = new System.Windows.Forms.Label();
            this.eventLocation = new System.Windows.Forms.Label();
            this.eventGoal = new System.Windows.Forms.RichTextBox();
            this.eventInfo = new System.Windows.Forms.RichTextBox();
            this.eventLimit = new System.Windows.Forms.RichTextBox();
            this.eventTools = new System.Windows.Forms.RichTextBox();
            this.eventLink = new System.Windows.Forms.TextBox();
            this.link_9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createEventButton
            // 
            this.createEventButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createEventButton.BackgroundImage")));
            this.createEventButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createEventButton.Font = new System.Drawing.Font("Microsoft YaHei", 22.5F);
            this.createEventButton.ForeColor = System.Drawing.Color.Green;
            this.createEventButton.Location = new System.Drawing.Point(1007, 12);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(50, 50);
            this.createEventButton.TabIndex = 13;
            this.createEventButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createEventButton.UseVisualStyleBackColor = true;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // EventComboBox
            // 
            this.EventComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EventComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventComboBox.FormattingEnabled = true;
            this.EventComboBox.Location = new System.Drawing.Point(12, 12);
            this.EventComboBox.Name = "EventComboBox";
            this.EventComboBox.Size = new System.Drawing.Size(121, 24);
            this.EventComboBox.TabIndex = 14;
            this.EventComboBox.SelectedIndexChanged += new System.EventHandler(this.EventComboBox_SelectedIndexChanged);
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.eventName.Location = new System.Drawing.Point(390, 104);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(13, 17);
            this.eventName.TabIndex = 33;
            this.eventName.Text = "-";
            this.eventName.Visible = false;
            // 
            // eventDate1
            // 
            this.eventDate1.AutoSize = true;
            this.eventDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eventDate1.Location = new System.Drawing.Point(390, 167);
            this.eventDate1.Name = "eventDate1";
            this.eventDate1.Size = new System.Drawing.Size(11, 15);
            this.eventDate1.TabIndex = 34;
            this.eventDate1.Text = "-";
            this.eventDate1.Visible = false;
            // 
            // eventDate2
            // 
            this.eventDate2.AutoSize = true;
            this.eventDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eventDate2.Location = new System.Drawing.Point(514, 167);
            this.eventDate2.Name = "eventDate2";
            this.eventDate2.Size = new System.Drawing.Size(11, 15);
            this.eventDate2.TabIndex = 35;
            this.eventDate2.Text = "-";
            this.eventDate2.Visible = false;
            // 
            // eventTimeStart
            // 
            this.eventTimeStart.AutoSize = true;
            this.eventTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eventTimeStart.Location = new System.Drawing.Point(390, 505);
            this.eventTimeStart.Name = "eventTimeStart";
            this.eventTimeStart.Size = new System.Drawing.Size(11, 15);
            this.eventTimeStart.TabIndex = 36;
            this.eventTimeStart.Text = "-";
            this.eventTimeStart.Visible = false;
            // 
            // eventTimeLength
            // 
            this.eventTimeLength.AutoSize = true;
            this.eventTimeLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eventTimeLength.Location = new System.Drawing.Point(390, 544);
            this.eventTimeLength.Name = "eventTimeLength";
            this.eventTimeLength.Size = new System.Drawing.Size(11, 15);
            this.eventTimeLength.TabIndex = 37;
            this.eventTimeLength.Text = "-";
            this.eventTimeLength.Visible = false;
            // 
            // eventCost
            // 
            this.eventCost.AutoSize = true;
            this.eventCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eventCost.Location = new System.Drawing.Point(390, 584);
            this.eventCost.Name = "eventCost";
            this.eventCost.Size = new System.Drawing.Size(11, 15);
            this.eventCost.TabIndex = 38;
            this.eventCost.Text = "-";
            this.eventCost.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 22.5F);
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(1007, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 39;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChangeEvent_Click);
            // 
            // tools_55
            // 
            this.tools_55.AutoSize = true;
            this.tools_55.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.tools_55.Location = new System.Drawing.Point(293, 285);
            this.tools_55.Name = "tools_55";
            this.tools_55.Size = new System.Drawing.Size(92, 19);
            this.tools_55.TabIndex = 50;
            this.tools_55.Text = "Обладнання:";
            this.tools_55.Visible = false;
            // 
            // goal_55
            // 
            this.goal_55.AutoSize = true;
            this.goal_55.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.goal_55.Location = new System.Drawing.Point(339, 229);
            this.goal_55.Name = "goal_55";
            this.goal_55.Size = new System.Drawing.Size(45, 19);
            this.goal_55.TabIndex = 49;
            this.goal_55.Text = "Мета:";
            this.goal_55.Visible = false;
            // 
            // author_22
            // 
            this.author_22.AutoSize = true;
            this.author_22.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.author_22.Location = new System.Drawing.Point(333, 133);
            this.author_22.Name = "author_22";
            this.author_22.Size = new System.Drawing.Size(51, 19);
            this.author_22.TabIndex = 48;
            this.author_22.Text = "Автор:";
            this.author_22.Visible = false;
            // 
            // info_4
            // 
            this.info_4.AutoSize = true;
            this.info_4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.info_4.Location = new System.Drawing.Point(248, 351);
            this.info_4.Name = "info_4";
            this.info_4.Size = new System.Drawing.Size(137, 19);
            this.info_4.TabIndex = 47;
            this.info_4.Text = "Програма та ведучі:";
            this.info_4.Visible = false;
            // 
            // location_3
            // 
            this.location_3.AutoSize = true;
            this.location_3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.location_3.Location = new System.Drawing.Point(252, 195);
            this.location_3.Name = "location_3";
            this.location_3.Size = new System.Drawing.Size(132, 19);
            this.location_3.TabIndex = 46;
            this.location_3.Text = "Місце проведення:";
            this.location_3.Visible = false;
            // 
            // limit_8
            // 
            this.limit_8.AutoSize = true;
            this.limit_8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.limit_8.Location = new System.Drawing.Point(295, 623);
            this.limit_8.Name = "limit_8";
            this.limit_8.Size = new System.Drawing.Size(89, 19);
            this.limit_8.TabIndex = 45;
            this.limit_8.Text = "Обмеження:";
            this.limit_8.Visible = false;
            // 
            // cost_7
            // 
            this.cost_7.AutoSize = true;
            this.cost_7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.cost_7.Location = new System.Drawing.Point(273, 578);
            this.cost_7.Name = "cost_7";
            this.cost_7.Size = new System.Drawing.Size(111, 19);
            this.cost_7.TabIndex = 44;
            this.cost_7.Text = "Вартість квитка:";
            this.cost_7.Visible = false;
            // 
            // time_6
            // 
            this.time_6.AutoSize = true;
            this.time_6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.time_6.Location = new System.Drawing.Point(193, 538);
            this.time_6.Name = "time_6";
            this.time_6.Size = new System.Drawing.Size(192, 19);
            this.time_6.TabIndex = 43;
            this.time_6.Text = "Орієнтовна тривалість події:";
            this.time_6.Visible = false;
            // 
            // start_5
            // 
            this.start_5.AutoSize = true;
            this.start_5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.start_5.Location = new System.Drawing.Point(260, 499);
            this.start_5.Name = "start_5";
            this.start_5.Size = new System.Drawing.Size(124, 19);
            this.start_5.TabIndex = 42;
            this.start_5.Text = "Час початку події:";
            this.start_5.Visible = false;
            // 
            // date_2
            // 
            this.date_2.AutoSize = true;
            this.date_2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.date_2.Location = new System.Drawing.Point(262, 167);
            this.date_2.Name = "date_2";
            this.date_2.Size = new System.Drawing.Size(123, 19);
            this.date_2.TabIndex = 41;
            this.date_2.Text = "Дата проведення:";
            this.date_2.Visible = false;
            // 
            // name_1
            // 
            this.name_1.AutoSize = true;
            this.name_1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.name_1.Location = new System.Drawing.Point(150, 100);
            this.name_1.Name = "name_1";
            this.name_1.Size = new System.Drawing.Size(234, 19);
            this.name_1.TabIndex = 40;
            this.name_1.Text = "Назва культурно-масового заходу:";
            this.name_1.Visible = false;
            // 
            // eventAuthor
            // 
            this.eventAuthor.AutoSize = true;
            this.eventAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eventAuthor.Location = new System.Drawing.Point(390, 137);
            this.eventAuthor.Name = "eventAuthor";
            this.eventAuthor.Size = new System.Drawing.Size(11, 15);
            this.eventAuthor.TabIndex = 51;
            this.eventAuthor.Text = "-";
            this.eventAuthor.Visible = false;
            // 
            // eventLocation
            // 
            this.eventLocation.AutoSize = true;
            this.eventLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eventLocation.Location = new System.Drawing.Point(390, 201);
            this.eventLocation.Name = "eventLocation";
            this.eventLocation.Size = new System.Drawing.Size(11, 15);
            this.eventLocation.TabIndex = 52;
            this.eventLocation.Text = "-";
            this.eventLocation.Visible = false;
            // 
            // eventGoal
            // 
            this.eventGoal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventGoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventGoal.Enabled = false;
            this.eventGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eventGoal.Location = new System.Drawing.Point(393, 231);
            this.eventGoal.Name = "eventGoal";
            this.eventGoal.Size = new System.Drawing.Size(430, 50);
            this.eventGoal.TabIndex = 53;
            this.eventGoal.Text = "";
            this.eventGoal.Visible = false;
            // 
            // eventInfo
            // 
            this.eventInfo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventInfo.Enabled = false;
            this.eventInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eventInfo.Location = new System.Drawing.Point(393, 353);
            this.eventInfo.Name = "eventInfo";
            this.eventInfo.Size = new System.Drawing.Size(430, 120);
            this.eventInfo.TabIndex = 55;
            this.eventInfo.Text = "";
            this.eventInfo.Visible = false;
            // 
            // eventLimit
            // 
            this.eventLimit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventLimit.Enabled = false;
            this.eventLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eventLimit.Location = new System.Drawing.Point(393, 625);
            this.eventLimit.Name = "eventLimit";
            this.eventLimit.Size = new System.Drawing.Size(373, 80);
            this.eventLimit.TabIndex = 56;
            this.eventLimit.Text = "";
            this.eventLimit.Visible = false;
            // 
            // eventTools
            // 
            this.eventTools.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventTools.Enabled = false;
            this.eventTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eventTools.Location = new System.Drawing.Point(393, 287);
            this.eventTools.Name = "eventTools";
            this.eventTools.Size = new System.Drawing.Size(430, 50);
            this.eventTools.TabIndex = 54;
            this.eventTools.Text = "";
            this.eventTools.Visible = false;
            // 
            // eventLink
            // 
            this.eventLink.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eventLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventLink.Location = new System.Drawing.Point(247, 16);
            this.eventLink.Name = "eventLink";
            this.eventLink.Size = new System.Drawing.Size(450, 21);
            this.eventLink.TabIndex = 58;
            this.eventLink.Visible = false;
            // 
            // link_9
            // 
            this.link_9.AutoSize = true;
            this.link_9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.link_9.Location = new System.Drawing.Point(188, 16);
            this.link_9.Name = "link_9";
            this.link_9.Size = new System.Drawing.Size(42, 19);
            this.link_9.TabIndex = 57;
            this.link_9.Text = "Сайт:";
            this.link_9.Visible = false;
            // 
            // DayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1064, 985);
            this.Controls.Add(this.eventLink);
            this.Controls.Add(this.link_9);
            this.Controls.Add(this.eventLimit);
            this.Controls.Add(this.eventInfo);
            this.Controls.Add(this.eventTools);
            this.Controls.Add(this.eventGoal);
            this.Controls.Add(this.eventLocation);
            this.Controls.Add(this.eventAuthor);
            this.Controls.Add(this.tools_55);
            this.Controls.Add(this.goal_55);
            this.Controls.Add(this.author_22);
            this.Controls.Add(this.info_4);
            this.Controls.Add(this.location_3);
            this.Controls.Add(this.limit_8);
            this.Controls.Add(this.cost_7);
            this.Controls.Add(this.time_6);
            this.Controls.Add(this.start_5);
            this.Controls.Add(this.date_2);
            this.Controls.Add(this.name_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eventCost);
            this.Controls.Add(this.eventTimeLength);
            this.Controls.Add(this.eventTimeStart);
            this.Controls.Add(this.eventDate2);
            this.Controls.Add(this.eventDate1);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.EventComboBox);
            this.Controls.Add(this.createEventButton);
            this.Name = "DayInfo";
            this.Text = "DayInfo";
            this.Load += new System.EventHandler(this.DayInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.ComboBox EventComboBox;
        private System.Windows.Forms.Label eventName;
        private System.Windows.Forms.Label eventDate1;
        private System.Windows.Forms.Label eventDate2;
        private System.Windows.Forms.Label eventTimeStart;
        private System.Windows.Forms.Label eventTimeLength;
        private System.Windows.Forms.Label eventCost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tools_55;
        private System.Windows.Forms.Label goal_55;
        private System.Windows.Forms.Label author_22;
        private System.Windows.Forms.Label info_4;
        private System.Windows.Forms.Label location_3;
        private System.Windows.Forms.Label limit_8;
        private System.Windows.Forms.Label cost_7;
        private System.Windows.Forms.Label time_6;
        private System.Windows.Forms.Label start_5;
        private System.Windows.Forms.Label date_2;
        private System.Windows.Forms.Label name_1;
        private System.Windows.Forms.Label eventAuthor;
        private System.Windows.Forms.Label eventLocation;
        private System.Windows.Forms.RichTextBox eventGoal;
        private System.Windows.Forms.RichTextBox eventInfo;
        private System.Windows.Forms.RichTextBox eventLimit;
        private System.Windows.Forms.RichTextBox eventTools;
        private System.Windows.Forms.TextBox eventLink;
        private System.Windows.Forms.Label link_9;
    }
}