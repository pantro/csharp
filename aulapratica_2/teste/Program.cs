Panda p = new Panda("Petey");   // Chamada de construtor
Console.WriteLine(p.name);

public class Panda
{
  public string name;                 
  public Panda(string n)        // Definição do Construtor: observe que o método não tem um tipo de retorno
  {
    name = n;                   // Código de inicialização da variável name 
  }
}