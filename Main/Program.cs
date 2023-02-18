//problem1
int[] numbers = { 1, 5, 8, 12, 15, 20 };

var ordered = (from n in numbers where n > 10 select n);
foreach (var item in ordered)
{
    System.Console.WriteLine(item);
}