using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace _10_12_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeAttributes ta = typeof(Console).Attributes;
            MethodAttributes ma = MethodInfo.GetCurrentMethod().Attributes;
            Console.WriteLine(ta + "\n" + ma);

            string Path = "data.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(Path);

            if (!File.Exists(Path))
            {
                Console.WriteLine("Нет доступа к файлу: {0}", Path);
                return;
            }
            Console.WriteLine("Началась обработка данных.");

            try
            {
                MemoryStream rawData = new MemoryStream(File.ReadAllBytes(Path));
                XmlSerializer xmls = new XmlSerializer(typeof(PsychiatricHospital));
                var xmlList = (PsychiatricHospital)xmls.Deserialize(rawData);
                Console.WriteLine("XML oбработан.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message, "Ошибка обработки XML данных");
            }

            Console.ReadKey();
        }
    }
}
