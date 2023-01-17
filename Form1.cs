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
            lexemes lxms = new lexemes();
            lemexeClass lxmscls = new lemexeClass();
            var lexemes = lxms.Check(TextMain.Text);
            var tcc = lxmscls.Classify(lexemes);

            firstTable.DataSource = lexemes;
            tccTable.DataSource = tcc;

            #region[Вывод список значений списков]

            #region[Ключевые слова]
            if (keywordTable.Columns.Contains("Keywords"))
            {
                foreach (var i in lxmscls.keywords)
                {
                    keywordTable.Rows.Add(i.ToString());
                }
            }
            #endregion

            #region[Индификаторы]
            if (indifTable.Columns.Contains("Identifier"))
            {
                foreach (var i in lxmscls.identifiers)
                {
                    indifTable.Rows.Add(i.ToString());
                }
            }
            #endregion

            #region[Литералы]
            if (literalTable.Columns.Contains("Litaral"))
            {
                foreach (var i in lxmscls.literals)
                {
                    literalTable.Rows.Add(i.ToString());
                }
            }
            #endregion

            #region[Разделители]
            if (separatorTable.Columns.Contains("Separators"))
            {
                foreach (var i in lxmscls.separators_list)
                {
                    separatorTable.Rows.Add(i.ToString());
                }
            }
            #endregion

            #endregion

            #region[Настройка вида таблиц]
            firstTable.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            firstTable.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 11);
            tccTable.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            tccTable.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 11);
            tccTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            keywordTable.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            keywordTable.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 11);
            literalTable.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            literalTable.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 11);
            indifTable.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            indifTable.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 11);
            separatorTable.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            separatorTable.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 11);
            #endregion
        }
        private void button_clearRichBox_Click(object sender, EventArgs e)
        {
            TextMain.Clear();
        }
    }
}
