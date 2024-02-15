
int mn=99999;
int MunNumber(int a,int b,int c,int d)
{
    if(a<mn)
    {
        mn=a;
    }
    if(b<mn)
    {
        mn=b;
    }
    if(c<mn)
    {
        mn=c;
    }
    if(d<mn)
    {
        mn=d;
    }
    return mn;
}
System.Console.WriteLine(MunNumber(20,200,3,45));