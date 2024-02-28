using Book_Check_Out_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_Check_Out_System.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayView(string name, string author, int page_number, DateTime due_date, int x)
        {
            Book book = new Book();
            book.name = name;
            book.author = author;
            book.pageNumber = page_number;
            book.dueDate = due_date;
            DateTime now = DateTime.Now;
            TimeSpan remainingTime = due_date - now;
            book.remainingTime = remainingTime;
            return View(book);
        }
    }
}
