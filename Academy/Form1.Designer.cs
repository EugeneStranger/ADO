namespace Academy
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.rbStudents = new System.Windows.Forms.RadioButton();
            this.rbGroups = new System.Windows.Forms.RadioButton();
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.lblStudCount = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.lblGroupsCount = new System.Windows.Forms.Label();
            this.cbDirectionOnGroupTab = new System.Windows.Forms.ComboBox();
            this.btnGroupAdd = new System.Windows.Forms.Button();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageStudents);
            this.tabControl1.Controls.Add(this.tabPageGroups);
            this.tabControl1.Controls.Add(this.tabPageTeachers);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.rbStudents);
            this.tabPageStudents.Controls.Add(this.rbGroups);
            this.tabPageStudents.Controls.Add(this.cbDirection);
            this.tabPageStudents.Controls.Add(this.buttonAdd);
            this.tabPageStudents.Controls.Add(this.lblStudCount);
            this.tabPageStudents.Controls.Add(this.dgvStudents);
            this.tabPageStudents.Controls.Add(this.cbGroup);
            this.tabPageStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageStudents.Size = new System.Drawing.Size(894, 475);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Студенты";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // rbStudents
            // 
            this.rbStudents.AutoSize = true;
            this.rbStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbStudents.Location = new System.Drawing.Point(409, 44);
            this.rbStudents.Name = "rbStudents";
            this.rbStudents.Size = new System.Drawing.Size(81, 17);
            this.rbStudents.TabIndex = 6;
            this.rbStudents.TabStop = true;
            this.rbStudents.Text = "Студенты";
            this.rbStudents.UseVisualStyleBackColor = true;
            this.rbStudents.CheckedChanged += new System.EventHandler(this.rbStudents_CheckedChanged);
            // 
            // rbGroups
            // 
            this.rbGroups.AutoSize = true;
            this.rbGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbGroups.Location = new System.Drawing.Point(335, 44);
            this.rbGroups.Name = "rbGroups";
            this.rbGroups.Size = new System.Drawing.Size(68, 17);
            this.rbGroups.TabIndex = 5;
            this.rbGroups.TabStop = true;
            this.rbGroups.Text = "Группы";
            this.rbGroups.UseVisualStyleBackColor = true;
            this.rbGroups.CheckedChanged += new System.EventHandler(this.rbGroups_CheckedChanged);
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Location = new System.Drawing.Point(7, 44);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(321, 21);
            this.cbDirection.TabIndex = 4;
            this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(752, 7);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(134, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить студента";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // lblStudCount
            // 
            this.lblStudCount.AutoSize = true;
            this.lblStudCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudCount.Location = new System.Drawing.Point(336, 10);
            this.lblStudCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudCount.Name = "lblStudCount";
            this.lblStudCount.Size = new System.Drawing.Size(80, 13);
            this.lblStudCount.TabIndex = 2;
            this.lblStudCount.Text = "Количество:";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(5, 71);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(884, 398);
            this.dgvStudents.TabIndex = 1;
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(7, 7);
            this.cbGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(321, 21);
            this.cbGroup.TabIndex = 0;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.btnDelete);
            this.tabPageGroups.Controls.Add(this.lblGroupsCount);
            this.tabPageGroups.Controls.Add(this.cbDirectionOnGroupTab);
            this.tabPageGroups.Controls.Add(this.btnGroupAdd);
            this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(894, 475);
            this.tabPageGroups.TabIndex = 2;
            this.tabPageGroups.Text = "Группы";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // lblGroupsCount
            // 
            this.lblGroupsCount.AutoSize = true;
            this.lblGroupsCount.Location = new System.Drawing.Point(335, 6);
            this.lblGroupsCount.Name = "lblGroupsCount";
            this.lblGroupsCount.Size = new System.Drawing.Size(117, 13);
            this.lblGroupsCount.TabIndex = 3;
            this.lblGroupsCount.Text = "Количество групп:";
            // 
            // cbDirectionOnGroupTab
            // 
            this.cbDirectionOnGroupTab.FormattingEnabled = true;
            this.cbDirectionOnGroupTab.Location = new System.Drawing.Point(3, 6);
            this.cbDirectionOnGroupTab.Name = "cbDirectionOnGroupTab";
            this.cbDirectionOnGroupTab.Size = new System.Drawing.Size(298, 21);
            this.cbDirectionOnGroupTab.TabIndex = 2;
            this.cbDirectionOnGroupTab.SelectedIndexChanged += new System.EventHandler(this.cbDirectionOnGroupTab_SelectedIndexChanged);
            // 
            // btnGroupAdd
            // 
            this.btnGroupAdd.Location = new System.Drawing.Point(751, 6);
            this.btnGroupAdd.Name = "btnGroupAdd";
            this.btnGroupAdd.Size = new System.Drawing.Size(137, 23);
            this.btnGroupAdd.TabIndex = 1;
            this.btnGroupAdd.Text = "Добавить группу";
            this.btnGroupAdd.UseVisualStyleBackColor = true;
            this.btnGroupAdd.Click += new System.EventHandler(this.btnGroupAdd_Click);
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroups.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Location = new System.Drawing.Point(3, 39);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.Size = new System.Drawing.Size(885, 430);
            this.dataGridViewGroups.TabIndex = 0;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageTeachers.Size = new System.Drawing.Size(894, 475);
            this.tabPageTeachers.TabIndex = 1;
            this.tabPageTeachers.Text = "Преподаватели";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(604, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить группу";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 525);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label lblStudCount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.RadioButton rbGroups;
        private System.Windows.Forms.RadioButton rbStudents;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.Button btnGroupAdd;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.ComboBox cbDirectionOnGroupTab;
        private System.Windows.Forms.Label lblGroupsCount;
        private System.Windows.Forms.Button btnDelete;
    }
}

