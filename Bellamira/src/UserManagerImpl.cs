using System;
using System.Linq;
using Ice;

namespace Bellamira.src
{
    public class UserManagerImpl : UserManagerDisp_
    {
        public override bool addUser(User u, Current current__)
        {
            Console.WriteLine("UserManagerImpl.addUser() called");
            try
            {
                SDB.getInstance().getDb().Insert(u);
                SDB.getInstance().disconnect();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public override bool addUserType(UserType ut, Current current__)
        {
            try
            {
                SDB.getInstance().getDb().Insert(ut);
                SDB.getInstance().disconnect();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public override bool delUser(string login, Current current__)
        {
            try
            {
                SDB.getInstance().getDb().Delete<User>(login);
                SDB.getInstance().disconnect();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public override bool delUserType(string login, Current current__)
        {
            try
            {
                SDB.getInstance().getDb().Delete<UserType>(login);
                SDB.getInstance().disconnect();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public override User[] getAllUsers(Current current__)
        {
            User[] tmp = SDB.getInstance().getDb().Table<User>().ToArray();
            SDB.getInstance().disconnect();
            return tmp;
        }

        public override UserType[] getAllUserTypes(Current current__)
        {
            UserType[] tmp = SDB.getInstance().getDb().Table<UserType>().ToArray();
            SDB.getInstance().disconnect();
            return tmp;
        }

        public override User getUser(string login, Current current__)
        {
            var user = SDB.getInstance().getDb().ExecuteScalar<User>("SELECT * FROM User WHERE Login='" + login + "'");
            SDB.getInstance().disconnect();
            return user;
        }

        public override UserType getUserType(string nameType, Current current__)
        {
            var userT = SDB.getInstance().getDb().Table<UserType>();
            foreach (var i in userT)
            {
                if (i.NameType == nameType)
                {
                    SDB.getInstance().disconnect();
                    return i;
                }
            }
            SDB.getInstance().disconnect();
            return null;
        }
        
        public override bool modifyUser(User u, string login, Current current__)
        {
            try
            {
                SDB.getInstance().getDb().Update(u);
                SDB.getInstance().disconnect();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }

        public override bool modifyUserType(UserType ut, string login, Current current__)
        {
            try
            {
                SDB.getInstance().getDb().Update(ut);
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
