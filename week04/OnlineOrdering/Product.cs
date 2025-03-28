namespace OnlineOrdering;

public class Product
{
    public string Name { get; set; }
    public int ProductId { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, int productid, float price, int quantity)
    {
        Name=  name;
        ProductId=productid;
        Price=price;
        Quantity=quantity;
    }

    public float TotalCost()
    {
        return Price *(float)Quantity;
    }
    
}

