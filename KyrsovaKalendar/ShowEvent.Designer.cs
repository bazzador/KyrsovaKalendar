namespace KyrsovaKalendar
{
    partial class ShowEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowEventForm));
            this.eventsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.exitProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventsPanel
            // 
            this.eventsPanel.Location = new System.Drawing.Point(0, 12);
            this.eventsPanel.Name = "eventsPanel";
            this.eventsPanel.Size = new System.Drawing.Size(1064, 377);
            this.eventsPanel.TabIndex = 0;
            // 
            // exitProgram
            // 
            this.exitProgram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitProgram.BackgroundImage")));
            this.exitProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitProgram.Location = new System.Drawing.Point(1061, 0);
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(40, 40);
            this.exitProgram.TabIndex = 61;
            this.exitProgram.UseVisualStyleBackColor = true;
            this.exitProgram.Click += new System.EventHandler(this.exitProgram_Click);
            // 
            // ShowEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1098, 394);
            this.Controls.Add(this.exitProgram);
            this.Controls.Add(this.eventsPanel);
            this.Name = "ShowEventForm";
            this.Text = "ShowEvent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel eventsPanel;
        private System.Windows.Forms.Button exitProgram;
    }
}