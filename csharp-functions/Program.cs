// See https://aka.ms/new-console-template for more information

// FUNZIONI

/* 
 * Preso un array di numeri interi, 
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
 * Restituisca il quadrato del numero passato come parametro.
*/

int Quadrato(int numero)
{
    return numero *= numero;
}

/*
 * Preso un array di numeri interi, 
 * restituisca un nuovo array con tutti gli elementi elevati quadrato. 
 * Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione!
*/
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] *= copiaArray[i];
    }

    return copiaArray;
}

/*
 * Preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
*/

int SommaElementiArray(int[] array)
{
    int sommaElementiArray = 0;
    for (int i = 0;i < array.Length; i++)
    {
        sommaElementiArray += array[i];
    }
    return sommaElementiArray;
}


// MAIN

int[] arrayBase = { 2, 6, 7, 5, 3, 9 };

StampaArray(arrayBase);

int[] arrayElevatoQuadrato = ElevaArrayAlQuadrato(arrayBase);

StampaArray(arrayElevatoQuadrato);
StampaArray(arrayBase);

int sommaArrayBase = SommaElementiArray(arrayBase);
int sommaArrayElevato = SommaElementiArray(arrayElevatoQuadrato);

Console.WriteLine($"{sommaArrayBase} è la somma degli elementi dell'array di partenza");
Console.WriteLine($"{sommaArrayElevato} è la somma degli elementi dell'array elevato al quadrato");