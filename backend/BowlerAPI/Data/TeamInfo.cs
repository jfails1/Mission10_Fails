using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BowlerAPI.Data
{
    public class TeamInfo
    {
        [Key]
        public int TeamID { get; set; }
        public string? TeamName { get; set; }
        public int CaptainID { get; set; }
    }
}
