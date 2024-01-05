using System.ComponentModel.DataAnnotations.Schema;

namespace TechCareerBootcampProje.Models{
    public class ReservationModel:BaseModel
    {
        public DateTime ReservationEntry { get; set; }
        public DateTime ReservationFinished { get; set; }

        public int ClientId { get; set; }
        public ClientModel? Client { get; set; }
    }
}