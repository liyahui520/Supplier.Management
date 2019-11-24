using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Abp.Domain.Entities.Auditing
{
   public interface IFullAudited:IAudited,IDeletionAudited,IMayHaveTenant
    {
    }
}
