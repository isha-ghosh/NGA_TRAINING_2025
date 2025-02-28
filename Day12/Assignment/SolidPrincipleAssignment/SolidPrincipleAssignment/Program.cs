using System;
using System.Collections.Generic;

// Single Responsibility Principle (SRP)
// Separate ReportGenerator (for generating reports) and ReportSaver (for saving reports)
public class ReportGenerator
{
    public string GenerateReport() => "Report Content";
}

public class ReportSaver
{
    public void SaveReport(string content)
    {
        Console.WriteLine("Report saved: " + content);
    }
}

// Open/Closed Principle (OCP)
// Introduce an interface for formatting and allow extensions without modifying existing code
public interface IReportFormatter
{
    string Format(string content);
}

public class PdfReportFormatter : IReportFormatter
{
    public string Format(string content) => "PDF: " + content;
}

public class ExcelReportFormatter : IReportFormatter
{
    public string Format(string content) => "Excel: " + content;
}

// Liskov Substitution Principle (LSP)
// Ensure derived classes can replace base classes without breaking functionality
public abstract class Report
{
    public abstract string GetContent();
}

public class SalesReport : Report
{
    public override string GetContent() => "Sales Report Content";
}

public class EmployeeReport : Report
{
    public override string GetContent() => "Employee Report Content";
}

// Interface Segregation Principle (ISP)
// Split interfaces so clients don’t need to implement unnecessary methods
public interface IReadableReport
{
    string ReadReport();
}

public interface IWritableReport
{
    void WriteReport(string content);
}

public class ReadableReport : IReadableReport
{
    public string ReadReport() => "Reading Report";
}

public class WritableReport : IWritableReport
{
    public void WriteReport(string content) => Console.WriteLine("Writing Report: " + content);
}

// Dependency Inversion Principle (DIP)
// High-level modules should depend on abstractions rather than concrete classes
public class ReportService
{
    private readonly ReportGenerator _generator;
    private readonly IReportFormatter _formatter;
    private readonly ReportSaver _saver;

    public ReportService(ReportGenerator generator, IReportFormatter formatter, ReportSaver saver)
    {
        _generator = generator;
        _formatter = formatter;
        _saver = saver;
    }

    public void ProcessReport()
    {
        string content = _generator.GenerateReport();
        string formatted = _formatter.Format(content);
        _saver.SaveReport(formatted);
    }
}

// Usage
class Program
{
    static void Main()
    {
        var generator = new ReportGenerator();
        var formatter = new PdfReportFormatter(); // Can switch to ExcelReportFormatter without modifying existing code
        var saver = new ReportSaver();
        var service = new ReportService(generator, formatter, saver);

        service.ProcessReport();
    }
}
