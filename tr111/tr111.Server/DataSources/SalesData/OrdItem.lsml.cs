using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class OrdItem
    {
        partial void Sum_Compute(ref decimal result)
        {
            result = Qty*Price;
            // Присвоение результату значения нужного поля

        }
    }
}
