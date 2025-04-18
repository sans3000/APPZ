using System;

public abstract class Grade
{
    public abstract void Display();
}

public class NumericGrade : Grade
{
    public override void Display() => Console.WriteLine("Numeric Grade: 95");
}

public abstract class GradeCreator
{
    public abstract Grade CreateGrade();
}

public class NumericGradeCreator : GradeCreator
{
    public override Grade CreateGrade() => new NumericGrade();
}