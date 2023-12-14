var dt1 = new DateTime(2024, 2, 29);
Console.WriteLine($"start={dt1.ToShortDateString()}");
for (int i = 0; i < 4; i++)
{
    dt1 = dt1.AddYears(1);  // 1年を4回加える
    Console.WriteLine($"step={dt1.ToShortDateString()}");
}
Console.WriteLine($"end={dt1.ToShortDateString()}");
var dt2 = new DateTime(2024, 2, 29);
Console.WriteLine($"start={dt2.ToShortDateString()}");
dt2 = dt2.AddYears(4);  // 4年を1回加える
Console.WriteLine($"end={dt2.ToShortDateString()}");

