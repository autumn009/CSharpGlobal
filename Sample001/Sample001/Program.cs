using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var dt = new DateTime(2029, 6, 2);

sub(dt);
Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
sub(dt);
Thread.CurrentThread.CurrentCulture = new CultureInfo("ja-JP");
sub(dt);


void sub(DateTime dt)
{
    Console.WriteLine($"{120:C}");
    Console.WriteLine(dt);
}
