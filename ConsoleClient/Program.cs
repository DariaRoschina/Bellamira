using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {

        public class App : Ice.Application


        {
            public static string My_str
            {
                get
                {
                    return str;
                }
                set
                {
                    str = value;
                }
            }
            public static string str = "fail";
            public override int run(string[] args)
            {
                if (args.Length > 0)
                {
                    //Console.Error.WriteLine(appName() + ": too many arguments");
                    return 1;
                }

                Bellamira.EntryPrx entry = Bellamira.EntryPrxHelper.checkedCast(communicator().propertyToProxy("Bellamira_entry.Proxy"));
                if (entry == null)
                {
                    //Console.Error.WriteLine(appName() + ": invalid proxy");
                    return 1;
                }

                str = entry.Test();



                return 0;
            }
        }
        static void Main(string[] args)
        {
            App ice_app = new App();
            //
            ice_app.main(new string[]{ }, "D:/Bellamira/Bellamira/WebClient/config.client");
            Console.Read();
        }
    }
}
