using System;
using chars;

public class Program
{
    public static void Main(string[] args)
    {
        var danHeng = new HsrChar
        {
            Name = "Dan Heng", Path = "The Hunt", Element = "Wind"
        };
        var phainon = new HsrChar
        {
            Name = "Phainon", Path = "Destruction", Element = "Physical"
        };

        Console.WriteLine("--- Character Actions ---");

        // CONTROL COUPLING di pake disini, remote mencet tombol "info"
        Console.Write("Info Dan Heng : ");
        danHeng.Cek("info");
        Console.Write("Info Phainon : ");
        phainon.Cek("info");

        // tombol laen, "path".
        Console.Write("Path : ");
        phainon.Cek("path");
        
        // tombol "element".
        Console.Write("Element : ");
        danHeng.Cek("element");
        
        // this is useless but i add it anyway
        Console.Write("Ultimate : ");
        phainon.Cek("ultimate");
    }
}