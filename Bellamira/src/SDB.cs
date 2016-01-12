using SQLite;
namespace Bellamira
{
    public class SDB
    {
        static private SQLiteConnection db1;
        static private SDB instance;

        private SDB() { }
        static public SDB getInstance()
        {
            if (instance == null)
            {
                instance = new SDB();
            }
            return instance;
        }

        public void connect()
        {
            db1 = new SQLiteConnection("Bellamira.db", true);
            User guest = new User("guest", "guest", "guest", "guest", "guest", null, null);
            db1.InsertOrReplace(guest);
        }
        
        public void disconnect()
        {
            db1.Dispose();
            db1 = null;
        }

        public SQLiteConnection getDb()
        {
            if (db1 == null) { connect(); }
            return db1;
        }
    }
}
