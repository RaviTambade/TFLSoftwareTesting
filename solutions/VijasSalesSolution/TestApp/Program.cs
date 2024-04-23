using HR.Entities;

using System.Xml.Serialization;

string fileName = @"D:/Ravi/TAP/TAP/softwaretesting/solutions/VijasSalesSolution/TestProjectXUnitVijaySales/SampleData/people.xml";
List<Person> people = new List<Person>();
using (FileStream stream = new FileStream(fileName, FileMode.Open))
{
    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
    people = serializer.Deserialize(stream) as List<Person>;
}


foreach( Person p in people)
{
    Console.WriteLine(p.Name);
    Console.WriteLine(p.Age);
}
