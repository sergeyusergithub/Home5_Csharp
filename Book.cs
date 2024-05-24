using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5_Csharp
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Author { get; set; }
        public string BookTitle { get; set; }
        public string YearOfIssue { get; set; }

        public Book(int id, string auth, string title, string year)
        {
            BookId = id;
            Author = auth;
            BookTitle = title;
            YearOfIssue = year;
        }


        // перегрузка оператора == сравнения книг
        public static bool operator ==(Book bk1, Book bk2)
        {
            if (bk1.Author == bk2.Author && bk1.BookTitle == bk2.BookTitle && bk1.YearOfIssue == bk2.YearOfIssue)
            {
                return true;
            }
            return false;
        }
        // перегрузка оператора != сравнения книг
        public static bool operator !=(Book bk1, Book bk2)
        {
            if (bk1.Author == bk2.Author && bk1.BookTitle == bk2.BookTitle &&
                bk1.YearOfIssue == bk2.YearOfIssue)
            {
                return false;
            }
            return true;
        }

        // метод отображения книги
        public void Print()
        {
            Console.WriteLine($"№: {BookId}\nАвтор: {Author}\nНазвание: {BookTitle}\nГод выхода: {YearOfIssue}");
        }
    }
}
