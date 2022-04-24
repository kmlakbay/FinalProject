using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
{
    //CustomerTest();
    //OrderTest();

    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var item in productManager.GetProductDetail())
    {
        Console.WriteLine("ID:{0} / ProductName:{1} / CategoryName:{2} / UnitsInStock:{3}",item.ProductId,item.ProductName,item.CategoryName,item.UnitsInStock);
    }


    //---------------------------------------------------------------------------------------------------
    static void CustomerTest()
    {
        CustomerManager productManager = new CustomerManager(new EfCustomerDal());
        int i = 0;
        foreach (var item in productManager.GetAll())
        {
            i++;
            Console.WriteLine(i + " " + item.CustomerId + " " + item.ContactName);
        }
    }

    static void OrderTest()
    {
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        foreach (var order in orderManager.GetAll())
        {
            Console.WriteLine(order.ShipCity);
        }
    }
}
 