//using System;

using System.Text;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 6:");

        // Phần (a): Tính trung bình cộng của các số trong mảng
        Console.Write("a. Nhập 8 số thực (8 byte) cách nhau bởi dấu cách: ");
        string[] input = Console.ReadLine().Split();
        double[] numbers = new double[8];

        for (int i = 0; i < 8; i++)
        {
            numbers[i] = double.Parse(input[i]);
        }

        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }

        double average = sum / 8;
        Console.WriteLine($"Trung bình cộng của các số trong mảng: {average}");

        // Phần (b): Tìm giá trị lớn nhất và nhỏ nhất trong mảng
        Console.Write("b. Nhập 8 số thực (8 byte) cách nhau bởi dấu cách: ");
        input = Console.ReadLine().Split();
        numbers = new double[8];

        for (int i = 0; i < 8; i++)
        {
            numbers[i] = double.Parse(input[i]);
        }

        double max = numbers[0];
        double min = numbers[0];

        foreach (double num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }

        Console.WriteLine($"Giá trị lớn nhất: {max}");
        Console.WriteLine($"Giá trị nhỏ nhất: {min}");
    }
}