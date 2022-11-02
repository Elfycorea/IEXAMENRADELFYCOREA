using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;
using IEXAMENRADELFYCOREA.Controllers;

namespace IEXAMENRADELFYCOREA
{
    public partial class App : Application
    {
        //CREAR ESTANCIA ESTATICA
        static Controllers.DBContac dBContac;

        public static Controllers.DBContac dbcontac
        {
            get
            {
                if (dBContac== null)
                {
                    string DBName = "contac.db3";
                    string PathDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBName);
                    dBContac = new Controllers.DBContac(PathDB);

                }
                return dBContac;

            }
        }
        public App()
        {
            InitializeComponent();

           MainPage = new NavigationPage(new Views.PagePrincipalxaml());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
