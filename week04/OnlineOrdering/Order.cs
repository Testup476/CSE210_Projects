namespace OnlineOrdering;

public class Order
{
    public static List<Product> _products{get;set;}
    public Customer _customer{get;set;}

    public Order(Customer customer)
    {
        _products= new List<Product>();
        _customer=customer;
    }

    public float TotalCost()
    {
        float productcost= _products.Sum(x=>x.TotalCost());
        float ShippingCost=_customer.LivesInUSA()? 5 : 10;
         return productcost + ShippingCost;
    }

    public string GetPackingLabel()
    {
        Console.WriteLine("-------------------");
        return string.Join("\n",_products.Select(x=>$"Name : {x.Name}, \n ID :{x.ProductId}, \n Price {x.Price}, \n Quantity : {x.Quantity}"));
    }

    public string GetShippingLabel()
    {
        Console.WriteLine("-------------------");
      return $"Customer : {_customer.Name} \n Address : {_customer.address.GetFullAdress()}";
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

}