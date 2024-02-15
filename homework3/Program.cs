


int mn=99999,mx=-99999;
int MinDigit(int n)
{
    for(int i=n;i>0;i/=10)
    {
        if(i%10<mn)
        {
            mn=i%10;
        }
    }
    return mn;    
}
System.Console.Write(MinDigit(1234));
System.Console.Write(" + ");
int MaxDigit(int n)
{
    for(int i=n;i>0;i/=10)
    {
        if(i%10>mx)
        {
            mx=i%10;
        }
    }
    return mx;    
}
System.Console.Write(MaxDigit(1234));
System.Console.Write(" = ");
System.Console.WriteLine(mn+mx);