DateTime targetDate1 = new DateTime(2029, 3, 1);
DateTimeOffset dateAndOffset1 = new DateTimeOffset(targetDate1,
                         TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time").GetUtcOffset(targetDate1));

DateTime targetDate2 = new DateTime(2029, 4, 1);
DateTimeOffset dateAndOffset2 = new DateTimeOffset(targetDate2,
                         TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time").GetUtcOffset(targetDate2));

Console.WriteLine($"[{targetDate2}]-[{targetDate1}]=[{dateAndOffset2-dateAndOffset1}]");
