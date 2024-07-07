using Sum.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum.Domain.Entities;

public class CategoryDetail : BaseEntity
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int CategoryId { get; set; }

    public required Category Category { get; set; }
}
