// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 * Bir nesne GELİŞİME AÇIK, DEĞİŞİME KAPALI olmalıdır.
 */

Report salesReport = new Report();
salesReport.Title = "Annualy Sales Report";
salesReport.ReportFormat = new ExcelReportType();

ReportGenerator reportGenerator = new ReportGenerator();
reportGenerator.Report = salesReport;
reportGenerator.CreateReport();


public abstract class ReportFormatType
{
    //bir zamanlar enum idi
    //PDF,
    //Excel,
    //PowerPoint,
    //Canvas
    public abstract string GetPath();


}

public class PdfReportType : ReportFormatType
{
    public override string GetPath()
    {
        return @"C:\PDFFiles";
    }
}

public class ExcelReportType : ReportFormatType
{
    public override string GetPath()
    {
        return @"C:\ExcelFiles";
    }
}

public class PPTReportType : ReportFormatType
{
    public override string GetPath()
    {
        return @"C:\PPTFiles";
    }
}
public class Report
{
    public ReportFormatType ReportFormat { get; set; }
    public string Title { get; set; }
    public string Owner { get; set; }

    public string Path { get; set; }

}

public class ReportGenerator
{
    public Report Report { get; set; } = new Report();
    public void CreateReport()
    {
        //switch (Report.ReportFormat)
        //{
        //    case ReportFormatType.PDF:
        //        Report.Path = @"C:\PDFFiles";
        //        break;
        //    case ReportFormatType.Excel:
        //        Report.Path = @"C:\ExcelFiles";

        //        break;
        //    case ReportFormatType.PowerPoint:
        //        Report.Path = @"C:\PPTFiles";
        //        break;
        //    case ReportFormatType.Canvas:
        //        break;
        //    default:
        //        break;
        //}

        Report.Path = Report.ReportFormat.GetPath();
        Console.WriteLine($"{Report.Title} raporunun adresi; {Report.Path}");
    }
}