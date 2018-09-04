using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextEditor.BL
{
    public interface IFileManager
    {
        void CreateContent(string filePath, string content);
        void CreateContent(string filePath, string content, Encoding encoding);
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string filePath);
        void SaveContent(string content, string filePath, Encoding encoding);
        bool IsExist(string filePath);
        int GetSymbolCount(string content);
        string PasteDateTime();
        List<int> SearchText(string word, string content);
    }
    public class FileManager:IFileManager
    {
        private readonly Encoding _defEnc = Encoding.GetEncoding(1251);
        //перегрузки для передачи кодировки

        //создать
        public void CreateContent(string filePath, string content) 
        {
            CreateContent(filePath, content, _defEnc);
        }

        //создать
        public void CreateContent(string filePath, string content, Encoding encoding) 
        {
            File.WriteAllText(filePath, content);
            //SaveContent(content, filePath);
        }

        //открыть
        public string GetContent(string filePath) 
        {

            return GetContent(filePath, _defEnc);
        }

        //открыть
        public string GetContent(string filePath, Encoding encoding) 
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;
        }
        
        //сохранить
        public void SaveContent(string content, string filePath)
        {
            SaveContent(content, filePath, _defEnc);
        }

        //сохранить
        public void SaveContent(string content, string filePath, Encoding encoding) 
        {
            File.WriteAllText(filePath, content, encoding);
        }

        //проверка на существование
        public bool IsExist(string filePath)  
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }

        //подсчитать символы
        public int GetSymbolCount(string content) 
        {
            //content = content.Replace(" ", "");
            int count = content.Replace("\n", "").Replace(" ", "").Length;
            return count;
        }

        //вставить текущую дату и время
        public string PasteDateTime ()   
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString();
        }


        //поиск позиций в тексте совпадений с искомым
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
    }
}
