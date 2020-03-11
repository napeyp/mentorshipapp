using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipApi.Models.Database
{
    public class Levels
    {
        [Key]
        public int LevelId { get; set; }
        public string Level { get; set; }
    }
}
