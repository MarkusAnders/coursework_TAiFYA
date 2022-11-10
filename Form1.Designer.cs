
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
			this.TextMain = new System.Windows.Forms.RichTextBox();
			this.tccTable = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.literalTable = new System.Windows.Forms.DataGridView();
			this.separatorTable = new System.Windows.Forms.DataGridView();
			this.indifTable = new System.Windows.Forms.DataGridView();
			this.keywordTable = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.firstTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tccTable)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.literalTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.separatorTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.indifTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.keywordTable)).BeginInit();
			this.menuStrip1.SuspendLayout();
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
			// TextMain
			// 
			this.TextMain.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TextMain.Location = new System.Drawing.Point(1030, 55);
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
			this.tabControl1.Location = new System.Drawing.Point(0, 30);
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
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.запуститьToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1259, 31);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// загрузитьToolStripMenuItem
			// 
			this.загрузитьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
			this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
			this.загрузитьToolStripMenuItem.Text = "Загрузить";
			this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
			// 
			// запуститьToolStripMenuItem
			// 
			this.запуститьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
			this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
			this.запуститьToolStripMenuItem.Text = "Запустить";
			this.запуститьToolStripMenuItem.Click += new System.EventHandler(this.запуститьToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1259, 493);
			this.Controls.Add(this.TextMain);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
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
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView firstTable;
		private System.Windows.Forms.RichTextBox TextMain;
		public System.Windows.Forms.DataGridView tccTable;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView literalTable;
		private System.Windows.Forms.DataGridView separatorTable;
		private System.Windows.Forms.DataGridView indifTable;
		private System.Windows.Forms.DataGridView keywordTable;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem запуститьToolStripMenuItem;
	}
}

