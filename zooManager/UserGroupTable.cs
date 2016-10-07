
namespace zooManager
{
    class UserGroupTable : XmlTable<UserGroup>
    {
        protected override string DbFile
        {
            get { return @"UserGroupDB.xml"; }
        }
    }
}
