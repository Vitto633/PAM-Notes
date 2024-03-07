using System.Xml.Linq;
using System;

namespace PrimeiroProgramaCsharp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string name = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnGreetingsClicked(object sender, EventArgs e)
        {
            name = NameEntry.Text;
            GreetLabel.Text = $"Hello, {name}!";
        }
    }



}
