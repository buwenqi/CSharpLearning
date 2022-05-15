using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Globalization;

namespace CSharpTestProject_NetCore
{
    class BaseTest
    {
        public void Test() {

            // parse string to int
            if (Int32.TryParse("-105", out int j))
            {
                Console.WriteLine(j);
            }
            else
            {
                Console.WriteLine("String could not be parsed.");
            }

            // string format
            string expectedADFName = String.Format(CultureInfo.InvariantCulture, "/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.DataFactory/factories/{2}", "1234", "TestResourceGroup", "test");
            Console.WriteLine("{0}: checking wether exist: {1}", DateTime.UtcNow, expectedADFName);

            // Json read and parse
            string jsonFile = "TestFiles/test.json";
            var payloadFile = File.ReadAllText(jsonFile);

            JToken jtoken = JToken.Parse(payloadFile);
            var test1 = jtoken["executioncontext"];
            var type1=test1.GetType();
            var is1 = test1 is JObject;
            var is2 = test1 is JArray;
            var test = (jtoken["executioncontext"] as JObject)?.GetValue("purviewConfiguration") as JObject;
            Console.WriteLine(test);

            // dictionary
            IDictionary<string, string> testDic = new Dictionary<string, string>();
            testDic["test"] = "test";
            testDic["test2"] = "test2";
            testDic.TryGetValue("test", out string outvalue);
            Console.WriteLine("outvalue:{0}", outvalue);

            // test ?? operation
            string flag = "e";
            string result = "good" ?? (flag="test");

            Console.WriteLine(result+","+ flag);

            //test serialize
            Address address = new Address("China", "Shanghai");
            object company = new Company(address);
            Console.WriteLine(JsonConvert.SerializeObject(company));

            // test print null
            Console.WriteLine(String.Format("{0} name is: {1}", "test", null));
        }
    }
}
