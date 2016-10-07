
namespace zooManager
{
    class AnimalTypeTable : XmlTable<AnimalType>
    {
        protected override string DbFile
        {
            get { return @"AnimalTypeDB.xml"; }
        }
    }
}
