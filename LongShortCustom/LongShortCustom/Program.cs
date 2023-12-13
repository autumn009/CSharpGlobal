using System.Globalization;
Console.OutputEncoding = System.Text.Encoding.UTF8;

var dt = new DateTime(2029, 6, 2);

Thread.CurrentThread.CurrentCulture = new CultureInfo("ja-JP");
sub(dt);
Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
sub(dt);
Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
sub(dt);
Thread.CurrentThread.CurrentCulture = new CultureInfo("hi-IN");
sub(dt);

void sub(DateTime dt)
{
    Console.WriteLine($"NativeName={Thread.CurrentThread.CurrentCulture.NativeName} Name={Thread.CurrentThread.CurrentCulture.Name}");
    Console.WriteLine($"LongDateString={dt.ToLongDateString()}");
    Console.WriteLine($"ShortDateString={dt.ToShortDateString()}");
    Console.WriteLine($"CustomDateString(yy yyyy MM MMM dd ddd)={dt.ToString("yy yyyy MM MMM dd ddd")}");
}
