using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 4:");

        // Kiểm tra số Palindrome
        Console.Write("a. Nhập số nguyên không dấu (8 byte): ");
        ulong palindromeNumber = ulong.Parse(Console.ReadLine());

        if (IsPalindrome(palindromeNumber))
        {
            Console.WriteLine($"{palindromeNumber} là số Palindrome.");
        }
        else
        {
            Console.WriteLine($"{palindromeNumber} không phải là số Palindrome.");
        }

        // Tính tổng mảng số nguyên có dấu
        Console.Write("b. Nhập các số nguyên có dấu (tối đa 8 số, mỗi số cách nhau bởi dấu cách): ");
        string[] input = Console.ReadLine().Split();
        long[] numbers = new long[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            
            numbers[i] = long.Parse(input[i]);
        }

        long sum = 0;
        foreach (long num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"Tổng các số trong mảng: {sum}");
    }

    public static bool IsPalindrome(ulong num)
    {
        ulong originalNum = num;
        ulong reversedNum = 0;

        while (num > 0)
        {
            reversedNum = reversedNum * 10 + (num % 10);
            num /= 10;
        }

        return originalNum == reversedNum;
    }
}