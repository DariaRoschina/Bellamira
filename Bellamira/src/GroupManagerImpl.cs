using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ice;

namespace Bellamira.src
{
    public class GroupManagerImpl : GroupManagerDisp_
    {
        public override bool addGroup(Group gp, Current current__)
        {
            Console.WriteLine("UserManagerImpl.addUser() called");
            try
            {
                SDB.getInstance().getDb().Insert(gp);
                SDB.getInstance().disconnect();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }

        public override bool addUserInGroup(User u, int idGr, Current current__)
        {
            Console.WriteLine("UserManagerImpl.addUser() called");
            try
            {
                int y =Convert.ToInt16(u.login);
                SDB.getInstance().getDb().Execute("Insert FROM Group WHERE Id ='" + idGr + "' AND teacherId='" + y+"'");
                SDB.getInstance().disconnect();

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }

        public override bool delGroup(int idGr, Current current__)
        {
            try
            {
                SDB.getInstance().getDb().Delete<Group>(idGr);
                SDB.getInstance().disconnect();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }

        public override bool delUserFromGroup(User u, int idGr, Current current__)
        {
            try
            {
                int y = Convert.ToInt16(u.login);
                SDB.getInstance().getDb().Execute("DELETE FROM Group WHERE Id ='" + idGr + "' AND teacherId='" + y+"'");
                SDB.getInstance().disconnect();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }

        public override Group[] getAllGroups(Current current__)
        {
            Group[] tmp= SDB.getInstance().getDb().Table<Group>().ToArray();
            SDB.getInstance().disconnect();
            return tmp;
        }

        public override Group getGroup(int idGr, Current current__)
        {
            var group = SDB.getInstance().getDb().Table<Group>().ElementAt<Group>(idGr);
            SDB.getInstance().disconnect();
            return group;
        }

        public override Group getGroupbyName(string nameGroup, Current current__)
        {
            var group = SDB.getInstance().getDb().Table<Group>();
            foreach (var i in group)
            {
                if (i.NameGroup == nameGroup)
                {
                    SDB.getInstance().disconnect();
                    return i;
                }
            }
            SDB.getInstance().disconnect();
            return null;
        }

        public override bool modifyGroup(Group gp, int idGr, Current current__)
        {
            try
            {
                SDB.getInstance().getDb().Update(gp);
                SDB.getInstance().disconnect();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }
    }
}