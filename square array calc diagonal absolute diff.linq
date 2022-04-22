<Query Kind="Statements">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

 
var input = "1 4 1 1";
var arr = new List<List<int>>()
{

    new List<int>{13, 14, 20, 10},
    new List<int>{ 5, 14, 20, 10},
    new List<int>{ 5, 14, 3, 10},
    new List<int>{ 1, 14, 20, 5},
};

var output = DiagonalDifference(arr);
Console.WriteLine(output);

// requires square matrix
int DiagonalDifference(List<List<int>> arr)
{
    var (sumLeftToRightDiagonal, sumRightToLeftDiagonal) = GetDiagonalSums(arr);
    var absoluteDifference = Math.Abs(sumLeftToRightDiagonal - sumRightToLeftDiagonal);
    return absoluteDifference;
}

(int, int) GetDiagonalSums(List<List<int>> arr)
{
    var arrayLength = arr.Count();
    var sumLeftToRightDiagonal = 0;    
    for (int i = 0; i < arrayLength; i++)
    {
        sumLeftToRightDiagonal += arr[i][i]; 
    }
    var sumRightToLeftDiagonal = 0;
    for (int i = 0; i < arrayLength; i++)
    {
        sumRightToLeftDiagonal += arr[arrayLength - 1 -i][i]; 
    } 
    return (sumLeftToRightDiagonal, sumRightToLeftDiagonal);
}