using System;
using System.Collections.Generic;
using System.Linq;
using MyBonsai.Models;
using Xamarin.Forms;

namespace MyBonsai.Views.WikiBonsai
{
    

    public partial class BonsaiSpeciesCatalogPage : ContentPage
    {
        #region Filter
		private string _Filter;
		public string Filter
		{
			get
			{
				return _Filter;
			}
			set
			{
				if (_Filter != value)
				{
					_Filter = value;
					OnPropertyChanged("Filter");
					this.FilterBonsaiSpecies();
				}
			}
		}
		#endregion

		#region BonsaiSpecies
		private List<BonsaiSpecies> _BonsaiSpecies;
		public List<BonsaiSpecies> BonsaiSpecies
		{
			get
			{
				return _BonsaiSpecies;
			}
			set
			{
				if (_BonsaiSpecies != value)
				{
					_BonsaiSpecies = value;
					OnPropertyChanged("BonsaiSpecies");
				}
			}
		}
		#endregion
		
		public BonsaiSpeciesCatalogPage()
		{
			InitializeComponent();

            _BonsaiSpecies = ViewModelLocator.Catalog.BonsaiSpecies;

            BindingContext = this;
		}

        public void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var bonsai = e.Item as BonsaiSpecies;
            Navigation.PushAsync(new BonsaiSpeciesDetailPage(bonsai));
        }

		private void FilterBonsaiSpecies()
		{
            if (ViewModelLocator.Catalog != null)
			{
				if (String.IsNullOrEmpty(_Filter))
				{
					BonsaiSpecies = ViewModelLocator.Catalog.BonsaiSpecies;
				}
				else
				{
                    BonsaiSpecies = ViewModelLocator.Catalog.BonsaiSpecies.Where(x => x.CommonName.ToLower().Contains(_Filter.ToLower())
                                                           || x.LatinName.ToLower().Contains(_Filter.ToLower())
                                                           || x.Type.ToLower().Contains(_Filter.ToLower())).ToList();
				}
			}
		}
    }
}
