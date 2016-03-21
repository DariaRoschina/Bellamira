using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bellamira;

namespace WebClient
{
    public class IceApplication
    {
        private static IceApplication instance;

        private static Ice.Communicator communicator;

        private Bellamira.EntryPrx entryPrx;

        private Bellamira.SessionPrx sessionPrx;

        private IceApplication() { }

        public EntryPrx EntryPrx
        {
            get
            {
                if (entryPrx == null)
                {
                    connect();
                }
                return entryPrx;
            }
        }

        public SessionPrx SessionPrx
        {
            get
            {
                if (sessionPrx == null)
                {
                    login("guest", "guest");
                }
                return sessionPrx;
            }
        }

        public SessionPrx login(string username, string passwd)
        {
            sessionPrx = entryPrx.login(username, passwd);
            return sessionPrx;
        }

        public SessionPrx reg(User user)
        {
            sessionPrx = entryPrx.Register(user);
            return sessionPrx;
        }

        public static IceApplication getInstance()
        {
            if (instance == null)
            {
                instance = new IceApplication();
                instance.connect();
            }
            return instance;
        }

        public int connect()
        {
            try
            {
                if (communicator == null || communicator.isShutdown())
                {
                    communicator = Ice.Util.initialize();
                }
                entryPrx = EntryPrxHelper.checkedCast(
                        communicator.stringToProxy("bellamira_entry:default -h localhost -p 10000"));
                entryPrx.Test();
                return 0;
            }
            catch (System.Exception ex)
            {
                System.Console.Error.WriteLine(ex);
                return 1;
            }
        }
        public int disconnect()
        {
            try
            {
                if (communicator != null || !communicator.isShutdown())
                {
                    communicator = null;
                }
                entryPrx = null;
                entryPrx.Test();
                return 0;
            }
            catch (System.Exception ex)
            {
                System.Console.Error.WriteLine(ex);
                return 1;
            }
        }

    }
}