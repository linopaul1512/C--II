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
    public static class ProjectsRepository
    {
        public const string fileName = "projects.json";

        public static List<Project> projectsList() //Read from the Json File
        {
            string projectsJson = File.ReadAllText(fileName);//JsonConvert.DeserializeObject
            var list = JsonConvert.DeserializeObject<List<Project>>(projectsJson);
            return list;
        }
        public static List<Project> searchProject(string code)
        {
            List<Project> list = null;
            list = projectsList().FindAll(p => p.code.ToUpper().Contains(code.ToUpper()));
            return list;
        }
        public static Project projectsCode(string code)
        {
            Project projects = null;
            projects = projectsList().Find(p => p.code == code);
            return projects;
        }
        public static void saveProjectList(List<Project> listProject)//Write from the Jsaon File
        {
            string projectsJson = JsonConvert.SerializeObject(listProject);
            File.WriteAllText(fileName, projectsJson);
        }
        public static void addProject(Project projects)
        {
            if (File.Exists(fileName))
            {
                var list = projectsList();
                list.Add(projects);
                saveProjectList(list);
            }
            else
            {
                MessageBox.Show("Project Json file has been created!");
                List<Project> firstList = new List<Project>();
                firstList.Add(projects);
                //var jsonX = JsonSerializer.Serialize(firstList, new JsonSerializerOptions() { WriteIndented = true });
                var jsonX = JsonConvert.SerializeObject(firstList);
                File.WriteAllText(fileName, jsonX);
            }
        }
        public static void projectsModify(string code, Project projects)
        {
            var list = projectsList();
            int index = projectsList().FindIndex(p => p.code == code);
            if (index != -1)
            {
                list[index] = projects;
                saveProjectList(list);
            }
            else MessageBox.Show("Project Code Not Found!!!");

        }
    }
}
