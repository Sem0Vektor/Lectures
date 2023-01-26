/*
Двумерные массивы
указываем тип данных, в квадратных скобках указываем тип 
размерности ([,] - это две размерности, и т.д.), первая 
размерность это - строки, вторая размерность - это столбцы,
далее наименование массива, 
= new *тип данных* [*количество строк*, *количество столбцов*];

*таблица чисел - матрица*
*/


string[,] table = new string [2, 5];
/*  table[0, 0] table[0, 1] table[0, 2] ... table[0, 4]
    table[1, 0] table[1, 1] table[1, 2] ... table[1, 4]

    по сути у массива теперь есть два индекса
    один для строк
*/

void PrintArray(int[,] mX)
{
    for(int r = 0; r < mX.GetLength(0); r++)
    {//GetLength() - новый оператор для того чтобы выяснить длину конкретного измерения массива, 0 - строка
        for(int c = 0; c < mX.GetLength(1); c++)
        {// 1 - столбец
            Console.Write($"{mX[r, c]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] mX)
{
    for(int r = 0; r < mX.GetLength(0); r++)
    {
        for(int c = 0; c < mX.GetLength(1); c++)
        {
            mX[r, c] = new Random().Next(1,10);
        }// интервал на самом деле подразумевается так [1, 10)
    }
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);