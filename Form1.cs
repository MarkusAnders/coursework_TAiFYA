using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace coursework_TAiFYA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_choiceFile_Click(object sender, EventArgs e) // кнопка выбрать файл
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "txt Files|*.txt" // задаем фильтр для файлов 
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK) // нажимаем ок и добавляем файл
            {
                TextMain.Text = File.ReadAllText(openFileDialog.FileName); //считываем файл в наше текстовое поле
            }
        }

        private void button_complete_Click(object sender, EventArgs e) // кнопка запустить
        {
            try
            {
                lexemes lxms = new lexemes(); // создаем экземпляр класса лексем
                lemexeClass lxmscls = new lemexeClass(); // тоже самое ТСС
                var lexemes = lxms.Check(TextMain.Text); // вызываем метод чек по нашему тексту
                var tcc = lxmscls.Classify(lexemes); // вызываем метод классификации по лексемам

                firstTable.DataSource = lexemes; // заполняем данные в таблицу лексем
                tccTable.DataSource = tcc; // заполняем данные таблицу ТСС

                #region[Вывод список значений списков]

                keywordTable.Rows.Clear(); //очищаем все строки в разделе ТСС, кроме главной таблицы
                indifTable.Rows.Clear();
                literalTable.Rows.Clear();
                separatorTable.Rows.Clear();

                #region[Ключевые слова]
                if (keywordTable.Columns.Contains("Keywords") && keywordTable.Columns.Contains("numberK"))// если таблица содержит колонки с именем .. то
                {
                    for (int i = 0; i < lxmscls.keywords.Count; i++) //проход по всему списку
                        keywordTable.Rows.Add(lxmscls.keywords[i], i.ToString()); // добавление строки слова и номера по списку
                }// даже если их некоторых нет в тексте, то они будут в таблице, так как они константа, смотри список слов в классе lexemeClass
                #endregion

                #region[Индификаторы]
                if (indifTable.Columns.Contains("Identifier") && indifTable.Columns.Contains("numberI")) // аналогично прошлому, но будем изменяться результат содержимого таблицы в зависимости от количества индификаторов
                {
                    for (int i = 0; i < lxmscls.identifiers.Count; i++)
                        indifTable.Rows.Add(lxmscls.identifiers[i], i.ToString());
                }
                #endregion

                #region[Литералы]
                if (literalTable.Columns.Contains("Litaral") && literalTable.Columns.Contains("numberL"))// аналогично индификаторам
                {
                    for (int i = 0; i < lxmscls.literals.Count; i++)
                        literalTable.Rows.Add(lxmscls.literals[i], i.ToString());
                }
                #endregion

                #region[Разделители]
                if (separatorTable.Columns.Contains("Separators") && separatorTable.Columns.Contains("numberR")) //аналогично ключевым словам
                {
                    for (int i = 0; i < lxmscls.separators_list.Count; i++)
                        separatorTable.Rows.Add(lxmscls.separators_list[i], i.ToString());
                }
                #endregion

                #endregion

                SettingTable(); // вызываем метод настройки визуала таблиц 
            }
            catch (Exception ex) // если вдруг не получилось заполнить таблицы данными будет характерная ошибка
			{
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_clearRichBox_Click(object sender, EventArgs e) //кнопка очисить
        {
            TextMain.Clear(); //простая очистка текста
        }

        private void SettingTable() //задаем настроки визуала таблицам
		{
            firstTable.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            firstTable.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 11);
            firstTable.Columns[0].HeaderText = "Лексема";
            firstTable.Columns[1].HeaderText = "Тип лексемы";
            firstTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            tccTable.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            tccTable.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 11);
            tccTable.Columns[0].HeaderText = "Входные данные";
            tccTable.Columns[1].HeaderText = "Результат";
            tccTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            keywordTable.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            keywordTable.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 10);

            literalTable.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            literalTable.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 10);

            indifTable.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            indifTable.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 10);

            separatorTable.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            separatorTable.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
        }
    }
}
