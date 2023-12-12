using System.Text;
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

var e1 = Encoding.UTF8;
Console.WriteLine(e1.EncodingName);
var e2 = Encoding.GetEncoding(932);
Console.WriteLine(e2.EncodingName);
var e3 = Encoding.GetEncoding("Shift_JIS");
Console.WriteLine(e3.EncodingName);
