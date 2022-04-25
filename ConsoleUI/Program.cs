using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
{
    //CustomerTest();
    //OrderTest();

    ProductDetailTest();


    //---------------------------------------------------------------------------------------------------
    static void CustomerTest()
    {
        CustomerManager productManager = new CustomerManager(new EfCustomerDal());
        int i = 0;
        foreach (var item in productManager.GetAll().Data)
        {
            i++;
            Console.WriteLine(i + " " + item.CustomerId + " " + item.ContactName);
        }
    }

    static void OrderTest()
    {
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        foreach (var order in orderManager.GetAll().Data)
        {
            Console.WriteLine(order.ShipCity);
        }
    }

    static void ProductDetailTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        var result = productManager.GetProductDetail();
        if (result.Success)
        {
            foreach (var item in result.Data)
            {
                Console.WriteLine("ID:{0} / ProductName:{1} / CategoryName:{2} / UnitsInStock:{3}", item.ProductId, item.ProductName, item.CategoryName, item.UnitsInStock);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
        
    }
}
 