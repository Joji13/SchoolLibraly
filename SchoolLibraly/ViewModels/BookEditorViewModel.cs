using System;
using SchoolLibraly.DAL.Entityes;
using MathCore.WPF.ViewModels;

namespace SchoolLibraly.ViewModels
{
    internal class BookEditorViewModel : ViewModel
    {
        #region BookId : int - Идентификатор книги

        public int BookId { get; }

        #endregion

        #region Name : string - Название книги

        /// <summary>Название книги</summary>
        private string _Name;

        /// <summary>Название книги</summary>
        public string Name { get => _Name; set => Set(ref _Name, value); }

        #endregion

        public BookEditorViewModel()
            : this(new Book { Id = 1, Name = "Название книги!" })
        {
            if (!App.IsDesignTime)
                throw new InvalidOperationException("Не для рантайма");
        }

        public BookEditorViewModel(Book book)
        {
            BookId = book.Id;
            Name = book.Name;
        }
    }
}
