using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongerSoftworks.Models
{
    public class TeamSectionModel : SectionModel
    {
        public List<TeamMember> TeamMembers { get; set; }
    }
    
    public class TeamMember
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<SocialLink> SocialLinks { get; set; }
    }
}
