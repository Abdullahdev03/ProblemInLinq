string[] words = { "apple", "banana", "cherry", "date", "elderberry" };

var sort = (from w in words orderby w.Length descending select w);
foreach (var item in sort)
{
  System.Console.WriteLine(item);
}