<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var test = new List<bool>(){
true,
false};

Console.WriteLine(test.OrderBy(x=>x));