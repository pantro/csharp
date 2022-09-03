var rect = new Rectangle(3, 4);              // Criação de objeto do tipo Rectangle

(float width, float height) = rect;            // Desconstrução
Console.WriteLine(width + " " + height);    // 3 4

// O uso de tipagem implícita é usada com a palavra-chave var:  
var (x, y) = rect;                           // Desconstrução
Console.WriteLine(x + " " + y);

// Se as variáveis já foram declaradas, podemos apenas chamar o desconstrutor
(x, y) = rect; 
Console.WriteLine(x + " " + y);

// A partir do C#, é permitido o uso de sintaxe mista
double x1 = 0;
(x1, double y2) = rect;
Console.WriteLine(x + " " + y);

class Rectangle
{
  public readonly float Width, Height;

  public Rectangle(float width, float height)
  {
    Width = width;
    Height = height;
  }

  public void Deconstruct(out float width, out float height)    // Declaração do método desconstrutor
  {
    width = Width;
    height = Height;
  }
}