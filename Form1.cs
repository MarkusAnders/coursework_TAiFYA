using System;
using System.IO;
using System.Windows.Forms;

namespace coursework_TAiFYA
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void load_file_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				TextMain.Text = File.ReadAllText(ofd.FileName);
			}
		}

		private void PerformToLexemAnalys_Click(object sender, EventArgs e)
		{
            lexemes lxms = new lexemes();
            lemexeClass lxmscls = new lemexeClass();
            var lexemes = lxms.Check(TextMain.Text);
            var tcc = lxmscls.Classify(lexemes);
            firstTable.DataSource = lexemes;
            tccTable.DataSource = tcc;

            if (!keywordTable.Columns.Contains("Keywords"))
            {
                keywordTable.Columns.Add("Keywords", "Ключевые слова");
                foreach (var i in lxmscls.keywords)
                {
                    keywordTable.Rows.Add(i.ToString());
                }
            }
            else
            {
                keywordTable.Rows.Clear();
                foreach (var i in lxmscls.keywords)
                {
                    keywordTable.Rows.Add(i.ToString());
                }
            }


            if (!indifTable.Columns.Contains("Identifier"))
            {
                indifTable.Columns.Add("Identifier", "Индификатор");

                foreach (var i in lxmscls.identifiers)
                {
                    indifTable.Rows.Add(i.ToString());
                }
            }
            else
            {
                indifTable.Rows.Clear();
                foreach (var i in lxmscls.identifiers)
                {
                    indifTable.Rows.Add(i.ToString());
                }
            }

            if (!literalTable.Columns.Contains("Litaral"))
            {
                literalTable.Columns.Add("Litaral", "Литерал");
                foreach (var i in lxmscls.literals)
                {
                    literalTable.Rows.Add(i.ToString());
                }
            }
            else
            {
                literalTable.Rows.Clear();
                foreach (var i in lxmscls.literals)
                {
                    literalTable.Rows.Add(i.ToString());
                }
            }

            if (!separatorTable.Columns.Contains("Separators"))
            {
                separatorTable.Columns.Add("Separators", "Разделитель");
                foreach (var i in lxmscls.separators_list)
                {
                    separatorTable.Rows.Add(i.ToString());
                }
            }
            else
            {
                separatorTable.Rows.Clear();
                foreach (var i in lxmscls.separators_list)
                {
                    separatorTable.Rows.Add(i.ToString());
                }
            }
        }
	}
}
