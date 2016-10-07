
using System;
using System.Collections.Generic;

namespace zooManager
{
    static class MyRegistry
    {
        private static Dictionary<string, dynamic> _register = new Dictionary<string, dynamic>();

        public static void Set(string key, dynamic value)
        {
            if (Get(key) != null) Unset(key);
            _register.Add(key, value);
        }

        public static void Unset(string key)
        {
            try
            {
                _register.Remove(key);
            }
            catch (Exception)
            { }
        }

        public static dynamic Get(string key)
        {
            try
            {
                return _register[key];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static UserTable GetUserTable()
        {
            if (Get("UserTable") == null) Set("UserTable", new UserTable());
            return Get("UserTable");
        }

        public static PlacementTable GetPlacementTable()
        {
            if (Get("PlacementTable") == null) Set("PlacementTable", new PlacementTable());
            return Get("PlacementTable");
        }

        public static AnimalTypeTable GetAnimalTypeTable()
        {
            if (Get("AnimalTypeTable") == null) Set("AnimalTypeTable", new AnimalTypeTable());
            return Get("AnimalTypeTable");
        }
        public static UserGroupTable GetUserGroupTable()
        {
            if (Get("UserGroupTable") == null) Set("UserGroupTable", new UserGroupTable());
            return Get("UserGroupTable");
        }

        public static Form1 GetLoginForm()
        {
            return Get("LoginForm") ?? null;
        }

        public static UserHomeForm GetUserHomeForm()
        {
            return Get("UserHomeForm") ?? null;
        }

        public static User GetUser()
        {
            return Get("user") ?? null;
        }
    }
}
