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
                db.CreateTable<Bellamira.User>();
                Bellamira.User u = new Bellamira.User();
                u.Fam = "1236123";
                u.Otch = "1236123";
                u.Name = "1236123";
                db.Insert(u);
            }
        }
    }
}
