// Семинар 1.
// 1. Задача . Напишите программу, которая на вход принимает  число и выдаёт его квадрат ( число уноженное на само себя)


Console.Clear();

//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int sqrt = number * number ;
//number *= number
//int sqrt = Convert.ToInt32(Math.Pow(number, 2));

//Console.WriteLine("Число в квадрате:" + sqrt);


//2. Задача. Напишите программу, которая на вход принимает два числа и проверяет, яляется ли первое число квадратом второго числа.

//Console.Write("Inpud second number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Inpud second number");
//int square = num2 * num2; 
//int num2 = Convert.ToInt32(Console.ReadLine());
//if (num1 == num2* num2); - избавимся от перемнной square
//if (num1 == square);    (==) - знак сравнения 
//{
    //Console.WrietLine("First number is a square of second number");
//}
//eles
//{
//   Console.WriteLine("First number is not a square of second number");
//}

//3. Задача. Напишим программу, которая будет выдовать названия дня недели по заданному номеру

Console.Write("Input number of the day: ");
int day = Convert.ToInt32(Console.WriteLine());

if (day < 1 || day > 7)
//(||)- означает "или" (|) - означает и
{
    Console.Write("Incorrect number");
}
else 
{
    if (day == 1)
    {
        Console.Write("Mondey");
    }
    if (day == 2)
    {
        Console.Write("Tuesday");
    }
    if (day == 3)
    {
     Console.Write("");   
    }

}