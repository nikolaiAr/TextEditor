using System;
using System.Collections.Generic;
using System.Drawing;
using TextEditor.BL;

namespace TextEditor
{
    public class Presenter
    {
        private readonly IMainForm _view;
        private readonly IFileManager _manager;
        private readonly IMessageService _messageService;
        private string _currentFilePath;

        public Presenter ( IMainForm view, IFileManager manager, IMessageService service)
        {
            _view = view;
            _manager = manager;
            _messageService = service;

            _view.SetSymbolCount(0);

            _view.ContentChanged += _view_ContentChanged;
            _view.FileOpenClick += _view_FileOpenClick;
            _view.FileSaveClick += _view_FileSaveClick;
            _view.FileCreateClick += _view_FileCreateClick;
            _view.PasteDate += _view_PasteDate;
            _view.SearchWord += _view_SearchWord;
        }

        private void _view_SearchWord(object sender, EventArgs e)
        {
            try
            {
                _view.ColorText(0, _view.Content.Length, Color.Black);
                List<int> numPosition = _manager.SearchText(_view.WordSearch, _view.Content);
                if (numPosition.Count != 0)
                {
                    foreach (int i in numPosition)
                    {
                        _view.ColorText(i, _view.WordSearch.Length, Color.Blue);
                    }
                    _messageService.ShowMessage("Количество совпадений: " + numPosition.Count);
                }
                else
                    _messageService.ShowMessage("Совпадений не обнаружено");
                _view.SetSearchCount(numPosition.Count);
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_PasteDate(object sender, EventArgs e)
        {
            try
            {
                _view.Content += "  " + _manager.PasteDateTime();
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_FileCreateClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = _view.FilePath;
                if ("" != filePath)
                {
                    _manager.CreateContent( filePath,_view.Content);
                    _messageService.ShowMessage("Создан новый файл");
                }
                else
                {
                    _messageService.ShowExclamation("Введите полное название файла");
                    return;
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowError (ex.Message);
            }
            
        }

        private void _view_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = _view.FilePath;
                if (_currentFilePath == filePath)
                {
                    string content = _view.Content;
                    _manager.SaveContent(content, _currentFilePath);
                    _messageService.ShowMessage("Файл успешно сохранен");
                }
                else
                {
                    _messageService.ShowError("Файл не существует");
                    return;
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = _view.FilePath;
                bool isExist = _manager.IsExist(filePath);
                if (!isExist)
                {
                    _messageService.ShowExclamation ("Выбранный файл не существует");
                    return;
                }

                _currentFilePath = filePath;
                string content = _manager.GetContent(filePath);
                int count = _manager.GetSymbolCount(content);

                _view.Content = content;
                _view.SetSymbolCount(count);

            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_ContentChanged(object sender, EventArgs e)
        {
            string content = _view.Content;
            int count = _manager.GetSymbolCount(content);
            _view.SetSymbolCount(count);
        }
    }
}
