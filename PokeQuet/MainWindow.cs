using System;
using Gtk;
using PokeQuet;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        var eevee = new Card
        {
            name = "Eeveee"
        };
        this.label3.Text = eevee.name;
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
