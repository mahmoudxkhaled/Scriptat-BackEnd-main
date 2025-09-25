using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scriptat.Data.ProjectPart
{
    public class VM_ProjectPartUpdate
    {
        public int ProjectId { get; set; }

        public int ProjectPartId { get; set; }

        public string ProjectPartTitle { get; set; }

        public string? ProjectPartSummary { get; set; }

        public string? ProjectPartSummaryFileUrl { get; set; }
    }
}
