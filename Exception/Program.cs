using System;
namespace Exceptions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                int a = 10;
                float b = a / 0;
            }
            catch (DivideByZeroException divideByZeroEx)
            {
                Console.WriteLine("Lỗi chia cho 0: " + divideByZeroEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi không xác định: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Kết thúc chương trình.");
            }
        }
    }
}