using RD_XT_NET_WEB_CI.Classes.TestResultsEntity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RD_XT_NET_WEB_CI.Classes
{
    public class TestResultWorker
    {
        private TestRun _result { get; set; }
        //This class using only for tests. Please don't remove it.
        public void Work()
        {
            ReadResults();

            foreach (var item in _result.Results)
            {
                Console.WriteLine($"{item.TestName}\n {item.Outcome} --- {item.Duration} \n***");
            }

        }

        private void ReadResults()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TestRun));

            var fileName = Directory.GetFiles(@"~/../../../../..\RD_XT_NET_WEB_CI_UNIT_TESTS\TestResults\").LastOrDefault();

            using (var stream = new StreamReader(fileName))
            {
                _result = (TestRun)xmlSerializer.Deserialize(stream);
            }
        }
    }
}
