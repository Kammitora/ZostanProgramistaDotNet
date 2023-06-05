using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5L27PracaDomowa
{
    public static class FileHelper
    {
        public static void Serialize(List<Employee> employees)
        {
            using (StreamWriter file = File.CreateText(Program.FilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, employees);
                file.Close();
            }
        }

        public static List<Employee> Deserialize()
        {
            using (StreamReader file = File.OpenText(Program.FilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                var employees = (List<Employee>)serializer.Deserialize(file, typeof(List<Employee>));
                file.Close();
                return employees;
            }
        }
    }
}
