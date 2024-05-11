using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Academy321
{
    public partial class FormStudent : Form
    {
        int id;
        public FormStudent()
        {
            InitializeComponent();
            FormDataLoader.LoadDataToComboBox(comboBoxDirection,"Directions", "direction_name", null, "Все");
            FormDataLoader.LoadDataToComboBox(comboBoxGroup, "Groups", "group_name");
            //comboBoxGroup.Items.Remove("Все");
            //comboBoxGroup.SelectedIndex = -1;
            id = 0;
            labelID.Visible = false;
            //InitForm();
        }
        void InitForm()
        {
            richTextBoxLastName.Text = "Тупенко";
            richTextBoxFirstName.Text = "Лемур";
            richTextBoxMiddleName.Text = "Лемурович";
            dateTimePickerBirthDate.Value = new DateTime(2005,04,01);
        }
        public void InitForm(DataTable table)
        {
            DataRow row = table.Rows[0];
            id = Convert.ToInt32(row["stud_id"].ToString());
            labelID.Text = $"ID студента в базе:" + id;
            richTextBoxLastName.Text = row["last_name"].ToString();
            richTextBoxFirstName.Text = row["first_name"].ToString();
            richTextBoxMiddleName.Text = row["middle_name"].ToString();
            dateTimePickerBirthDate.Value = DateTime.Parse(row["birth_date"].ToString());
            richTextBoxEmail.Text = row["email"].ToString();
            richTextBoxPhone.Text = row["phone"].ToString();
            Connector connector = new Connector();
            connector.LoadColumnFromTable("group_name, direction", "Groups", $"group_id = {row["group"]}");
            comboBoxGroup.SelectedIndex = comboBoxGroup.FindStringExact(connector.DataTable.Rows[0]["group_name"].ToString());
            connector.LoadColumnFromTable("direction_name", "Directions", $"direction_id={connector.DataTable.Rows[0]["direction"]}");
            comboBoxDirection.SelectedIndex = comboBoxDirection.FindStringExact(connector.DataTable.Rows[0]["direction_name"].ToString());

            //pictureBoxPhoto.Image = photo;
            labelID.Visible = true;
            LockFields();

        }
        void LockFields()
        {
            comboBoxGroup.Enabled = false;
            comboBoxDirection.Enabled = false;
            richTextBoxLastName.Enabled = false;
            richTextBoxFirstName.Enabled = false;
            richTextBoxMiddleName.Enabled = false;
            dateTimePickerBirthDate.Enabled = false;
            richTextBoxEmail.Enabled = false;
            richTextBoxPhone.Enabled = false;                 
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            //Single responsibility principle
            connector.InsertDataToBase
                (
                "Students",
                "last_name, first_name, middle_name, birth_date, email, phone, photo, [group]",
                $"" +
$"'{richTextBoxLastName.Text}'," +
$"'{richTextBoxFirstName.Text}'," +
$"'{richTextBoxMiddleName.Text}'," +
$"'{dateTimePickerBirthDate.Value}',"+
$"'{richTextBoxEmail.Text}',"+
$"'{richTextBoxPhone.Text}',"+
$"'{pictureBoxPhoto.Image}',"+
$"{connector.GetIDbyValue("Groups", "group_id,group_name",comboBoxGroup.SelectedItem.ToString())}"
                )
                ;
        }

        private void buttonBrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            string filename = open.FileName;
            pictureBoxPhoto.Image = Image.FromFile(filename);
        }

        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormDataLoader.GroupFilter(comboBoxDirection, comboBoxGroup);
        }
    }
}
