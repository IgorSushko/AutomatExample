using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using test21.model;

namespace test21.rest
{
    public class RestQuery
    {
        String url;
        
        public RestQuery(String url) {

            this.url = url;
        
        }

        private RestClient restClient()
        {
              return new RestClient(url);
        }

        public String Get(String path)
        {

            return restClient().Execute<List<Employee>>(new RestRequest(path, Method.GET)).Content; 
        }

        public String Post(String path, CreateEmployee createEmployee)
        {
            
             return restClient()
                    .Execute<Employees>(new RestRequest(path, Method.POST)
                    .AddJsonBody(JsonConvert.SerializeObject(createEmployee)))
                    .Content;
            
        }
        
        public String Delete(String path,Int32 id)
        {
            String endPoint = path + "/" + id;
            Console.WriteLine(endPoint);
            return restClient()
                .Execute(new RestRequest(path, Method.DELETE))
                .Content;

        }

    }
}
