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
    public partial class CityItemDetail
    {
        partial void CityItem_Loaded(bool succeeded)
        {
            // Добавьте сюда свой код.
            this.SetDisplayNameFromEntity(this.CityItem);
        }

        partial void CityItem_Changed()
        {
            // Добавьте сюда свой код.
            this.SetDisplayNameFromEntity(this.CityItem);
        }

        partial void CityItemDetail_Saved()
        {
            // Добавьте сюда свой код.
            this.SetDisplayNameFromEntity(this.CityItem);
        }
    }
}