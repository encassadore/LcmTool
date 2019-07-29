using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LcmTool.Models
{
    public class ELViewModel
    {
        public int lcmID { get; set; }
        public Nullable<int> resourceID { get; set; }
        public Nullable<int> statusID { get; set; }
    }
}