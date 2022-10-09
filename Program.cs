/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. (можно решить через строку, а можно математически)
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите ваша пятизначное число");
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
}