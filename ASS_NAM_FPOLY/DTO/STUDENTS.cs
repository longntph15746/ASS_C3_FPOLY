﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_NAM_FPOLY.DTO
{
    class STUDENTS
    {
        [Key]
        [MaxLength(50)]
        public string MASV { get; set; }

        [MaxLength(50)]
        public string Hoten { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string Sdt { get; set; }

        public bool Gioitinh { get; set; }

        [MaxLength(50)]
        public string Diachi { get; set; }

        [MaxLength(50)]
        public string Hinh { get; set; }

        [ForeignKey("ID")]
        public string ID { get; set; }

        public virtual GRADE Grade { get; set; }
    }
}
