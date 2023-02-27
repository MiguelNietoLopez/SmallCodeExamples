string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderArray = orderStream.Split(',');
Array.Sort(orderArray);
foreach (string order in orderArray)

{
    int length = order.Length;
    if (length == 4)
    {
        Console.WriteLine(order);
    }
    else
    {
        Console.WriteLine(order + "\t- Error");
    }
}
