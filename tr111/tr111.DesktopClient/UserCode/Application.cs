using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Model.Storage;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class Application
    {
        partial void CreateNewCustomerItem_CanRun(ref bool result)
        {

            result = Current.User.HasPermission(Permissions.CanRunCustomerNewScr);
        }

        partial void SplashScr_CanRun(ref bool result)
        {
            

        }
    }
}
