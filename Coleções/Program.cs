

int[,] matriz = new int[4,2]

{
    {8, 8 },
    {10, 20 },
    {50, 100 },
    {90, 200 }
};

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        System.Console.WriteLine(matriz[i, j]);
    }
}


//ARRAY DO TIPO VETOR

// See https://aka.ms/new-console-template for more information

//int [] arrayinteiros = new int[3];

//arrayinteiros[0] = 10;
//arrayinteiros[1] = 20;
//arrayinteiros[2] = 30;

// System.Console.WriteLine("Percorrendo o array pelo for");
// for (int i = 0; i < arrayinteiros.Length; i++)
// {
//   System.Console.WriteLine(arrayinteiros[i]);  
// }
// System.Console.WriteLine("Percorrendo o array pelo foreach");
// foreach (int item in arrayinteiros)
// {
//     System.Console.WriteLine(item);
// }


