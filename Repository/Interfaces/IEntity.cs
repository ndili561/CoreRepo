using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IEntity
    {
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime ModifiedDate { get; set; }
        string ModifiedBy { get; set; }
    }
}
