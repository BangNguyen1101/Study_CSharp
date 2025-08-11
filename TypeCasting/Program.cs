using System;
internal class Program
{
    public static void Main(string[] args)
    {
        // Implicit Casting ( Chuyển đổi ngầm định tự động)
        // nhỏ hơn -> lớn hơn
        int myInt = 9;
        double myDouble = myInt;       // int -> double

        Console.WriteLine(myInt);      // Outputs 9
        Console.WriteLine(myDouble);   // Outputs 9



        // Explicit Casting (chuyển đổi tường minh bằng tay)
        int five = 5;
        var doubleFive = (double)five;
        Console.WriteLine(doubleFive);

        char a = 'a';
        var valueA = (int)a;
        Console.WriteLine(valueA);

        float myFloat = 4.56F;
        decimal myMoney = (decimal)myFloat;
        Console.WriteLine(myMoney);

        // Casting: là chuyển 1 giá trị từ kiểu này sang kiểu khác hoặc xuất ra lỗi
        // Conversion: Là cố chuyển một kiểu đối tượng sang kiểu khác, ít lỗi hơn nhưng chậm hơn
        int five2 = 5;
        decimal decFive = Convert.ToDecimal(five);

        decimal myMoney2 = 5.67M;
        int intMoney = Convert.ToInt32(myMoney);

        // Parsing: Là cố chuyển một chuỗi sang một kiểu nguyên thuỷ
        

        // TryParse(): Trong trường hợp chúng ta không biết liệu một string có thể chuyển sang kiểu nào đó hay không thì chúng ta có thể dùng TryParse()

    }
}