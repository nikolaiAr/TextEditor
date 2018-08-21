﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace TextEditor.BL
{
    public interface IFileManager
    {
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string filePath);
        void SaveContent(string content, string filePath, Encoding encoding);
        bool IsExist(string filePath);
        int GetSymbolCount(string content);
    }
    public class FileManager:IFileManager
    {
        private readonly Encoding _defEnc = Encoding.GetEncoding(1251);

        public string GetContent(string filePath) //открыть
        {

            return GetContent(filePath, _defEnc);
        }

        public string GetContent(string filePath, Encoding encoding) //открыть
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;
        }

        public void SaveContent(string content, string filePath)
        {
            SaveContent(content, filePath, _defEnc);
        }
        public void SaveContent(string content, string filePath, Encoding encoding) //сохранить
        {
            File.WriteAllText(filePath, content, encoding);
        }

        public bool IsExist(string filePath)  //проверка на существование
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }

        public int GetSymbolCount(string content) //подсчитать символы
        {
            int count = content.Length;
            return count;
        }
    }
}
