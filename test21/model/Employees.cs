using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace test21.model
{
    class Employees
    {
        public String status { get; set; }

        [JsonProperty("data")]
        public List<Employee> data { get; set; }

        public override string ToString()
        {
            return "status: " + status + ", " + "data: " + data + ".";
        }
    }
}
