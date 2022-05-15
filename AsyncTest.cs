using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTestProject_NetCore
{
    class AsyncTest
    {
        public void TestAsyncAwait() {
            Task<int> task = GetUrlContentLengthAsync();
            Console.WriteLine("after sync method");
            int result=task.Result;
            Console.WriteLine("test result: {0}", result);
        }

        public void TestEventHanlder()
        {

        }

        private  async Task<int> GetUrlContentLengthAsync()
        {
            Console.WriteLine("Enter GetUrlContentLengthAsync……");
            var client = new HttpClient();

            Task<string> getStringTask = client.GetStringAsync("https://docs.microsoft.com/dotnet");

            DoIndependentWork();

            string contents = await getStringTask;
            Console.WriteLine("Return GetUrlContentLengthAsync……");

            return contents.Length;
        }

        void DoIndependentWork()
        {
            Console.WriteLine("Working...");
        }
    }


}
