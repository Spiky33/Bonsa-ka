using System;
using System.Threading.Tasks;
using MyBonsai.Models;
using MyBonsai.Views;
using MyBonsai.WebService;
using Xamarin.Forms;

namespace MyBonsai
{
	public class App : Application
	{
        public BonsaiWikiCatalog bonsaiCatalog { get; set; }

		public App()
		{
            MainPage = new MainPage();
			MainPage.BackgroundColor = Color.Transparent;
			MainPage.Title = "MyBonsai";
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}