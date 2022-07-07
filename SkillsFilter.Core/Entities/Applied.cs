using SkillsFilter.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsFilter.Core.Entities
{
    public class Applied : BaseEntity
    {
        public Applied(string jobName, DateTime dateApplied, string companyName, JobStatus status, string address)
        {
            JobName = jobName;
            DateApplied = dateApplied;
            CompanyName = companyName;
            Status = JobStatus.Sent;
            Address = address;
        }

        public string JobName { get; private set; }
        public DateTime DateApplied { get; private set; }
        public string CompanyName { get; private set; }
        public JobStatus Status { get; private set; }
        public string Address { get; private set; }


    }
}
