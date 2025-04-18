using System;

public interface IUser
{
    void ShowRole();
}

public interface IAccess
{
    void ShowAccessLevel();
}

public class Student : IUser
{
    public void ShowRole() => Console.WriteLine("I am a student");
}

public class StudentAccess : IAccess
{
    public void ShowAccessLevel() => Console.WriteLine("Limited access");
}

public interface IUserFactory
{
    IUser CreateUser();
    IAccess CreateAccess();
}

public class StudentFactory : IUserFactory
{
    public IUser CreateUser() => new Student();
    public IAccess CreateAccess() => new StudentAccess();
}