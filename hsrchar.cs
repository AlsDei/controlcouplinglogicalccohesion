using System;
namespace chars;

// LOGICAL COHESION
// 3 private method nya ini dibawah sebnaarnya independen ssemua, tapi me as developer ngerupin mereka jadi 1 grup di method CEK.
// karena 'logically' mereka tuh method yg sama sama nge cek info dari object
public class HsrChar
{
    public string Name { get; set; }
    public string Path { get; set; }
    public string Element { get; set; }

    // CONTROL COUPLING.
    // parameter type nih bukan data, tapi kayak instruksi buat ngejalanin method cek ini, sesuai dengan value dari parameter ini
    // pokok e kayak remote control jarene. u mencet tombol "info" di remote, bakal di kasi info dari char nya. Gituh mas
    public void Cek(string Type)
    {
        switch (Type.ToLower())
        {
            case "info":
                DisplayInfo();
                break;

            case "path":
                ShowPath();
                break;

            case "element":
                CheckElement();
                break;

            default:
                Console.WriteLine("No such check is in here");
                break;
        }
    }

    private void DisplayInfo()
    {
        Console.WriteLine($"Character: {Name} [{Element} | {Path}]");
    }

    private void ShowPath()
    {
        Console.WriteLine($"{Name} follows the Path of '{Path}'.");
    }

    private void CheckElement()
    {
        Console.WriteLine($"{Name}'s Element is {Element}.");
    }
}