using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ice;

namespace Bellamira.src
{
    public class SessionImpl : SessionDisp_
    {
        private UserManager user_mg = new UserManagerImpl();

        private GroupManager gmp = new GroupManagerImpl();

        private TimeTableManagerImpl te = new TimeTableManagerImpl();

        public override UserManagerPrx getUserManager(Current current__)
        {
            Console.WriteLine("SessionImpl.getUserManager() called");
            UserManagerPrx up =  UserManagerPrxHelper.uncheckedCast(current__.adapter.addWithUUID(user_mg));
            return up; 
        }

        public override GroupManagerPrx getGroupManager(Current current__)
        {

            Console.WriteLine("SessionImpl.getGroupManager() called");
            GroupManagerPrx gp = GroupManagerPrxHelper.uncheckedCast(current__.adapter.addWithUUID(gmp));
            return gp;
        }

        public override TimeTableManagerPrx getTimeTableManager(Current current__)
        {
            Console.WriteLine("SessionImpl.getTimeTableManager() called");
            TimeTableManagerPrx tm = TimeTableManagerPrxHelper.uncheckedCast(current__.adapter.addWithUUID(te));
            return tm;
        }
    }
}
