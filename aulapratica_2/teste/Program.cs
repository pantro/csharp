Octopus o = new Octopus();

o.Foo(123);         // int
o.Foo(123.0);       // double
o.Foo(123, 123F);   // int, float
o.Foo(123F, 123);   // float, int

class Octopus
{
    public void Foo(int x)         { Console.WriteLine("int"); }
    public void Foo(double x)      { Console.WriteLine("double"); }
    public void Foo(int x, float y) { Console.WriteLine("int, float"); }
    public void Foo(float x, int y) { Console.WriteLine("float, int"); }
}
