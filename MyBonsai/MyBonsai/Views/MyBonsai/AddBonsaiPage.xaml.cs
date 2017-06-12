using System;
using System.Collections.Generic;
using MyBonsai.Models;
using Xamarin.Forms;

namespace MyBonsai.Views.MyBonsai
{
    public partial class AddBonsaiPage : ContentPage
    {
        public BonsaiSpecies BonsaiSpecie;

        public AddBonsaiPage()
        {
            InitializeComponent();
        }

		public AddBonsaiPage(BonsaiSpecies bonsai)
		{
			InitializeComponent();

            BindingContext = this;
		}
    }
}
