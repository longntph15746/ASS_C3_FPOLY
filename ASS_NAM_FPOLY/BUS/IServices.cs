using ASS_NAM_FPOLY.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_NAM_FPOLY.BUS
{
    public interface IServices
    {
        List<STUDENTS> GetAllSTUDENTS();
        void AddStudent(STUDENTS students);
        void UpdateStudent(STUDENTS students);
        void DeleteStudent(string MASV);
    }
}
