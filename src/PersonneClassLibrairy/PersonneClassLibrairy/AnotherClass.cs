using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenantPlugIn;

namespace PersonneClassLibrairy;

public class AnotherClass
{
    public TenantPlugIn.Tenant Tenant { get; set; }

    public AnotherClass(Tenant t)
    {
        Tenant = t;
    }

}
