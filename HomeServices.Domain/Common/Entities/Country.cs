using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeServices.Domain.Common.Entities
{
    internal class Country : BaseAuditableEntity
    {
        public Country() 
        {
            Players = new List<Player>();
            Stadiums = new List<Stadium>();
        }

        public string Name { get; set; }
        public string TwoLetterIsoCode { get; set; }
        public string ThreeLetterIsoCode { get; set; }
        public string FlagUrl { get; set; }
        public int? DisplayOrder { get; set; }

        public List<Player> Players { get; set; }
        public List<Stadium> Stadiums { get; set;}
    }
}
