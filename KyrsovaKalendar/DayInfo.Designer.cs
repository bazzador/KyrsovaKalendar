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
            this.eventLimit = new System.Windows.Forms.RichTextBox();
            this.eventInfo = new System.Windows.Forms.RichTextBox();
            this.eventName = new System.Windows.Forms.Label();
            this.eventDate1 = new System.Windows.Forms.Label();
            this.eventDate2 = new System.Windows.Forms.Label();
            this.eventTimeStart = new System.Windows.Forms.Label();
            this.eventTimeLength = new System.Windows.Forms.Label();
            this.eventCost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createEventButton
            // 
            this.createEventButton.Font = new System.Drawing.Font("Microsoft YaHei", 22.5F);
            this.createEventButton.ForeColor = System.Drawing.Color.Green;
            this.createEventButton.Location = new System.Drawing.Point(743, 12);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(45, 45);
            this.createEventButton.TabIndex = 13;
            this.createEventButton.Text = "+";
            this.createEventButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createEventButton.UseVisualStyleBackColor = true;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // EventComboBox
            // 
            this.EventComboBox.FormattingEnabled = true;
            this.EventComboBox.Location = new System.Drawing.Point(42, 33);
            this.EventComboBox.Name = "EventComboBox";
            this.EventComboBox.Size = new System.Drawing.Size(121, 21);
            this.EventComboBox.TabIndex = 14;
            this.EventComboBox.SelectedIndexChanged += new System.EventHandler(this.EventComboBox_SelectedIndexChanged);
            // 
            // eventLimit
            // 
            this.eventLimit.Location = new System.Drawing.Point(244, 356);
            this.eventLimit.Name = "eventLimit";
            this.eventLimit.ReadOnly = true;
            this.eventLimit.Size = new System.Drawing.Size(373, 82);
            this.eventLimit.TabIndex = 30;
            this.eventLimit.Text = "";
            // 
            // eventInfo
            // 
            this.eventInfo.Location = new System.Drawing.Point(244, 129);
            this.eventInfo.Name = "eventInfo";
            this.eventInfo.ReadOnly = true;
            this.eventInfo.Size = new System.Drawing.Size(431, 118);
            this.eventInfo.TabIndex = 28;
            this.eventInfo.Text = "";
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Location = new System.Drawing.Point(244, 69);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(10, 13);
            this.eventName.TabIndex = 33;
            this.eventName.Text = "-";
            // 
            // eventDate1
            // 
            this.eventDate1.AutoSize = true;
            this.eventDate1.Location = new System.Drawing.Point(244, 100);
            this.eventDate1.Name = "eventDate1";
            this.eventDate1.Size = new System.Drawing.Size(10, 13);
            this.eventDate1.TabIndex = 34;
            this.eventDate1.Text = "-";
            // 
            // eventDate2
            // 
            this.eventDate2.AutoSize = true;
            this.eventDate2.Location = new System.Drawing.Point(388, 99);
            this.eventDate2.Name = "eventDate2";
            this.eventDate2.Size = new System.Drawing.Size(10, 13);
            this.eventDate2.TabIndex = 35;
            this.eventDate2.Text = "-";
            // 
            // eventTimeStart
            // 
            this.eventTimeStart.AutoSize = true;
            this.eventTimeStart.Location = new System.Drawing.Point(244, 269);
            this.eventTimeStart.Name = "eventTimeStart";
            this.eventTimeStart.Size = new System.Drawing.Size(10, 13);
            this.eventTimeStart.TabIndex = 36;
            this.eventTimeStart.Text = "-";
            // 
            // eventTimeLength
            // 
            this.eventTimeLength.AutoSize = true;
            this.eventTimeLength.Location = new System.Drawing.Point(244, 299);
            this.eventTimeLength.Name = "eventTimeLength";
            this.eventTimeLength.Size = new System.Drawing.Size(10, 13);
            this.eventTimeLength.TabIndex = 37;
            this.eventTimeLength.Text = "-";
            // 
            // eventCost
            // 
            this.eventCost.AutoSize = true;
            this.eventCost.Location = new System.Drawing.Point(244, 329);
            this.eventCost.Name = "eventCost";
            this.eventCost.Size = new System.Drawing.Size(10, 13);
            this.eventCost.TabIndex = 38;
            this.eventCost.Text = "-";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 22.5F);
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(743, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 39;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChangeEvent_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label8.Location = new System.Drawing.Point(153, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Обмеження:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label9.Location = new System.Drawing.Point(134, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Вартість квитка:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label10.Location = new System.Drawing.Point(65, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Орієнтовна тривалість події:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label11.Location = new System.Drawing.Point(95, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Інформація про подію:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label12.Location = new System.Drawing.Point(121, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 42;
            this.label12.Text = "Час початку події:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label13.Location = new System.Drawing.Point(124, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 41;
            this.label13.Text = "Дата проведення:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label14.Location = new System.Drawing.Point(30, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "Назва культурно-масового заходу:";
            // 
            // DayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eventCost);
            this.Controls.Add(this.eventTimeLength);
            this.Controls.Add(this.eventTimeStart);
            this.Controls.Add(this.eventDate2);
            this.Controls.Add(this.eventDate1);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.eventLimit);
            this.Controls.Add(this.eventInfo);
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
        private System.Windows.Forms.RichTextBox eventLimit;
        private System.Windows.Forms.RichTextBox eventInfo;
        private System.Windows.Forms.Label eventName;
        private System.Windows.Forms.Label eventDate1;
        private System.Windows.Forms.Label eventDate2;
        private System.Windows.Forms.Label eventTimeStart;
        private System.Windows.Forms.Label eventTimeLength;
        private System.Windows.Forms.Label eventCost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}