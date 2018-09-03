using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor
{
    public interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler FileCreateClick;
        event EventHandler ContentChanged;
        event EventHandler PasteDate;

    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            textBox.TextChanged += TextBox_TextChanged;
            numFont.ValueChanged += numFont_ValueChanged;
            itemOpenFile.Click += ItemOpenFile_Click;
            itemSaveFile.Click += ItemSaveFile_Click;
            itemCreateFile.Click += ItemCreateFile_Click;
            itemSelectFile.Click += ItemSelectFile_Click;
            itemPasteDateTime.Click += ItemPasteDateTime_Click;
            itemSelectAll.Click += ItemSelectAll_Click;
            textSearch.Visible = false;
            butSearch.Visible = false;
            lblCountIdent.Visible = false;
            itemSearch.Click += ItemSearch_Click;
            butSearch.Click += ButSearch_Click;
            comboFont.SelectedIndexChanged += numFont_ValueChanged;
            itemDelete.Click += ItemDelete_Click;
            itemCopy.Click += ItemCopy_Click;
            itemCut.Click += ItemCut_Click;
            itemPaste.Click += ItemPaste_Click;
            comboFont.SelectedItem = "Arial";

            //context Menu
            contMenuCut.Click += ItemCut_Click;
            contMenuCopy.Click += ItemCopy_Click;
            contMenuPaste.Click += ItemPaste_Click;
            contMenuDelete.Click += ItemDelete_Click;
            contMenuSearch.Click += ItemSearch_Click;
            contMenuSeleactAll.Click += ItemSelectAll_Click;
            contMenuPasteDateTime.Click += ItemPasteDateTime_Click;
            cntxtMenuSearchHide.Click += CntxtMenuSearchHide_Click;
        }

        private void CntxtMenuSearchHide_Click(object sender, EventArgs e)
        {
            textSearch.Visible = false;
            butSearch.Visible = false;
            itemSearch.Visible = true;
            contMenuSearch.Visible = true;
            lblCountIdent.Visible = false;
            lebelCountIdent.Text = "0";
            lebelCountIdent.Visible = false;
            textSearch.Text = "";
            colorText(0, Content.Length, Color.Black);
        }

        #region Вставить Вырезать Копировать Удалить Выделить

        private void ItemPaste_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void ItemCut_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void ItemCopy_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void ItemDelete_Click(object sender, EventArgs e)
        {
            textBox.SelectedText = "";
        }

        private void ItemSelectAll_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }
        #endregion

        #region Поиск
        private void ButSearch_Click(object sender, EventArgs e)
        {
            colorText(0, Content.Length, Color.Black);
             {
                 List<int> numPosition = SearchText(textSearch.Text, textBox.Text);
                if (numPosition.Count != 0)
                {
                    foreach (int i in numPosition)
                    {
                        colorText(i, textSearch.Text.Length, Color.Blue);
                    }
                    MessageBox.Show("Количество совпадений: " + numPosition.Count);
                    lblCountIdent.Visible = true;
                    lebelCountIdent.Text = numPosition.Count.ToString();
                }
                else
                    MessageBox.Show("Совпадений не обнаружено");
                textBox.Select(Content.Length, 0);
                textBox.SelectionColor = Color.Black;
            }
        }

        private void ItemSearch_Click(object sender, EventArgs e)
        {
            textSearch.Visible = true;
            butSearch.Visible = true;
            itemSearch.Visible = false;
            contMenuSearch.Visible = false;
        }

        //поиск в тексте
        public List<int> SearchText(string word, string content)
        {
            List<int> listPosition = new List<int>();
            int curPosition = content.IndexOf(word, 0);
            while (curPosition != -1)
            {
                listPosition.Add(curPosition);
                curPosition = content.IndexOf(word, curPosition + word.Length);
            }
            if (curPosition != -1)
                listPosition.Add(curPosition);
            return listPosition;
        }

        //выбор цвета текста
        private void colorText(int startPosition, int length, Color color)
        {
            textBox.SelectionStart = startPosition;
            textBox.SelectionLength = length;
            textBox.SelectionColor = color;
        }
        #endregion

        #region Проброс событий

        private void ItemPasteDateTime_Click(object sender, EventArgs e)
        {
            if (PasteDate != null)
                PasteDate(this, EventArgs.Empty);
        }

        private void ItemSelectFile_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private void ItemCreateFile_Click(object sender, EventArgs e)
        {
            if (FileCreateClick != null)
                FileCreateClick(this, EventArgs.Empty);
        }

        private void ItemSaveFile_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null)
                FileSaveClick(this, EventArgs.Empty);
        }

        private void ItemOpenFile_Click(object sender, EventArgs e)
        {
            if (""==FilePath)
            {
                SelectFile();
            }
            if (FileOpenClick != null)
                FileOpenClick(this, EventArgs.Empty);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null)
                ContentChanged(this, EventArgs.Empty);
        }

        #endregion

        #region IMainForm
        public string FilePath
        {
            get { return filePath.Text; }
        }

        public string Content
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public void SetSymbolCount(int count)
        {
            lblSymbolCount.Text = count.ToString();
        }

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler FileCreateClick;
        public event EventHandler ContentChanged;
        public event EventHandler PasteDate;
        #endregion

        //обработчик выбора файла
        private void SelectFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = dlg.FileName;
                if (FileOpenClick != null)
                    FileOpenClick(this, EventArgs.Empty);
            }
        }

        //выбор шрифта
        private void numFont_ValueChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font((string)comboFont.SelectedItem, (float)numFont.Value);
        }

        //переопределение кнопки закрытия
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            switch (MessageBox.Show(this, "Вы уверены, что хотите закрыть редактор?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        
    }
}
