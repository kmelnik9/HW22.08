// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Number2(int A){
    int result = (A / 10)%10;
    return result;
}
System.Console.WriteLine(Number2(918));


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Number3(int A){
    int digitCount = (int)Math.Log10(A)+1;
    int result = -1;
    int degree = (int)Math.Pow(10,(digitCount-2));
    if (digitCount>2){
        result = (A%degree)/(degree/10);
    }
        return result;
}
System.Console.WriteLine(Number3(32679));


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOff (int A){
    if (A<6){
        System.Console.WriteLine("нет");
    }
    else {
        System.Console.WriteLine("да");
    }
}

DayOff(1);