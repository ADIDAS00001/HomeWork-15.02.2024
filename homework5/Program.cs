

void Swap(ref int x,ref int y)
{
    int z;
    z=x;
    x=y;
    y=z;
    System.Console.WriteLine($"x = {x}\ny = {y}");
}
System.Console.Write("x = ");
int x=Convert.ToInt32(Console.ReadLine());
System.Console.Write("y = ");
int y=Convert.ToInt32(Console.ReadLine());
Swap(ref x,ref y);