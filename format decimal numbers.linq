<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>


// input
var arr = new List<int>(){1,1,0,-1-1};


if(arr == null || arr.Count() == 0){
    Console.WriteLine(0.000000);
    Console.WriteLine(0.000000);
    Console.WriteLine(0.000000);
    return;
}

var positive = arr.Count(n=>n > 0);
var negative = arr.Count(n=>n < 0);
var zero = arr.Count(n=>n == 0);

var count = arr.Count();
var posRatio = positive > 0 ? (double) positive / count : 0.000000;
var negRatio = negative > 0 ? (double) negative / count : 0.000000;
var zeroRatio = zero > 0 ? (double) zero / count : 0.000000;

// format a decimal number to 6 decimal places
Console.WriteLine("{0:0.######}", posRatio);
Console.WriteLine("{0:0.######}", negRatio);
Console.WriteLine("{0:0.######}", zeroRatio); 