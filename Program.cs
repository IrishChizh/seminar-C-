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

//Console.Write("Input number of the day: ");
//int day = Convert.ToInt32(Console.WriteLine());

//if (day < 1 || day > 7)
//(||)- означает "или" (|) - означает и
//{
  //  Console.Write("Incorrect number");
//}
//else 
//{
  //  if (day == 1)
   // {
     //   Console.Write("Mondey");
    //}
    //if (day == 2)
    //{
      //  Console.Write("Tuesday");
    //}
    //if (day == 3)
    //{
     //Console.Write("");   
    //}

//}


//4.задача. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N
//выводим текст с запросом в терминале
//Console.WriteLine("Введите число: ");
// Присваевыем переменной N введенное число
//int N = Convert.ToInt32(Console.ReadLine());
//объеявляем новую переменну, в которую сохраним веденное число N с противоположным знаком.
//int A = -N;
//условный цикл , котрый будет "работать" до тех пор , пока значение переменной A <= N
//while(A <= N )
//{
    //Console.Write(A + " ");
    //A ++; // A = A + 1 or A +=1
//}

//5.Задача. Напишите программу, которая на вход принимает 3-ёх значное число
//и на выходе показывает последнюю цифру этого числа.
 //Console.WriteLine("Введите трёх значное число: ");
 //int num = Convert.ToInt32(Console.ReadLine());
 //int c = num % 10;
 //Console.Write(c);

//  Console.WriteLine("Введите трёх значное число: ");
//  int num = Convert.ToInt32(Console.ReadLine());
//  if (num <= 99 && num >=999)
 // решение по модолю 
  //Console.WriteLine("Последняя цифра" + Math.Abs(num) %10);
//  {
//    int c = num % 10;
//    Console.Write(c);
//  }
//  if (num <= -99 && num >= -999)
//  {
//   int c = num %10;
//   Console.Write(c);
//  }
//  else 
//  {
//   Console.WriteLine("Введёное число не трёхзначное!!!!");
//  }



// // HOME WORKE
// // Ex.1 
// //  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3
  
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
//  int b = Convert.ToInt32(Console.ReadLine());
// if (a > b )
// {
//   Console.Write(a);
// }
// else if (a < b )
// {
//  Console.Write(b);
 
// }
// else if ( a == b )
// {
//   Console.Write (a=b);
// }



// //Ex.2  
// //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

// Console.WriteLine("Введите первое число : ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;
// if (max<num2)
// {
//     max=num2;
// }
// if (max<num3)  
// {
//    max = num3;
// }
// Console.WriteLine("Максимальное число: "+ max);



// Ex.3  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
// {
//   Console.WriteLine("True");
// }
// else 
// {
//   Console.WriteLine("Fols");
// }


// Ex.4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N : ");
int i = Convert.ToInt32(Console.ReadLine());
int counter = 2;
while (counter <= i)
{
  Console.Write( $"{counter} ");
  counter +=2;
}