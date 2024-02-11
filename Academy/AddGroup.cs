using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Academy
{
    public partial class AddGroup : Form
    {
        Form1 mainForm;
        private string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;         //Вытягивает результаты запросов из базы и сохраняет их в DataSet
        DataSet set;
        SqlCommandBuilder builder;
        public System.Windows.Forms.ComboBox CBDirection { get => cbDirection; }
        public System.Windows.Forms.ComboBox CBLearningForms { get => cbLearningForm; }
        public System.Windows.Forms.ComboBox CBLearningTime { get => cbTime; }
        string[] week = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
        CheckBox[] cbWeek;
        public AddGroup(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            GetDataFromBase();
            mainForm.LoadDataToComboBox(cbLearningForm, "LearningForms", "form_name", "Выберите форму обучения");
            //mainForm.LoadDataToComboBox(cbDirection, "Directions", "direction_name", "Выберите направление обучения");
            mainForm.LoadDataToComboBox(cbTime, "LearningTimes", "time_name", "Выберите время обучения");
            cbWeek = new CheckBox[7];
            
        }
        byte GetBitSet()
        {
            byte days = 0;
            #region PrintInConsole

            //AllocConsole();
            //Console.Write("Days:\t");
            //for (int i = 0; i < clbWeek.CheckedItems.Count; i++)
            //{
            //    Console.Write(clbWeek.CheckedItems[i] + "\t");
            //}
            //Console.WriteLine();
            //Console.Write("Nums:\t");
            //for (int i = 0; i < clbWeek.CheckedIndices.Count; i++)
            //{
            //    Console.Write(clbWeek.CheckedIndices[i] + "\t");
            //}
            //Console.WriteLine();
            //Console.WriteLine("\n-----------------------------------------\n"); 
            #endregion
            for (int i = 0; i < clbWeek.CheckedIndices.Count; i++)
            {
                //byte day = (byte)Math.Pow(2, clbWeek.CheckedIndices[i]);
                //days += day;
                byte day = 1;
                day <<= clbWeek.CheckedIndices[i];
                days |= day;
                /*
                -------------------------------------------------------------------------------------------------------------------------------------
                << (побитовый сдвиг влево) -            бинарный оператор, который сдвигает число на заданное количество бит влево.
                                                        Сдвиг числа на один бит влево увеличивает число в 2 раза (выполняет умножение числа на 2)
                                                        Сдвиг числа на два бита влево увеличивает число в 4 раза (выполняет умножение числа на 2^2)
                                                        Сдвиг числа на три бита влево увеличивает число в 8 раза (выполняет умножение числа на 2^3)
                -------------------------------------------------------------------------------------------------------------------------------------
                >> (побитовый сдвиг вправо) -           бинарный оператор, который сдвигает число на заданное количество бит вправо.
                                                        Сдвиг числа на один бит влево уменьшает число в 2 раза (выполняет деление числа на 2)
                                                        Сдвиг числа на два бита влево уменьшает число в 4 раза (выполняет деление числа на 2^2)
                                                        Сдвиг числа на три бита влево уменьшает число в 8 раза (выполняет деление числа на 2^3)
                -------------------------------------------------------------------------------------------------------------------------------------
                | (побитовое сложение, побитовый OR) -  если соответствующий бит хотя бы в одном операнде равен 1,
                                                        то этот же бит результата будет равен 1
                -------------------------------------------------------------------------------------------------------------------------------------
                Все побитовые операторы можно комбинировать с оператором присваивания
                -------------------------------------------------------------------------------------------------------------------------------------
                */
            }
            return days;
        }
        [DllImport("kernel32.dll")]
        [return:MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        void GetDataFromBase()
        {
            try 
            {
                set = new DataSet();
                string cmd = $@"SELECT * FROM Directions";
                adapter = new SqlDataAdapter(cmd, connection);
                builder = new SqlCommandBuilder(adapter);
                adapter.Fill(set, "Directions");

                adapter.SelectCommand.CommandText = $@"SELECT * FROM LearningTimes";
                builder.DataAdapter = adapter;
                adapter.Fill(set, "LearningTimes");
            }
            catch(Exception e)
            {
                MessageBox.Show(this, e.Message);
            }
        }
        string GenereteGroupName()
        {
            //PD_212 - Программирование, День, Поток 212
            //SD_212 - Сетевые технологии, День, Поток 212
            //VSU_213 - Воскресенье, Сети, Утро, Поток 213
            //Java_326 - годичные курсы
            //if (cbLearningForm.SelectedIndex == 0) return "Выберите форму обучения";
            //if (cbDirection.SelectedItem == null || cbDirection.SelectedItem.ToString() == "Выберите направление обучения")
            //      return "Выберите направление обучения";
            //if (cbTime.SelectedIndex == 0) return "Выберите время обучения";
            if (!AllcombosOK()) return "Что-то пошло не так :-(";
            string group_name = "";
            if (cbLearningForm.SelectedItem.ToString() != "Годичные курсы")
            {
                if (cbLearningForm.SelectedItem.ToString() == "Полустационар") group_name += clbWeek.SelectedItem.ToString() == "Сб" ? "S" : "V";
                //if (cbDirection.SelectedItem.ToString() == "Разработка программного обеспечения")
                {
                    //DataRow[] rows = set.Tables["Directions"].Select("direction_name='Разработка программного обеспечения'");
                    //DataRow row = rows[0];
                    //group_name += row["direction_code_name"];
                    group_name += 
                        set.Tables["Directions"].Select($"direction_name='{cbDirection.SelectedItem.ToString()}'")[0]["direction_code_name"];
                    group_name +=
                        set.Tables["LearningTimes"].Select($"time_name='{CBLearningTime.SelectedItem.ToString()}'")[0]["time_code_name"];
                }
            }
            group_name += "_";
            return group_name;
        }

        private void btnGeneration_Click(object sender, EventArgs e)
        {
            //if (  cbLearningForm.Text != "Выберите форму обучения" 
            //    & cbDirection.Text != "Выберите направление обучения" 
            //    & CBLearningTime.Text != "Выберите время обучения")
            tbGroupName.Text = GenereteGroupName();
        }

        private void cbLearningForm_SelectedIndexChanged(object sender, EventArgs e)
        {

            //mainForm.LoadDataToComboBox
            //cbDirection.Text = "Выберите форму обучения";
            //    (cbDirection,
            //    "Directions, LearningForms, LearningFormsDirectionsRelation",
            //    "direction_name",
            //    "",
            //    $@"WHERE LearningFormsDirectionsRelation.learning_form = LearningForms.form_id
            //       AND LearningFormsDirectionsRelation.direction       = Directions.direction_id
            //       AND form_name = '{cbLearningForm.SelectedItem.ToString()}'"
            //    );
            int selectedIndexInDirection = cbDirection.SelectedIndex;
            string directionName = cbDirection.SelectedItem?.ToString();

            cbDirection.Items.Clear();
            cbDirection.Text = "Выберите направление обучения";
            if (cbLearningForm.SelectedIndex != 0)
            {
                mainForm.LoadDataFromStorageToComboBox
                   (
                    cbDirection,
                    "Directions, LearningForms, LearningFormsDirectionsRelation",
                    "direction_name",
                    "Выберите форму обучения",
                    $@"LearningFormsDirectionsRelation.learning_form = LearningForms.form_id
                        AND LearningFormsDirectionsRelation.direction       = Directions.direction_id
                        AND form_name = '{cbLearningForm.SelectedItem.ToString()}'"
                    );
                //cbDirection.SelectedIndex = selectedIndexInDirection < cbDirection.Items.Count ? selectedIndexInDirection : -1;
                //cbDirection.Text = cbDirection.Items[0].ToString();
                bool badDirection = false;
                if (selectedIndexInDirection < cbDirection.Items.Count)
                {
                    cbDirection.SelectedIndex = selectedIndexInDirection;
                }
                else
                {
                    badDirection = true;
                }
                if (directionName != cbDirection.SelectedItem?.ToString()) badDirection = true;
                if (badDirection)
                {
                    cbDirection.SelectedIndex = -1;
                    cbDirection.Text = "Выберите направление обучения";
                    MessageBox.Show(this, "На форме обучения нет такого направления", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbDirection.Select();
                }

            }
            
        }

        private void clbWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLearningDaysCode.Text = $"Дни обучения: {GetBitSet()}";
        }
        bool ComboBoxOK(System.Windows.Forms.ComboBox comboBox)
        {
            if (comboBox.SelectedItem == null) return false;
            if (comboBox.SelectedItem.ToString().Contains(" обучения")) return false;
            return true;
        }
        bool AllcombosOK()
        {
            string message = "";
            if (cbLearningForm.SelectedItem.ToString() == "Выберите форму обучения") message = "Выберите форму обучения";
            else if (cbDirection.SelectedItem == null || cbDirection.SelectedItem.ToString() == "Выберите направление обучения") message = "Выберите направление обучения";
            else if (cbTime.SelectedItem.ToString() == "Выберите время обучения") message = "Выберите время обучения";
            if (message.Length > 0)
            {
                MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            if (AllcombosOK() == false)  return; 
            //if (
            //    !ComboBoxOK(cbLearningForm) ||
            //    !ComboBoxOK(cbDirection) ||
            //    !ComboBoxOK(cbTime)
            //    )
            //{
            //    MessageBox.Show(this, "Ничего не выбрано", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            bool wrong_days = false;
            if (cbLearningForm.SelectedItem.ToString() == "Стационар"       && clbWeek.CheckedItems.Count != 3) wrong_days = true;
            if (cbLearningForm.SelectedItem.ToString() == "Полустационар"   && clbWeek.CheckedItems.Count != 1) wrong_days = true;
            if (cbLearningForm.SelectedItem.ToString() == "Годичные курсы"  && clbWeek.CheckedItems.Count != 2) wrong_days = true;
            if (wrong_days) MessageBox.Show(this, "Проверьте дни обучения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show(this, "Всё хорошо ;-)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (wrong_days) return;

            TablesStorage storage = new TablesStorage();
            storage.GetDataFromBase("Directions");
            storage.GetDataFromBase("LearningTimes");
            storage.GetDataFromBase("Groups");

            //string insert_cmd = $@"
            //    INSERT INTO Groups(group_name, direction, learning_time, learning_days)
            //    VALUES (
            //        '{tbGroupName.Text}',
            //        {set.Tables["Directions"].Select($"direction_name='{cbDirection.SelectedItem.ToString()}'")[0]["direction_id"]},
            //        {set.Tables["LearningTimes"].Select($"time_name='{cbTime.SelectedItem.ToString()}'")[0]["time_id"]},
            //        {GetBitSet()}
            //        )";
            //storage.Adapter.InsertCommand.ExecuteNonQuery();
            //storage.Insert(insert_cmd);
            DataRow row = storage.Set.Tables["Groups"].NewRow();
            if (storage.Set.Tables["Groups"].Select($"group_name = '{tbGroupName.Text}'").Length == 0)
            {
                row["group_name"] = tbGroupName.Text;
                row["direction"] = storage.Set.Tables["Directions"].Select($"direction_name = '{cbDirection.SelectedItem.ToString()}'")[0]["direction_id"];
                row["learning_time"] = storage.Set.Tables["LearningTimes"].Select($"time_name='{cbTime.SelectedItem.ToString()}'")[0]["time_id"];
                row["learning_days"] = GetBitSet();
                storage.Set.Tables["Groups"].Rows.Add(row);
                storage.Adapter.Update(storage.Set, "Groups");
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Такая группа уже есть", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
