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
    public partial class EditableOrderGrid
    {
        partial void Method_Execute()
        {
            var firstOrder = this.Order.First();

            var ord = this.FindControlInCollection("OrdDate", firstOrder).IsReadOnly = true;

            // Добавьте сюда свой код.
        }
    }
}
