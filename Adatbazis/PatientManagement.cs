using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Adatbazis
{
    public class PatientManagement
    {
        public static string currentPatientName { get; set; }
        public void AddPatient(Patient patient )
        {
            using(var context = new PatientDbContext())
            {
                context.Patients.Add( patient );
                currentPatientName = patient.PatientName;

                context.SaveChanges();
            }
        }

        public void addResult(string result) 
        {
            using (var context = new PatientDbContext())
            {
                var findPatient =(from item in context.Patients 
                                  where item.PatientName.
                                  Equals(currentPatientName) 
                                  select item).FirstOrDefault();

                findPatient.PatientResults = result;


                context.SaveChanges();
            }
       
        }

        public Patient getPatient(string nev)
        {
            using (var context = new PatientDbContext())
            {
                return (from item in context.Patients
                        where item.PatientName.
                        Equals(nev)
                        select item).FirstOrDefault();
            }

        }

    }
}
