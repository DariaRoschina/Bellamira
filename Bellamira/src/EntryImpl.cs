using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ice;
using SQLite;

namespace Bellamira.src
{

    class EntryImpl : Bellamira.EntryDisp_
    {

        public override SessionPrx login(string name, string password, Current current__)
        {
            Console.WriteLine("EntryImpl. login() called");
            SDB.getInstance().connect();
            User user = SDB.getInstance().getDb().Find<User>(name);
            SDB.getInstance().disconnect();
            SessionImpl session = new SessionImpl();
            SessionPrx session_prx = SessionPrxHelper.uncheckedCast(current__.adapter.addWithUUID(session));//создаю прокси для этой сессии
            try
            {
                if (user != null && user.password == password)
                {
                 }
                else
                {
                    // return null;
                    throw new UserAlreadyExists();
                }
            }
            catch (SQLiteException sqlex)
            {
                throw new UserAlreadyExists();
            }

            return session_prx;
        }

        public override SessionPrx Register(User user, Current current__)
        {
            Console.WriteLine("EntryImpl. Register() called");
            SessionImpl session = new SessionImpl();
            SessionPrx session_prx = SessionPrxHelper.uncheckedCast(current__.adapter.addWithUUID(session));//создаю прокси для этой сессии
            try
            {
                SDB.getInstance().getDb().Insert(user);
            }
            catch (SQLiteException sqlex)
            {
                throw new UserAlreadyExists();
            }
            return session_prx;

        }
        
        public override string Test(Current current__)
        {
            
            Console.WriteLine("EntryImpl. Test() called");

            //SQLiteConnection db;
            //SDB.getInstance().connect();
            //db = SDB.getInstance().getDb();

            //db.CreateTable<User>();
            ////db.DeleteAll<User>();
            //db.CreateTable<Group>();
            //db.CreateTable<UserType>();
            //Group gp = new Group();
            //gp.nameGroup = "младшая";
            //db.Insert(gp);
            //Group gp1 = new Group();
            //gp1.nameGroup = "средняя";
            //db.Insert(gp1);
            //Group gp2 = new Group();
            //gp2.nameGroup = "старшая";
            //db.Insert(gp2);

            //UserType ut = new UserType();
            //ut.NameType = "Учитель";
            //db.Insert(ut);

            //UserType ut1 = new UserType();
            //ut1.NameType = "Ученик";
            //db.Insert(ut1);

            //User u = new Bellamira.User(z);
            //u.password = "pet123";
            //u.Fam = "Петрова";
            //u.Name = "Ольга";
            //u.Otch = "Юрьевна";

            //db.Insert(u);
            //  var persons = db.Table<Group>();

            // var p = db.Table<User>();
            // string tmp = "";
            // foreach (var i in p)
            // {
            //     tmp += i.ToString();

            // }


            //SDB.getInstance().disconnect();

            //return tmp; 
          
            return "ok";
        }
    }
}
