// See https://aka.ms/new-console-template for more information
using NLog;
public class AuthenticationService
{
    //instance of a logger class
    private static readonly Logger logger = LogManager.GetCurrentClassLogger();
    private Dictionary<string, string> _users = new Dictionary<string, string>()
    {
        {"isha", "pass123" },
        {"disha", "pass12345" }
    };
    public bool Login(string username, string password)
    {
        logger.Info($"Login attempt has made : {username}");
        if (!_users.ContainsKey(username))
        {
            logger.Warn($"Login failed! Incorrect password for user: {username}");
            Console.WriteLine("Invalid username and password");
            return false;

        }
        logger.Info($"Login successful for user: {username}");
        Console.WriteLine("Login successful!!");
        return true;
    }
}
class Program
{
    static void Main()
    {
        var config = new NLog.Config.LoggingConfiguration();
        var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "logfile.txt" };
        config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);//logfile where we want to store
        var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

        config.AddRule(LogLevel.Debug, LogLevel.Fatal, logconsole); // create a log rule what we want store or display on console
        config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

        LogManager.Configuration = config; //use to apply all the config you have  set
        
        AuthenticationService authenticationService = new AuthenticationService();
        authenticationService.Login("isha", "pass123");
        authenticationService.Login("nisha", "pass12345");



    }
}