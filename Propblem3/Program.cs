string[] names = { "Alice", "Anny", "Amy", "Dave", "Alex" };

var started = (from s in names where s.StartsWith("A")  select s );
foreach (var item in started)
{
  System.Console.WriteLine(item);
}