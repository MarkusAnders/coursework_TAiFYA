
namespace coursework_TAiFYA
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.firstTable = new System.Windows.Forms.DataGridView();
			this.PerformToLexemAnalys = new System.Windows.Forms.Button();
			this.load_file = new System.Windows.Forms.Button();
			this.TextMain = new System.Windows.Forms.RichTextBox();
			this.tccTable = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.literalTable = new System.Windows.Forms.DataGridView();
			this.separatorTable = new System.Windows.Forms.DataGridView();
			this.indifTable = new System.Windows.Forms.DataGridView();
			this.keywordTable = new System.Windows.Forms.DataGridView();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.firstTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tccTable)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.literalTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.separatorTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.indifTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.keywordTable)).BeginInit();
			this.SuspendLayout();
			// 
			// tabPage1
			// 
			this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPage1.Controls.Add(this.firstTable);
			this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1020, 428);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Лексический анализ";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// firstTable
			// 
			this.firstTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.firstTable.Location = new System.Drawing.Point(0, 0);
			this.firstTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.firstTable.Name = "firstTable";
			this.firstTable.RowHeadersWidth = 51;
			this.firstTable.RowTemplate.Height = 24;
			this.firstTable.Size = new System.Drawing.Size(338, 428);
			this.firstTable.TabIndex = 0;
			// 
			// PerformToLexemAnalys
			// 
			this.PerformToLexemAnalys.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PerformToLexemAnalys.Location = new System.Drawing.Point(177, 466);
			this.PerformToLexemAnalys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PerformToLexemAnalys.Name = "PerformToLexemAnalys";
			this.PerformToLexemAnalys.Size = new System.Drawing.Size(165, 45);
			this.PerformToLexemAnalys.TabIndex = 8;
			this.PerformToLexemAnalys.Text = "Выполнить";
			this.PerformToLexemAnalys.UseVisualStyleBackColor = true;
			this.PerformToLexemAnalys.Click += new System.EventHandler(this.PerformToLexemAnalys_Click);
			// 
			// load_file
			// 
			this.load_file.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.load_file.Location = new System.Drawing.Point(6, 466);
			this.load_file.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.load_file.Name = "load_file";
			this.load_file.Size = new System.Drawing.Size(165, 45);
			this.load_file.TabIndex = 7;
			this.load_file.Text = "Загрузить";
			this.load_file.UseVisualStyleBackColor = true;
			this.load_file.Click += new System.EventHandler(this.load_file_Click);
			// 
			// TextMain
			// 
			this.TextMain.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TextMain.Location = new System.Drawing.Point(1032, 31);
			this.TextMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TextMain.Name = "TextMain";
			this.TextMain.Size = new System.Drawing.Size(225, 428);
			this.TextMain.TabIndex = 6;
			this.TextMain.Text = "";
			// 
			// tccTable
			// 
			this.tccTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tccTable.Location = new System.Drawing.Point(0, 0);
			this.tccTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tccTable.Name = "tccTable";
			this.tccTable.RowHeadersWidth = 51;
			this.tccTable.RowTemplate.Height = 24;
			this.tccTable.Size = new System.Drawing.Size(338, 428);
			this.tccTable.TabIndex = 4;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(2, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1028, 457);
			this.tabControl1.TabIndex = 9;
			// 
			// tabPage2
			// 
			this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPage2.Controls.Add(this.literalTable);
			this.tabPage2.Controls.Add(this.tccTable);
			this.tabPage2.Controls.Add(this.separatorTable);
			this.tabPage2.Controls.Add(this.indifTable);
			this.tabPage2.Controls.Add(this.keywordTable);
			this.tabPage2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1020, 428);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "ТСС таблица";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// literalTable
			// 
			this.literalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.literalTable.Location = new System.Drawing.Point(340, 215);
			this.literalTable.Name = "literalTable";
			this.literalTable.RowHeadersWidth = 51;
			this.literalTable.RowTemplate.Height = 24;
			this.literalTable.Size = new System.Drawing.Size(339, 213);
			this.literalTable.TabIndex = 3;
			// 
			// separatorTable
			// 
			this.separatorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.separatorTable.Location = new System.Drawing.Point(682, 215);
			this.separatorTable.Name = "separatorTable";
			this.separatorTable.RowHeadersWidth = 51;
			this.separatorTable.RowTemplate.Height = 24;
			this.separatorTable.Size = new System.Drawing.Size(339, 213);
			this.separatorTable.TabIndex = 2;
			// 
			// indifTable
			// 
			this.indifTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.indifTable.Location = new System.Drawing.Point(682, 0);
			this.indifTable.Name = "indifTable";
			this.indifTable.RowHeadersWidth = 51;
			this.indifTable.RowTemplate.Height = 24;
			this.indifTable.Size = new System.Drawing.Size(339, 213);
			this.indifTable.TabIndex = 1;
			// 
			// keywordTable
			// 
			this.keywordTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.keywordTable.Location = new System.Drawing.Point(340, 0);
			this.keywordTable.Name = "keywordTable";
			this.keywordTable.RowHeadersWidth = 51;
			this.keywordTable.RowTemplate.Height = 24;
			this.keywordTable.Size = new System.Drawing.Size(339, 213);
			this.keywordTable.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1259, 519);
			this.Controls.Add(this.PerformToLexemAnalys);
			this.Controls.Add(this.load_file);
			this.Controls.Add(this.TextMain);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.firstTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tccTable)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.literalTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.separatorTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.indifTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.keywordTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView firstTable;
		private System.Windows.Forms.Button PerformToLexemAnalys;
		private System.Windows.Forms.Button load_file;
		private System.Windows.Forms.RichTextBox TextMain;
		public System.Windows.Forms.DataGridView tccTable;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView literalTable;
		private System.Windows.Forms.DataGridView separatorTable;
		private System.Windows.Forms.DataGridView indifTable;
		private System.Windows.Forms.DataGridView keywordTable;
	}
}

