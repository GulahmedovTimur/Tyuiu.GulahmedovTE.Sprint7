using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GulahmedovTE.Sprint7.Task0.V5.Lib;
namespace Tyuiu.GulahmedovTE.Sprint7.Task0.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        private void buttonOpenFile_GTE_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogButton_GTE.ShowDialog();
                openFilePath = openFileDialogButton_GTE.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewMatrix_GTE.RowCount = rows + 1;
                dataGridViewMatrix_GTE.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMatrix_GTE.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridViewMatrix_GTE.AutoResizeColumns();
                dataGridViewMatrix_GTE.ScrollBars = ScrollBars.Both;
                for (int i = 0; i < dataGridViewMatrix_GTE.RowCount - 1; i++)
                {

                    if (dataGridViewMatrix_GTE.Rows[i].Cells[3].Value.ToString() == "")
                    {
                        dataGridViewMatrix_GTE.Rows.RemoveAt(i);
                        i--;
                    }
                }


            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_GTE_Click(object sender, EventArgs e)
        {
            saveFileDialogMain_GTE.FileName = openFilePath;
            saveFileDialogMain_GTE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMain_GTE.ShowDialog();

            string path = saveFileDialogMain_GTE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMatrix_GTE.RowCount;
            int columns = dataGridViewMatrix_GTE.ColumnCount;

            string str = "";



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMatrix_GTE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMatrix_GTE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void textBoxPoiskName_GTE_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxPoiskName_GTE.Text.ToLower(); //приведение к нижнему регистру
            foreach (DataGridViewRow row in dataGridViewMatrix_GTE.Rows)
            {
                if (row.Cells["name_GTE"].Value != null)
                {
                    string column2Text = row.Cells["name_GTE"].Value.ToString().ToLower();
                    if (column2Text.Contains(searchText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void comboBoxFilter_GTE_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueFilt = comboBoxFilter_GTE.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox
            if (!string.IsNullOrEmpty(valueFilt))
            {
                foreach (DataGridViewRow row in dataGridViewMatrix_GTE.Rows)
                {
                    if (!row.IsNewRow) // проверка новая ли строка
                    {
                        if (row.Cells["otdel_GTE"].Value != null && row.Cells["otdel_GTE"].Value.ToString() == valueFilt)
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
        }

        private void buttonGrafic_Click(object sender, EventArgs e)
        {
            // Очищаем старый график перед построением нового
            chart_GTE.Series.Clear();
            chart_GTE.Titles.Clear();
            if (chart_GTE.ChartAreas.Count > 0)
            {
                chart_GTE.ChartAreas[0].AxisX.Title = "";
                chart_GTE.ChartAreas[0].AxisY.Title = "";
            }
            BuildChart();
        }

        private void BuildChart()
        {
            try
            {
                int rows = dataGridViewMatrix_GTE.RowCount;
                int columns = dataGridViewMatrix_GTE.ColumnCount;
                string str;
                string[,] matrix = new string[rows, columns];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        str = "";
                        str += dataGridViewMatrix_GTE.Rows[i].Cells[j].Value;
                        matrix[i, j] = str;
                    }

                }

                int summa = 0;
                int summb = 0;
                int summg = 0;
                int summd = 0;
                int summe = 0;
                int summc = 0;
                for (int i = 0; i < rows - 1; i++)
                {
                    if (matrix[i, 1] == "Мясная гастрономия")
                    {
                        summa += Convert.ToInt32(dataGridViewMatrix_GTE.Rows[i].Cells[3].Value);
                    }
                    if (matrix[i, 1] == "Молочные продукты")
                    {
                        summb += Convert.ToInt32(dataGridViewMatrix_GTE.Rows[i].Cells[3].Value);
                    }
                    if (matrix[i, 1] == "Рыба и морепродукты")
                    {
                        summg += Convert.ToInt32(dataGridViewMatrix_GTE.Rows[i].Cells[3].Value);
                    }
                    if (matrix[i, 1] == "Бакалея")
                    {
                        summd += Convert.ToInt32(dataGridViewMatrix_GTE.Rows[i].Cells[3].Value);
                    }
                    if (matrix[i, 1] == "Хлебобулочные изделия")
                    {
                        summc += Convert.ToInt32(dataGridViewMatrix_GTE.Rows[i].Cells[3].Value);
                    }
                    if (matrix[i, 1] == "Напитки")
                    {
                        summe += Convert.ToInt32(dataGridViewMatrix_GTE.Rows[i].Cells[3].Value);
                    }
                }


                string[] seriesArray = { "Мясная гастрономия", "Молочные продукты", "Рыба и морепродукты", "Бакалея", "Хлебобулочные изделия", "Напитки" };
                int[] pointsArray = { summa, summb, summg, summd, summc, summe };

                // Add series.
                for (int i = 0; i < seriesArray.Length; i++)
                {
                    // Add series.
                    Series series = this.chart_GTE.Series.Add(seriesArray[i]);

                    // Add point.
                    series.Points.Add(pointsArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Невозможно построить график", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdmin_GTE_Click(object sender, EventArgs e)
        {
            FormInfo formOProgramme = new FormInfo();
            formOProgramme.ShowDialog();
        }

        private void buttonAddRow_GTE_Click(object sender, EventArgs e)
        {
            string Articule_GTE = textBoxArticuleAdd_GTE.Text;
            string otdel_GTE = textBoxOtdelAdd_GTE.Text;
            string name_GTE = textBoxNameAdd_GTE.Text;
            string CountSklad_GTE = textBoxCountSkadAdd_GTE.Text;
            string CountUpakovka_GTE = textBoxCountUpaAdd_GTE.Text;
            string CountUpakovok_GTE = textBoxCountUpakovokadd_GTE.Text;
            string postavshik_GTE = textBoxPostavshikAdd_GTE.Text;
            string price_GTE = textBoxPriceAdd_GTE.Text;


            // заполнение
            dataGridViewMatrix_GTE.Rows.Add(Articule_GTE, otdel_GTE, name_GTE, CountSklad_GTE, CountUpakovka_GTE, CountUpakovok_GTE, postavshik_GTE, price_GTE);
            textBoxArticuleAdd_GTE.Text = "";
            textBoxOtdelAdd_GTE.Text = "";
            textBoxNameAdd_GTE.Text = "";
            textBoxCountSkadAdd_GTE.Text = "";
            textBoxCountUpaAdd_GTE.Text = "";
            textBoxCountUpakovokadd_GTE.Text = "";
            textBoxPostavshikAdd_GTE.Text = "";
            textBoxPriceAdd_GTE.Text = "";
            dataGridViewMatrix_GTE.CurrentCell = dataGridViewMatrix_GTE.Rows[dataGridViewMatrix_GTE.Rows.Count - 1].Cells[0];
        }

        private void ClearTableAndChart()
        {
            //очистка таблицы
            dataGridViewMatrix_GTE.Rows.Clear();
            dataGridViewMatrix_GTE.Refresh();

            // очистка графика
            if (chart_GTE.ChartAreas.Count > 0)
            {
                chart_GTE.Series.Clear();
                chart_GTE.ChartAreas[0].AxisX.Title = ""; // сбрасываем заголовок оси X
                chart_GTE.ChartAreas[0].AxisY.Title = ""; // сбрасываем заголовок оси Y
                chart_GTE.Titles.Clear(); // сбрасываем заголовки графика
            }

        }

        private void buttonClear_GTE_Click(object sender, EventArgs e)
        {
            FormWarn confirmationForm = new FormWarn(); // Создаем экземпляр формы подтверждения
            DialogResult result = confirmationForm.ShowDialog(this);  // Запускаем форму как диалог

            if (confirmationForm.ConfirmationResult) // Если пользователь нажал "Да"
            {
                ClearTableAndChart(); // Вызываем метод для очистки
            }
        }

        private void buttonClear_GTE_MouseEnter(object sender, EventArgs e)
        {
            buttonClear_GTE.BackColor = Color.Red;
        }

        private void buttonClear_GTE_MouseLeave(object sender, EventArgs e)
        {
            buttonClear_GTE.BackColor = SystemColors.Control;
        }
    }
}