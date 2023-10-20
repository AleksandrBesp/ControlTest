// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.Write("Введите длинну массива: ");
int sise = int.Parse(Console.ReadLine() ?? "0");//Определение длинны изначального массива строк

// Метод запроса и введения данных
string ReadData(string msg)
{
    Console.WriteLine(msg);
    string str = Console.ReadLine() ?? "0";
    return str;
}

// Метод создания массива строк
string[] StringArray (int sise)
{
    string [] strArr = new string [sise];
    for(int i =0; i < sise ; i++)
    {
        strArr[i] = ReadData("Введите значение строки массива: ");//Заполнение массива через мнтод ReadData

    }
    return strArr;
}

//создание нового массва
string[] NewStringArray(string[] strArr, int sise)
{
    int newSise = new Random().Next(1, 3);//
    string textStr = "0";
    if(sise <= 3)
    {
        newSise = 1;
    }
    string[] newStrArr = new string [newSise];
    for(int ind =0; ind < newSise ; ind++)
    {
        int j = new Random().Next(0,sise - 1);
        textStr = strArr[j];
        while (NewStringArrControl(newStrArr, textStr))
                {
                    j = new Random().Next(0,sise - 1);
                    textStr = strArr[j];
                }
 
        newStrArr[ind] = textStr;
    }
    return newStrArr;
}

bool NewStringArrControl(string[] newStrArrint, string textStr)//Проверяет повторы чисел
{
    for (int i = 0; i < newStrArrint.GetLength(0); i++)
    {
        if (newStrArrint[i] == textStr)
            return true;
    }
    return false;
}

// Выводит массив строк в консоль
void OutputStringArray(string[] strArr)
{
    Console.Write("[");
    for (int i = 0; i < strArr.Length - 1; i++)
        System.Console.Write(strArr[i] + " - ");
    System.Console.WriteLine(strArr[strArr.Length - 1] + "]");
}

// вызов методов
string[] strArr = StringArray(sise);
Console.WriteLine("Вывод изначального массива строк: ");
OutputStringArray(strArr);
string[] newStrArr = NewStringArray(strArr, sise);
Console.WriteLine("Вывод нового массива строк: ");
OutputStringArray(newStrArr);