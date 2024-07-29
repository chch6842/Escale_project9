using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace escale.Models
{
  public class z_sqlScaleData : DapperSql<ScaleData>
  {
    public z_sqlScaleData()
    {
      OrderByColumn = SessionService.SortColumn;
      OrderByDirection = SessionService.SortDirection;
      DefaultOrderByColumn = "ScaleData.RecordDate";
      DefaultOrderByDirection = "ASC";
      if (string.IsNullOrEmpty(OrderByColumn)) OrderByColumn = DefaultOrderByColumn;
      if (string.IsNullOrEmpty(OrderByDirection)) OrderByDirection = DefaultOrderByDirection;
    }
  }
}
