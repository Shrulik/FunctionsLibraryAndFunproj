using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDep
{
    public class DepTest
    {

        public static string Bla()
        {            
            var la = JsonConvert.SerializeObject("bla");

            return "bla";
        }
    }
}