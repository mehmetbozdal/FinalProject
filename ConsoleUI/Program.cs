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
            ProductTest(); //Product için önce metoda refactoring yaptık, comment kaldırıp metodu kullanabilirsiniz
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails()) //GetAll kısmını hangisini istiyorsan ona çevirebilirsin. Getall hepsini, GetAllByCategory parantez içine hangi kategori ise yaz vb.
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }
    }
}
