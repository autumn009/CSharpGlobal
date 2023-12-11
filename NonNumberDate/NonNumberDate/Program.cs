using System.Globalization;

var dt = new DateTime(2029, 6, 2);
Console.WriteLine("アメリカの英語");
Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
Console.WriteLine(dt.ToString("yyyy MMMM dd"));
Console.WriteLine("日本の日本語");
Thread.CurrentThread.CurrentCulture = new CultureInfo("ja-JP");
Console.WriteLine(dt.ToString("yyyy MMMM dd"));
Console.WriteLine("インドのヒンディー語");
Thread.CurrentThread.CurrentCulture = new CultureInfo("hi-IN");
Console.WriteLine(dt.ToString("yyyy MMMM dd"));
