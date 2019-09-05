using System;
using System.Xml.Serialization;

namespace TeamsFileGenerator
{
    public class Team
    {
        [XmlElement("idteam")]
        public int idteam;

        [XmlElement("teamname")]
        public string teamname;

        [XmlElement("teamresource")]
        public string teamresource;

    }
}
