using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Extensions
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<SelectListItem> ToSelcetListItem<T>(this IEnumerable<T> items, int selectedValue)
        {
            return from item in items
                   select new SelectListItem
                   {
                       Text = item.GetProppertyValue("Name"),
                       Value = item.GetProppertyValue("Id"),
                       Selected = item.GetProppertyValue("Id").Equals(selectedValue.ToString())
                   };
        }
    }
}
