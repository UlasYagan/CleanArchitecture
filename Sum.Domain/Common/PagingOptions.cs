using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum.Domain.Common;

public class PagingOptions
{
    public PagingOptions(int? pageSize, int? pageNumber)
    {
        PageSize = pageSize ?? 10;
        PageNumber = pageNumber ?? 1;
    }

    public int? PageSize { get; set; }
    public int? PageNumber { get; set; }
}
