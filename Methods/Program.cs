using System.Buffers;

internal class Methods
{
    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    } 
    public int Subtract(int num3, int num4)
    {
        return num3 - num4;
    }
    static void Main(string[] args)
    {
        Methods m = new Methods();
        Console.Write("Nhập số thứ 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập số thứ 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập số thứ 3: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập số thứ 4: ");
        int num4 = Convert.ToInt32(Console.ReadLine());

        int tong = m.Add(num1, num2);
        int hieu = m.Subtract(num3, num4);

        Console.WriteLine("Phép cộng = {0}", tong);
        Console.WriteLine("Phép trừ = {0}", hieu);
    }
}