using System;
using System.Globalization;
using System.IO;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NewFileWriterSpike.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    
    [ObservableProperty] public partial string Email { get; set; } = "";
    [ObservableProperty] public partial DateTime Date { get; set; } = DateTime.Today;
    

    
    [RelayCommand]
    public void ReadWrite()
    {
        
        try
        {
            string path = "C:\\Users\\Bruger\\Desktop\\invite.ics";
            var cultureInfo = new CultureInfo("da-DK");
            var icsDate = Date.ToString("yyyyMMdd", cultureInfo);
            var startTime = "T120000";
            var endTime = "T140000";

            using StreamWriter sw = new StreamWriter(path);
            
            sw.WriteLine("BEGIN:VCALENDAR");
            sw.WriteLine("VERSION:2.0");
            sw.WriteLine("PRODID:-//Example Corp//Example Calendar//EN");
            sw.WriteLine("BEGIN:VEVENT");
            sw.WriteLine("UID:12345@example.com");
            sw.WriteLine($"DTSTAMP:{icsDate}{startTime}");
            sw.WriteLine($"DTSTART:{icsDate}{startTime}");
            sw.WriteLine($"DTEND:{icsDate}{endTime}");
            sw.WriteLine($"ATTENDEE;CN=\"{Email}\";ROLE=REQ-PARTICIPANT;RSVP=TRUE:mailto:{Email}");
            sw.WriteLine("SUMMARY:Cool Spike Event");
            sw.WriteLine("END:VEVENT");
            sw.WriteLine("END:VCALENDAR");

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    

}


