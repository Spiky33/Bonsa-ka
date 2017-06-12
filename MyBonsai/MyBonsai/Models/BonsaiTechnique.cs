using System;
using System.Collections.Generic;

namespace MyBonsai.Models
{
    public class BonsaiTechnique
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<string> Pictures { get; set; }

        public BonsaiTechnique()
        {
            
        }
    }
}
