using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Demo4.Data
{
    public class Application
    {
        [Key]
        public int Id { get; set; }
        public DateOnly? DateStart {  get; set; }
        public string? Status { get; set; }
        public string? NumEquipmet { get; set; }
        public string? Comment { get; set; }
        public int? TimeWork { get; set; }
        public IdentityUser? Employee { get; set; }
        public int? TypeProblemId { get; set; }
        public int? TypeEquipmentId { get; set; }
        public string? Clientname { get; set; }
    }
}
