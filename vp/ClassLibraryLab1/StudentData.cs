
using System.Xml.Serialization;

namespace ClassLibraryLab1
{
    public class StudentsData
    {
        public List<Student> Students { get; private set; } = new List<Student>();
        public const string DefaultFilename = @"C:\RTU\vp\Lab1\students1.xml";

        public void Add(Student newStud)
        {
            if (newStud != null)
                Students.Add(newStud);
        }

        public void Save(string filename = "")
        {
            if (string.IsNullOrEmpty(filename))
                filename = DefaultFilename;

            using (var data = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                var serializer = new XmlSerializer(typeof(List<Student>));
                serializer.Serialize(data, Students);
            }
        }

        public void Load(string filename = "")
        {
            if (string.IsNullOrEmpty(filename))
                filename = DefaultFilename;

            using (var data = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                var serializer = new XmlSerializer(typeof(List<Student>));
                Students = (List<Student>)serializer.Deserialize(data);
            }

        }
    }
}
