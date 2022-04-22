<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

long input = Convert.ToInt64("3".Trim());
//long input = 3;

var inputBits = Convert.ToString(input, 2);
Console.WriteLine($"inputBits: {inputBits}");

var input32BitsPadded = inputBits.PadLeft(32, '0');
Console.WriteLine($"inputBits padded: {input32BitsPadded}");

var flippedIinput32BitsPadded = new char [input32BitsPadded.Length];
for(int i = 0; i< input32BitsPadded.Length; i++)
{
	if(input32BitsPadded[i] == '0')	flippedIinput32BitsPadded[i] = '1';
	else flippedIinput32BitsPadded[i] = '0';
}
var test = new string(flippedIinput32BitsPadded);
Console.WriteLine($"flipped:                 {test}");

var flippedBits32 = Convert.ToString(~input, 2).PadLeft(32,'0');

var flippedBitsUInt32 = test;
Console.WriteLine($"flippedBitsUInt32: {flippedBitsUInt32}");

var flippedUInt32 = Convert.ToUInt32(flippedBitsUInt32,2);
Console.WriteLine($"flipped u32 input: {flippedUInt32}");

var flippedLong = Convert.ToInt64(flippedUInt32); 
Console.WriteLine(flippedLong);

// expected output: 2147483648