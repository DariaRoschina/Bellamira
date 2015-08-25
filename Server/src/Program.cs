using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SQLiteConnection("Bellamira.db", true))
            {
                // db.DeleteAll<Bellamira.User>();
                // db.DeleteAll<Bellamira.Group>();
                //db.DeleteAll<Bellamira.TimeTableEntry>();
                //db.DeleteAll<Bellamira.UserType>();

                db.CreateTable<Bellamira.User>();
                db.CreateTable<Bellamira.Group>();
                //  db.CreateTable<Bellamira.TimeTableEntry>();
                // db.CreateTable<Bellamira.UserType>();
                //  Bellamira.User u = new Bellamira.User(y);
                //  Bellamira.UserType ut = new Bellamira.UserType();
                Bellamira.Group gp = new Bellamira.Group();
                //  Bellamira.TimeTableEntry tt = new Bellamira.TimeTableEntry();
                //   ut.nameType = "teacher";
                //   int y = ut.Id;
                //   db.Insert(ut);
                gp.nameGroup = "one";
                int z = gp.Id;
                db.Insert(gp);
                Bellamira.User u = new Bellamira.User(z);
                u.Fam = "1236123";
                u.Otch = "1236123";
                u.Name = "1236123";
                db.Insert(u);

                //  Console.WriteLine(u);
                //  Console.WriteLine(ut);
                //  Console.WriteLine(gp);
                var persons = db.Table<Bellamira.Group>();
                foreach (var i in persons)
                {
                    Console.WriteLine(i.ToString());

                }
                var p = db.Table<Bellamira.User>();
                foreach (var i in p)
                {
                    Console.WriteLine(i.ToString());

                }
                //var r = db.Table<Bellamira.UserType>();
                //foreach (var i in r)
                //{
                //    Console.WriteLine(i.ToString());

                //}
                Console.Read();

            }
        }
    }
}
