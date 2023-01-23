using Bottles;

var bottle1 = new Bottle(5);
var bottle2 = new Bottle(7);
var wantedVolume = 7;

for (int operationNo = 0; operationNo < 8; operationNo++)
{
    bottle1.Empty();
    bottle2.Empty();
    if (operationNo == 0) bottle1.FillFromTap();         // Fylle flaske 1 fra springen
    else if (operationNo == 1) bottle2.FillFromTap();    // Fylle flaske 2 fra springen
    else if (operationNo == 2) bottle2.FillWith(bottle1); // Tømme flaske 1 i flaske 2 - 
    // Tanken er at Empty() returnerer hvor mye det var i flasken før den ble tømt
    else if (operationNo == 3) bottle1.FillWith(bottle2); // Tømme flaske 2 i flaske 1
    else if (operationNo == 4) bottle2.EmptyInto(bottle1);    // Fylle opp flaske 2 med flaske 1
    // Tanken er at FillToTop tar en annen Bottle som parameter. Hvis det er nok, fyller den 
    // bottle2 og reduserer bottle1 tilsvarende. Hvis ikke gjør den ingenting.
    else if (operationNo == 5) bottle1.FillWith(bottle2);    // Fylle opp flaske 1 med flaske 2
    else if (operationNo == 6) bottle1.Empty();               // Tømme flaske 1 (kaste vannet)
    else if (operationNo == 7) bottle2.Empty();               // Tømme flaske 2 (kaste vannet)

    if (bottle1._content == wantedVolume || bottle2._content == wantedVolume)
    {
        Console.WriteLine("Fant ønsket volum ved operasjon " + operationNo);
    }
}