using System.Globalization;
Console.OutputEncoding = System.Text.Encoding.UTF8;

var dt = new DateTime(2029, 6, 2);

string[] c =
{
    "ja-JP",
    "en-US",
    "fr-FR",
    "hi-IN"
};

string[] formats = { "D", "d", "yyyy MMM dd" };

foreach (var ci in c)
{
    Thread.CurrentThread.CurrentCulture = new CultureInfo(ci);
    Console.WriteLine($"NativeName={Thread.CurrentThread.CurrentCulture.NativeName} Name={Thread.CurrentThread.CurrentCulture.Name}");
    foreach (var format in formats)
    {
        var s = ToString(dt, format);
        var r = FromString(s, format);
        Console.WriteLine((dt == r ? "一致" : "失敗")+ $" {ci} {format} {s}");
    }
}

string ToString(DateTime dt, string format)
{
    return dt.ToString(format);
}

DateTime FromString(string data, string format)
{
    return DateTime.ParseExact(data, format, CultureInfo.CurrentCulture);
}
