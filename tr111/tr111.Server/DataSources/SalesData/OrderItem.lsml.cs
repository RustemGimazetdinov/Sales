using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class OrderItem
    {
        partial void Amount_Compute(ref decimal result)
        {
            result = this.OrdItemSet.Sum(t => t.Sum);
            // Присвоение результату значения нужного поля

        }
    }
}
