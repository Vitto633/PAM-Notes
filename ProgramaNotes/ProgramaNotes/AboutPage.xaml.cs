using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaNotes;

public partial class AboutPage : ContentPage
{
    string path = Path.Combine(FileSystem.AppDataDirectory, "arquivonovo.txt");
    string text = "";
    
    public AboutPage()
    {
        InitializeComponent();
        if(File.Exists(path))
        {
            FileEditor.Text = File.ReadAllText(path);
        }
    }
    
    private void SaveButton_OnClicked(object? sender, EventArgs e)
    {
        text = FileEditor.Text;
        File.WriteAllText(path, text);
        DisplayAlert("Sucesso", "Arquivo salvo com sucesso", "Ok");
    }

    private void DeleteButton_OnClicked(object? sender, EventArgs e)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            FileEditor.Text = "";
        }
    }
}