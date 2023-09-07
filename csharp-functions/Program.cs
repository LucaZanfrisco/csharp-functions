// See https://aka.ms/new-console-template for more information

// FUNZIONI

/* 
 * void StampaArray(int[] array): che preso un array di numeri interi, 
 * stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. 
*/
void StampaArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write((i < array.Length - 1) ? $"{array[i]}, " : $"{array[i]}");
    }

    Console.WriteLine("]");
}

/*
 * int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
*/

int Quadrato(int numero)
{
    return numero *= numero;
}
