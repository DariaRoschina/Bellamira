using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Bellamira.src
{

    class Server
    {
     
        class App : Ice.Application
        {
            public override int run(string[] args)
            {
                if (args.Length > 0)
                {
                    System.Console.Error.WriteLine(appName() + ": too many arguments");
                    return 1;
                }

                Ice.ObjectAdapter adapter = communicator().createObjectAdapter("Bellamira_entry");
                adapter.add(new EntryImpl(), communicator().stringToIdentity("bellamira_entry"));
                adapter.activate();
                communicator().waitForShutdown();
                return 0;
            }
        }


        static int Main(string[] args)
        {
            App app = new App();

            return app.main(args, "../../config.server");
        }
    }
}

