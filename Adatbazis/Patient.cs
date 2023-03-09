using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbazis
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; }
        public string PatientResults { get; set;} = string.Empty;


       


    }
}
