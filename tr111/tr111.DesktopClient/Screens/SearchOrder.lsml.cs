using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class SearchOrder
    {
        partial void Order_Validate(ScreenValidationResultsBuilder results)
        {
             //results.AddScreenError("dfgdh");
            // results.AddPropertyError("<Сообщение об ошибке>");

        }

        partial void Method_Execute()
        {
            Property1 = Order.SelectedItem.OrdItemSetQuery.Where(t => t.Price > 100).Execute().Count().ToString();
        }
    }
}
