using Cvcanavari.Entities.Abstract;

namespace Cvcanavari.Entities.Concrete
{
    public class Cv : IEntity
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string ImageUrl { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string Github { get; set; }
        public string PersonelWebsite { get; set; }
        public string CvFileUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string AcademicHistory1 { get; set; }
        public string AcademicHistory2 { get; set; }
        public string AcademicHistory3 { get; set; }
        public string ProfessionalExperience1 { get; set; }
        public string ProfessionalExperience2 { get; set; }
        public string ProfessionalExperience3 { get; set; }
        public string Skills1 { get; set; }
        public string Skills2 { get; set; }
        public string Skills3 { get; set; }
        public string Awards1 { get; set; }
        public string Awards2 { get; set; }
        public string Awards3 { get; set; }
        public string Certifications { get; set; }
    }
}
