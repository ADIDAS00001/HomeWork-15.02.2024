


int mx=-99999;
int MunNumber(int val1,int val2)
{
    if(val1>mx)
    {
        mx=val1;
    }
    if(val2>mx)
    {
        mx=val2;
    }
    return mx;
}
System.Console.WriteLine(MunNumber(2,1));