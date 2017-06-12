using System;
using System.Collections.Generic;
using MyBonsai.Models;
using Xamarin.Forms;

namespace MyBonsai.Views
{
    public partial class MyBonsaiPage : ContentPage
    {
        private List<Bonsai> _myBonsai;

		#region MyBonsai
		private List<Bonsai> _MyBonsai;
		public List<Bonsai> MyBonsai
		{
			get
			{
				return _MyBonsai;
			}
			set
			{
				if (_MyBonsai != value)
				{
					_MyBonsai = value;
					OnPropertyChanged("MyBonsai");
				}
			}
		}
		#endregion

		public MyBonsaiPage()
        {
            InitializeComponent();
        }

		public MyBonsaiPage(List<Bonsai> myBonsai)
		{
			InitializeComponent();

            _myBonsai = myBonsai;
            BindingContext = this;
		}
    }
}
