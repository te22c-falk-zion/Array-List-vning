
string[] toyNames = {"Beyblade", "Bakugan", "Lego", "Digimon", "Pokemon TCG"};
string[] names = {"Don Quixote","Ishmael", "Yi sang", "Charon", "Faust"};
int[] ints = {10, 4, 8, 6, 4};

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"{names[i]} picked up a {toyNames[i]} and gave it a {ints[i]}");
    Console.ReadLine();
}