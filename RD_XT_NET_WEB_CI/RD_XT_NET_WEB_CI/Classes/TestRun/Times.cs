using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RD_XT_NET_WEB_CI.Classes.TestResultsEntity
{
    public class Times
    {
        [XmlAttribute(AttributeName = "creation")]
        public DateTime Creation { get; set; }
        [XmlAttribute(AttributeName = "queuing")]
        public DateTime Start { get; set; }
        [XmlAttribute(AttributeName = "finish")]
        public DateTime Finish { get; set; }
    }
}
