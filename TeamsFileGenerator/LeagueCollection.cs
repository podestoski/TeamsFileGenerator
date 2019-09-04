using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TeamsFileGenerator
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("LeagueCollection")]
    public class LeagueCollection
    {
        [XmlArray("leagues")]
        [XmlArrayItem("league", typeof(League))]
        public List<League> leagues { get; set; }
    }
}
