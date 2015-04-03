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
            //filter = city => city.CityName.StartsWith("Ка");

        }

        partial void Order_Validate(OrderItem entity, EntitySetValidationResultsBuilder results)
        {
            //if (entity.Details.Properties.OrdDate.EntityState == EntityState.Deleted && entity.OrdItemSet.Any())
            //    results.AddEntityError("Возможно удаление только пустого заказа");
        }

        partial void Order_Deleting(OrderItem entity)
        {
            var vr = entity.Details.ValidationResults;
            if (vr.HasErrors)
            {
                throw new ValidationException(null, null, entity.Details.ValidationResults);
            }
        }

        partial void Query1_CanExecute(ref bool result)
        {

        }

        partial void Query1_PreprocessQuery(int? IdCust, bool? hasfilter, ref IQueryable<OrderItem> query)
        {
            if (hasfilter.Value)
                query =
                    from ord in query
                    where ord.OrdItemSet.Any()
                    orderby ord.OrdDate descending 
                    select ord;
                    
                    //query.Where(ord => ord.OrdItemSet.Any());
        }

        partial void Query_Executing(QueryExecutingDescriptor queryDescriptor)
        {

        }

        partial void Query_Executed(QueryExecutedDescriptor queryDescriptor)
        {

        }
    }
}
