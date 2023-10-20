using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers;

public class SearchController : Controller
{
    private readonly IBookRepository _bookRepository;

    public SearchController(IBookRepository bookRepository)
    {
        this._bookRepository = bookRepository;
    }

    public IActionResult Index(string query)
    {
        var books = _bookRepository.GetAllByTitle(query);
        var result = View(books);
        return result;
    }
}