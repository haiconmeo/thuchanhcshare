using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlysinhvien
{
    class qlsv
    {
       public List<sinhvien> l;
       public qlsv()
        {
            sinhviendaihoc s1 = new sinhviendaihoc {
                name = "Bu Bu HUy",
                mssv = "1",
                ngaysinh = DateTime.Now,
                diachi = "Đa nang",
                dienthoai = "01675571178",
                nienkhoa = "16",
                loaihinh = 2,
                chuyennganh ="cntt",

            };
            sinhviencaodang s2 = new sinhviencaodang
            {
                name = "Manh",
                mssv = "2",
                ngaysinh = DateTime.Now,
                diachi = "Nghe An",
                dienthoai = "01675571178",
                nienkhoa = "16",
                loaihinh = 1,
               

            };
            sinhvienbang2 s3 = new sinhvienbang2
            {
                name = "Tue Anh",
                mssv = "3",
                ngaysinh = DateTime.Now,
                diachi = "Quang nam",
                dienthoai = "016755",
                nienkhoa = "16",
                loaihinh = 1,
                //chuyennganh = "cntt",
                bang1 ="ky su",
                donvi ="bk"

            };
            l = new List<sinhvien>();
            l.Add(s1);
            l.Add(s2);
            l.Add(s3);

        }
        public List<sinhvien>  delsv(string m)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].mssv == m)
                {
                    l.RemoveAt(i);
                    break;
                }
            }
            return l;
        }
        public List<sinhvien> getlist()
        {
         
                return l;
          
        }
    }
}
