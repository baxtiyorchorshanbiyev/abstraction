namespace Abstraction.Models;
interface IPrinter
{
    void Print(string documentName);

    void PrintPreview(string documentName);

    void Clean();
}

class LaserPrinter : IPrinter
{
    public void Print(string documentName)
    {
        Console.WriteLine($"Laser printer tez chop etdi: {documentName}");
    }

    public void PrintPreview(string documentName)
    {
        Console.WriteLine($"Laser printer oldindan ko'rdi: {documentName}");
    }

    public void Clean()
    {
        Console.WriteLine("Laser printer tozalandi");
    }
}

class InkjetPrinter : IPrinter
{
    public void Print(string documentName)
    {
        Console.WriteLine($"Inkjet printer sifatli chop etdi: {documentName}");
    }

    public void PrintPreview(string documentName)
    {
        Console.WriteLine($"Inkjet printer oldindan ko'rdi: {documentName}");
    }

    public void Clean()
    {
        Console.WriteLine("Inkjet printer siyoh purkagichlari tozalandi");
    }
}

class ThermalPrinter : IPrinter
{
    public void Print(string documentName)
    {
        Console.WriteLine($"Termoprinter chek chop etdi: {documentName}");
    }

    public void PrintPreview(string documentName)
    {
        Console.WriteLine($"Termoprinter oldindan ko'rdi: {documentName}");
    }

    public void Clean()
    {
        Console.WriteLine("Termoprinter termobosma kallagi tozalandi");
    }
}

static class PrinterTest
{
    public static void RunTest()
    {
        IPrinter thermalPrinter = new ThermalPrinter();

        IPrinter[] printers =
        {
            new LaserPrinter(),
            new InkjetPrinter(),
            thermalPrinter
        };

        foreach (IPrinter printer in printers)
        {
            Console.WriteLine($"Tekshiruv: {printer.GetType().Name}");
            printer.PrintPreview("Dars-jadvali");
            printer.Clean();
            printer.Print("Dars-jadvali");
            Console.WriteLine();
        }
        thermalPrinter.PrintPreview("Chek");
    }
}
