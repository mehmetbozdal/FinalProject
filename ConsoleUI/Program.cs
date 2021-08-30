using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle yani mevcut yazılımına dokunmadan birşeyler ekliyorsan O prensibine uymuş oluyorsun
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAllByUnitPrice(40,100)) //GetAll kısmını hangisini istiyorsan ona çevirebilirsin. Getall hepsini, GetAllByCategory parantez içine hangi kategori ise yaz vb.
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
