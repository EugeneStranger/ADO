using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Academy
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        DataTable table;
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            //LoadTablesToComboBox();
            LoadGroupsToComboBox(cbGroup);
            SelectStudents();
            LoadDirectionsToComboBox();
            rbStudents.Checked = true;
            LoadDataToComboBox(cbDirectionOnGroupTab, "Directions", "direction_name", "Выберите направление");
        }
        void LoadTablesToComboBox()
        {
            string commandLine = @"SELECT table_name FROM information_schema.tables";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               // comboBox1.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }
        public void LoadDataToComboBox
            (
            System.Windows.Forms.ComboBox comboBox,
            string sourceTable,
            string sourceColumn,
            string invite = "Выберите значение",
            string condition = null
            )
        {
            string commandLine = $@"SELECT {sourceColumn} FROM {sourceTable} ";
            if (condition != null) commandLine += condition;
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            //cmd.Connection = connection;
            //cmd.Parameters.Add("@table_name", sourceTable);
            //cmd.Parameters.Add("@column_name", sourceColumn);
            //cmd.CommandText = @"SELECT @column_name FROM @table_name";
            connection.Open();
            reader = cmd.ExecuteReader();
            if (invite != "") comboBox.Items.Add(invite);
            while (reader.Read())
            {
                comboBox.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close() ;
            comboBox.SelectedItem = invite;
        }
        public void LoadDataFromStorageToComboBox
            (
                System.Windows.Forms.ComboBox comboBox,
                string table_name,
                string column_name,
                string invite = "Выберите значение",
                string condition = null                
            )
        {
            TablesStorage storage = new TablesStorage();
            storage.GetDataFromBase(table_name,column_name,condition);
            DataRow[] rows = storage.Set.Tables[0].Select();
            for (int i=0; i < rows.Length; i++)
            {
                comboBox.Items.Add(rows[i][column_name]);
            }
        }
        public void SelectDataFromTable(
            System.Windows.Forms.DataGridView dataGridView,
            string commandLine
            //string tableName,
            //params string[] columns
            )
        {
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = connection;
            //cmd.CommandText = "SELECT ";
            //for ( int i = 0; i < columns.Length; i++)
            //{
            //    cmd.Parameters.Add($"{columns[i]}", columns[i]);
            //    cmd.CommandText += $"{columns[i]}";
            //    cmd.CommandText += i == columns.Length - 1 ? " " : ", ";
            //}
            //cmd.CommandText += $"FROM {tableName}";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));
            }
            //table.Columns.Add("Дни обучения");            
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                //if (row["learning_days"] != null)
                try
                {
                    row["learning_days"] = BitSetToDays(Convert.ToByte(row["learning_days"]));
                }
                catch (Exception e)
                {
                }
                table.Rows.Add(row);
            }
            dataGridView.DataSource = table;
            reader.Close();
            connection.Close();
        }
        public void LoadGroupsToComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            string commandLine = @"SELECT group_name FROM Groups";
            SqlCommand cmd = new SqlCommand( commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox.Items.Add(reader[0]);
            }
            reader.Close ();
            connection.Close ();
        }
        public void LoadDirectionsToComboBox()
        {
            string commandLine = @"SELECT direction_name FROM Directions";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                cbDirection.Items.Add(reader[0]);
            }
            reader.Close ();
            connection.Close();
        }
        void SelectStudents(string group = "")
        {
            string commandLine = @"
                    SELECT 
                        [Фамилия] = last_name,
                        [Имя] = first_name,
                        [Отчество] = middle_name,
                        [Дата Рождения] = birth_date,
                        [Группа] = group_name
                    FROM Students JOIN Groups ON [group] = group_id";
            if (group.Length != 0) commandLine += $" WHERE [group_name] = '{group}'";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            table = new DataTable();
            for (int i  =0; i <reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));
            }
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                row["Дата Рождения"] = Convert.ToDateTime(reader["Дата Рождения"]).ToString("yyyy.MM.dd");
                table.Rows.Add(row);
            }
            dgvStudents.DataSource = table;
            reader.Close();
            if (group.Length > 0)
            {
                cmd.CommandText = $@"
                SELECT COUNT(stud_id) 
                FROM Students JOIN  Groups ON Students.[group] = Groups.group_id
                WHERE [group_name] = '{group}' GROUP BY group_name"; 
            }
            else
            {
                cmd.CommandText = $@"
                SELECT COUNT(stud_id) 
                FROM Students JOIN  Groups ON Students.[group] = Groups.group_id
                ";
            }
            lblStudCount.Text = $"Количество студентов: {Convert.ToInt32(cmd.ExecuteScalar()).ToString()}";
            connection.Close();
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectStudents(cbGroup.SelectedItem.ToString());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddStudent add_student = new AddStudent();
            LoadGroupsToComboBox(add_student.GroupCombo);
            DialogResult result = add_student.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.Parameters.Add("@last_name", add_student.FullName.Split(' ')[0]);
                cmd.Parameters.Add("@first_name", add_student.FullName.Split(' ')[1]);
                if (add_student.FullName.Split(' ').Length==3) cmd.Parameters.Add("@middle_name", add_student.FullName.Split(' ')[2]);
                cmd.Parameters.Add("@birth_date", add_student.BirthDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.Add("@group", add_student.Group);
                cmd.CommandText = @"
                 IF NOT EXISTS (SELECT stud_id FROM Students 
                 WHERE last_name = @last_name 
                 AND first_name = @first_name 
                 AND middle_name = @middle_name)
                 BEGIN
                    INSERT INTO 
                    Students (last_name, first_name, middle_name, birth_date, [group])
                    VALUES (@last_name, @first_name, @middle_name, @birth_date, 
                            (SELECT group_id FROM Groups WHERE group_name = @group))
                 END
                 "; 
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                cbGroup.SelectedItem = add_student.Group;
                SelectStudents();
            }
        }

        private void cbDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvStudents.DataSource = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection= connection;
            if (cbDirection.SelectedItem != null) cmd.Parameters.Add("@direction", cbDirection.SelectedItem);
            if (rbStudents.Checked)
            {
                cmd.CommandText = @"
                SELECT 
                    [Фамилия] = last_name,
                    [Имя] = first_name,
                    [Отчество] = middle_name,
                    [Дата рождения] = birth_date,
                    [Группа] = group_name,
                    [Направление] = direction_name
                FROM Students 
                    JOIN Groups ON Students.[group] = Groups.group_id
                    JOIN Directions ON Groups.direction = Directions.direction_id";
                if (cbDirection.SelectedItem !=null) cmd.CommandText +=
                @" WHERE Directions.direction_name = @direction
                "; 
            }
            if (rbGroups.Checked)
            {
                cmd.CommandText = @"
                SELECT 
                    [Группа] = group_name,
                    [Направление] = direction_name
                FROM Groups 
                    JOIN Directions ON Groups.direction = Directions.direction_id";
                if (cbDirection.SelectedItem != null) cmd.CommandText +=
                @" WHERE Directions.direction_name = @direction
                ";
            }
            connection.Open();
            reader = cmd.ExecuteReader();
            table = new DataTable();
            for(int i=0; i<reader.FieldCount;i++)
            {
                table.Columns.Add(reader.GetName(i));
            }
            while(reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                table.Rows.Add(row);
            }
            dgvStudents.DataSource = table;
            reader.Close();
            int studentsCount = dgvStudents.RowCount - 1;
            lblStudCount.Text = $"Количество студентов: {studentsCount.ToString()}";
            connection.Close();
        }

        private void rbGroups_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGroups.Checked) 
            {
                cbDirection_SelectedIndexChanged(sender, e);
            }
        }

        private void rbStudents_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStudents.Checked) 
            {
                cbDirection_SelectedIndexChanged(sender, e);
            }
        }

        private void cbDirectionOnGroupTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SelectDataFromTable(dataGridViewGroups, "Groups", "group_name", "direction");
            string condition = "";
            if (cbDirectionOnGroupTab.SelectedIndex != 0)
                condition += $@"WHERE direction_name='{cbDirectionOnGroupTab.SelectedItem}'";

            string commandLine = $@"
                SELECT group_name, learning_days, direction_name, [number_of_students]=COUNT(stud_id)
                FROM Groups JOIN Directions ON direction=direction_id
                LEFT JOIN Students ON [group]=[group_id]
                    {condition}
                GROUP BY [group_id], [group_name], [learning_days], [direction_name]
                ORDER BY [group_id]
                ";
            SelectDataFromTable(dataGridViewGroups, commandLine);
            lblGroupsCount.Text = $"Количество групп: {dataGridViewGroups.Rows.Count - 1}";
        }

        private void btnGroupAdd_Click(object sender, EventArgs e)
        {
            AddGroup add = new AddGroup(this);
            //LoadDataToComboBox(add.CBDirection, "Directions", "direction_name", "Выберите направление обучения");
            //LoadDataToComboBox(add.CBLearningForms, "LearningForms", "form_name", "Выберите форму обучения");
            //LoadDataToComboBox(add.CBLearningTime, "LearningTimes", "time_name", "Выберите время обучения");
            DialogResult result = add.ShowDialog();
            //if (result == DialogResult.OK) 
            //{
            //TablesStorage storage = new TablesStorage();
            //storage.GetDataFromBase("Groups, Directions", "group_name, direction_name",);
            //cbDirectionOnGroupTab_SelectedIndexChanged(sender, e);
            //}
            //TablesStorage storage;
            //storage.GetDataFromBase()
            cbDirectionOnGroupTab_SelectedIndexChanged(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TablesStorage storage = new TablesStorage();
            //storage.GetDataFromBase("Groups,Directions", "group_name, direction_name", "direction=direction_id");
            //dataGridViewGroups.DataSource = storage.Set.Tables[0];
            storage.GetDataFromBase("Groups");
            //dataGridViewGroups.DataSource = storage.Set.Tables[0];
            //foreach (DataGridViewCell cell in dataGridViewGroups.SelectedCells)
            //{
            //    storage.Set.Tables[0].Rows.RemoveAt(cell.RowIndex);
            ////    MessageBox.Show(this, storage.Set.Tables[0].ToString());
            ////    //dataGridViewGroups.Rows.RemoveAt(cell.RowIndex);
            //}
            //int deleted_rows = storage.Adapter.Update(storage.Set.Tables["Groups"]);
            //MessageBox.Show(this, deleted_rows.ToString());
            //cbDirectionOnGroupTab_SelectedIndexChanged(sender, e);
            ////storage.Adapter.Update(storage.Set);
            MessageBox.Show(this, dataGridViewGroups.SelectedRows[0].Cells["group_name"].Value.ToString(), "Info");
            DataRow[] rows = storage.Set.Tables["Groups"].
                Select($"group_name = '{dataGridViewGroups.SelectedRows[0].Cells["group_name"].Value.ToString()}'");
            rows[0].Delete();
            storage.Adapter.Update(storage.Set,"Groups");
            cbDirectionOnGroupTab_SelectedIndexChanged(sender, e);
        }
        private string BitSetToDays(byte bitSet)
        {
            string[] week = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
            string days = "";
            for (int i = 0; i < week.Length; i++)
            {
                byte day = 1;
                day <<= i;
                if ((day & bitSet) != 0)
                {
                    int day_index = (int)Math.Log(day & bitSet, 2);
                    days += week[day_index] + ", ";
                }
            }
            return days;
        }

        private void dataGridViewGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
