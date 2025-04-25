using C_Domain;
using C_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DocumentManager.Pages
{
    public class BooksModel : PageModel
    {

        private readonly IBookService _bookService;
        public IEnumerable<Book> Books { get; set; }

        public BooksModel(IBookService bookService)
        {
            Books = Enumerable.Empty<Book>();
            _bookService = bookService;
        }

        public void OnGet()
        {
            Books = _bookService.GetBooks();
        }
    }
}
