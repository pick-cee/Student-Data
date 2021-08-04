using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentData
{
    class StudentInfo
    {
        string path;
        public List<Data> _Data { get; set; } = new List<Data>();
        public void AddData(Data data)
        {
            _Data.Add(data);
            path = @"C://Student Data.csv";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("***********************************************************");
                    sw.WriteLine("Name, " + "Matric Number, " + "Level, " + "Course of study");
                    sw.WriteLine(data.Name + " , " + data.Matric + " , " + data.Level + " , " + data.Course);
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("***********************************************************");
                sw.WriteLine("Name, " + "Matric Number, " + "Level, " + "Course of study");
                sw.WriteLine(data.Name + " , " + data.Matric + " , " + data.Level + " , " + data.Course);
            }
               /*StreamWriter sw = new StreamWriter File.AppendAllLines("C://Student Data.csv");
                sw.WriteLine("Name, " + "Matric Number, " + "Level, " + "Course of study");
                sw.WriteLine(data.Name + " , " + data.Matric + " , " + data.Level + " , " + data.Course);
                sw.WriteLine("***********************************************");
                sw.Close();*/
        }

        public void DisplayByMatric (String matric)
        {
            var mat = _Data.FirstOrDefault(d => d.Matric == matric);
            if (mat == null)
            {
                Console.WriteLine("Data not Found, Try Again!!");
            }
            else
            {
                Console.WriteLine($"Name: {mat.Name} Matric: {mat.Matric} Level: {mat.Level} Course: {mat.Course}");
            }
        }

        public void DisplayAllData()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string line = "";
                while((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            /*foreach(var mat in _Data)
            {
                Console.WriteLine($"Name: {mat.Name} Matric: {mat.Matric} Level: {mat.Level} Course: {mat.Course}");
            }*/
        }
    }
}
