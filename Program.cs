
using System.Threading.Channels;
using Lab1;

Vector3 a = new Vector3(3,4,0);
Vector3 b = new Vector3(4,3,0);

Console.WriteLine($"A:{a}");
Console.WriteLine($"B:{b}");
Console.WriteLine($"Cos:{a.Cos(b)}");
Console.WriteLine($"Length A:{a.Length()}");
Console.WriteLine($"Scalar:{a.Scalar(b)}");
Console.WriteLine($"Sum:{a+b}");
Console.WriteLine($"Difference:{a-b}");

var jsonA = a.ToJson();
var fromJSON = Vector3.FromJson(jsonA);
a.SaveJson("jsonA.json");
var fromFile = Vector3.FromFile("jsonA.json");
Console.WriteLine($"JSON:{jsonA}");
Console.WriteLine($"From JSON:{fromJSON}");
Console.WriteLine($"From JSON file :{fromFile}");
