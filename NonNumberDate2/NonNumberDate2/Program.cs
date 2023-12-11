using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
var dt = new DateTime(2029, 6, 2);
Console.WriteLine("インドのヒンディー語");
Thread.CurrentThread.CurrentCulture = new CultureInfo("hi-IN");
Console.WriteLine(dt.ToString("yyyy MMMM dd"));
