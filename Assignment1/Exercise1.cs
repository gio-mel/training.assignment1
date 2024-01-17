namespace Assignment1;

public class Person
{
    protected int Age { get; private set; }

    public void Greet()
    {
        Console.WriteLine("Hello");
    }

    public void SetAge(int age)
    {
        Age = age;
    }
}

public class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I'm studying");
    }

    public void ShowAge()
    {
        Console.WriteLine("My age is: " + Age + " years old");
    }
}

public class Teacher : Person
{
    public void Explain()
    {
        Console.Write("I'm explaining");
    }
}

public class StudentProfessorTest
{
    public static void Main()
    {
        var person = new Person();
        person.Greet();

        var student = new Student();
        student.SetAge(15);
        student.Greet();
        student.ShowAge();

        var teacher = new Teacher();
        teacher.SetAge(30);
        teacher.Explain();
    }
}