using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipApi.Models.Database
{
    public class MembershipTypes
    {
        [Key]
        public int MembershipId { get; set; }
        
        public string MembershipDescription { get; set; }
    }
}
