// string[,] table = new string[2,5]; // задается двумерный массив (строки, столбцы)
// int[,] matrix = new int[2,5]; // массив строк/матрица (строки, столбцы)
/*
string[,] table = new string[2,5];
// String.Empty - инициализация строк по умолчанию
// table[0,0]   table[0,1]   table[0,2]    table[0,3]   table[0,4]
// table[1,1]   table[1,1]   table[1,2]    table[1,3]   table[1,4]

table[1,2] = "слово"; // для поиска элемента

for(int rows = 0; rows < 2; rows++) // цикл строк
{
    for(int columns = 0; columns < 5; columns++) // вложенный цикл столбцов
    {
        Console.WriteLine($"{table[rows,columns]} ");
    }
}
*/



// Выводим случайный массив и заполняем его числами
/*
void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++) // цикл строк
    {
        for(int j = 0; j < matr.GetLength(1); j++) // вложенный цикл столбцов
        {
            matr[i,j] = new Random().Next(1,10);
        }
    Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];
void PrintArray(int[,] matr)
{
    for(int i = 0; i < matrix.GetLength(0); i++) // цикл строк
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // вложенный цикл столбцов
        {
            Console.Write($"{matrix[i,j]} ");
        }
    Console.WriteLine();
    }
}
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
*/


// Закрашивание картинки
/*
int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

void PrintImage(int[,] image)
{
    for(int i = 0; i < image.GetLength(0); i++) // цикл строк
    {
        for(int j = 0; j < image.GetLength(1); j++) // вложенный цикл столбцов
        {
            //Console.Write($"{image[i,j]} ");
            if(image[i,j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
    Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if(pic[row,col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}

PrintImage(pic);
FillImage(13,13);
PrintImage(pic);
*/


// Рекурсия (Вызов метода в самом методе). Вычисление факториала
/*
double Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for(int i = 1; i < 40; i++ )
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

Console.WriteLine(Factorial(40));
*/

// Числа Фибонначи
/*
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci (int n)
{
    if(n ==1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for(int i = 1; i < 40; i++ )
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
*/

