namespace ReadExcireWindowsForms;
using System;

class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
        // Funktionalität zur Begrüßung
    }
    
}