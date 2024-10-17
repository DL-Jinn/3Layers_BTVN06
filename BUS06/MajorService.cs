using DAL06.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BUS06
{
    public class MajorService
    {
        public List<Major> GetAllByFaculty(int facultyID) 
        {
            StudentModel context = new StudentModel();
            return context.Majors.Where(p=>p.FacultyID == facultyID).ToList();
        }
    }
}
