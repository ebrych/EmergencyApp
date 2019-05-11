using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Emergencias
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        public void Logear()
        {
            string nombre = user.Text;
            string contrasena = pass.Text;
            Console.WriteLine(nombre);
            Console.WriteLine(contrasena);
        }

    }
}
