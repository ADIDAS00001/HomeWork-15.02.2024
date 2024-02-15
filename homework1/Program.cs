


void EvenCount(int n)
{
    int e=0,o=0,d=0,s=0;
    for(int i=n;i>0;i/=10)
    {
        if(i%10%2==0)
        {
            e++;
        }
    }
    System.Console.WriteLine($"Even:{e}");
    for(int i=n;i>0;i/=10)
    {
        if(i%10%2!=0)
        {
            o++;
        }
    }
    System.Console.WriteLine($"Odd:{o}");
    for(int i=n;i>0;i/=10)
    {
        d++;
    }
    System.Console.WriteLine($"Digit:{d}");
    for(int i=n;i>0;i/=10)
    {
       s+=i%10;
    }
    System.Console.WriteLine($"Sum:{s}");

}
EvenCount(12345);