int[] array = new int[3];

array[0] = 72;
array[1] = 64;
array[2] = 50;

// foreach (var item in array)
// {
//     Console.WriteLine(item);
// }


Array.Resize(ref array, array.Length + 1);

array[3] = 55;
array[3] = 69;

// foreach (var item in array)
// {
//     Console.WriteLine(item);
// }

List<string> stringList = [];

stringList.Add("SP");
stringList.Add("BA");
stringList.Add("MG");
stringList.Add("RJ");
stringList.Add("SC");


Console.WriteLine($"Quantidade de estados rergistrados {stringList.Count}\n");

foreach (var item in stringList)
{
    Console.WriteLine(item);
}

if (stringList.Contains("MG"))
{
    Console.WriteLine("\nUai sô!!");
}