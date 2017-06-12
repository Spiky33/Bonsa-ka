using System;
using System.Collections.Generic;
using MyBonsai.WebService;

namespace MyBonsai.Models
{
	public static class ViewModelLocator
	{
		private static BonsaiWikiCatalog _catalog = new WebServiceConsumer().GetCatalog();
		public static BonsaiWikiCatalog Catalog
		{
			get
			{
				return _catalog;
			}
		}
	}

    public class BonsaiWikiCatalog
    {
        public List<BonsaiSpecies> BonsaiSpecies { get; set; }
		public List<BonsaiDisease> BonsaiDiseases { get; set; }
		public List<BonsaiTechnique> BonsaiTechniques { get; set; }
        public List<BonsaiShape> BonsaiShapes { get; set; }

        public List<Bonsai> MyBonsai { get; set; }
    }
}