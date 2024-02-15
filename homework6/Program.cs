

int Division(int a)
{
    for(int i=1;i<a;i++)
    {
        if(a%i==0)
        {
            System.Console.Write(i+ " ");
        }
    }
    return a;
}
System.Console.WriteLine(Division(32));