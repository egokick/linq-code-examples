<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

      int Cookies(int k, List<int> A)
    {   
        if(A.Count() == 0) return -1;
                
        int i = 0;
        while(true)
        {
            if(A.Count() == 1)
            {
                if(A.First() > k) return i;
                return -1;
            }
            var cookieMin = A.Min();
            A.Remove(cookieMin);
            var cookieTwo = A.Min();
            A.Remove(cookieTwo);
            
            var combinedSweetness = cookieMin + (2 * cookieTwo);                        
            i++;
            if(combinedSweetness > k)
            {
                Console.WriteLine($"combinedSweetness: {combinedSweetness}, k: {k}, input: {string.Join(", ", A)}");
                return i;   
            }
            A.Add(combinedSweetness);
        };        
    }
	
	var result = Cookies(4, new List<int>(){ 4, 10
});
	Console.WriteLine(result);