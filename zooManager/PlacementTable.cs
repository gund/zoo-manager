
namespace zooManager
{
    class PlacementTable : XmlTable<Placement>
    {
        protected override string DbFile
        {
            get { return @"PlacementDB.xml"; }
        }
    }
}
