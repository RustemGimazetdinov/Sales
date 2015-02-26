using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
using System.Linq.Expressions;

namespace LightSwitchApplication
{
    public partial class SalesDataService
    {
        partial void CitySet_CanDelete(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.CanDeleteCity);
        }

        partial void CustomerSet_CanInsert(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.CanAddClient);
        }

        partial void CitySet_Filter(ref Expression<Func<CityItem, bool>> filter)
        {
            filter = city => city.CityName.StartsWith("Ка");

        }
    }
}
