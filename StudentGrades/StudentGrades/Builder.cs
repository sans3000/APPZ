using System;

public class GradeReport
{
    public string Header { get; set; }
    public string Content { get; set; }
}

public interface IReportBuilder
{
    void BuildHeader();
    void BuildContent();
    GradeReport GetReport();
}

public class StudentReportBuilder : IReportBuilder
{
    private GradeReport _report = new GradeReport();

    public void BuildHeader() => _report.Header = "Student Grades Report";
    public void BuildContent() => _report.Content = "Grades: Math - 90, CS - 95";

    public GradeReport GetReport() => _report;
}

public class ReportDirector
{
    public void Construct(IReportBuilder builder)
    {
        builder.BuildHeader();
        builder.BuildContent();
    }
}