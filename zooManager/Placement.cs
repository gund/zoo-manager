
namespace zooManager
{
    public class Placement : XmlDataObject
    {

        public string Name { get; set; }
        public int RoomCount { get; set; }
        public double Square { get; set; }
        public bool IsReservoir { get; set; }
        public int AnimalCount { get; set; }

    }
}
