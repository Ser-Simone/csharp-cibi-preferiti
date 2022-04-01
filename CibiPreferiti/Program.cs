// See https://aka.ms/new-console-template for more information
Console.WriteLine("Benvenuto!");
string[] cibi = { "Pizza", "Pasta", "Ostrica", "Sushi", "Raffaello", "Spinaci" };



Console.WriteLine("la classifica è composta da " + cibi.Length + "posizioni");

for (int i = 0; i < cibi.Length; i++)
{
    Console.WriteLine(cibi[i] + " è alla posizione " + i ); 
   // Console.WriteLine("la classifica è composta da " [i] + "posizioni");
}


Console.WriteLine("Il tuo cibo preferito è " + cibi[1]);
int cibi2 = cibi.Length - 1;
Console.WriteLine("il tuo cibo meno preferito è " + cibi[cibi2]);