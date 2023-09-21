# Labb2 – Schackbrädan
## Om uppgiften
Det här är den andra uppgiften i kursen och nu kommer du själv få tänka ut en struktur och ett programflöde som löser uppgiften. Du kommer inte behöva använda speciellt avancerade flöden eller datatyper för att lösa uppgiften utan det handlar snarare om att hitta en logisk lösning.

## Vad du ska göra
Skapa ett nytt projekt i Visual Studio (Console Application → C# → .Net Core)

Döp projektet till "ChessBoard"

När programmet startar ska användaren få mata in en siffra.

Du ska sedan skriva ut ett "schackbräde" med så många rader och kolumner som användaren angav

Brädet skriver du ut genom att låta varje svart ruta representeras av detta tecken ◼︎ och varje vit ruta av detta tecken ◻︎. Du bör kunna kopiera dessa tecken från denna uppgiftsbeskrivning.

## Tips
När du tar en input från användaren kommer den in som en string. I denna uppgift behöver du ha den som en integer. För att konvertera det du får in från användaren kan du använda följande kod:

int number = Int32.parse(text); //gör om variabeln text till en integer

Om fyrkanterna visas konstigt kan du använda den här koden:

//unicode to show the squares, and setting a unicode standard output

Console.OutputEncoding = System.Text.Encoding.Unicode;

Om du inte får fyrkanterna att växla till varannan svart eller vit mellan raderna så finns det ett sätt att lösa det med att kombinera in XOR (^).
