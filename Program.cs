using System;
using System.Globalization;
using CSVandJSON;
using CsvHelper;

public class Program
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public static void Main(string[] args)
    {

        JsonFile.JsonReader();
    //    var person = new List<Person>
    //    {
    //        new Person{Id=101, Name= "Amol", Age=24},
    //        new Person{Id=102, Name= "Rishi", Age=22},
    //        new Person{Id=103, Name= "Tannie", Age=23},
    //    };

    //    string path = @"C:\Users\amol-gosavi\source\repos\amol-1811\CSVandJSON\CSVandJSON\Person.csv";

    //    //File.Create(path);
    //    //using (var writer = new  StreamWriter(path))
    //    //    using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
    //    //{
    //    //    csvWriter.WriteRecords(person);
    //    //}

    //    using (var reader = new StreamReader(path))
    //    using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
    //    {
    //        var records = csvReader.GetRecords<Person>();
    //        foreach (var record in records)
    //        {
    //            Console.WriteLine($"PersonID={record.Id}, PersonName={record.Name}, PersonAge={record.Age}");
    //        }
    //    }
    }
}