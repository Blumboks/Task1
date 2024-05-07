// void FromMToN(int m, int n)
// {
//     if (m > n)
//     {
//         FromMToN(m - 1, n);
//         System.Console.Write(m + " ");
//     }
//     else if(n > m)
//     {
//         FromMToN(m, n - 1);
//         System.Console.Write(n + " ");
//     }
//     else System.Console.Write(m + " ");
// }
// FromMToN(10, 21);


// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkermanFunction(m, n);

// void AkermanFunction(int m, int n)
// {
//     Console.Write(Akerman(m, n));
// }

// int Akerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akerman(m - 1, Akerman(m, n - 1)));
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] array = { 5, 7, 9, 2, 88, 44 };
//         PrintArrayReversed(array, array.Length - 1);
//     }
//     static void PrintArrayReversed(int[] array, int index)
//     {
//         if (index >= 0)
//         {
//             Console.Write(array[index] + " ");
//             PrintArrayReversed(array, index - 1);
//         }
//     }
// }