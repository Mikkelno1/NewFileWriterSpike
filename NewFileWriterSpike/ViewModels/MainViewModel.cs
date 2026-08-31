using System;
using System.IO;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NewFileWriterSpike.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    
    [ObservableProperty] public partial string Email { get; set; } = "";
    [ObservableProperty] public partial DateTime Date { get; set; } = DateTime.Today;
    

    /*
    [RelayCommand]
    public void ReadWrite()
    {
        string path = "C:\\Users\\Mikkel  Norinder\\Desktop\\invite.ics";
        try
        {
            StreamWriter sw = new StreamWriter(path);

            sw.WriteLine(Email + "\n" + Date);
            
            sw.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    */

    [RelayCommand]
    public void ReadWrite()
    {
        
    }

}


