using System;
using NLog;

namespace Logger
{
    public class NLogger :ILogger
    {
        private readonly NLog.Logger _logger;
        public NLogger(string className)
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
