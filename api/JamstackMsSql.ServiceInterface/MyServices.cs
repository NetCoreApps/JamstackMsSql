using System;
using ServiceStack;
using JamstackMsSql.ServiceModel;

namespace JamstackMsSql.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
