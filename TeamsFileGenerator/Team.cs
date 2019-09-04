using System;
using System.Xml.Serialization;

namespace TeamsFileGenerator
{
    public class Team
    {
        [XmlElement("idTeam")]
        public int idTeam;

        [XmlElement("teamname")]
        public string teamname;

        [XmlElement("teamresource")]
        public string teamresource;

    }
}
