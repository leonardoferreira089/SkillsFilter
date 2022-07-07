using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsFilter.Core.Entities
{
    public class Skill : BaseEntity
    {
        public Skill(string skillName)
        {
            SkillName = skillName;
            Qty = 1;
        }

        public string SkillName { get; private set; }
        public int Qty { get; private set; } 
    }
}
