<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var test = new List<string>();
test.Add("test");
// check if removing all records leaves you with a null list
test.RemoveAll(x=>true);

// it doesn't 
if(test is null) Console.WriteLine("test is null");
else Console.WriteLine($"test is not null: ");
