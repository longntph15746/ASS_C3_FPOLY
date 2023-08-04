using ASS_NAM_FPOLY.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_NAM_FPOLY.BUS
{
    class Services : IServices
    {
        private List<STUDENTS> lst = new List<STUDENTS>();
        public Services(List<STUDENTS> lstStudent)
        {
            this.lst = lstStudent;
        }

        public Services()
        {
        }

        public List<STUDENTS> GetAllSTUDENTS()
        {
            List<STUDENTS> students = new List<STUDENTS>();
            return students;
        }
        public void AddStudent(STUDENTS students)
        {
            lst.Add(students);
        }

        public void DeleteStudent(string MASV)
        {
            var studentToRemove = lst.FirstOrDefault(p => p.MASV == MASV);
            if (studentToRemove != null)
            {
                lst.Remove(studentToRemove);
            }
        }

        public void UpdateStudent(STUDENTS students)
        {
            var existingStudent = lst.FirstOrDefault(p => p.MASV == students.MASV);
            if (existingStudent != null)
            {
                existingStudent.Hoten = students.Hoten;
                existingStudent.MASV = students.MASV;
                existingStudent.Email = students.Email;
                existingStudent.Sdt = students.Sdt;
                existingStudent.Gioitinh = students.Gioitinh;
                existingStudent.Diachi = students.Diachi;
                existingStudent.Hinh = students.Hinh;
            }
        }
    }
}
