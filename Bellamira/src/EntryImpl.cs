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
            Console.WriteLine("EntryImpl.login() called");

            User user = SDB.getInstance().getDb().Find<User>(name);
            if (user != null && user.password == password)
            {
                SessionImpl session = new SessionImpl();
                SessionPrx session_prx = SessionPrxHelper.uncheckedCast(current__.adapter.addWithUUID(session));//создаю прокси для этой сессии
                return session_prx;
            }
            else
            {
                return null;
            }
        }

        public override SessionPrx Register(User user, Current current__)
        {
            Console.WriteLine("EntryImpl.Register() called");

            SessionImpl session = new SessionImpl();

            SessionPrx session_prx = SessionPrxHelper.uncheckedCast(current__.adapter.addWithUUID(session));//создаю прокси для этой сессии

            SDB.getInstance().getDb().Insert(user);

            Console.WriteLine(user.ToString());

            return session_prx;

        }

        public override string Test(Current current__)
        {
            Console.WriteLine("EntryImpl.Register() called");

            return "ok";
        }
    }
}
