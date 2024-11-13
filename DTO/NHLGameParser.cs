using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Persistence.DTO
{
    public class NHLGameParser
    {
        public int Id { get; set; }
        public int WeekId { get; set; }
        public bool IsHomeGame { get; set; }
        public DateTime GameDate { get; set; }
        public bool IsWin { get; set; }
        public int OpposingTeamId { get; set; }
        public string OpposingTeamCode { get; set; }
    }
}