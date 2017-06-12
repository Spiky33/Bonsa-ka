using System;
using System.Collections.Generic;
using MyBonsai.Models;
using Xamarin.Forms;

namespace MyBonsai.Views.WikiBonsai
{
    public partial class WikiBonsaiPage : TabbedPage
    {
        public WikiBonsaiPage()
        {
            InitializeComponent();
        }

        public WikiBonsaiPage(BonsaiWikiCatalog catalog)
        {
            InitializeComponent();
        }
    }
}
