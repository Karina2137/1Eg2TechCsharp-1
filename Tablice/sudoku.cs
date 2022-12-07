/*int[] T = new int[100];
Random rand = new Random();
for (int i = 0; i < T.Length; i++)
{
    T[i] = rand.Next(10, 100);
}

int suma_parz = 0;
int ilosc_nieparz = 0;
for (int i = 0; i < T.Length; i++)
{
    if (T[i] % 2 == 0) suma_parz += T[i];
    else ilosc_nieparz += 1;
}
Console.Write(suma_parz + " " + ilosc_nieparz);*/


/*int[,] T2D = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(T2D[ i,j] + "\t");
    }
    Console.WriteLine();
}*/


//Ala sudoku
/*int[,] M = new int[,] { { 1, 2, 3 }, { 4, 5, 6, }, { 7, 8, 9 } };
for (int l = 0; l < 3; l++)
{
    for (int k = 0; k < 3; k++)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(M[i, j] + " ");
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}*/

//macierz 4x4, dowolne liczby

/*int[,] M = new int[4,4];
Random rand = new Random();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        M[i, j] = rand.Next(1, 10);
    }
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(M[i,j] + "\t");
        Console.WriteLine();
    }
}*/

//wypełnij macierz 3x5 liczbami dwucyfrowymi korzystając z GetLenght()

/*int[,] M = new int[3, 5];
Random r = new Random();
for(int i =0; i<M.GetLength(0); i++)
{
    for (int j = 0; j < M.GetLength(1); j++)
    {
        M[i, j] = r.Next(10, 100);
    }
}
for (int i = 0; i < M.GetLength(0); i++)
{
    for (int j = 0; j < M.GetLength(1); j++)
    {
        Console.Write(M[i,j] + "\t");
    }
    Console.WriteLine();
}*/
