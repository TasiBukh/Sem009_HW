// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

int n = InputNumbers("Введи n: ");
int count = 2;
PrintNumber(n, count);
Console.WriteLine(1);

void PrintNumber(int n, int count)
{
    if (count > n) return;
    PrintNumber(n, count + 1);
    Console.WriteLine(count+ ", ");
}

int InputNumbers(string input)
{
    Console.WriteLine(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}