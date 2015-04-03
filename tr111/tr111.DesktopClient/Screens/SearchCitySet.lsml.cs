using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Security;
using Microsoft.LightSwitch.Threading;

namespace LightSwitchApplication
{
    public partial class SearchCitySet
    {
        partial void AddNewCityAction_Execute()
        {
            var newCity = DataWorkspace.SalesData.CitySet.AddNew();
            newCity.CityName = "Москва";
            DataWorkspace.SalesData.SaveChanges();
        }

        partial void EditSelectedAction_Execute()
        {
            var edCity = CitySet.SelectedItem;
            edCity.CityName = edCity.CityName + "Ex";
        }

        partial void DelSelectedAction_Execute()
        {
            CitySet.SelectedItem.Delete();
        }

        partial void CitySet_SelectionChanged()
        {
            
        }

        partial void CancelAction_Execute()
        {
            this.ShowMessageBox(CitySet.SelectedItem.Details.Properties.CityName.OriginalValue);
            CitySet.SelectedItem.Details.DiscardChanges();
        }

        partial void AddCustAction_Execute()
        {
            CustomerSet.AddNew();
            this.OpenModalWindow("AddEdCustWnd");
        }

        partial void SaveEdCustAction_Execute()
        {
            DataWorkspace.SalesData.SaveChanges();
            this.CloseModalWindow("AddEdCustWnd");
        }

        partial void CancelEdCustAction_Execute()
        {
            CustomerSet.SelectedItem.Details.DiscardChanges();
            this.CloseModalWindow("AddEdCustWnd");
        }

        partial void EditSelectedCustAction_Execute()
        {
            this.OpenModalWindow("AddEdCustWnd");
        }

        partial void EditSelectedCustAction_CanExecute(ref bool result)
        {
            result = CustomerSet.SelectedItem != null;
        }

        partial void AddCustAction_CanExecute(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.CanAddClient) &&
                     this.CitySet.SelectedItem.CityName != "Москва";

        }

        partial void Method_Execute()
        {
            var users = DataWorkspace.SecurityData.UserRegistrations.Cast<UserRegistration>();
            foreach (var u in users)
            {
                this.ShowMessageBox(u.UserName);
            }
        }

        partial void Method1_Execute()
        {
            this.FindControl("LName").ControlAvailable += OnControlAvailable;


            // Добавьте сюда свой код.

        }

        private void OnControlAvailable(object sender, ControlAvailableEventArgs args)
        {
            var tb = (TextBox) args.Control;
            tb.Background = new SolidColorBrush(Colors.Magenta);
            tb.FontSize = 18;
            tb.MaxLength = 10;
            tb.TextChanged += (o, txtargs) =>
            {
                this.LNameLenProperty=tb.Text.Length.ToString();
            };
        }

        partial void Method2_Execute()
        {
            Dispatchers.Main.BeginInvoke(() =>
            {
                var ofd = new OpenFileDialog();
                ofd.ShowDialog();
            });
        }
    }
}
