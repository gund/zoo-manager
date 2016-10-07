
namespace zooManager
{
    public class User : XmlDataObject
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Group { get; set; }
        public string SecretPhrase { get; set; }
    }
}
