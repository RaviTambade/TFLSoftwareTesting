 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
namespace TestApp.Repositories
{
    public class CSVManager
    {
        public static void WriteToCSV(string filePath)
        {
            // Example data to write
            string[] lines = { "John,Doe,25", "Jane,Smith,30", "Bob,Johnson,40" };

            // Write data to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Data has been written to CSV.");
        }
        public static void ReadFromCSV(string filePath)
        {
            // Read data from the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line by comma to get individual values
                    string[] parts = line.Split(',');

                    // Example: Assuming format is "FirstName,LastName,Age"
                    string firstName = parts[0];
                    string lastName = parts[1];
                    int age = int.Parse(parts[2]);

                    // Do something with the data, e.g., print it
                    Console.WriteLine($"Name: {firstName} {lastName}, Age: {age}");
                }
            }

        }
    }
}