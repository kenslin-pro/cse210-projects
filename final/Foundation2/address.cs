class address
{
  private string street { get; set; }
  private string city { get; set; }
  private string state { get; set; }
  private string country { get; set; }
  public address(string streetaddress, string City, string State, string Country)
  {
    street = streetaddress;
    city = City;
    state = State;
    country = Country;
  }
  public string Getaddress()
  {
    return this.street + this.city + this.state + this.country;
  }


}