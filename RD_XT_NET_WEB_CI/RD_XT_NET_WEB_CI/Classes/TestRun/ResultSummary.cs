using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RD_XT_NET_WEB_CI.Classes.TestResultsEntity
{
    class ResultSummary
    {
        [XmlAttribute(AttributeName = "outcome")]
        public string Outcome { get; set; }
        public Counters Counters { get; set; }
    }
}
