using System;

public class StudentGrade : ICloneable
{
    public string Subject { get; set; }
    public double Grade { get; set; }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}