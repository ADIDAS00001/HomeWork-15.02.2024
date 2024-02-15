

int a=Convert.ToInt32(Console.ReadLine());
int[] A=new int[a];
for(int i=0;i<a;i++)
{
    A[i]=Convert.ToInt32(Console.ReadLine());
}
System.Console.Write("IncrementArrayElements:");
int b=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<a;i++)
{
    A[i]+=b;
    System.Console.Write(A[i]+" ");

}
