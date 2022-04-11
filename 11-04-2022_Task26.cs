using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Day25
{
    class _111_04_2022_Task26
    {
        public static void Main()
        {
            IList<Doctorss> DoctorData = new List<Doctorss>()
            {
                new Doctorss() { DoctorName = "Nithin", DoctorID = 007, DoctorAge = 40, Experience = 15, SpeID = 1 },
                new Doctorss() { DoctorName = "Rukesh", DoctorID = 111, DoctorAge = 50, Experience = 25, SpeID = 2 },
                new Doctorss() { DoctorName = "Haris", DoctorID = 123, DoctorAge = 39, Experience = 14, SpeID = 1 },
                new Doctorss() { DoctorName = "Abinesh", DoctorID = 777, DoctorAge = 54, Experience = 29, SpeID = 3 },
                new Doctorss() { DoctorName = "Ajay", DoctorID = 432, DoctorAge = 35, Experience = 10, SpeID = 2 },

            };
            IList<Specialityss> SpecialityData = new List<Specialityss>()
            {
                new Specialityss() { SpeID = 1, Specialization="Cardiologist"},
                new Specialityss() { SpeID = 2, Specialization = "Neurology" },
                new Specialityss() { SpeID = 3, Specialization = "Dermatologist" },

            };

            var joinData = from Doc in DoctorData
                           join Spe in SpecialityData
                           on Doc.SpeID equals Spe.SpeID
                           select new
                           {

                               DocID = Doc.DoctorID,
                               SpeID = Spe.SpeID,
                               DoctorName = Doc.DoctorName,
                               SpecializeName = Spe.Specialization,
                               DoctorAge = Doc.DoctorAge,
                               Experience = Doc.Experience


                           };
            foreach (var groupdata in joinData)
            {
                Console.WriteLine("Doctor Name :{0} And he is Specialize in {1}", groupdata.DoctorName, groupdata.SpecializeName);

            }
        }
    }
    public class Doctorss
    {
        public string DoctorName { get; set; }
        public int DoctorID { get; set; }
        public int DoctorAge { get; set; }
        public int Experience { get; set; }
        public int SpeID { get; set; }

    }

    public class Specialityss
    {
        public int SpeID { get; set; }
        public string Specialization { get; set; }
    }
}