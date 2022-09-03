Panda a = new Panda();
Panda b = new Panda();
a.Marry(b);
//Console.WriteLine(new Panda().Marry(new Panda()));

public class Panda
{
  public Panda Mate;

  public void Marry(Panda partner)
  {
    Mate = partner;
    partner.Mate = this;        // Atribui o próprio objeto
  }
}
