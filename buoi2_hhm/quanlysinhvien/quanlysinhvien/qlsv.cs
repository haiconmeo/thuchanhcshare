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
                name = "manh",
                mssv = "1",
                ngaysinh = DateTime.Now,
                diachi = "nghe an1",
                dienthoai = "01675571178",
                nienkhoa = "16",
                loaihinh = 2,
                chuyennganh ="cntt",
                //bang1 ="ky su",
                //congtac =""

            };
            sinhviencaodang s2 = new sinhviencaodang
            {
                name = "manh1",
                mssv = "2",
                ngaysinh = DateTime.Now,
                diachi = "nghe an2",
                dienthoai = "01675571178",
                nienkhoa = "16",
                loaihinh = 1,
               

            };
            sinhvienbang2 s3 = new sinhvienbang2
            {
                name = "manh2",
                mssv = "3",
                ngaysinh = DateTime.Now,
                diachi = "nghe an3",
                dienthoai = "01675571178",
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
