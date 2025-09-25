using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scriptat.Data.Project
{
    public class VM_ProjectUpdate
    {
        public int ProjectId { get; set; }

        public string ProjectTitle { get; set; }

        public string? ProjectCode { get; set; }

        public string? ProjectSummary { get; set; }

        public string? ProjectSummaryFileUrl { get; set; }

        public string? ProjectDescription { get; set; }

        public int ProjectPartCount { get; set; }

        public int ProjectTypeId { get; set; }
    }
}
