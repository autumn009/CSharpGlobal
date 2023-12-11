sub();
var oldEncoding = Console.OutputEncoding;
Console.OutputEncoding = System.Text.Encoding.UTF8;
sub();
Console.OutputEncoding = oldEncoding;
sub();

void sub()
{
    Console.WriteLine($"Encoding: {Console.OutputEncoding.EncodingName}");
    Console.WriteLine($"Price {120:C}");
}
