using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_XavierSchool
{
    public static class StudentsRepository
    {
        public const string fileName = "students.json";

        public static List<Student> studentsList() //Read from the Json File
        {
            string studentsJson = File.ReadAllText(fileName);//JsonConvert.DeserializeObject
            var list = JsonConvert.DeserializeObject<List<Student>>(studentsJson);
            return list;
        }
        public static List<Student> searchStudent(string code)
        {
            List<Student> list = null;
            list = studentsList().FindAll(p => p.code.ToUpper().Contains(code.ToUpper()));
            return list;
        }
        public static Student studentsCode(string code)
        {
            Student students = null;
            students = studentsList().Find(p => p.code == code);
            return students;
        }
        public static void saveStudentList(List<Student> listStudent)//Write from the Jsaon File
        {
            string studentsJson = JsonConvert.SerializeObject(listStudent);
            File.WriteAllText(fileName, studentsJson);
        }
        public static void addStudent(Student students)
        {
            if (File.Exists(fileName))
            {
                var list = studentsList();
                list.Add(students);
                saveStudentList(list);
            }
            else
            {
                MessageBox.Show("Student Json file has been created!");
                List<Student> firstList = new List<Student>();
                firstList.Add(students);
                //var jsonX = JsonSerializer.Serialize(firstList, new JsonSerializerOptions() { WriteIndented = true });
                var jsonX = JsonConvert.SerializeObject(firstList);
                File.WriteAllText(fileName, jsonX);
            }
        }
        public static void studentsModify(string code, Student students)
        {
            var list = studentsList();
            int index = studentsList().FindIndex(p => p.code == code);
            if (index != -1)
            {
                list[index] = students;
                saveStudentList(list);
            }
            else MessageBox.Show("Student Code Not Found!!!");

        }
    }
}
