using System;
using Xamarin.Forms;
using Segunparcial_App.Class;

namespace Segunparcial_App.Views
{
    public class View2 : ContentPage
    {
        int Salary;
        int Year;
        string FirstN;
        string LastN;
        public static char chName;
        Button btnReturn;


        public View2(int Salar, int YearB, string FName, string LName)
        {
            Salary = Salar;
            Year = YearB;
            FirstN = FName;
            LastN = LName;
            chName = FirstN[0];

            clasValidate clsVal = new clasValidate(FirstN, LastN, Year);

            Label lblMensaje = new Label
            {
                Text = clsVal.Mensajefinal(chName.ToString(), Salary)
            };

            //btnReturn = new Button
            //  { Text = "Nueva Consulta" };
            //  btnReturn.Clicked += BtnReturn_Clicked;

            Label lbConsulta = new Label
            {
                Text = "Para una nueva consulta dar atras."
            };

            Content = new StackLayout
            {
                Padding = 15,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    lblMensaje,lbConsulta
                }
            };


        }

        //  private async void BtnReturn_Clicked(object sender, EventArgs e)
        //{
        //  await Navigation.PushAsync(new View1());
        //}
    }
}