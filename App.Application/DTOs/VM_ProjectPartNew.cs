using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scriptat.Data.ProjectPart
{
    public class VM_ProjectPartNew
    {
        public int ProjectId { get; set; }

        public int ScriptTypeId { get; set; }

        public string ProjectPartTitle { get; set; }

        public string? ProjectPartFileUrl { get; set; }

        public string UserId { get; set; }
    }
}
