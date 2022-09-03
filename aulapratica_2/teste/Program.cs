Console.WriteLine(Foo1(10) == Foo2(10));    // True

int Foo1(int x) { return x * 2; }
int Foo2(int x) => x * 2; 