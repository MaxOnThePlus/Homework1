//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine ());

// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine ());

// int max = 0;
// int min = 0;

// if ( a > b)
// {
//     Console.WriteLine($"Максимальное число {a}, минимальное число {b}");
// }
// else
// {
//      Console.WriteLine($"Максимальное число {b}, минимальное число {a}");
// }


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine ());

// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine ());

// Console.WriteLine("Введите первое число");
// int c = Convert.ToInt32(Console.ReadLine ());

// int max = a;

// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// Console.WriteLine($"Максимальное число {max}");

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine ());

// if (a % 2 == 0)
// {
//     Console.WriteLine($"Число {a} является четным");
// }
// else
// {
//     Console.WriteLine($"Число {a} является нечетным");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число N");
int  N = Convert.ToInt32(Console.ReadLine ());
int Lowerborder = 2;

while (Lowerborder  < N)
{
    Console.WriteLine($"{Lowerborder}");
    Lowerborder = Lowerborder + 2;
}