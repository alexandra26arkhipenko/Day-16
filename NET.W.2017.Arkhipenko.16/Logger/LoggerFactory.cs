namespace Logger
{
    public class LoggerFactory
    {
        public static ILogger GetLogger(string nameClass)
        {
            return new Logger(nameClass);
        }
    }
}