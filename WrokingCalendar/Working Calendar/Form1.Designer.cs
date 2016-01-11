namespace Working_Calendar
{
    partial class Form1
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
            this.firstNamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.firstName0 = new System.Windows.Forms.TextBox();
            this.addWorker = new System.Windows.Forms.Button();
            this.lastNamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lastName0 = new System.Windows.Forms.TextBox();
            this.salaryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.salary0 = new System.Windows.Forms.TextBox();
            this.editPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.disableEdditing = new System.Windows.Forms.CheckBox();
            this.firstNamePanel.SuspendLayout();
            this.lastNamePanel.SuspendLayout();
            this.salaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNamePanel
            // 
            this.firstNamePanel.AutoScroll = true;
            this.firstNamePanel.AutoSize = true;
            this.firstNamePanel.BackColor = System.Drawing.Color.Transparent;
            this.firstNamePanel.Controls.Add(this.firstName0);
            this.firstNamePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.firstNamePanel.Location = new System.Drawing.Point(13, 42);
            this.firstNamePanel.Name = "firstNamePanel";
            this.firstNamePanel.Size = new System.Drawing.Size(107, 252);
            this.firstNamePanel.TabIndex = 0;
            // 
            // firstName0
            // 
            this.firstName0.ForeColor = System.Drawing.SystemColors.GrayText;
            this.firstName0.Location = new System.Drawing.Point(3, 3);
            this.firstName0.Name = "firstName0";
            this.firstName0.Size = new System.Drawing.Size(100, 20);
            this.firstName0.TabIndex = 0;
            this.firstName0.Text = "First Name";
            this.firstName0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstName0.Enter += new System.EventHandler(this.firstName0_Enter);
            this.firstName0.Leave += new System.EventHandler(this.firstName0_Leave);
            // 
            // addWorker
            // 
            this.addWorker.BackColor = System.Drawing.Color.LightGreen;
            this.addWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addWorker.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addWorker.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addWorker.Location = new System.Drawing.Point(13, 13);
            this.addWorker.Name = "addWorker";
            this.addWorker.Size = new System.Drawing.Size(107, 25);
            this.addWorker.TabIndex = 1;
            this.addWorker.Text = "Add Worker";
            this.addWorker.UseVisualStyleBackColor = false;
            this.addWorker.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastNamePanel
            // 
            this.lastNamePanel.AutoScroll = true;
            this.lastNamePanel.AutoSize = true;
            this.lastNamePanel.BackColor = System.Drawing.Color.Transparent;
            this.lastNamePanel.Controls.Add(this.lastName0);
            this.lastNamePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lastNamePanel.Location = new System.Drawing.Point(126, 42);
            this.lastNamePanel.Name = "lastNamePanel";
            this.lastNamePanel.Size = new System.Drawing.Size(107, 252);
            this.lastNamePanel.TabIndex = 1;
            // 
            // lastName0
            // 
            this.lastName0.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lastName0.Location = new System.Drawing.Point(3, 3);
            this.lastName0.Name = "lastName0";
            this.lastName0.Size = new System.Drawing.Size(100, 20);
            this.lastName0.TabIndex = 0;
            this.lastName0.Text = "Last Name";
            this.lastName0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastName0.Enter += new System.EventHandler(this.lastName0_Enter);
            this.lastName0.Leave += new System.EventHandler(this.lastName0_Leave);
            // 
            // salaryPanel
            // 
            this.salaryPanel.AutoScroll = true;
            this.salaryPanel.AutoSize = true;
            this.salaryPanel.BackColor = System.Drawing.Color.Transparent;
            this.salaryPanel.Controls.Add(this.salary0);
            this.salaryPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.salaryPanel.Location = new System.Drawing.Point(239, 42);
            this.salaryPanel.Name = "salaryPanel";
            this.salaryPanel.Size = new System.Drawing.Size(107, 252);
            this.salaryPanel.TabIndex = 1;
            // 
            // salary0
            // 
            this.salary0.ForeColor = System.Drawing.SystemColors.GrayText;
            this.salary0.Location = new System.Drawing.Point(3, 3);
            this.salary0.Name = "salary0";
            this.salary0.Size = new System.Drawing.Size(100, 20);
            this.salary0.TabIndex = 0;
            this.salary0.Text = "Salary";
            this.salary0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salary0.Enter += new System.EventHandler(this.salary0_Enter);
            this.salary0.Leave += new System.EventHandler(this.salary0_Leave);
            // 
            // editPanel
            // 
            this.editPanel.AutoScroll = true;
            this.editPanel.AutoSize = true;
            this.editPanel.BackColor = System.Drawing.Color.Transparent;
            this.editPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.editPanel.Location = new System.Drawing.Point(352, 42);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(106, 252);
            this.editPanel.TabIndex = 2;
            // 
            // disableEdditing
            // 
            this.disableEdditing.AutoSize = true;
            this.disableEdditing.Location = new System.Drawing.Point(352, 47);
            this.disableEdditing.Name = "disableEdditing";
            this.disableEdditing.Size = new System.Drawing.Size(100, 17);
            this.disableEdditing.TabIndex = 0;
            this.disableEdditing.Text = "Enable Edditing";
            this.disableEdditing.UseVisualStyleBackColor = true;
            this.disableEdditing.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Working_Calendar.Properties.Resources.technology_background_design_work_34969216;
            this.ClientSize = new System.Drawing.Size(463, 299);
            this.Controls.Add(this.disableEdditing);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.addWorker);
            this.Controls.Add(this.salaryPanel);
            this.Controls.Add(this.lastNamePanel);
            this.Controls.Add(this.firstNamePanel);
            this.Name = "Form1";
            this.Text = "Worker\'s callendar";
            this.firstNamePanel.ResumeLayout(false);
            this.firstNamePanel.PerformLayout();
            this.lastNamePanel.ResumeLayout(false);
            this.lastNamePanel.PerformLayout();
            this.salaryPanel.ResumeLayout(false);
            this.salaryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel firstNamePanel;
        private System.Windows.Forms.TextBox firstName0;
        private System.Windows.Forms.Button addWorker;
        private System.Windows.Forms.FlowLayoutPanel lastNamePanel;
        private System.Windows.Forms.TextBox lastName0;
        private System.Windows.Forms.FlowLayoutPanel salaryPanel;
        private System.Windows.Forms.TextBox salary0;
        private System.Windows.Forms.FlowLayoutPanel editPanel;
        private System.Windows.Forms.CheckBox disableEdditing;
    }
}

