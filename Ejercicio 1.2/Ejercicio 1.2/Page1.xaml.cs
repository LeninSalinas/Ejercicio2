using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            // Obtén el objeto "persona" del BindingContext
            var persona = (Persona)BindingContext;

            // Muestra los datos en el Label
            lblDatos.Text = $"Nombre: {persona.Nombre} Apellidos: {persona.Apellidos} Edad: {persona.Edad} Correo Electrónico: {persona.correo}";
        }
    }
}
