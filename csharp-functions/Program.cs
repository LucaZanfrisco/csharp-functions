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

/*
 * Dato un numero inserito dall'utente, riempire un array da input
*/

int[] riempiArray(int lunghezza)
{
    int[] arrayUtente = new int[lunghezza];

    for(int i = 0; i < arrayUtente.Length; i++)
    {
        Console.Write($"Inserire il {i + 1} numero: ");
        arrayUtente[i] = int.Parse(Console.ReadLine());
    }
    return arrayUtente;
}

// Una funzione che, dato un numero intero n > 0, ne calcoli il fattoriale

int Fattoriale(int numero)
{
    if(numero > 0)
    {
        int fattoriale = 1;
        for(int i = 1; i <= numero; i++)
        {
            fattoriale *= i;
        }
        return fattoriale;
    }
    else
    {
        return 1;
    }
}


/*
// MAIN

int[] arrayBase = { 2, 6, 7, 5, 3, 9 };

StampaArray(arrayBase);

int[] arrayElevatoQuadrato = ElevaArrayAlQuadrato(arrayBase);

StampaArray(arrayElevatoQuadrato);
StampaArray(arrayBase);

int sommaArrayBase = SommaElementiArray(arrayBase);
int sommaArrayElevato = SommaElementiArray(arrayElevatoQuadrato);

Console.WriteLine($"{sommaArrayBase} è la somma degli elementi dell'array di partenza");
Console.WriteLine($"{sommaArrayElevato} è la somma degli elementi dell'array elevato al quadrato ");

Console.WriteLine("\n --------------------------------------- \n");

// MAIN BONUS

Console.Write("Inserire la quantità di numeri che si vogliono inserire: ");
int lunghezzaArray = int.Parse(Console.ReadLine());

int[] arrayUtente = riempiArray(lunghezzaArray);

StampaArray(arrayUtente);

int[] arrayUtenteElevatoQuadrato = ElevaArrayAlQuadrato(arrayUtente);

StampaArray(arrayUtenteElevatoQuadrato);
StampaArray(arrayUtente);

int sommaArrayUtente = SommaElementiArray(arrayUtente);
int sommaArrayUtenteElevato = SommaElementiArray(arrayUtenteElevatoQuadrato);

Console.WriteLine($"{sommaArrayUtente} è la somma degli elementi dell'array di partenza");
Console.WriteLine($"{sommaArrayUtenteElevato} è la somma degli elementi dell'array elevato al quadrato");

*/

// SBIZZARRIMENTO

Console.WriteLine("\n---------------------------\n");

Console.Write("Inserire un numero del quale verra calcolato il fattoriale, inserire un numero positivo: ");
int numeroFattoriale = int.Parse(Console.ReadLine());

int fattoriale = Fattoriale(numeroFattoriale);

Console.WriteLine($"Il Fattoriale di {numeroFattoriale} è: {fattoriale}");




