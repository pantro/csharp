var o = new Octopus("Jack");

Console.WriteLine(o.Name);  // Jack  
o.Legs = 20;                // Erro de compilação

class Octopus
{
  public readonly string Name;
  public readonly int Legs = 8;
  
  public Octopus(string name)
  {
    Name = name;
  }
}