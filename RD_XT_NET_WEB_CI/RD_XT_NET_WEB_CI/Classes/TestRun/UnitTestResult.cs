using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RD_XT_NET_WEB_CI.Classes.TestResultsEntity
{
    public class UnitTestResult
    {
        [XmlAttribute(AttributeName = "executionId")]
        public Guid ExecutionId { get; set; }
        [XmlAttribute(AttributeName = "testId")]
        public Guid TestId { get; set; }
        [XmlAttribute(AttributeName = "testName")]
        public string TestName { get; set; }
        [XmlAttribute(AttributeName = "computerName")]
        public string ComputerName { get; set; }
        [XmlAttribute(AttributeName = "duration")]
        public string Duration { get; set; }
        [XmlAttribute(AttributeName = "outcome")]
        public string Outcome { get; set; }
    }
}
