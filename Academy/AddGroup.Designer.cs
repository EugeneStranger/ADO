namespace Academy
{
    partial class AddGroup
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
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.cbLearningForm = new System.Windows.Forms.ComboBox();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.groupBoxDaysOfWeek = new System.Windows.Forms.GroupBox();
            this.cbMon = new System.Windows.Forms.CheckBox();
            this.cbTew = new System.Windows.Forms.CheckBox();
            this.groupBoxDaysOfWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Location = new System.Drawing.Point(3, 12);
            this.cbDirection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(526, 21);
            this.cbDirection.TabIndex = 0;
            this.cbDirection.Text = "Направление обучения";
            // 
            // cbLearningForm
            // 
            this.cbLearningForm.FormattingEnabled = true;
            this.cbLearningForm.Location = new System.Drawing.Point(3, 40);
            this.cbLearningForm.Name = "cbLearningForm";
            this.cbLearningForm.Size = new System.Drawing.Size(526, 21);
            this.cbLearningForm.TabIndex = 1;
            this.cbLearningForm.Text = "Форма обучения";
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(3, 68);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(526, 21);
            this.cbTime.TabIndex = 2;
            this.cbTime.Text = "Время обучения";
            // 
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(3, 152);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(526, 20);
            this.tbGroupName.TabIndex = 3;
            this.tbGroupName.Text = "Название группы";
            // 
            // groupBoxDaysOfWeek
            // 
            this.groupBoxDaysOfWeek.Controls.Add(this.cbTew);
            this.groupBoxDaysOfWeek.Controls.Add(this.cbMon);
            this.groupBoxDaysOfWeek.Location = new System.Drawing.Point(3, 95);
            this.groupBoxDaysOfWeek.Name = "groupBoxDaysOfWeek";
            this.groupBoxDaysOfWeek.Size = new System.Drawing.Size(526, 50);
            this.groupBoxDaysOfWeek.TabIndex = 4;
            this.groupBoxDaysOfWeek.TabStop = false;
            this.groupBoxDaysOfWeek.Text = "Дни обучения";
            // 
            // cbMon
            // 
            this.cbMon.AutoSize = true;
            this.cbMon.Location = new System.Drawing.Point(9, 19);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(42, 17);
            this.cbMon.TabIndex = 0;
            this.cbMon.Text = "Пн";
            this.cbMon.UseVisualStyleBackColor = true;
            // 
            // cbTew
            // 
            this.cbTew.AutoSize = true;
            this.cbTew.Location = new System.Drawing.Point(48, 19);
            this.cbTew.Name = "cbTew";
            this.cbTew.Size = new System.Drawing.Size(40, 17);
            this.cbTew.TabIndex = 1;
            this.cbTew.Text = "Вт";
            this.cbTew.UseVisualStyleBackColor = true;
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 186);
            this.Controls.Add(this.groupBoxDaysOfWeek);
            this.Controls.Add(this.tbGroupName);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.cbLearningForm);
            this.Controls.Add(this.cbDirection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            this.groupBoxDaysOfWeek.ResumeLayout(false);
            this.groupBoxDaysOfWeek.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.ComboBox cbLearningForm;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.GroupBox groupBoxDaysOfWeek;
        private System.Windows.Forms.CheckBox cbMon;
        private System.Windows.Forms.CheckBox cbTew;
    }
}