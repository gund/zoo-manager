using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace zooManager
{
    abstract class XmlTable<T> where T: XmlDataObject, new()
    {
        protected abstract string DbFile { get; }
        protected List<T> Data = new List<T>();

        protected XmlTable()
        {
            LoadTable();
        }

        protected bool LoadTable()
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(List<T>));
                var reader = new StreamReader(DbFile);
                Data = (List<T>)xmlSerializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        protected bool SaveTable()
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(List<T>));
                var writer = new StreamWriter(DbFile);
                xmlSerializer.Serialize(writer, Data);
                writer.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void TruncateTable()
        {
            if (Data.Count == 0) return;
            Data.Clear();
        }

        public T LoadById(int id)
        {
            if (Data.Count == 0) return default(T);
            try
            {
                return Data[id];
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        public bool RemoveById(int id)
        {
            if (Data.Count == 0) return true;
            try
            {
                Data.RemoveAt(GetIdxById(id));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void Add(T item)
        {
            item.Id = Data.Count > 0 ? Data.Last().Id + 1 : 0; // Auto Increment
            Data.Add(item);
        }

        protected int GetIdxById(int id)
        {
            if (Data.Count == 0) return 0;
            try
            {
                return Data.Find(item => item.Id == id).Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Count()
        {
            return Data.Count;
        }

        ~XmlTable()
        {
            SaveTable();
        }

    }
}
