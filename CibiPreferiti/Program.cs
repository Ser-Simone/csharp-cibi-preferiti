// See https://aka.ms/new-console-template for more information
Console.WriteLine("Benvenuto!");
string[] cibi = { "Pizza", "Pasta", "Ostrica", "Sushi", "Raffaello", "Spinaci", "Broccoli" };



Console.WriteLine("la classifica è composta da " + cibi.Length + " posizioni");

for ( int i = 0; i < cibi.Length; i++)
{
    int posizione = i + 1;
    Console.WriteLine(cibi[i] + " è alla posizione " + posizione ); 
   // Console.WriteLine("la classifica è composta da " [i] + "posizioni");
}

Console.WriteLine("Il tuo cibo preferito è " + cibi[1]);
int cibi2 = cibi.Length - 1;
Console.WriteLine("il tuo cibo meno preferito è " + cibi[cibi2]);

int metaClass = cibi.Length%2;

if (metaClass==0)
{
    metaClass = cibi.Length;
    Console.WriteLine(metaClass);
    metaClass = metaClass / 2;
    Console.WriteLine("il cibo medio è " + cibi[metaClass]);
    Console.WriteLine("il cibo medio è " + cibi[metaClass-1]);
}else
{
    metaClass = cibi.Length;
    metaClass = metaClass / 2;
    Console.WriteLine("il cibo medio è " + cibi[metaClass]);
}