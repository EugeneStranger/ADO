namespace Academy321
{
    partial class FormStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.richTextBoxLastName = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFirstName = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMiddleName = new System.Windows.Forms.RichTextBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelStudent = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelDirection = new System.Windows.Forms.TableLayoutPanel();
            this.labelDirection = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.richTextBoxEmail = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPhone = new System.Windows.Forms.RichTextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonBrows = new System.Windows.Forms.Button();
            this.tableLayoutPanelStudent.SuspendLayout();
            this.tableLayoutPanelDirection.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(3, 50);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(169, 16);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Имя:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(3, 89);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(169, 16);
            this.labelMiddleName.TabIndex = 2;
            this.labelMiddleName.Text = "Отчество:";
            this.labelMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(3, 11);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(169, 16);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Фамилия:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxLastName
            // 
            this.richTextBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxLastName.Location = new System.Drawing.Point(178, 8);
            this.richTextBoxLastName.MaxLength = 256;
            this.richTextBoxLastName.Multiline = false;
            this.richTextBoxLastName.Name = "richTextBoxLastName";
            this.richTextBoxLastName.Size = new System.Drawing.Size(257, 23);
            this.richTextBoxLastName.TabIndex = 4;
            this.richTextBoxLastName.Text = "";
            // 
            // richTextBoxFirstName
            // 
            this.richTextBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxFirstName.Location = new System.Drawing.Point(178, 47);
            this.richTextBoxFirstName.MaxLength = 256;
            this.richTextBoxFirstName.Multiline = false;
            this.richTextBoxFirstName.Name = "richTextBoxFirstName";
            this.richTextBoxFirstName.Size = new System.Drawing.Size(257, 23);
            this.richTextBoxFirstName.TabIndex = 5;
            this.richTextBoxFirstName.Text = "";
            // 
            // richTextBoxMiddleName
            // 
            this.richTextBoxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxMiddleName.Location = new System.Drawing.Point(178, 86);
            this.richTextBoxMiddleName.MaxLength = 256;
            this.richTextBoxMiddleName.Multiline = false;
            this.richTextBoxMiddleName.Name = "richTextBoxMiddleName";
            this.richTextBoxMiddleName.Size = new System.Drawing.Size(257, 23);
            this.richTextBoxMiddleName.TabIndex = 6;
            this.richTextBoxMiddleName.Text = "";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthDate.Location = new System.Drawing.Point(3, 129);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(169, 16);
            this.labelBirthDate.TabIndex = 7;
            this.labelBirthDate.Text = "Дата рождения:";
            this.labelBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // tableLayoutPanelStudent
            // 
            this.tableLayoutPanelStudent.ColumnCount = 2;
            this.tableLayoutPanelStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelStudent.Controls.Add(this.labelBirthDate, 0, 3);
            this.tableLayoutPanelStudent.Controls.Add(this.richTextBoxMiddleName, 1, 2);
            this.tableLayoutPanelStudent.Controls.Add(this.dateTimePicker1, 1, 3);
            this.tableLayoutPanelStudent.Controls.Add(this.richTextBoxFirstName, 1, 1);
            this.tableLayoutPanelStudent.Controls.Add(this.labelLastName, 0, 0);
            this.tableLayoutPanelStudent.Controls.Add(this.labelMiddleName, 0, 2);
            this.tableLayoutPanelStudent.Controls.Add(this.richTextBoxLastName, 1, 0);
            this.tableLayoutPanelStudent.Controls.Add(this.labelFirstName, 0, 1);
            this.tableLayoutPanelStudent.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelStudent.Name = "tableLayoutPanelStudent";
            this.tableLayoutPanelStudent.RowCount = 4;
            this.tableLayoutPanelStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudent.Size = new System.Drawing.Size(438, 157);
            this.tableLayoutPanelStudent.TabIndex = 9;
            // 
            // tableLayoutPanelDirection
            // 
            this.tableLayoutPanelDirection.ColumnCount = 2;
            this.tableLayoutPanelDirection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelDirection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelDirection.Controls.Add(this.labelDirection, 0, 0);
            this.tableLayoutPanelDirection.Controls.Add(this.labelGroup, 0, 1);
            this.tableLayoutPanelDirection.Controls.Add(this.comboBoxDirection, 1, 0);
            this.tableLayoutPanelDirection.Controls.Add(this.comboBoxGroup, 1, 1);
            this.tableLayoutPanelDirection.Location = new System.Drawing.Point(12, 290);
            this.tableLayoutPanelDirection.Name = "tableLayoutPanelDirection";
            this.tableLayoutPanelDirection.RowCount = 2;
            this.tableLayoutPanelDirection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDirection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDirection.Size = new System.Drawing.Size(438, 79);
            this.tableLayoutPanelDirection.TabIndex = 10;
            // 
            // labelDirection
            // 
            this.labelDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDirection.AutoSize = true;
            this.labelDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirection.Location = new System.Drawing.Point(3, 11);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(169, 16);
            this.labelDirection.TabIndex = 0;
            this.labelDirection.Text = "Направление обучения:";
            // 
            // labelGroup
            // 
            this.labelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(3, 51);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(169, 16);
            this.labelGroup.TabIndex = 1;
            this.labelGroup.Text = "Группа:";
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(178, 9);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(257, 21);
            this.comboBoxDirection.TabIndex = 2;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(178, 48);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(257, 21);
            this.comboBoxGroup.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.labelEmail, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelPhone, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.richTextBoxEmail, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.richTextBoxPhone, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 191);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(438, 79);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(3, 11);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(169, 16);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(3, 51);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(169, 16);
            this.labelPhone.TabIndex = 1;
            this.labelPhone.Text = "Телефон:";
            // 
            // richTextBoxEmail
            // 
            this.richTextBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxEmail.Location = new System.Drawing.Point(178, 7);
            this.richTextBoxEmail.MaxLength = 256;
            this.richTextBoxEmail.Multiline = false;
            this.richTextBoxEmail.Name = "richTextBoxEmail";
            this.richTextBoxEmail.Size = new System.Drawing.Size(257, 24);
            this.richTextBoxEmail.TabIndex = 2;
            this.richTextBoxEmail.Text = "";
            this.richTextBoxEmail.WordWrap = false;
            // 
            // richTextBoxPhone
            // 
            this.richTextBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxPhone.Location = new System.Drawing.Point(178, 46);
            this.richTextBoxPhone.MaxLength = 256;
            this.richTextBoxPhone.Multiline = false;
            this.richTextBoxPhone.Name = "richTextBoxPhone";
            this.richTextBoxPhone.Size = new System.Drawing.Size(257, 25);
            this.richTextBoxPhone.TabIndex = 3;
            this.richTextBoxPhone.Text = "";
            this.richTextBoxPhone.WordWrap = false;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto.Image")));
            this.pictureBoxPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto.InitialImage")));
            this.pictureBoxPhoto.Location = new System.Drawing.Point(468, 12);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(239, 250);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 12;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(468, 338);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 30);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(594, 338);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 30);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonBrows
            // 
            this.buttonBrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBrows.Location = new System.Drawing.Point(594, 290);
            this.buttonBrows.Name = "buttonBrows";
            this.buttonBrows.Size = new System.Drawing.Size(120, 29);
            this.buttonBrows.TabIndex = 15;
            this.buttonBrows.Text = "Обзор";
            this.buttonBrows.UseVisualStyleBackColor = true;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(719, 375);
            this.Controls.Add(this.buttonBrows);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanelDirection);
            this.Controls.Add(this.tableLayoutPanelStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormStudent";
            this.Text = "Студент";
            this.tableLayoutPanelStudent.ResumeLayout(false);
            this.tableLayoutPanelStudent.PerformLayout();
            this.tableLayoutPanelDirection.ResumeLayout(false);
            this.tableLayoutPanelDirection.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.RichTextBox richTextBoxLastName;
        private System.Windows.Forms.RichTextBox richTextBoxMiddleName;
        private System.Windows.Forms.RichTextBox richTextBoxFirstName;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDirection;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.RichTextBox richTextBoxEmail;
        private System.Windows.Forms.RichTextBox richTextBoxPhone;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonBrows;
    }
}