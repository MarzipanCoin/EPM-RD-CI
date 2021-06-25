using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RD_XT_NET_WEB_CI.Classes.TestResultsEntity
{
    class Counters
    {
        //   <Counters total = "1" executed="1" passed="1" failed="0" error="0" timeout="0" aborted="0" inconclusive="0" 
        //passedButRunAborted="0" notRunnable="0" notExecuted="0" disconnected="0" warning="0" completed="0" 
        //inProgress="0" pending="0" />
        [XmlAttribute(AttributeName = "total")]
        public int Total { get; set; }
        [XmlAttribute(AttributeName = "executed")]
        public int Executed { get; set; }
        [XmlAttribute(AttributeName = "passed")]
        public int Passed { get; set; }
        [XmlAttribute(AttributeName = "failed")]
        public int Failed { get; set; }
        [XmlAttribute(AttributeName = "error")]
        public int Error { get; set; }
        [XmlAttribute(AttributeName = "timeout")]
        public int Timeout { get; set; }
        [XmlAttribute(AttributeName = "aborted")]
        public int Aborted { get; set; }
        [XmlAttribute(AttributeName = "notexecuted")]
        public int NotExecuted { get; set; }
        [XmlAttribute(AttributeName = "warning")]
        public int Warning { get; set; }
        [XmlAttribute(AttributeName = "completed")]
        public int Completed { get; set; }
        [XmlAttribute(AttributeName = "inProgress")]
        public int InProgress { get; set; }
        [XmlAttribute(AttributeName = "pending")]
        public int Pending { get; set; }
    }
}
