using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static Program;

namespace CSVandJSON
{
    public class JsonFile
    {
        public static void JsonReader()
        {
            var person = new List<Person>
            {
                new Person{Id=101, Name= "Amol", Age=24},
                new Person{Id=102, Name= "Rishi", Age=22},
                new Person{Id=103, Name= "Tannie", Age=23},
            };

            string path = @"C:\Users\amol-gosavi\source\repos\amol-1811\CSVandJSON\CSVandJSON\Person.json";

            //File.Create(path);
            string jsonData = JsonConvert.SerializeObject(person, Formatting.Indented);
            File.WriteAllText(path, jsonData);

            string jsonRead = File.ReadAllText(path);
            var deserializedData = JsonConvert.DeserializeObject<List<Person>>(jsonRead);
            foreach(var per in deserializedData)
            {
                Console.WriteLine($"PerID={per.Id}, PerName={per.Name}, PerAge={per.Age}");
            }
        }
    }
}
