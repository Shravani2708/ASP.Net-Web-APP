using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HW2WebApplication.Models
{
    public class Vaccine
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int  DosesRequired { get; set; }
        public int DaysBetweenDoses { get; set; }
        public int TotalDosesReceived { get; set; }
        public int TotalDosesLeft { get; set; }

        public Vaccine() { }

        public Vaccine(int id, string vname, int dosesRequired, int daysBtwDoses,int totalDosesReceived, int totalDosesLeft)
        {
            Id = id;
            Name = vname;
            DosesRequired = dosesRequired;
            DaysBetweenDoses = daysBtwDoses;
            TotalDosesReceived = totalDosesReceived;
            TotalDosesLeft = totalDosesLeft;
        }
    }
}
