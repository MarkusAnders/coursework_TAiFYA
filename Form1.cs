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

        private void button_choiceFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextMain.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void button_complete_Click(object sender, EventArgs e)
        {
			try
			{
                lexemes lxms = new lexemes();
                lemexeClass lxmscls = new lemexeClass();
                var lexemes = lxms.Check(TextMain.Text);
                var tcc = lxmscls.Classify(lexemes);

                firstTable.DataSource = lexemes;
                tccTable.DataSource = tcc;

                #region[Вывод список значений списков]

                keywordTable.Rows.Clear();
                indifTable.Rows.Clear();
                literalTable.Rows.Clear();
                separatorTable.Rows.Clear();

                #region[Ключевые слова]
                if (keywordTable.Columns.Contains("Keywords") && keywordTable.Columns.Contains("numberK"))
                {
                    for (int i = 0; i < lxmscls.keywords.Count; i++)
                        keywordTable.Rows.Add(lxmscls.keywords[i], i.ToString());
                }
                #endregion

                #region[Индификаторы]
                if (indifTable.Columns.Contains("Identifier") && indifTable.Columns.Contains("numberI"))
                {
                    for (int i = 0; i < lxmscls.identifiers.Count; i++)
                        indifTable.Rows.Add(lxmscls.identifiers[i], i.ToString());
                }
                #endregion

                #region[Литералы]
                if (literalTable.Columns.Contains("Litaral") && literalTable.Columns.Contains("numberL"))
                {
                    for (int i = 0; i < lxmscls.literals.Count; i++)
                        literalTable.Rows.Add(lxmscls.literals[i], i.ToString());
                }
                #endregion

                #region[Разделители]
                if (separatorTable.Columns.Contains("Separators") && separatorTable.Columns.Contains("numberR"))
                {
                    for (int i = 0; i < lxmscls.separators_list.Count; i++)
                        separatorTable.Rows.Add(lxmscls.separators_list[i], i.ToString());
                }
                #endregion

                #endregion

                SettingTable();
            }
            catch (Exception ex)
			{
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_clearRichBox_Click(object sender, EventArgs e)
        {
            TextMain.Clear();
        }

        private void SettingTable()
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
