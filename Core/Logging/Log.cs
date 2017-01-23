using System;
using log4net;

namespace Core.Logging
{
    public class Log
    {
        private static readonly ILog _logger = LogManager.GetLogger("LogFileAppender");

        public Log()
        {
        }

        public static void Info(object message, Exception ex)
        {
            _logger.Info(message, ex);
        }

        public static void Info(object message)
        {
            _logger.Info(message);
        }

        public static void Error(object message, Exception ex)
        {
            _logger.Error(message, ex);
        }

        public static void Error(object message)
        {
            _logger.Error(message);
        }

        public static void Fatal(object message, Exception ex)
        {
            _logger.Fatal(message, ex);
        }

        public static void Fatal(object message)
        {
            _logger.Fatal(message);
        }

        public static void Debug(object message, Exception ex)
        {
            _logger.Debug(message, ex);
        }

        public static void Debug(object message)
        {
            _logger.Debug(message);
        }
    }
}