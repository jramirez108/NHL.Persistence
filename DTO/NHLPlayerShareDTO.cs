﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Persistence.DTO
{
    public class NHLPlayerShareDTO
    {
        public int PlayerId { get; set; }
        public double Share { get; set; }
        public string Type { get; set; }
        public int GameId { get; set; }
    }
}