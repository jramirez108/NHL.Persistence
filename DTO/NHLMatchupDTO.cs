using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHL.Persistence.Models;

namespace NHL.Persistence.DTO
{
    public class NHLMatchupDTO
    {
        public int GameId { get; set; }
        public NHLTeam HomeTeam { get; set; }
        public NHLTeam VisitorTeam { get; set; }
        public DateTime GameDate { get; set; }
        public List<NHLPlayerStatDTO> HomeTeamTDAllowed { get; set; }
        public List<NHLPlayerStatDTO> VisitorTeamTDAllowed { get; set; }
    }
}
