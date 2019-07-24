using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Mvc
{
    public static class GlobalVariables
    {
        public static HttpClient WebApiClient = new HttpClient();

        static GlobalVariables()//Constructor
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:65350/api/"); //Get it prom Properties of WebApi Project
            WebApiClient.DefaultRequestHeaders.Clear();//clearing previous Default RequestHeaders
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//Creating Default RequestHeaders
        }
    }
}