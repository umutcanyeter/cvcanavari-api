using Cvcanavari.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cvcanavari.Entities.Concrete
{
    public class Cv : IEntity
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string AcademicHistory { get; set; }
        public string ProfessionalExperience { get; set; }
        public string Skills { get; set; }
        public string Awards { get; set; }
        public string Certifications { get; set; }
    }
}
