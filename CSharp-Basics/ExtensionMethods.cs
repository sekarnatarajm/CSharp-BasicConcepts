using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace CSharp_Basics
{
    public class CommandHandler
    {
        public string Id { get; set; }
        public ProxyApi ProxyApi { get; set; }
    }
    public class ProxyApi
    {
        public string ApiName { get; set; }
        public string ApiType { get; set; }
        public BasicAuth BasicAuth { get; set; }
    }

    public class BasicAuth
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            var serialized = JsonConvert.SerializeObject(self);
            return JsonConvert.DeserializeObject<T>(serialized);
        }

        public static T SkipSecretDataOne<T>(this T self)
        {
            var name = typeof(T).Name;
            var converter = TypeDescriptor.GetConverter(typeof(T));
            
            if(name == "ProxyApi")
            {
                var dspp = self.DeepCopy<T>() as ProxyApi;
                dspp.BasicAuth.Password = "";
                var dd = (T)Convert.ChangeType(dspp, typeof(T));
                return dd;
            }
            else if (name == "CommandHandler")
            {
                var dspp = self.DeepCopy<T>() as CommandHandler;
                dspp.ProxyApi.BasicAuth.Password = "";
                var dd = (T)Convert.ChangeType(dspp, typeof(T));
                return dd;
            }
            return (T)Convert.ChangeType(self, typeof(T));
        }
    }

    public class SkipSecretData
    {
        //public void SkipData()
        //{
        //    ProxyApi proxyApi = new ProxyApi();
        //    proxyApi.ApiName = "TestApi";
        //    proxyApi.ApiType = "Order Status";
        //    proxyApi.BasicAuth = new BasicAuth()
        //    {
        //        Username = "test123",
        //        Password = "test@123"
        //    };

        //    var logData = proxyApi.SkipSecretDataOne<ProxyApi>();

        //    //var logData = proxyApi.DeepCopy<ProxyApi>();
        //    //logData.SkipSecretDataOne<ProxyApi>();

        //    PushProxy(proxyApi);


        //    Console.WriteLine();
        //    Console.WriteLine("Log Object Data : {0}", JsonConvert.SerializeObject(LogData(logData)));
        //}

        //public void PushProxy(ProxyApi proxyApi)
        //{
        //    Console.WriteLine("Proxy Object Data : {0}", JsonConvert.SerializeObject(proxyApi));
        //}



        //public ProxyApi LogData(ProxyApi proxyApi)
        //{
        //    var logData = proxyApi.DeepCopy<ProxyApi>();
        //    logData.BasicAuth.Password = "";
        //    return logData;
        //}

        public void SkipData()
        {
            try
            {
                var proxyData = GetProxyData();
                var proxyLogData = proxyData.SkipSecretDataOne<ProxyApi>();
                Console.WriteLine("Proxy Original Object  : {0}", JsonConvert.SerializeObject(proxyData));
                Console.WriteLine("Proxy Duplicate Object  : {0}", JsonConvert.SerializeObject(proxyLogData));

                var commandProxyData = GetCommandProxyData();
                var commandProxyDataLogData = commandProxyData.SkipSecretDataOne<CommandHandler>();
                Console.WriteLine("ProxyCommand Original Object  : {0}", JsonConvert.SerializeObject(commandProxyData));
                Console.WriteLine("ProxyCommand Duplicate Object  : {0}", JsonConvert.SerializeObject(commandProxyDataLogData));
            }
            catch (Exception ex)
            {
            }            
        }



        public ProxyApi GetProxyData()
        {
            ProxyApi proxyApi = new ProxyApi();
            proxyApi.ApiName = "TestApi";
            proxyApi.ApiType = "Order Status";
            proxyApi.BasicAuth = new BasicAuth()
            {
                Username = "test123",
                Password = "test@123"
            };
            return proxyApi;
        }

        public CommandHandler GetCommandProxyData()
        {
            ProxyApi proxyApi = new ProxyApi();
            proxyApi.ApiName = "TestApi";
            proxyApi.ApiType = "Order Status";
            proxyApi.BasicAuth = new BasicAuth()
            {
                Username = "test123",
                Password = "test@123"
            };
            CommandHandler commandHandler = new CommandHandler()
            {
                Id = "One",
                ProxyApi = proxyApi
            };
            
            return commandHandler;
        }
    }
}
