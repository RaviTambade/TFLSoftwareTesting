using HR.Entities;
using System.Text.Json;
using System.Xml.Serialization;

namespace TestProjectXUnitVijaySales.Utility
{
    public class DataManager
    {
        public DataManager() { }

        //Deserialization logic

        public List<Person> GetJSONSampleData()
        {
            //Retrive data from sample given to testers
            //DeSerialization of data from people.json
            //Use File IO
            //Use JsonSerializer.Deserialize method
            //retrieve list of person data
            //return list of person data
            string fileName = @"D:/Ravi/TAP/TAP/softwaretesting/solutions/VijasSalesSolution/TestProjectXUnitVijaySales/TestingSampleData/people.json";
            string jsonString = File.ReadAllText(fileName);
            List<Person> jsonPeople = JsonSerializer.Deserialize<List<Person>>(jsonString);
            return jsonPeople;
        }
        public List<Person> GetXmlSampleData()
        {
            string fileName = @"D:/Ravi/TAP/TAP/softwaretesting/solutions/VijasSalesSolution/TestProjectXUnitVijaySales/TestingSampleData/people.xml";
            List<Person> people = new List<Person>();
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                people = serializer.Deserialize(stream) as List<Person>;
            }
            return people;
        }



        //Serialization
        public bool SetJSONSampleData() {
            bool status = false;
            List<Person> list = new List<Person>();
            list.Add(new Person { Age = 48, Name = "Ravi" });
            list.Add(new Person { Age = 22, Name = "Pragati" });
            list.Add(new Person { Age = 21, Name = "Ajinkya" });

            string fileName = @"D:/Ravi/TAP/TAP/softwaretesting/solutions/VijasSalesSolution/TestProjectXUnitVijaySales/TestingSampleData/people.json";

            var options = new JsonSerializerOptions { IncludeFields = true };
            var peopleJson = JsonSerializer.Serialize<List<Person>>(list, options);
            File.WriteAllText(fileName, peopleJson);
            status = true;
            return status;


        }
        public bool SetXMLSampleData()
        {
            bool status = false;
            List<Person> list = new List<Person>();
            list.Add(new Person { Age = 26, Name = "Seema" });
            list.Add(new Person { Age = 12, Name = "Manoj" });
            list.Add(new Person { Age = 23, Name = "Jai" });

            string fileName = @"D:/Ravi/TAP/TAP/softwaretesting/solutions/VijasSalesSolution/TestProjectXUnitVijaySales/TestingSampleData/people.xml";

            using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                serializer.Serialize(stream, list);
            }
            status=true;
            return status;
        }
    }
}