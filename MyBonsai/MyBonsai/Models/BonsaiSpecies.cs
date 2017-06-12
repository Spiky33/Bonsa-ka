using System;
using System.Collections.Generic;

namespace MyBonsai.Models
{
	public class BonsaiSpecies
	{
		public string CommonName { get; set; }
		public string LatinName { get; set; }
		public string CoverImage { get; set; }
		public string Description { get; set; }
		public string Type { get; set; }
		public string Leef { get; set; }

		public string Exposition { get; set; }
		public string Pruning { get; set; }
		public string Watering { get; set; }
		public int[] FrequencyWatering { get; set; }
		public string Fertilizing { get; set; }
		public string Sickness { get; set; }
		public string Substrat { get; set; }
		public string Repoting { get; set; }
		public string Multiplicating { get; set; }
		public List<string> Pictures { get; set; }
	}
}
