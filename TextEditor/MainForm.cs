using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        #region Проброс событий
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
            textBox.Font = new Font("Calibri", (float)numFont.Value);
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
