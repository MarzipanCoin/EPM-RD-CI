using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RD_XT_NET_WEB_CI.Classes.TestResultsEntity
{
    [XmlRoot("TestRun", Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class TestRun
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        public Times Times { get; set; }
        public UnitTestResult[] Results { get; set; }

    }
}
