using Microsoft.Win32.SafeHandles;
using System.Security.Authentication.ExtendedProtection;

namespace CalidadT1;

public class BookStore
{
    private List<Book> shoppingCart;
    public BookStore()
    {
        shoppingCart = new List<Book>();
    }

    public void AddToCart(Book book)
    {
        bool entrada = false;
        for(int i=0; i < shoppingCart.Count(); i++)
        {
            if (shoppingCart[i]==book)
            {
                Book aux = book;
                aux.Name = book.Name;
                aux.Price = book.Price * (9 / 10);
                shoppingCart.Add(aux);
                entrada = true;
                i = shoppingCart.Count();
            }
        }
        if (entrada == false)
        {
            shoppingCart.Add(book);
        }
        //shoppingCart.Add(book);

    }
    
    public decimal GetTotal()
    {
        decimal acu = 0;
        int i;
        for (i = 0; i < shoppingCart.Count(); i++)
        {
            acu += shoppingCart[i].Price;
        }
        //return shoppingCart.Sum(x => x.Price);
        return acu;
    }
}