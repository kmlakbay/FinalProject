using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    int i=0;
    foreach (var item in productManager.GetAll())
    {
        i++;
        Console.WriteLine(i+" "+item.ProductName);
    }
}
 