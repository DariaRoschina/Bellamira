using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace Bellamira
{
    public class SDB
    {
        public SQLiteConnection db1;
        static private SDB instance;

        private SDB() { }
        static public SDB getInstance()
        {
            if (instance == null)
            {
                instance = new SDB();
                var db1 = new SQLiteConnection("Bellamira.db", true);
            }
            return instance;
        }


        //public void connect()
        //{
        //    var db1 = new SQLiteConnection("Bellamira.db", true);
        //}


        public void disconnect()
        {
            db1.Dispose();
        }

        public SQLiteConnection getDb()
        {
            return db1;
        }

    }
}
