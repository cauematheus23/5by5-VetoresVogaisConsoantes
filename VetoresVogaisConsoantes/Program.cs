char[] carac = new char[10];
for (int i = 0; i < 10; i++)
{ 
    Console.WriteLine($"Digite o {i}° caracter");
    carac[i] = char.Parse(Console.ReadLine());
    
}
Console.Write("Vogais: ");
for (int j = 0; j < 10; j++)
{
    if (carac[j] == 'a' || carac[j] == 'e' || carac[j] == 'i' || carac[j] == 'o' || carac[j] == 'u')
    {
        
        Console.Write(carac[j]);
    }
}
Console.WriteLine();
Console.Write("Consoantes: ");
for (int j = 0; j < 10; j++)
{
    if (carac[j] != 'a' && carac[j] != 'e' && carac[j] != 'i' && carac[j] != 'o' && carac[j] != 'u')
    {
        Console.Write(carac[j]);
    }
}