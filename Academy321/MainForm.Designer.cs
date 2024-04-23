namespace Academy321
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.labelCountStudentsOnDirection = new System.Windows.Forms.Label();
            this.labelGroupsCount = new System.Windows.Forms.Label();
            this.labelCountStudentsInGroups = new System.Windows.Forms.Label();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.comboBoxStudentsGroup = new System.Windows.Forms.ComboBox();
            this.labelStudentsGroup = new System.Windows.Forms.Label();
            this.comboBoxStudentsDirection = new System.Windows.Forms.ComboBox();
            this.labelStudentsDirection = new System.Windows.Forms.Label();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.tabPageScheduale = new System.Windows.Forms.TabPage();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusTrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStudentsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGroupsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStudents);
            this.tabControl.Controls.Add(this.tabPageGroups);
            this.tabControl.Controls.Add(this.tabPageScheduale);
            this.tabControl.Controls.Add(this.tabPageTeachers);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(925, 551);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.statusStrip1);
            this.tabPageStudents.Controls.Add(this.labelCountStudentsOnDirection);
            this.tabPageStudents.Controls.Add(this.labelGroupsCount);
            this.tabPageStudents.Controls.Add(this.labelCountStudentsInGroups);
            this.tabPageStudents.Controls.Add(this.buttonAddStudent);
            this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
            this.tabPageStudents.Controls.Add(this.comboBoxStudentsGroup);
            this.tabPageStudents.Controls.Add(this.labelStudentsGroup);
            this.tabPageStudents.Controls.Add(this.comboBoxStudentsDirection);
            this.tabPageStudents.Controls.Add(this.labelStudentsDirection);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(917, 525);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Студенты";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // labelCountStudentsOnDirection
            // 
            this.labelCountStudentsOnDirection.AutoSize = true;
            this.labelCountStudentsOnDirection.Location = new System.Drawing.Point(416, 48);
            this.labelCountStudentsOnDirection.Name = "labelCountStudentsOnDirection";
            this.labelCountStudentsOnDirection.Size = new System.Drawing.Size(207, 13);
            this.labelCountStudentsOnDirection.TabIndex = 8;
            this.labelCountStudentsOnDirection.Text = "Количество студентов на направлении:";
            // 
            // labelGroupsCount
            // 
            this.labelGroupsCount.AutoSize = true;
            this.labelGroupsCount.Location = new System.Drawing.Point(651, 48);
            this.labelGroupsCount.Name = "labelGroupsCount";
            this.labelGroupsCount.Size = new System.Drawing.Size(225, 13);
            this.labelGroupsCount.TabIndex = 7;
            this.labelGroupsCount.Text = "Количество групп на данном направлении:";
            // 
            // labelCountStudentsInGroups
            // 
            this.labelCountStudentsInGroups.AutoSize = true;
            this.labelCountStudentsInGroups.Location = new System.Drawing.Point(48, 48);
            this.labelCountStudentsInGroups.Name = "labelCountStudentsInGroups";
            this.labelCountStudentsInGroups.Size = new System.Drawing.Size(169, 13);
            this.labelCountStudentsInGroups.TabIndex = 6;
            this.labelCountStudentsInGroups.Text = "Количество студентов в группе:";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddStudent.Location = new System.Drawing.Point(786, 12);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(125, 23);
            this.buttonAddStudent.TabIndex = 5;
            this.buttonAddStudent.Text = "Добавить";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(8, 67);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(903, 455);
            this.dataGridViewStudents.TabIndex = 4;
            // 
            // comboBoxStudentsGroup
            // 
            this.comboBoxStudentsGroup.FormattingEnabled = true;
            this.comboBoxStudentsGroup.Location = new System.Drawing.Point(51, 14);
            this.comboBoxStudentsGroup.Name = "comboBoxStudentsGroup";
            this.comboBoxStudentsGroup.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStudentsGroup.TabIndex = 3;
            this.comboBoxStudentsGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentsGroup_SelectedIndexChanged);
            // 
            // labelStudentsGroup
            // 
            this.labelStudentsGroup.AutoSize = true;
            this.labelStudentsGroup.Location = new System.Drawing.Point(3, 17);
            this.labelStudentsGroup.Name = "labelStudentsGroup";
            this.labelStudentsGroup.Size = new System.Drawing.Size(42, 13);
            this.labelStudentsGroup.TabIndex = 2;
            this.labelStudentsGroup.Text = "Группа";
            // 
            // comboBoxStudentsDirection
            // 
            this.comboBoxStudentsDirection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStudentsDirection.FormattingEnabled = true;
            this.comboBoxStudentsDirection.Location = new System.Drawing.Point(419, 14);
            this.comboBoxStudentsDirection.Name = "comboBoxStudentsDirection";
            this.comboBoxStudentsDirection.Size = new System.Drawing.Size(361, 21);
            this.comboBoxStudentsDirection.TabIndex = 1;
            this.comboBoxStudentsDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentsDirection_SelectedIndexChanged);
            // 
            // labelStudentsDirection
            // 
            this.labelStudentsDirection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudentsDirection.AutoSize = true;
            this.labelStudentsDirection.Location = new System.Drawing.Point(289, 17);
            this.labelStudentsDirection.Name = "labelStudentsDirection";
            this.labelStudentsDirection.Size = new System.Drawing.Size(124, 13);
            this.labelStudentsDirection.TabIndex = 0;
            this.labelStudentsDirection.Text = "Направление обучения";
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(917, 525);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Группы";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // tabPageScheduale
            // 
            this.tabPageScheduale.Location = new System.Drawing.Point(4, 22);
            this.tabPageScheduale.Name = "tabPageScheduale";
            this.tabPageScheduale.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScheduale.Size = new System.Drawing.Size(917, 525);
            this.tabPageScheduale.TabIndex = 2;
            this.tabPageScheduale.Text = "Расписание";
            this.tabPageScheduale.UseVisualStyleBackColor = true;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(917, 525);
            this.tabPageTeachers.TabIndex = 3;
            this.tabPageTeachers.Text = "Преподаватели";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTrip,
            this.toolStripStatusLabelStudentsCount,
            this.toolStripStatusLabelGroupsCount});
            this.statusStrip1.Location = new System.Drawing.Point(3, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(911, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusTrip
            // 
            this.statusTrip.Name = "statusTrip";
            this.statusTrip.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelStudentsCount
            // 
            this.toolStripStatusLabelStudentsCount.Name = "toolStripStatusLabelStudentsCount";
            this.toolStripStatusLabelStudentsCount.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelGroupsCount
            // 
            this.toolStripStatusLabelGroupsCount.Name = "toolStripStatusLabelGroupsCount";
            this.toolStripStatusLabelGroupsCount.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 551);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "AcademyPD_321";
            this.tabControl.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.TabPage tabPageScheduale;
        private System.Windows.Forms.ComboBox comboBoxStudentsDirection;
        private System.Windows.Forms.Label labelStudentsDirection;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.ComboBox comboBoxStudentsGroup;
        private System.Windows.Forms.Label labelStudentsGroup;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Label labelGroupsCount;
        private System.Windows.Forms.Label labelCountStudentsInGroups;
        private System.Windows.Forms.Label labelCountStudentsOnDirection;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusTrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStudentsCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGroupsCount;
    }
}

