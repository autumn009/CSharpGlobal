DateTime targetDate1 = new DateTime(2029, 6, 2, 6, 0, 0);
DateTimeOffset dateAndOffset = new DateTimeOffset(targetDate1,
                         TimeZoneInfo.Local.GetUtcOffset(targetDate1));
Console.WriteLine($"現地時間(日本時間) {dateAndOffset}");

DateTime targetDate2 = new DateTime(2029, 6, 2, 8, 30, 0);
DateTimeOffset dateAndOffset2 = new DateTimeOffset(targetDate2,
                         TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time").GetUtcOffset(targetDate2));
Console.WriteLine($"米国東部標準時 {dateAndOffset2}");

Console.WriteLine($"差分 {dateAndOffset2-dateAndOffset}");
