Class1 c1 = Class1.Create();  // OK
Class1 c2 = new Class1();    // Erro: Não irá compilar

public class Class1
{
  Class1() { }        // Construtor privado
  
  public static Class1 Create()
  {
    // Execução de alguma lógica para configurar a instanciação da classe Class1
    return new Class1();
  }
}