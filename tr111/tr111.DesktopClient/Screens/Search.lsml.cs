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
    public partial class Search
    {
        partial void Search_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            Property1 = DataWorkspace.SalesData.Order.Where(ord => ord.OrdDate > DateTime.Today).Execute().Count().ToString();

        }
    }
}
