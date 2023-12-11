using System.Globalization;

var dt = new DateTime(2029, 6, 2);

var a = async () => {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Task1 {i} {Thread.CurrentThread.CurrentCulture.Name} {dt.ToShortDateString()}");
        await Task.Delay(100);
    }
};
var b = async () =>
{
    Thread.CurrentThread.CurrentCulture = new CultureInfo("ja-JP");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Task2 {i} {Thread.CurrentThread.CurrentCulture.Name} {dt.ToShortDateString()}");
        await Task.Delay(150);
    }
};
await Task.WhenAll(new Task[] { a(), b() });
