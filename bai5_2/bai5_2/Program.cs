using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 5:");

        // Phần (a): Tìm giá trị lớn nhất và nhỏ nhất trong mảng
        Console.Write("a. Nhập 4 số thực (4 byte) cách nhau bởi dấu cách: ");
        string[] input = Console.ReadLine().Split();
        float[] numbers = new float[4];

        for (int i = 0; i < 4; i++)
        {
            numbers[i] = float.Parse(input[i]);
        }

        float max = numbers[0];
        float min = numbers[0];

        foreach (float num in numbers)
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

        // Phần (b): Tính tổng các số trong mảng
        Console.Write("b. Nhập 4 số thực (4 byte) cách nhau bởi dấu cách: ");
        input = Console.ReadLine().Split();
        numbers = new float[4];

        for (int i = 0; i < 4; i++)
        {
            numbers[i] = float.Parse(input[i]);
        }

        float sum = 0;
        foreach (float num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"Tổng các số trong mảng: {sum}");
    }
}