


int mn=99999;
int MunNumber(int val1,int val2)
{
    if(val1<mn)
    {
        mn=val1;
    }
    if(val2<mn)
    {
        mn=val2;
    }
    return mn;
}
System.Console.WriteLine(MunNumber(2,1));