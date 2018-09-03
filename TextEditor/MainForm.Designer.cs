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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numFont = new System.Windows.Forms.NumericUpDown();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSymbolCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
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
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contMenuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.contMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.contMenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.contMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contMenuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.contMenuSeleactAll = new System.Windows.Forms.ToolStripMenuItem();
            this.contMenuPasteDateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cntxtMenuSearch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxtMenuSearchHide = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCountIdent = new System.Windows.Forms.ToolStripStatusLabel();
            this.lebelCountIdent = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.cntxtMenuSearch.SuspendLayout();
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblSymbolCount,
            this.lblCountIdent,
            this.lebelCountIdent});
            this.statusStrip.Location = new System.Drawing.Point(0, 490);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(887, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip";
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
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(887, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip";
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
            this.toolStripSeparator2,
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
            this.butSearch.ContextMenuStrip = this.cntxtMenuSearch;
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
            this.textBox.ContextMenuStrip = this.contextMenu;
            this.textBox.Location = new System.Drawing.Point(24, 48);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(841, 430);
            this.textBox.TabIndex = 13;
            this.textBox.Text = "";
            // 
            // comboFont
            // 
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
            this.comboFont.Size = new System.Drawing.Size(116, 21);
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
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contMenuCut,
            this.contMenuCopy,
            this.contMenuPaste,
            this.contMenuDelete,
            this.toolStripSeparator1,
            this.contMenuSearch,
            this.contMenuSeleactAll,
            this.contMenuPasteDateTime});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(149, 164);
            // 
            // contMenuCut
            // 
            this.contMenuCut.Name = "contMenuCut";
            this.contMenuCut.Size = new System.Drawing.Size(148, 22);
            this.contMenuCut.Text = "Вырезать";
            // 
            // contMenuCopy
            // 
            this.contMenuCopy.Name = "contMenuCopy";
            this.contMenuCopy.Size = new System.Drawing.Size(148, 22);
            this.contMenuCopy.Text = "Копировать";
            // 
            // contMenuPaste
            // 
            this.contMenuPaste.Name = "contMenuPaste";
            this.contMenuPaste.Size = new System.Drawing.Size(148, 22);
            this.contMenuPaste.Text = "Вставить";
            // 
            // contMenuDelete
            // 
            this.contMenuDelete.Name = "contMenuDelete";
            this.contMenuDelete.Size = new System.Drawing.Size(148, 22);
            this.contMenuDelete.Text = "Удалить";
            // 
            // contMenuSearch
            // 
            this.contMenuSearch.Name = "contMenuSearch";
            this.contMenuSearch.Size = new System.Drawing.Size(148, 22);
            this.contMenuSearch.Text = "Найти";
            // 
            // contMenuSeleactAll
            // 
            this.contMenuSeleactAll.Name = "contMenuSeleactAll";
            this.contMenuSeleactAll.Size = new System.Drawing.Size(148, 22);
            this.contMenuSeleactAll.Text = "Вделить все";
            // 
            // contMenuPasteDateTime
            // 
            this.contMenuPasteDateTime.Name = "contMenuPasteDateTime";
            this.contMenuPasteDateTime.Size = new System.Drawing.Size(148, 22);
            this.contMenuPasteDateTime.Text = "Вставить дату";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // cntxtMenuSearch
            // 
            this.cntxtMenuSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxtMenuSearchHide});
            this.cntxtMenuSearch.Name = "contextMenuStrip1";
            this.cntxtMenuSearch.Size = new System.Drawing.Size(116, 26);
            // 
            // cntxtMenuSearchHide
            // 
            this.cntxtMenuSearchHide.Name = "cntxtMenuSearchHide";
            this.cntxtMenuSearchHide.Size = new System.Drawing.Size(115, 22);
            this.cntxtMenuSearchHide.Text = "Скрыть";
            // 
            // lblCountIdent
            // 
            this.lblCountIdent.Name = "lblCountIdent";
            this.lblCountIdent.Size = new System.Drawing.Size(146, 17);
            this.lblCountIdent.Text = "Количество совпадений: ";
            // 
            // lebelCountIdent
            // 
            this.lebelCountIdent.Name = "lebelCountIdent";
            this.lebelCountIdent.Size = new System.Drawing.Size(0, 17);
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
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.numFont);
            this.Controls.Add(this.label2);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(530, 300);
            this.Name = "MainForm";
            this.Text = "Текстовый редактор";
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.cntxtMenuSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFont;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblSymbolCount;
        private System.Windows.Forms.MenuStrip menuStrip;
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
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contMenuCut;
        private System.Windows.Forms.ToolStripMenuItem contMenuCopy;
        private System.Windows.Forms.ToolStripMenuItem contMenuPaste;
        private System.Windows.Forms.ToolStripMenuItem contMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem contMenuSearch;
        private System.Windows.Forms.ToolStripMenuItem contMenuSeleactAll;
        private System.Windows.Forms.ToolStripMenuItem contMenuPasteDateTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip cntxtMenuSearch;
        private System.Windows.Forms.ToolStripMenuItem cntxtMenuSearchHide;
        private System.Windows.Forms.ToolStripStatusLabel lblCountIdent;
        private System.Windows.Forms.ToolStripStatusLabel lebelCountIdent;
    }
}

