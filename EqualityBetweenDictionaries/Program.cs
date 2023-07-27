// See https://aka.ms/new-console-template for more information

var dic1 = new Dictionary<int, int>();
dic1.Add(1123, 10);
dic1.Add(1124, 10);
dic1.Add(1125, 10);

var dic2 = new Dictionary<int, int>();
dic2.Add(1123, 10);
dic2.Add(1124, 10);
dic2.Add(1125, 5);

if (dic1.Count == dic2.Count && !dic1.Except(dic2).Any())
    Console.WriteLine("Dicts are equal");
else
    Console.WriteLine("Dicts aren't equal");

//output Dicts aren't equal