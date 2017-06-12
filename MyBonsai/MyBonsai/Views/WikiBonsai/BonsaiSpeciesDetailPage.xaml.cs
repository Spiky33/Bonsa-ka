using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using MyBonsai.Models;
using MyBonsai.Views.MyBonsai;
using Xamarin.Forms;

namespace MyBonsai.Views.WikiBonsai
{
    public partial class BonsaiSpeciesDetailPage : ContentPage
    {
        public BonsaiSpecies bonsaiDetail;
		
		public BonsaiSpeciesDetailPage()
		{
			InitializeComponent();
		}

        public BonsaiSpeciesDetailPage(BonsaiSpecies bonsai)
        {
            InitializeComponent();

            bonsaiDetail = bonsai;

            Title = bonsaiDetail.CommonName;
            BindingContext = bonsaiDetail;

			var tapImage = new TapGestureRecognizer()
			{
				Command = TransitionCommand
			};
			tapImage.Tapped += tapImage_Tapped;
			img.GestureRecognizers.Add(tapImage);
		}

		private ICommand TransitionCommand
		{
			get
			{
				return new Command(async () =>
				{
					img.AnchorX = 0.48;
					img.AnchorY = 0.48;
					await img.ScaleTo(0.8, 50, Easing.Linear);
					await Task.Delay(100);
					await img.ScaleTo(1, 50, Easing.Linear);
				});
			}
		}

		void tapImage_Tapped(object sender, EventArgs e)
		{
			Navigation.PushAsync(new AddBonsaiPage(bonsaiDetail));
		}
    }
}
