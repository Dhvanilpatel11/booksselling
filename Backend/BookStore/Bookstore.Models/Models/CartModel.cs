using BookStore.Models.DataModels;

namespace BookStore.Models.Models
{
    public class CartModel
    {
        public CartModel() { }

        public CartModel(Cart cart)
        {
            Id = cart.Id;
            //TODO: add all properties
        }

        public CartModel(Bookstore.Models.ViewModels.Cart c)
        {
            C = c;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public Bookstore.Models.ViewModels.Cart C { get; }
    }
}
