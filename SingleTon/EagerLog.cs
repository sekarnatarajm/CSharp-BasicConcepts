using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    public interface ILog
    {
        void LogInfo(string message);
        void LogError(string message);

    }
    public sealed class Log : ILog
    {
        private static Log instance = null;
        private static readonly object logLock = new object();
        private Log() { }

        public static Log GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (logLock)
                    {
                        instance = new Log();
                    }
                }
                return instance;
            }
        }

        public void LogInfo(string message)
        {
            LogMessage(message);
            LogMessage(message);
        }

        public void LogError(string message)
        {
            LogMessage(message);
        }
        private static void LogMessage(string message)
        {
            try
            {
                string fileName = $"Log_{DateTime.Now.Year}";
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                //using StreamWriter streamWriter = new StreamWriter(filePath, true);
                StreamWriter streamWriter = new StreamWriter(filePath, true);
                streamWriter.WriteLine(message);
                streamWriter.Flush();
                streamWriter.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }

    //Eager loading
    public sealed class EagerLog : ILog
    {
        private static EagerLog instance = new EagerLog();
        private EagerLog() { }

        public static EagerLog GetInstance
        {
            get
            {
                return instance;
            }
        }

        public void LogInfo(string message)
        {
            LogMessage(message);
        }

        public void LogError(string message)
        {
            LogMessage(message);
        }
        private static void LogMessage(string message)
        {
            try
            {
                string fileName = $"Log_{DateTime.Now.Year}";
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                //using StreamWriter streamWriter = new StreamWriter(filePath, true);
                StreamWriter streamWriter = new StreamWriter(filePath, true);
                streamWriter.WriteLine(message);
                streamWriter.Flush();
                streamWriter.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }


    //Lazy loading
    public sealed class LazyLog : ILog
    {
        private static Lazy<LazyLog> instance = new Lazy<LazyLog>(new LazyLog());
        private LazyLog() { }

        public static LazyLog GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void LogInfo(string message)
        {
            LogMessage(message);
        }

        public void LogError(string message)
        {
            LogMessage(message);
        }
        private static void LogMessage(string message)
        {
            try
            {
                string fileName = $"Log_{DateTime.Now.Year}";
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                //using StreamWriter streamWriter = new StreamWriter(filePath, true);
                StreamWriter streamWriter = new StreamWriter(filePath, true);
                streamWriter.WriteLine(message);
                streamWriter.Flush();
                streamWriter.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
