﻿// Лекция 3. Методы

// Первый вид методов - ничего не принимают, ничего не возвращают
/*
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1(); // вЫЗОВ МЕТОДА
*/
// Method1; - это неправильный вызов метода, будет выдавать ошибку




//--------------------------------------------------------------------------------



// Вид 2 - Методы, которые ничего не возвращают, но могут принимать какие-то аргументы
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// //Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "Новый текст");



//----------------------------------------------------------------------------------


//Вид3 - Методы которые чсто-то возарщают, но ничего не принимают




// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


//-------------------------------------------------------------------------------------

// Вит4 - Методы, которые что-то приниаю т и возвращают

// string Method4 (int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; //тоже самое что result = "";

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "zZ");
// Console.WriteLine(res);

//--------------------------------------------------------------------------------------

//Цикл for !!!!!!!!!!!!!!!!!! Ураааааааааааааа!!!!!!!

// string Method4 (int count, string text)
// {
//     string result = String.Empty; //тоже самое что result = "";
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "zZ");
// Console.WriteLine(res);

//--------------------------------------------------------------------

//Цикл в цикле

// string result = String.Empty; //тоже самое что result = "";
// for (int i = 2; i < 10; i++)
// {
//     for (int j = 0; j <=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

//------------------------------------------------------------------

//Используем цикл for: Дан текст, в нем нужно все пробелы заменить
// черточками, маленькие буквы "к" заменить большими "К", а большие "С" на маленькие "с"

//Ясна ли задача? Что за дан текст?? Ввел пользов, скачали, или  что? - У нас это будет строка
//Что значит черточками? Какими? Тире, дефис, минус.
//Какой алфавит?

string text =
    "- Я думаю, - сказал князь, улыбаясь, - что, "
    + "ежели бы вас послали вместо нашего милого Винценгероде,"
    + "вы бы взяли приступом согласие прусского короля. "
    + "Вы так краснороечивы. Вы дидате мне чаю?";

// string s = "qwerty"
//             012345
//s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

//----------------------------------------------------------------------------------

//Сортировка массива методом выбора

// 6 8 3 2 1 4 5 7
// |       |

//Задача для сортировки звучи так:
//1. Найти позицию минимального элемента в неотсортированной части массива
//2. Произвести обмен этого значения со значением первой неотсортированной позиции
//3. Повторять пока есть неотсортированные элементы

int[] arr = { 66, 81, 13, 12, 11, 14, 51, 17 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
                minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
