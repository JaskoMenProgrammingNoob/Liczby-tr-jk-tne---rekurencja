class Program
{
    static long trojkat(int n)
    {
        if ( n == 1 )
        {
            return 1;
        } 
        
        return n + trojkat(n - 1);
         
        
        
        

    }
    static void Main(string[] args)
    {
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Trójkąt {i} = { trojkat(i)}");
        }

    }
}












