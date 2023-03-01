using Accessibility;
using ExaminationApp.Constants;
using ExaminationApp.Entities;
using ExaminationApp.Forms;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace ExaminationApp.Services
{
    public class BookStoreService
    {
        private BookStoreContext _context;
        public BookStoreService() 
        {
            _context = new BookStoreContext();
        }

        // Взять все книги из базы
        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context
                .Books
                .ToListAsync();
        }

        // Получить книгу по Id
        public async Task<Book> GetBookByIdAsync(int bookId)
        {

            return await _context
                .Books
                .FindAsync(bookId);
        }

        // Добавить книгу
        public async Task AddBookAsync(string title, string author, string publisher, BookGenre genre, int pagesCount, int yearPublished, decimal price)
        {
            var book = new Book();
            book.Title = title;
            book.Author = author;
            book.Publisher = publisher;
            book.Genre = genre;
            book.PagesCount = pagesCount;
            book.PublishYear = yearPublished;
            book.Price = price;

            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        // Изменить книгу
        public async Task EditBookAsync(Book book, string title, string author, string publisher, BookGenre genre, int pagesCount, int yearPublished, decimal price)
        {
            book.Title = title;
            book.Author=author;
            book.Publisher=publisher;
            book.Genre = genre;
            book.PagesCount = pagesCount;
            book.PublishYear = yearPublished;
            book.Price = price;

            await _context.SaveChangesAsync();
        }

      
        // Удалить книгу
        public async Task DeleteBookAsync(int bookId)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (book != null)
            {
                if (book.SoldBooks != null && book.SoldBooks.Any())
                {
                    throw new Exception
                        ("В системе существуют продажы данной книги:  Удаление невозможно");
                }

                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Данной книги несуществует");
            }
            
        }

        // Отфильтровать книги
        public async Task<List<Book>> FilterBooksAsync(string author, string title, int bookGenre)
        {
            return  await _context
                .Books
                .Where(a=>a.Author.Contains(author) && a.Title.Contains(title) &&( bookGenre == 0 || a.Genre == (BookGenre)bookGenre ))
                .ToListAsync();
        }

        // Взять список новинок. Книги изданные за последние 5 лет
        public async Task<List<Book>> GetNewBooksListAsync()
        {
            return await _context
                .Books
                .Where(x => x.PublishYear > DateTime.Now.Year - 5)
                .ToListAsync();

        }

        // Взять топ продаж. Первые 3 книги по кол-ву проданных экземпляров
        public async Task<List<Book>> GetTopSalesAsync()
        {
            return await _context.Books
                .OrderByDescending(x => x.SoldBooks.Sum(s => s.SoldAmount))
                .Take(3)
                .ToListAsync();
        }

        // Взять топ авторов. Первые 3 автора по продажам их книг
        public async Task<List<string>> GetTopAuthorsAsync()
        {

            return await _context.Books
                .GroupBy(x => x.Author)
                .OrderByDescending(x => x.SelectMany(y => y.SoldBooks).Sum(z => z.SoldAmount))
                .Take(3)
                .Select(x => x.Key)
                .ToListAsync();


        }

        // Взять топ жанров за сколько-то дней. Первые 3 жанра по продажам их книг
        public async Task<List<BookGenre>> GetTopGenresAsync(int days)
        {
            throw new NotImplementedException();
        }
    }
}
