using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool running = true;
        while (running)
        {
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Tìm số lớn nhất và nhỏ nhất trong dãy số");
            Console.WriteLine("2. Tính tổng các số chẵn trong dãy số");
            Console.WriteLine("3. Tính tổng các số từ 1 đến n");
            Console.WriteLine("4. Thoát");

            Console.Write("Nhập lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FindMinMax();
                    break;
                case 2:
                    SumEvenNumbers();
                    break;
                case 3:
                    Sum1ToN();
                    break;
                case 4:
                    running = false;
                    Console.WriteLine("Chương trình kết thúc.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }

            Console.WriteLine();
        }
    }

    public static void FindMinMax()
    {
        Console.Write("Nhập dãy số nguyên có dấu (tối đa 10 số, mỗi số cách nhau bởi dấu cách): ");
        string[] input = Console.ReadLine().Split();
        sbyte[] numbers = new sbyte[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = sbyte.Parse(input[i]);
        }

        sbyte max = numbers[0];
        sbyte min = numbers[0];

        foreach (sbyte num in numbers)
        {
            if (num > max)
                max = num;
            if (num < min)
                min = num;
        }

        Console.WriteLine($"Số lớn nhất: {max}");
        Console.WriteLine($"Số nhỏ nhất: {min}");
    }

    public static void SumEvenNumbers()
    {
        Console.Write("Nhập dãy số nguyên có dấu (tối đa 10 số, mỗi số cách nhau bởi dấu cách): ");
        string[] input = Console.ReadLine().Split();
        sbyte[] numbers = new sbyte[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = sbyte.Parse(input[i]);
        }

        sbyte evenSum = 0;
        foreach (sbyte num in numbers)
        {
            if (num % 2 == 0)
                evenSum += num;
        }

        Console.WriteLine($"Tổng các số chẵn: {evenSum}");
    }

    public static void Sum1ToN()
    {
        Console.Write("Nhập số nguyên n (tối đa 1 byte): ");
        byte n = byte.Parse(Console.ReadLine());
        int total = (n * (n + 1)) / 2;
        Console.WriteLine($"Tổng của các số từ 1 đến {n} là: {total}");
    }
}