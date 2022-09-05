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

int[,] matrix = new int[3,4];
for(int i = 0; i < 3; i++) // цикл строк
{
    for(int j = 0; j < 4; j++) // вложенный цикл столбцов
    {
        Console.WriteLine($"-{matrix[i,j]}-");
    }
}