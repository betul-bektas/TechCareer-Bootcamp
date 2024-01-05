namespace TechCareerBootcampProje.Models{
    public class ClientModel:BaseModel
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public int CompanyId { get; set; }
    }
}