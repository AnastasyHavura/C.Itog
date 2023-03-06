// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (m<n)
{
    NumSum(m,n,sum);
}
else
{
    NumSum(n,m,sum);
}
void NumSum(int m, int n, int sum)
{  
    if (m>n)
    {
        Console.WriteLine($". Сумма натуральных элементов в промежутке между этими числами равна {sum}");
        return;
    }
  
   sum = sum + m;
    Console.Write(m +" ");
    m++;
    NumSum(m,n,sum);
}