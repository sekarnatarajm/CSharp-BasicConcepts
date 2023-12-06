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
        public static T CopyObject<T>(this T self)
        {
            var serialized = JsonConvert.SerializeObject(self);
            return JsonConvert.DeserializeObject<T>(serialized);
        }

        public static T SkipSecretDataOne<T>(this T inputData)
        {
            var name = typeof(T).Name;

            var proxyApiName = typeof(ProxyApi).Name;
            var commandHandlerName = typeof(CommandHandler).Name;

            if (name == proxyApiName)
            {
                var dspp = inputData.CopyObject<T>() as ProxyApi;
                dspp.BasicAuth.Password = "";
                var dd = (T)Convert.ChangeType(dspp, typeof(T));
                return dd;
            }
            else if (name == commandHandlerName)
            {
                var dspp = inputData.CopyObject<T>() as CommandHandler;
                dspp.ProxyApi.BasicAuth.Password = "";
                var dd = (T)Convert.ChangeType(dspp, typeof(T));
                return dd;
            }
            return (T)Convert.ChangeType(inputData, typeof(T));
        }

        public static T SkipSecretDataOnePatternMatching<T>(this T inputData)
        {
            Predicate<object> isObjectMatching = o => o.GetType().Name == inputData.GetType().Name;

            switch (inputData)
            {
                case ProxyApi proxyApi when isObjectMatching(proxyApi):
                    var proxyApiData = inputData.CopyObject<T>() as ProxyApi;
                    proxyApiData.BasicAuth.Password = "";
                    var proxyApiDataResult = (T)Convert.ChangeType(proxyApiData, typeof(T));
                    return proxyApiDataResult;
                case CommandHandler proxyApi when isObjectMatching(proxyApi):
                    var cmdHandler = inputData.CopyObject<T>() as CommandHandler;
                    cmdHandler.ProxyApi.BasicAuth.Password = "";
                    var cmdHandlerResult = (T)Convert.ChangeType(cmdHandler, typeof(T));
                    return cmdHandlerResult;
                default:
                    return (T)Convert.ChangeType(inputData, typeof(T));
            }          
        }
    }

    public class SkipSecretData
    {
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
