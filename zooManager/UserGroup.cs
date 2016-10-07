
namespace zooManager
{
    public class UserGroup : XmlDataObject
    {
        public string Name { get; set; }
        public Access PrivilegesAccess { get; set; }
        public enum Access
        {
            Read,
            Write,
            Admin
        }
    }
}
