sub();
Console.OutputEncoding = System.Text.Encoding.UTF8;
sub();
Console.OutputEncoding = System.Text.Encoding.GetEncoding(932);
sub();

void sub()
{
    Console.WriteLine($"Encoding: {Console.OutputEncoding.EncodingName}");
    Console.WriteLine($"Price {120:C}");
}
