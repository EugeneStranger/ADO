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
            this.clbWeek = new System.Windows.Forms.CheckedListBox();
            this.btnGeneration = new System.Windows.Forms.Button();
            this.lblLearningDaysCode = new System.Windows.Forms.Label();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Location = new System.Drawing.Point(3, 41);
            this.cbDirection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(392, 21);
            this.cbDirection.TabIndex = 0;
            this.cbDirection.Text = "Выберите направление обучения";
            // 
            // cbLearningForm
            // 
            this.cbLearningForm.FormattingEnabled = true;
            this.cbLearningForm.Location = new System.Drawing.Point(3, 12);
            this.cbLearningForm.Name = "cbLearningForm";
            this.cbLearningForm.Size = new System.Drawing.Size(392, 21);
            this.cbLearningForm.TabIndex = 1;
            this.cbLearningForm.Text = "Выберите форму обучения";
            this.cbLearningForm.SelectedIndexChanged += new System.EventHandler(this.cbLearningForm_SelectedIndexChanged);
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(3, 68);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(392, 21);
            this.cbTime.TabIndex = 2;
            this.cbTime.Text = "Выберите время обучения";
            // 
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(3, 158);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(392, 20);
            this.tbGroupName.TabIndex = 3;
            this.tbGroupName.Text = "Название группы";
            // 
            // clbWeek
            // 
            this.clbWeek.CheckOnClick = true;
            this.clbWeek.ColumnWidth = 55;
            this.clbWeek.FormattingEnabled = true;
            this.clbWeek.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
            this.clbWeek.Location = new System.Drawing.Point(3, 109);
            this.clbWeek.MultiColumn = true;
            this.clbWeek.Name = "clbWeek";
            this.clbWeek.Size = new System.Drawing.Size(392, 19);
            this.clbWeek.TabIndex = 4;
            this.clbWeek.SelectedIndexChanged += new System.EventHandler(this.clbWeek_SelectedIndexChanged);
            // 
            // btnGeneration
            // 
            this.btnGeneration.Location = new System.Drawing.Point(281, 202);
            this.btnGeneration.Name = "btnGeneration";
            this.btnGeneration.Size = new System.Drawing.Size(114, 23);
            this.btnGeneration.TabIndex = 5;
            this.btnGeneration.Text = "Generate";
            this.btnGeneration.UseVisualStyleBackColor = true;
            this.btnGeneration.Click += new System.EventHandler(this.btnGeneration_Click);
            // 
            // lblLearningDaysCode
            // 
            this.lblLearningDaysCode.AutoSize = true;
            this.lblLearningDaysCode.Location = new System.Drawing.Point(0, 142);
            this.lblLearningDaysCode.Name = "lblLearningDaysCode";
            this.lblLearningDaysCode.Size = new System.Drawing.Size(89, 13);
            this.lblLearningDaysCode.TabIndex = 6;
            this.lblLearningDaysCode.Text = "Дни обучения";
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Location = new System.Drawing.Point(3, 202);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(113, 23);
            this.btnCreateGroup.TabIndex = 7;
            this.btnCreateGroup.Text = "Создать группу";
            this.btnCreateGroup.UseVisualStyleBackColor = true;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 237);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.lblLearningDaysCode);
            this.Controls.Add(this.btnGeneration);
            this.Controls.Add(this.clbWeek);
            this.Controls.Add(this.tbGroupName);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.cbLearningForm);
            this.Controls.Add(this.cbDirection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.ComboBox cbLearningForm;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.CheckedListBox clbWeek;
        private System.Windows.Forms.Button btnGeneration;
        private System.Windows.Forms.Label lblLearningDaysCode;
        private System.Windows.Forms.Button btnCreateGroup;
    }
}