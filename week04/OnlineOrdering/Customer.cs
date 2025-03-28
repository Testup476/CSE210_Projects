namespace OnlineOrdering;

public class Customer
{
    public string Name { get; set; }

    public Address address { get; set; }

    public Customer(string name, Address _address)
    {
        Name=name;
        address=_address;
    }
    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

}