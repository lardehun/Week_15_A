using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void Serialize(Person sp)
        {
            FileStream fs = new FileStream("Person.Dat", FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, sp);

            fs.Close();
        }

        private static Person Deserialize()
        {
            Person dsp = new Person();

            FileStream fs = new FileStream("Person.Dat", FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();

            dsp = (Person)bf.Deserialize(fs);

            fs.Close();

            return dsp;
        }
    }
}
