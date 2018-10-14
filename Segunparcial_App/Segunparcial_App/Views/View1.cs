using System;
using System.Linq;
using Xamarin.Forms;
using Segunparcial_App.Views;
using Segunparcial_App.Class;


namespace Segunparcial_App.Views
{
    public class View1 : ContentPage
    {
        public int Salary = -1;
        public int Year = -1;
        public Label Titulo;
        public Entry FirstNEntry;
        public Entry LastNEntry;
        public Entry YearBornEntry;
        public Entry SalaryEntry;
        Button btnConsulta;

        public View1()
        {
            Titulo = new Label
            {
                Text = "INGRESE TODOS LOS DATOS",
                FontSize = 30,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };

            FirstNEntry = new Entry
            {
                Placeholder = "Digitar Nombre",
                Keyboard = Keyboard.Text
            };

            LastNEntry = new Entry
            {
                Placeholder = "Digitar Apellidos",
                Keyboard = Keyboard.Text
            };

            YearBornEntry = new Entry
            {
                Placeholder = "Digite su año de nacimiento",
                Keyboard = Keyboard.Numeric
            };

            SalaryEntry = new Entry
            {
                Placeholder = "Digite su salario ",
                Keyboard = Keyboard.Numeric
            };

            btnConsulta = new Button
            {
                Text = "Consultar"
            };

            btnConsulta.Clicked += BtnConsulta_Clicked;

            Content = new StackLayout
            {
                Padding = 15,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    Titulo, FirstNEntry, LastNEntry, YearBornEntry, SalaryEntry, btnConsulta
                }
            };

        }

        private async void BtnConsulta_Clicked(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty((FirstNEntry.Text))
                || string.IsNullOrEmpty((LastNEntry.Text))
                || string.IsNullOrEmpty((YearBornEntry.Text))
                || string.IsNullOrEmpty((SalaryEntry.Text))
                )
            {
                await DisplayAlert("Precaucion!", "Ingreses todos los datos", "Aceptar");
                FirstNEntry.Focus();
            }
            else
            {
                Salary = (Convert.ToInt32(SalaryEntry.Text));
                Year = (Convert.ToInt16(YearBornEntry.Text));
                clasConditions clsRes = new clasConditions(Salary, Year, FirstNEntry.Text, LastNEntry.Text);
                if (clsRes.ValidateYear() == 1)
                {
                    if (Year < 2018)
                    {
                        if (clsRes.ValidateSalary() == 1)
                        {
                            await DisplayAlert("Precaucion!", "El salario no debe estar entre  $737.000 y $900.000", "Aceptar");
                            SalaryEntry.Focus();
                        }
                        else
                        {
                            await Navigation.PushModalAsync(new View2(Salary, Year, FirstNEntry.Text, LastNEntry.Text));
                        }
                    }
                    else
                    {
                        await DisplayAlert("Alto!", "Ingrese un año valido de 4 digitos inferior al año actual", "Entiendo");
                        YearBornEntry.Focus();
                    }
                }
                else
                {
                    await DisplayAlert("Espera!", "Ingrese un año valido de 4 digitos", "Entiendo");
                    YearBornEntry.Focus();
                }
            }

        }
    }
}