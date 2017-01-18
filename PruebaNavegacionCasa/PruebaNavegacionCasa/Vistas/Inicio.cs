using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PruebaNavegacionCasa.Vistas
{
    public class Inicio: ContentPage
    {
        public Inicio()
        {
            var etiqueta = new Label
            {
                Text = "Pagina de inicio"
            };

            var btnCambiarPagina = new Button
            {
                Text = "Click Me"
            };

            btnCambiarPagina.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new Navegue());
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { etiqueta,btnCambiarPagina}
                
            };
        }
    }
}
