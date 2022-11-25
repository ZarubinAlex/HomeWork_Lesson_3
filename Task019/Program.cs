// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


bool isTaskMeet (string number){
    
    if (int.Parse(number) < 10000 || int.Parse(number) > 99999) return false;
    
    return true;
}

bool palindrome (string number){
    
    bool key = true;
    for(int i=0; i<number.Length/2; i++)
        if(number[i] != number[number.Length - 1 - i]) key = false;

    return key;
}


Console.Clear();

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

if(isTaskMeet(number)) 
    
    if(palindrome(number)) 
        Console.WriteLine("Да, палиндром"); 
    else 
        System.Console.WriteLine("Нет, не палиндром");
else
    Console.WriteLine("Число вне диапазона");

Console.WriteLine();