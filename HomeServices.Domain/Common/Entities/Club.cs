﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeServices.Domain.Common.Entities
{
    internal class Club : BaseAuditableEntity
    {
        public Club() 
        {
            Players = new List<Player>();
        }

        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string WebSiteUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string YoutubeUrl { get; set; }
        public string InstagramUrl { get; set; }
        public int? StadiumId { get; set; }

        public Stadium Stadium { get; set; }
        public List<Player> Players { get; set; }
    }
}
