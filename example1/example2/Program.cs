Console.WriteLine("Введите 2 числа");
string firstnumber = Console.ReadLine();
string secondnumber = Console.ReadLine();
var number1 = double.Parse(firstnumber);
var number2 = double.Parse(secondnumber);
if (number1 * number1 == number2)
{ Console.WriteLine("да");
}
else
{ Console.WriteLine("нет");
}
