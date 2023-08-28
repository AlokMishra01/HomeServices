using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeServices.Domain.Common.Entities
{
    internal class Player : BaseAuditableEntity
    {
        public string Name { get; set; }
        public int? ShirtNo { get; set; }
        public int? ClubId { get; set;}
        public string PhotoUrl { get; set; }
        public DateTime? BirthDate{ get; set; }
    }
}
