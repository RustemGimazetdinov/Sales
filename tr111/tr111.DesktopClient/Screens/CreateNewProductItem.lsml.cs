using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Threading;

namespace LightSwitchApplication
{
    public partial class CreateNewProductItem
    {
        partial void CreateNewProductItem_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Добавьте сюда свой код.
            this.ProductItemProperty = new ProductItem();
        }

        partial void CreateNewProductItem_Saved()
        {
            // Добавьте сюда свой код.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.ProductItemProperty);
        }

        partial void CreateNewProductItem_Created()
        {
            Dispatchers.Main.BeginInvoke(() =>
            {
                INotifyPropertyChanged p = this.ProductItemProperty;
                p.PropertyChanged += (sender, args) =>
                {
                    if (args.PropertyName == "InStock")
                    {
                        this.ShowMessageBox("instock changed");
                    }

                };
            });

            
            // Добавьте сюда свой код.

        }
    }
}