﻿using System;
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
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Academy321
{
    public partial class MainForm : Form
    {
        string connectionString;
        SqlConnection connection;
        DataTable table;
        SqlDataReader reader;
        SqlCommand command;

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            if (AllocConsole())
            {
                Console.WriteLine(connectionString); 
            }
            connection = new SqlConnection(connectionString);
            LoadDataToComboBox(comboBoxStudentsGroup, "Groups", "group_name");
            LoadDataToComboBox(comboBoxStudentsDirection, "Directions", "direction_name");
            //LoadStudents();
        }
        void LoadStudents(string condition=null)
        {
            connection.Open();
            string cmd = $@"
SELECT
        [ФИО]               = FORMATMESSAGE('%s %s %s', last_name, first_name, middle_name),
        [Дата Рождения]     = birth_date,
        [Группа]            = group_name,
        [Направление]       = direction_name
FROM Students
JOIN Groups ON ([group] = group_id)
JOIN Directions ON (direction = direction_id)
            ";
            if (condition != null && !condition.Contains("Все")) 
            { 
                cmd += $" WHERE {condition}"; 
            }
            SqlCommand command = new SqlCommand(cmd, connection);
            reader = command.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));
            }
            while(reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount;i++) row[i] = reader[i];
                table.Rows.Add(row);
            }
            dataGridViewStudents.DataSource = table;
            connection.Close();
        }

        public void LoadGroupsToComboBox()
        {
            string cmd = @"SELECT group_name FROM Groups";
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxStudentsGroup.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }
        public void LoadDirectionsToComboBox()
        {
            string cmd = @"SELECT direction_name FROM Directions";
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxStudentsDirection.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }
        public void LoadDataToComboBox(System.Windows.Forms.ComboBox list, string tables, string column, string condition = null)
        {
            list.Items.Clear();
            list.Items.Add("Все");
            list.SelectedIndex = 0;
            string cmd = $@"SELECT {column} FROM {tables} ";
            if (condition !=null)
            {
                cmd += $"WHERE {condition}";
            }
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();
        private void setStatus()
        {
            toolStripStatusLabelStudentsCount.Text = $"Количество студентов: {dataGridViewStudents.RowCount - 1}";
            if(comboBoxStudentsDirection.SelectedItem?.ToString() == "Все")
            {
                toolStripStatusLabelGroupsCount.Text = $"Всего групп: {comboBoxStudentsGroup.Items.Count - 1}";
            }
            else
            {
                toolStripStatusLabelGroupsCount.Text = $"Групп по выбранному направлению: {comboBoxStudentsGroup.Items.Count-1}";
            }
        }
        private void comboBoxStudentsGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudents($"group_name = '{comboBoxStudentsGroup.SelectedItem.ToString()}'");
            //labelCountStudentsInGroups.Text = "Количество студентов в группе: " + (dataGridViewStudents.RowCount-1);
            setStatus();
        }

        private void comboBoxStudentsDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxStudentsGroup.Items.Clear();
            if (comboBoxStudentsDirection.SelectedIndex > 0)
            {
                string condition = $"direction = direction_id AND direction_name = '{comboBoxStudentsDirection.SelectedItem.ToString()}'";
                LoadDataToComboBox(comboBoxStudentsGroup, "Groups, Directions", "group_name", condition);
            }
            else
            {
                LoadDataToComboBox(comboBoxStudentsGroup, "Groups", "group_name");
            }
            //labelGroupsCount.Text = "Количество групп на данном направлении: " + (comboBoxStudentsGroup.Items.Count-1);
            LoadStudents($"direction_name = '{comboBoxStudentsDirection.SelectedItem.ToString()}'");
            //labelCountStudentsOnDirection.Text = "Количество студентов на направлении: " + (dataGridViewStudents.RowCount - 1);
            setStatus();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent();
            formStudent.ShowDialog();
        }
    }
   
}
