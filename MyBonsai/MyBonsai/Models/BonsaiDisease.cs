using System;
using System.Collections.Generic;

namespace MyBonsai.Models
{
    public class BonsaiDisease
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<string> Pictures { get; set; }

        public BonsaiDisease()
        {
            
        }
    }
}
