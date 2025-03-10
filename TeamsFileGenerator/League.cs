﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TeamsFileGenerator
{
    [Serializable()]
    public class League
    {
        [XmlElement("idleague")]
        public int idleague { get; set; }

        [XmlElement("leaguename")]
        public string leaguename { get; set; }

        [XmlArray("teams")]
        [XmlArrayItem("team", typeof(Team))]
        public List<Team> teams { get; set; }

    }
}
