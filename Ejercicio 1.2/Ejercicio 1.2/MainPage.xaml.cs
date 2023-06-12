using Ejercicio_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio_1._2
{
    public partial class MainPage : ContentPage
    {
        Persona persona;
        public MainPage()
        {
            InitializeComponent();
            persona = new Persona();

            BindingContext=persona;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            persona.Nombre = Nombres.Text;
            persona.Apellidos = Apellidos.Text;
            int edad;
            if (int.TryParse(Edad.Text, out edad))
            {
                persona.Edad = edad;
            }
            else
            {
                // Mostrar un mensaje de error si la entrada de edad no es un número válido
                DisplayAlert("Error", "La edad debe ser un número válido", "OK");
                return;
            }

            persona.correo=Correo.Text;

            var segundaPagina = new Page1();
            segundaPagina.BindingContext = persona;
            await Navigation.PushAsync(segundaPagina);
        }
    }
}
