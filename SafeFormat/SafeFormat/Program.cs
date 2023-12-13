using System.Globalization;
Console.OutputEncoding = System.Text.Encoding.UTF8;
const string format = "yyyyMMddHHmmss";

DateTime[] dts =
{
    DateTime.MinValue,
    new DateTime(2029, 6, 2, 1, 23, 45),
    new DateTime(2029, 12, 24, 23, 59, 0),
    DateTime.MaxValue,
};

foreach (var dt in dts)
{
    var s = dt.ToString(format);
    var r = DateTime.ParseExact(s, format, CultureInfo.CurrentCulture);
    Console.WriteLine($"{dt}=>{s}=>{r}");
}
