using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Bellamira

{

    class Program
    {

        static void Main(string[] args)
        {
            SQLiteConnection db;
            SDB.getInstance().connect();
            db = SDB.getInstance().getDb();
            db.CreateTable<User>();
            db.CreateTable<Group>();

            Group gp = new Group();
            gp.nameGroup = "one";
            string z = gp.Id.ToString();
            db.Insert(gp);

            User u = new Bellamira.User(z);
            u.Fam = "1236123";
            u.Otch = "1236123";
            u.Name = "1236123";
            Console.WriteLine(u.Student_Group_Id);
            db.Insert(u);
               

            var persons = db.Table<Group>();
            foreach (var i in persons)
            {
                Console.WriteLine(i.ToString());

            }
            var p = db.Table<User>();
            foreach (var i in p)
            {
                Console.WriteLine(i.ToString());

            }

            Console.Read();
            SDB.getInstance().disconnect();
        }
    }
}

