using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsFilter.Core.Entities
{
    public class Enterprise : BaseEntity
    {
        public Enterprise(string enterpriseName, string address, string stackHardSkill, string stackSoftSkill)
        {
            EnterpriseName = enterpriseName;
            Address = address;
            StackHardSkill = stackHardSkill;
            StackSoftSkill = stackSoftSkill;
        }

        public string EnterpriseName { get; private set; }
        public string Address { get; private set; }
        public string StackHardSkill { get; private set; }
        public string StackSoftSkill { get; private set; }

    }
}
