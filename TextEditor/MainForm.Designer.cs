namespace TextEditor
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numFont = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSymbolCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCreateFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSelectFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPasteDateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.comboFont = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл:";
            // 
            // filePath
            // 
            this.filePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePath.Location = new System.Drawing.Point(433, 0);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(454, 20);
            this.filePath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Размер шрифта";
            // 
            // numFont
            // 
            this.numFont.Location = new System.Drawing.Point(128, 24);
            this.numFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numFont.Name = "numFont";
            this.numFont.Size = new System.Drawing.Size(42, 20);
            this.numFont.TabIndex = 5;
            this.numFont.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblSymbolCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(887, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabel1.Text = "Количество символов:";
            // 
            // lblSymbolCount
            // 
            this.lblSymbolCount.Name = "lblSymbolCount";
            this.lblSymbolCount.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCreateFile,
            this.itemOpenFile,
            this.itemSelectFile,
            this.itemSaveFile});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem.Text = "Файл";
            // 
            // itemCreateFile
            // 
            this.itemCreateFile.Name = "itemCreateFile";
            this.itemCreateFile.Size = new System.Drawing.Size(132, 22);
            this.itemCreateFile.Text = "Создать";
            // 
            // itemOpenFile
            // 
            this.itemOpenFile.Name = "itemOpenFile";
            this.itemOpenFile.Size = new System.Drawing.Size(132, 22);
            this.itemOpenFile.Text = "Открыть";
            // 
            // itemSelectFile
            // 
            this.itemSelectFile.Name = "itemSelectFile";
            this.itemSelectFile.Size = new System.Drawing.Size(132, 22);
            this.itemSelectFile.Text = "Выбрать";
            // 
            // itemSaveFile
            // 
            this.itemSaveFile.Name = "itemSaveFile";
            this.itemSaveFile.Size = new System.Drawing.Size(132, 22);
            this.itemSaveFile.Text = "Сохранить";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCut,
            this.itemCopy,
            this.itemPaste,
            this.itemDelete,
            this.itemSearch,
            this.itemSelectAll,
            this.itemPasteDateTime});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem1.Text = "Правка";
            // 
            // itemCut
            // 
            this.itemCut.Name = "itemCut";
            this.itemCut.Size = new System.Drawing.Size(180, 22);
            this.itemCut.Text = "Вырезать";
            // 
            // itemCopy
            // 
            this.itemCopy.Name = "itemCopy";
            this.itemCopy.Size = new System.Drawing.Size(180, 22);
            this.itemCopy.Text = "Копировать";
            // 
            // itemPaste
            // 
            this.itemPaste.Name = "itemPaste";
            this.itemPaste.Size = new System.Drawing.Size(180, 22);
            this.itemPaste.Text = "Вставить";
            // 
            // itemDelete
            // 
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.Size = new System.Drawing.Size(180, 22);
            this.itemDelete.Text = "Удалить";
            // 
            // itemSearch
            // 
            this.itemSearch.Name = "itemSearch";
            this.itemSearch.Size = new System.Drawing.Size(180, 22);
            this.itemSearch.Text = "Найти";
            // 
            // itemSelectAll
            // 
            this.itemSelectAll.Name = "itemSelectAll";
            this.itemSelectAll.Size = new System.Drawing.Size(180, 22);
            this.itemSelectAll.Text = "Выделить все";
            // 
            // itemPasteDateTime
            // 
            this.itemPasteDateTime.Name = "itemPasteDateTime";
            this.itemPasteDateTime.Size = new System.Drawing.Size(180, 22);
            this.itemPasteDateTime.Text = "Вставить дату";
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.Location = new System.Drawing.Point(731, 24);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(156, 20);
            this.textSearch.TabIndex = 11;
            // 
            // butSearch
            // 
            this.butSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSearch.Location = new System.Drawing.Point(650, 24);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 20);
            this.butSearch.TabIndex = 12;
            this.butSearch.Text = "Найти";
            this.butSearch.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(24, 48);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(841, 430);
            this.textBox.TabIndex = 13;
            this.textBox.Text = "";
            // 
            // comboFont
            // 
            this.comboFont.DisplayMember = "1";
            this.comboFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFont.FormattingEnabled = true;
            this.comboFont.Items.AddRange(new object[] {
            "Arial",
            "Calibri",
            "Fixedsys",
            "Gabriola",
            "Impact",
            "Small Fonts",
            "Symbol",
            "System",
            "Times New Roman"});
            this.comboFont.Location = new System.Drawing.Point(241, 23);
            this.comboFont.Name = "comboFont";
            this.comboFont.Size = new System.Drawing.Size(120, 21);
            this.comboFont.TabIndex = 14;
            this.comboFont.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Шрифт";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 512);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboFont);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.numFont);
            this.Controls.Add(this.label2);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(530, 300);
            this.Name = "MainForm";
            this.Text = "Текстовый редактор";
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFont;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblSymbolCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemCreateFile;
        private System.Windows.Forms.ToolStripMenuItem itemOpenFile;
        private System.Windows.Forms.ToolStripMenuItem itemSaveFile;
        private System.Windows.Forms.ToolStripMenuItem itemSelectFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemCut;
        private System.Windows.Forms.ToolStripMenuItem itemCopy;
        private System.Windows.Forms.ToolStripMenuItem itemPaste;
        private System.Windows.Forms.ToolStripMenuItem itemDelete;
        private System.Windows.Forms.ToolStripMenuItem itemSearch;
        private System.Windows.Forms.ToolStripMenuItem itemSelectAll;
        private System.Windows.Forms.ToolStripMenuItem itemPasteDateTime;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.ComboBox comboFont;
        private System.Windows.Forms.Label label3;
    }
}

