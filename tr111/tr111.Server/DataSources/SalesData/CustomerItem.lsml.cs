using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class CustomerItem
    {
        partial void FullName_Compute(ref string result)
        {
            result = string.Format("{0} {1}", LName, FName);
        }

        partial void OrdCnt_Compute(ref int result)
        {
            result = OrderSet.Count();
        }
    }
}
