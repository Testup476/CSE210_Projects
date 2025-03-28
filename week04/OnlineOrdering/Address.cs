namespace OnlineOrdering;

public class Address
{
  public string  Street{get;set;}
  public string City { get; set; }
  public string State { get; set; }
  public string Country { get; set; }

  public Address(string street, string city, string state, string country)
  {
    Street=street;
    City=city;
    State=state;
    Country=country;
  }  

  public bool IsInUSA()
  =>Country.Equals("USA");
  public override bool Equals(object obj)
  {
    
    if (obj == null || GetType() != obj.GetType())
    {
        return false;
    }
    
    // TODO: write your implementation of Equals() here
    throw new System.NotImplementedException();
    return base.Equals (obj);
  }
  // override object.GetHashCode
  public override int GetHashCode()
  {
    // TODO: write your implementation of GetHashCode() here
    throw new System.NotImplementedException();
    return base.GetHashCode();
  }

  public string GetFullAdress()
  {
    return $"{Street} \n {State} \n{Country}";
  } 
  
}