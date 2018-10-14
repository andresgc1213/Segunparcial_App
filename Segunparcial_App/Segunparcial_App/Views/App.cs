using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Segunparcial_App.Views;
using System.Data;

namespace Segunparcial_App.Views
{
    public class App : Application
    {


        public App()
        {

            View1 InicioPage = new View1();

            MainPage = new NavigationPage(InicioPage);
        }
    }
}
