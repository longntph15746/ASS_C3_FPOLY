using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_NAM_FPOLY.DTO
{
    class GRADE
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string MASV { get; set; }

        public int TiengAnh { get; set; }

        public int Tinhoc { get; set; }

        public int GDTC { get; set; }

    }
}
