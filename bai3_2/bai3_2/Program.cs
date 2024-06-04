using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Chương trình tính tổng các số trong mảng");
        Console.WriteLine("1. Mảng số nguyên không dấu");
        Console.WriteLine("2. Mảng số nguyên có dấu");
        Console.Write("Nhập lựa chọn (1 hoặc 2): ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Nhập các số nguyên không dấu (tối đa 10 số, mỗi số cách nhau bởi dấu cách): ");
            string[] input = Console.ReadLine().Split();
            ushort[] numbers = new ushort[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = ushort.Parse(input[i]);
            }

            ushort sum = 0;
            foreach (ushort num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"Tổng các số trong mảng: {sum}");
        }
        else if (choice == 2)
        {
            Console.Write("Nhập các số nguyên có dấu (tối đa 10 số, mỗi số cách nhau bởi dấu cách): ");
            string[] input = Console.ReadLine().Split();
            short[] numbers = new short[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = short.Parse(input[i]);
            }

            short sum = 0;
            foreach (short num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"Tổng các số trong mảng: {sum}");
        }
        else
        {
            Console.WriteLine("Lựa chọn không hợp lệ.");
        }
    }
}