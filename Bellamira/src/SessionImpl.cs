using System;
using Ice;

namespace Bellamira.src
{
    public class SessionImpl : SessionDisp_
    {
        private UserManager user_mg = new UserManagerImpl();

        private GroupManager gmp = new GroupManagerImpl();

        public override UserManagerPrx getUserManager(Current current__)
        {
            UserManagerPrx up = UserManagerPrxHelper.uncheckedCast(current__.adapter.addWithUUID(user_mg));
            return up;
        }

        public override GroupManagerPrx getGroupManager(Current current__)
        {
            GroupManagerPrx gp = GroupManagerPrxHelper.uncheckedCast(current__.adapter.addWithUUID(gmp));
            return gp;
        }

        public override TimeTableManagerPrx getTimeTableManager(Current current__)
        {
            throw new NotImplementedException();
        }
    }
}
