using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTestProject_NetCore
{
    class StartTest
    {
        static void Main() {

            BaseTest baseTest = new BaseTest();
            // baseTest.Test();

            AsyncTest asyncTest = new AsyncTest();
            asyncTest.TestAsyncAwait();
        }
    }
}
