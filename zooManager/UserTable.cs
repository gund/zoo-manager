
using System;
using System.Collections.Generic;

namespace zooManager
{
    class UserTable : XmlTable<User>
    {
        protected override string DbFile
        {
            get { return @"UserDB.xml"; }
        }

        public User LoadByLogin(string login)
        {
            try
            {
                return Data.Find(item => item.Login == login);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
