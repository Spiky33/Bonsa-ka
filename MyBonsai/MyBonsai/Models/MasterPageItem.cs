using System;

namespace MyBonsai.Models
{
    public class MasterPageItem
    {
        public string Identifier { get; set; }

		public string Title { get; set; }

		public string IconSource { get; set; }

		public Type TargetType { get; set; }
    }
}