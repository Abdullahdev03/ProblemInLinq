int[] numbers = { 1, 5, 8, 12, 15, 20 };
var odds = (from n in numbers where n%2 ==0 select n).Sum();
// var sum = odds.Sum();
System.Console.WriteLine(odds);

