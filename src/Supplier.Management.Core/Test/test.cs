using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Supplier.Management.Common;

namespace Supplier.Management.Test
{
   public class test: FullAudited
    {
        public string note { get; set; }
    }
}
