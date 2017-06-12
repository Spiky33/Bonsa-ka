using System;
using System.Collections.Generic;
using MyBonsai.Models;
using MyBonsai.Views.WikiBonsai;
using Xamarin.Forms;

namespace MyBonsai.Views
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
                Identifier = "mybonsai",
				Title = "Mes Bonsaïs",
				IconSource = "menuitem_mybonsai.png",
				TargetType = typeof(MyBonsaiPage)
			});
            masterPageItems.Add(new MasterPageItem
			{
                Identifier = "bonsaiwiki",
				Title = "Bonsai Wiki",
				IconSource = "menuitem_catalog.png",
                TargetType = typeof(WikiBonsaiPage)
			});

			listView.ItemsSource = masterPageItems;
        }
    }
}
