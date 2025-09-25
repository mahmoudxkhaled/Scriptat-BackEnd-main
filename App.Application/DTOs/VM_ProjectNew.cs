using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scriptat.Data.Project
{
    public class VM_ProjectNew
    {
        public int ProjectTypeId { get; set; }

        public string ProjectCode { get; set; }

        public string ProjectTitle { get; set; }

        public int ProjectPartCount { get; set; }

        public string ProjectDescription { get; set; }

        public int ScriptTypeId { get; set; }

        public string ProjectPartTitle { get; set; }

        public string? ProjectPartFileUrl { get; set; }

        public string UserId { get; set; }
    }
}
