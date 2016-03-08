using Craswell.Squid.AclHelper;
using log4net;
using log4net.Config;

namespace SquidAclHelper
{
    /// <summary>
    /// The main class for the CLI program.
    /// </summary>
    internal class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            ILog logger = LogManager.GetLogger("SquidAclHelper");
            var helper = new Craswell.Squid.AclHelper.SquidAclHelper(logger);

            helper.Start();
        }
    }
}
