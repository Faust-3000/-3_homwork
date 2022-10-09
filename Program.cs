/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. (можно решить через строку, а можно математически)
14212 -> нет
12821 -> да
23432 -> да */

/* Console.WriteLine("Введите ваша пятизначное число");
String X = Console.ReadLine()!;
if((X.Length == 5)){
    int A = Convert.ToInt32(X[0]);
    int B = Convert.ToInt32(X[1]);
    int C = Convert.ToInt32(X[3]);
    int D = Convert.ToInt32(X[4]);
    if((A == D) && (B == C)){
        Console.WriteLine("Ваша число являеться палендромом");
    }
    else{
        Console.WriteLine("Ваша число не являеться палендромом");
    }
}
else{
    Console.WriteLine("Вы ввели не пятизначное число");
} */

/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 

AB = корень((Х2 -Х1) в квадрате + (Y2 -Y1) в квадрате + (Z2 - Z1) в квдрате)) */

/* Console.WriteLine("Введите первую координату X");
int Xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первую координату Y");
int Ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первую координату Z");
int Za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите вторую координату X");
int Xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите вторую координату Y");
int Yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите вторую координату Z");
int Zb = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt (Math.Pow ((Xb - Xa), 2) + Math.Pow ((Yb - Ya), 2) + Math.Pow ((Zb - Za), 2));

Console.WriteLine(result); */

/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
чисел от 1 до N. */

/* Console.WriteLine("Введите больше 1");
int num = int.Parse(Console.ReadLine()!);
int start = 1;

if(num < start){
    Console.WriteLine("Вы ввели нее верное число");
}
else{
    while(num > start){
        Console.Write($"{Math.Pow(start, 3)}, ");
        start++;
    }
    Console.WriteLine($"{Math.Pow(num, 3)}");
} */

