using Sum.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum.Domain.Entities;

public class Brand : BaseEntity
{
    public string? Name { get; set; }
}
