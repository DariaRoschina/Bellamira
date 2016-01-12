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
            
            //SQLiteConnection db;
            //SDB.getInstance().connect();
            //db = SDB.getInstance().getDb();
            //db.CreateTable<User>();
            //db.CreateTable<Group>();

            //Group gp = new Group();
            //gp.nameGroup = "one";
            //string z = gp.Id.ToString();
            //db.Insert(gp);

            //User u = new Bellamira.User(z);
            //u.Fam = "1236123";
            //u.Otch = "1236123";
            //u.Name = "1236123";
            //Console.WriteLine(u.Student_Group_Id);
            //db.Insert(u);


            //var persons = db.Table<Group>();
            //foreach (var i in persons)
            //{
            //    Console.WriteLine(i.ToString());

            //}
            //var p = db.Table<User>();
            //foreach (var i in p)
            //{
            //    Console.WriteLine(i.ToString());

            //}

            //Console.Read();
            //SDB.getInstance().disconnect();
        }
    }
}

