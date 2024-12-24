namespace Tyuiu.GulahmedovTE.Sprint7.Task0.V5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            openFileDialogButton_GTE = new OpenFileDialog();
            saveFileDialogMain_GTE = new SaveFileDialog();
            formMainbindingSource_GTE = new BindingSource(components);
            groupBox1 = new GroupBox();
            buttonOpenFile_GTE = new Button();
            buttonSaveFile_GTE = new Button();
            groupBox2 = new GroupBox();
            label10 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            textBoxPriceAdd_GTE = new TextBox();
            textBoxPostavshikAdd_GTE = new TextBox();
            textBoxCountUpakovokadd_GTE = new TextBox();
            textBoxCountUpaAdd_GTE = new TextBox();
            textBoxCountSkadAdd_GTE = new TextBox();
            textBoxNameAdd_GTE = new TextBox();
            label5 = new Label();
            textBoxOtdelAdd_GTE = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBoxArticuleAdd_GTE = new TextBox();
            buttonAdmin_GTE = new Button();
            buttonGrafic = new Button();
            comboBoxFilter_GTE = new ComboBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            textBoxPoiskName_GTE = new TextBox();
            groupBox4 = new GroupBox();
            label2 = new Label();
            chart_GTE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewMatrix_GTE = new DataGridView();
            Articule_GTE = new DataGridViewTextBoxColumn();
            otdel_GTE = new DataGridViewTextBoxColumn();
            name_GTE = new DataGridViewTextBoxColumn();
            CountSklad_GTE = new DataGridViewTextBoxColumn();
            CountUpakovka_GTE = new DataGridViewTextBoxColumn();
            CountUpakovok_GTE = new DataGridViewTextBoxColumn();
            postavshik_GTE = new DataGridViewTextBoxColumn();
            price_GTE = new DataGridViewTextBoxColumn();
            groupBox5 = new GroupBox();
            pictureBox2 = new PictureBox();
            groupBox6 = new GroupBox();
            pictureBox1 = new PictureBox();
            buttonAddRow_GTE = new Button();
            splitter1 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)formMainbindingSource_GTE).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_GTE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_GTE).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialogButton_GTE
            // 
            openFileDialogButton_GTE.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSlateGray;
            groupBox1.Controls.Add(buttonOpenFile_GTE);
            groupBox1.Controls.Add(buttonSaveFile_GTE);
            groupBox1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(60, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 132);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // buttonOpenFile_GTE
            // 
            buttonOpenFile_GTE.BackColor = Color.White;
            buttonOpenFile_GTE.ForeColor = Color.DarkSlateGray;
            buttonOpenFile_GTE.Location = new Point(21, 41);
            buttonOpenFile_GTE.Name = "buttonOpenFile_GTE";
            buttonOpenFile_GTE.Size = new Size(146, 52);
            buttonOpenFile_GTE.TabIndex = 1;
            buttonOpenFile_GTE.Text = "Выбрать файл";
            buttonOpenFile_GTE.UseVisualStyleBackColor = false;
            buttonOpenFile_GTE.Click += buttonOpenFile_GTE_Click;
            // 
            // buttonSaveFile_GTE
            // 
            buttonSaveFile_GTE.BackColor = Color.White;
            buttonSaveFile_GTE.ForeColor = Color.DarkSlateGray;
            buttonSaveFile_GTE.Location = new Point(173, 41);
            buttonSaveFile_GTE.Name = "buttonSaveFile_GTE";
            buttonSaveFile_GTE.Size = new Size(146, 52);
            buttonSaveFile_GTE.TabIndex = 2;
            buttonSaveFile_GTE.Text = "Сохранить файл";
            buttonSaveFile_GTE.UseVisualStyleBackColor = false;
            buttonSaveFile_GTE.Click += buttonSaveFile_GTE_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkSlateGray;
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBoxPriceAdd_GTE);
            groupBox2.Controls.Add(textBoxPostavshikAdd_GTE);
            groupBox2.Controls.Add(textBoxCountUpakovokadd_GTE);
            groupBox2.Controls.Add(textBoxCountUpaAdd_GTE);
            groupBox2.Controls.Add(textBoxCountSkadAdd_GTE);
            groupBox2.Controls.Add(textBoxNameAdd_GTE);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxOtdelAdd_GTE);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxArticuleAdd_GTE);
            groupBox2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(406, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 358);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавление товара";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(15, 223);
            label10.Name = "label10";
            label10.Size = new Size(149, 21);
            label10.TabIndex = 19;
            label10.Text = "Кол-во упаковок";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(15, 296);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 18;
            label7.Text = "Цена";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(15, 258);
            label8.Name = "label8";
            label8.Size = new Size(102, 21);
            label8.TabIndex = 17;
            label8.Text = "Поставщик";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(15, 72);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 16;
            label9.Text = "Отдел";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(15, 187);
            label6.Name = "label6";
            label6.Size = new Size(162, 21);
            label6.TabIndex = 15;
            label6.Text = "Кол-во в упаковке";
            // 
            // textBoxPriceAdd_GTE
            // 
            textBoxPriceAdd_GTE.Location = new Point(211, 300);
            textBoxPriceAdd_GTE.Name = "textBoxPriceAdd_GTE";
            textBoxPriceAdd_GTE.Size = new Size(114, 28);
            textBoxPriceAdd_GTE.TabIndex = 14;
            // 
            // textBoxPostavshikAdd_GTE
            // 
            textBoxPostavshikAdd_GTE.Location = new Point(211, 262);
            textBoxPostavshikAdd_GTE.Name = "textBoxPostavshikAdd_GTE";
            textBoxPostavshikAdd_GTE.Size = new Size(114, 28);
            textBoxPostavshikAdd_GTE.TabIndex = 13;
            // 
            // textBoxCountUpakovokadd_GTE
            // 
            textBoxCountUpakovokadd_GTE.Location = new Point(211, 223);
            textBoxCountUpakovokadd_GTE.Name = "textBoxCountUpakovokadd_GTE";
            textBoxCountUpakovokadd_GTE.Size = new Size(114, 28);
            textBoxCountUpakovokadd_GTE.TabIndex = 12;
            // 
            // textBoxCountUpaAdd_GTE
            // 
            textBoxCountUpaAdd_GTE.Location = new Point(211, 184);
            textBoxCountUpaAdd_GTE.Name = "textBoxCountUpaAdd_GTE";
            textBoxCountUpaAdd_GTE.Size = new Size(114, 28);
            textBoxCountUpaAdd_GTE.TabIndex = 11;
            // 
            // textBoxCountSkadAdd_GTE
            // 
            textBoxCountSkadAdd_GTE.Location = new Point(211, 146);
            textBoxCountSkadAdd_GTE.Name = "textBoxCountSkadAdd_GTE";
            textBoxCountSkadAdd_GTE.Size = new Size(114, 28);
            textBoxCountSkadAdd_GTE.TabIndex = 10;
            // 
            // textBoxNameAdd_GTE
            // 
            textBoxNameAdd_GTE.Location = new Point(211, 108);
            textBoxNameAdd_GTE.Name = "textBoxNameAdd_GTE";
            textBoxNameAdd_GTE.Size = new Size(114, 28);
            textBoxNameAdd_GTE.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(15, 149);
            label5.Name = "label5";
            label5.Size = new Size(153, 21);
            label5.TabIndex = 8;
            label5.Text = "Кол-во на складе";
            // 
            // textBoxOtdelAdd_GTE
            // 
            textBoxOtdelAdd_GTE.Location = new Point(211, 69);
            textBoxOtdelAdd_GTE.Name = "textBoxOtdelAdd_GTE";
            textBoxOtdelAdd_GTE.Size = new Size(114, 28);
            textBoxOtdelAdd_GTE.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(15, 111);
            label4.Name = "label4";
            label4.Size = new Size(192, 21);
            label4.TabIndex = 6;
            label4.Text = "Наименование товара\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(15, 33);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 5;
            label3.Text = "Артикул";
            // 
            // textBoxArticuleAdd_GTE
            // 
            textBoxArticuleAdd_GTE.Location = new Point(211, 31);
            textBoxArticuleAdd_GTE.Name = "textBoxArticuleAdd_GTE";
            textBoxArticuleAdd_GTE.Size = new Size(114, 28);
            textBoxArticuleAdd_GTE.TabIndex = 0;
            // 
            // buttonAdmin_GTE
            // 
            buttonAdmin_GTE.BackgroundImage = Properties.Resources.help;
            buttonAdmin_GTE.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAdmin_GTE.Location = new Point(12, 12);
            buttonAdmin_GTE.Name = "buttonAdmin_GTE";
            buttonAdmin_GTE.Size = new Size(38, 37);
            buttonAdmin_GTE.TabIndex = 9;
            buttonAdmin_GTE.UseVisualStyleBackColor = true;
            buttonAdmin_GTE.Click += buttonAdmin_GTE_Click;
            // 
            // buttonGrafic
            // 
            buttonGrafic.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            buttonGrafic.ForeColor = Color.DarkSlateGray;
            buttonGrafic.Location = new Point(75, 25);
            buttonGrafic.Name = "buttonGrafic";
            buttonGrafic.Size = new Size(149, 54);
            buttonGrafic.TabIndex = 0;
            buttonGrafic.Text = "Показать график";
            buttonGrafic.UseVisualStyleBackColor = true;
            buttonGrafic.Click += buttonGrafic_Click;
            // 
            // comboBoxFilter_GTE
            // 
            comboBoxFilter_GTE.FormattingEnabled = true;
            comboBoxFilter_GTE.Items.AddRange(new object[] { "Мясная гастрономия", "Молочные продукты", "Рыба и морепродукты", "Овощи и фрукты", "Бакалея", "Хлебобулочные изделия", "Напитки" });
            comboBoxFilter_GTE.Location = new Point(21, 60);
            comboBoxFilter_GTE.Name = "comboBoxFilter_GTE";
            comboBoxFilter_GTE.Size = new Size(298, 28);
            comboBoxFilter_GTE.TabIndex = 0;
            comboBoxFilter_GTE.SelectedIndexChanged += comboBoxFilter_GTE_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkSlateGray;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBoxPoiskName_GTE);
            groupBox3.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(60, 282);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(340, 107);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Поиск";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 4;
            label1.Text = "По наименованию товара";
            // 
            // textBoxPoiskName_GTE
            // 
            textBoxPoiskName_GTE.Location = new Point(21, 58);
            textBoxPoiskName_GTE.Name = "textBoxPoiskName_GTE";
            textBoxPoiskName_GTE.Size = new Size(298, 28);
            textBoxPoiskName_GTE.TabIndex = 3;
            textBoxPoiskName_GTE.TextChanged += textBoxPoiskName_GTE_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.DarkSlateGray;
            groupBox4.Controls.Add(comboBoxFilter_GTE);
            groupBox4.Controls.Add(label2);
            groupBox4.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold);
            groupBox4.ForeColor = SystemColors.ControlLightLight;
            groupBox4.Location = new Point(60, 169);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(340, 107);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Сортировка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(21, 24);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 8;
            label2.Text = "По отделу";
            // 
            // chart_GTE
            // 
            chartArea1.Name = "ChartArea1";
            chart_GTE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_GTE.Legends.Add(legend1);
            chart_GTE.Location = new Point(2, 501);
            chart_GTE.Name = "chart_GTE";
            chart_GTE.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_GTE.Series.Add(series1);
            chart_GTE.Size = new Size(809, 548);
            chart_GTE.TabIndex = 8;
            // 
            // dataGridViewMatrix_GTE
            // 
            dataGridViewMatrix_GTE.BackgroundColor = Color.DarkSlateGray;
            dataGridViewMatrix_GTE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_GTE.Columns.AddRange(new DataGridViewColumn[] { Articule_GTE, otdel_GTE, name_GTE, CountSklad_GTE, CountUpakovka_GTE, CountUpakovok_GTE, postavshik_GTE, price_GTE });
            dataGridViewMatrix_GTE.Dock = DockStyle.Right;
            dataGridViewMatrix_GTE.GridColor = Color.DarkSlateGray;
            dataGridViewMatrix_GTE.Location = new Point(817, 0);
            dataGridViewMatrix_GTE.Name = "dataGridViewMatrix_GTE";
            dataGridViewMatrix_GTE.RowHeadersVisible = false;
            dataGridViewMatrix_GTE.Size = new Size(1087, 1041);
            dataGridViewMatrix_GTE.TabIndex = 10;
            // 
            // Articule_GTE
            // 
            Articule_GTE.HeaderText = "Артикул";
            Articule_GTE.Name = "Articule_GTE";
            // 
            // otdel_GTE
            // 
            otdel_GTE.HeaderText = "Отдел";
            otdel_GTE.Name = "otdel_GTE";
            // 
            // name_GTE
            // 
            name_GTE.HeaderText = "Наименование товара";
            name_GTE.Name = "name_GTE";
            // 
            // CountSklad_GTE
            // 
            CountSklad_GTE.HeaderText = "Кол-во на складе";
            CountSklad_GTE.Name = "CountSklad_GTE";
            // 
            // CountUpakovka_GTE
            // 
            CountUpakovka_GTE.HeaderText = "Кол-во в упаковке";
            CountUpakovka_GTE.Name = "CountUpakovka_GTE";
            // 
            // CountUpakovok_GTE
            // 
            CountUpakovok_GTE.HeaderText = "Кол-во упаковок";
            CountUpakovok_GTE.Name = "CountUpakovok_GTE";
            // 
            // postavshik_GTE
            // 
            postavshik_GTE.HeaderText = "Поставщик";
            postavshik_GTE.Name = "postavshik_GTE";
            // 
            // price_GTE
            // 
            price_GTE.HeaderText = "Цена";
            price_GTE.Name = "price_GTE";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.DarkSlateGray;
            groupBox5.Controls.Add(pictureBox2);
            groupBox5.Controls.Add(buttonGrafic);
            groupBox5.Location = new Point(60, 395);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(340, 100);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(230, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.DarkSlateGray;
            groupBox6.Controls.Add(pictureBox1);
            groupBox6.Controls.Add(buttonAddRow_GTE);
            groupBox6.Location = new Point(407, 395);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(340, 100);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(259, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // buttonAddRow_GTE
            // 
            buttonAddRow_GTE.Location = new Point(104, 26);
            buttonAddRow_GTE.Name = "buttonAddRow_GTE";
            buttonAddRow_GTE.Size = new Size(149, 54);
            buttonAddRow_GTE.TabIndex = 0;
            buttonAddRow_GTE.Text = "Добавить";
            buttonAddRow_GTE.UseVisualStyleBackColor = true;
            buttonAddRow_GTE.Click += buttonAddRow_GTE_Click;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Right;
            splitter1.Location = new Point(807, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 1041);
            splitter1.TabIndex = 13;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1904, 1041);
            Controls.Add(splitter1);
            Controls.Add(groupBox6);
            Controls.Add(buttonAdmin_GTE);
            Controls.Add(groupBox5);
            Controls.Add(dataGridViewMatrix_GTE);
            Controls.Add(groupBox4);
            Controls.Add(chart_GTE);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            ForeColor = Color.DarkSlateGray;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormMain";
            Text = "Оптовая база";
            ((System.ComponentModel.ISupportInitialize)formMainbindingSource_GTE).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_GTE).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_GTE).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialogButton_GTE;
        private SaveFileDialog saveFileDialogMain_GTE;
        private BindingSource formMainbindingSource_GTE;
        private GroupBox groupBox1;
        private Button buttonOpenFile_GTE;
        private Button buttonSaveFile_GTE;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox textBoxPoiskName_GTE;
        private GroupBox groupBox4;
        private Label label2;
        private ComboBox comboBoxFilter_GTE;
        private Button buttonGrafic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_GTE;
        private Button buttonAdmin_GTE;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label6;
        private TextBox textBoxPriceAdd_GTE;
        private TextBox textBoxPostavshikAdd_GTE;
        private TextBox textBoxCountUpakovokadd_GTE;
        private TextBox textBoxCountUpaAdd_GTE;
        private TextBox textBoxCountSkadAdd_GTE;
        private TextBox textBoxNameAdd_GTE;
        private Label label5;
        private TextBox textBoxOtdelAdd_GTE;
        private Label label4;
        private Label label3;
        private TextBox textBoxArticuleAdd_GTE;
        private DataGridView dataGridViewMatrix_GTE;
        private DataGridViewTextBoxColumn Articule_GTE;
        private DataGridViewTextBoxColumn otdel_GTE;
        private DataGridViewTextBoxColumn name_GTE;
        private DataGridViewTextBoxColumn CountSklad_GTE;
        private DataGridViewTextBoxColumn CountUpakovka_GTE;
        private DataGridViewTextBoxColumn CountUpakovok_GTE;
        private DataGridViewTextBoxColumn postavshik_GTE;
        private DataGridViewTextBoxColumn price_GTE;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Button buttonAddRow_GTE;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Splitter splitter1;
    }
}
