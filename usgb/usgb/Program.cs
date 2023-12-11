﻿using System.Globalization;

var dt = new DateTime(2029, 6, 2);

Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
sub(dt);
Thread.CurrentThread.CurrentCulture = new CultureInfo("en-gb");
sub(dt);

static void sub(DateTime dt) => Console.WriteLine($"{Thread.CurrentThread.CurrentCulture.Name} {dt.ToShortDateString()}");
