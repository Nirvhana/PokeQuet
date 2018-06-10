using System;
using Gtk;

namespace PokeQuet
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Application.Init();
			MainMenu win = new MainMenu();
            win.Show();
            Application.Run();




        }
    }
}
