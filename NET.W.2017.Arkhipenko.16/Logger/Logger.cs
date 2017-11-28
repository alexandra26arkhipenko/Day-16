using System;
using NLog;

namespace Logger
{
    public class Logger :ILogger
    {
        private readonly NLog.Logger _logger;
        public Logger(string className)
        {
            if (string.IsNullOrWhiteSpace(className))
            {
                throw new ArgumentException($"{nameof(className)} IsNullOrWhiteSpace", nameof(className));
            }

            _logger = LogManager.GetLogger(className);
        }
        public void Info(string message) =>
            _logger.Info(message);
    }
}
