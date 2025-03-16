double sqMeterslanscaped = double.Parse(Console.ReadLine());
double priceMeter = 7.61;
double priceWithoutDiscount = sqMeterslanscaped * priceMeter;
double discount = priceWithoutDiscount * 0.18;
double totalPrice = priceWithoutDiscount - discount;

Console.WriteLine($"The final price is: {totalPrice} lv.");
Console.WriteLine($"The discount is: {discount} lv.");


