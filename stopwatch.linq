<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

DateTime start = DateTime.Now;

long t=0;
for(long i=0; i<1000000000; i++){
	t++;
}
Console.WriteLine(t);
        
DateTime end = DateTime.Now;

TimeSpan ts = end - start;
Console.WriteLine(ts.ToString());