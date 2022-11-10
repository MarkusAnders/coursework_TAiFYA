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
			var lexemes = lxms.Check(TextMain.Text);
			firstTable.DataSource = lexemes;
		}
	}
}
