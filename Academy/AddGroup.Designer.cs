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
            this.lcbWeek = new System.Windows.Forms.CheckedListBox();
            this.btnGeneration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Location = new System.Drawing.Point(3, 41);
            this.cbDirection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(336, 21);
            this.cbDirection.TabIndex = 0;
            this.cbDirection.Text = "Выберите направление обучения";
            // 
            // cbLearningForm
            // 
            this.cbLearningForm.FormattingEnabled = true;
            this.cbLearningForm.Location = new System.Drawing.Point(3, 12);
            this.cbLearningForm.Name = "cbLearningForm";
            this.cbLearningForm.Size = new System.Drawing.Size(336, 21);
            this.cbLearningForm.TabIndex = 1;
            this.cbLearningForm.Text = "Форма обучения";
            this.cbLearningForm.SelectedIndexChanged += new System.EventHandler(this.cbLearningForm_SelectedIndexChanged);
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(3, 68);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(336, 21);
            this.cbTime.TabIndex = 2;
            this.cbTime.Text = "Время обучения";
            // 
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(3, 145);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(336, 20);
            this.tbGroupName.TabIndex = 3;
            this.tbGroupName.Text = "Название группы";
            // 
            // lcbWeek
            // 
            this.lcbWeek.CheckOnClick = true;
            this.lcbWeek.ColumnWidth = 47;
            this.lcbWeek.FormattingEnabled = true;
            this.lcbWeek.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
            this.lcbWeek.Location = new System.Drawing.Point(3, 109);
            this.lcbWeek.MultiColumn = true;
            this.lcbWeek.Name = "lcbWeek";
            this.lcbWeek.Size = new System.Drawing.Size(336, 19);
            this.lcbWeek.TabIndex = 4;
            // 
            // btnGeneration
            // 
            this.btnGeneration.Location = new System.Drawing.Point(225, 173);
            this.btnGeneration.Name = "btnGeneration";
            this.btnGeneration.Size = new System.Drawing.Size(114, 23);
            this.btnGeneration.TabIndex = 5;
            this.btnGeneration.Text = "Generate";
            this.btnGeneration.UseVisualStyleBackColor = true;
            this.btnGeneration.Click += new System.EventHandler(this.btnGeneration_Click);
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 237);
            this.Controls.Add(this.btnGeneration);
            this.Controls.Add(this.lcbWeek);
            this.Controls.Add(this.tbGroupName);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.cbLearningForm);
            this.Controls.Add(this.cbDirection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
        private System.Windows.Forms.CheckedListBox lcbWeek;
        private System.Windows.Forms.Button btnGeneration;
    }
}