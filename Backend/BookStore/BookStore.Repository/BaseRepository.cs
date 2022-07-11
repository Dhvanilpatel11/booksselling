using Bookstore.Models.ViewModels;
using BookStore.Models;

namespace BookStore.Repository
{
    public class BaseRepository
    {
        protected readonly BookStoreContext _context = new BookStoreContext();
    }
}
