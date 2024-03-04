using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoAdat.Models
{
    public class Tipp
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Sz1 { get; set; }
        public int Sz2 { get; set; }
        public int Sz3 { get; set; }
        public int Sz4 { get; set; }
        public int Sz5 { get; set; }

        public Tipp()
        {

        }

        public Tipp(string sor)
        {
            string[] tomb = sor.Split(";");
            EmployeeId = int.Parse(tomb[0]);
            Sz1 = int.Parse(tomb[1]);
            Sz2 = int.Parse(tomb[2]);
            Sz3 = int.Parse(tomb[3]);
            Sz4 = int.Parse(tomb[4]);
            Sz5 = int.Parse(tomb[5]);
        }
    }
}
