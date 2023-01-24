/*
Функции в программировании 

ВозвращаемыйТипДанных ИмяМетода(ТипДанных1 ИмяАргумента1, ...)
{
    Тело Метода
    return ЗначениеСоответствующееВозвращаемомуТипуДанных;
}

Первая группа методов - ничего не возвращают, ничего не принимают
Вторая группа методов - что-то принимают, ничего не возвращают
Третья группа методов - ничего не принимают, что-то возвращают
Четвёртая группа методов - что-то принимают, что-то возвращают
*/

//First type

void Method1()
{
    Console.WriteLine("Author ...");
}

Method1();

//Second type

void Method2(string msg, string css)
{
    Console.WriteLine(msg + css);
}
Method2(msg:"Text of a message",css:"TEXT OF A MeSSAGE");//We can point at the needed argument

void Method21(string msg, int count)
{
    int i = 0;
    while ( i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(msg: "this is text", count: 2);

//Third type

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Fourth type

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = $"{result} {text}";
        i++;
    }
    return result;
}

string res = Method4(10, "fuck");
Console.WriteLine(res);