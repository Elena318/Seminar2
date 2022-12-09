/*int data = 15;
Console.Write("Доброе утро! Ссегодня " + data + ноября);  //("..." +...+ "...") 
//переменная преобразуется в строчку
Console.Write($"Доброе утро! Сегодня {data} ноября."); //($"...{...}...{...}...")
//переменная остается числовым значением
*/

//Напишите программу, которая получает на вход двузначное число и показывает наибоьшую цифру числа.
/*int Digits (int namber) //объявление метода Digits, который получает аргументом целое число, возвращает тоже целое число.
{
    int ed = namber % 10;//поиск единиц в числе
    int dec = namber / 10;//поиск десятков в числе

    int result;
    if (ed > dec){ //сравнение десятков и единиц
        result = ed; //завершение метода, возвращение в программу единицы
    }
    else result = dec;//завершение метода возвращение в программу десятки
    return result;

}
Console.Write("Введите двузначное число: ");
int user_nam = Convert.ToInt32(Console.ReadLine());

int res = Digits(user_nam);//вызов метода с аргументом user_nam
Console.Write($"Наибольшая цифра в числе {res}");*/

//Напишите программу , которая выводит случайное число из отрезка[10, 99] и показывает наибольшую цифру числа.
//72 -> 7   85 ->8 

/*int Digits () //объявление метода Digits, который получает аргументом целое число, возвращает тоже целое число.
{
    int randomNum = new Random().Next(10, 100); //генерация двузначного числа(число 100 не включается)
    Console.WriteLine("Ваше число " + randomNum);

    int ed = randomNum % 10;//поиск единиц в числе
    int dec = randomNum / 10;//поиск десятков в числе

    int result;
    if (ed > dec){ //сравнение десятков и единиц
        result = ed; //завершение метода, возвращение в программу единицы
    }
    else result = dec;//завершение метода возвращение в программу десятки
    return result;

}
Console.Write("Наибольшая цифра числа " + Digits());*/


//Напишите программу, которая принимает на вход число   проверяет, кратно ли оно a и b.

/*void Cratnost(int num, int a, int b)//num=user_num, a=divider1, b=divider2
{
    if (num % a == 0 && num % b == 0) //проверка на кратность
    {
        Console.WriteLine($"Число {num} кратное {a} и {b}");
    }
    else Console.WriteLine($"Число {num} не кратное {a} и {b}");
}
//Запрос данных у пользователя
Console.Write("Введите число: ");
int user_nam = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое кратное: ");
int divider1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе кратное: ");
int divider2 = Convert.ToInt32(Console.ReadLine());
//Вызов метода
Cratnost(user_nam, divider1, divider2);*/

//Напишите программу, которая вводит случайне трехзначное число и удаляет вторую цифру из этого числа.
//465 -> 46   789 -> 79

/*int DeleteDec()
{
    int randomNum = new Random().Next(100, 1000);
    Console.WriteLine("Наше число" + randomNum);

    int fut_dec = randomNum / 100; //деление нацело
    int fut_ed = randomNum % 10;  //деление с остатком

    int new_num = fut_dec * 10 + fut_ed;
    return new_num;
}

Console.WriteLine($"Новое число {DeleteDec()}"); */


