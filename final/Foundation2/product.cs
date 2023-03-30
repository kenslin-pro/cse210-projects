class product
{
  private string name { get; set; }
  private int productid { get; set; }
  private int price { get; set; }
  private int quantity { get; set; }
  public product(string productName, int productId, int price, int productQuantity)
  {
    name = productName;
    productid = productId;
    price = price * productQuantity;
    quantity = productQuantity;
  }

}