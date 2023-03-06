using System;

// Classe base com dados encapsulados
class Person
{
    protected string name;
    protected int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Greet()
    {
        Console.WriteLine($"Ola, meu nome e {name} e tenho {age} anos.");
    }
}

// Classe derivada que herda da classe base
class Student : Person
{
    protected string school;

    public Student(string name, int age, string school)
        : base(name, age)
    {
        this.school = school;
    }

    public void Study()
    {
        Console.WriteLine($"{name} esta estudando em {school}.");
    }
}

class EncInhProgram
{
    static void Main()
    {
        // Create a new instance of the Student class
        Student student = new Student("Rafael Fischer", 22, "UNICENTRO");

        // Call methods on the Student object
        student.Greet();
        student.Study();
    }
}
