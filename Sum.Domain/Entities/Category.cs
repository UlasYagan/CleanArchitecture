using Sum.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum.Domain.Entities;

public class Category : BaseEntity
{
    public int ParentId { get; set; }
    public string? Name { get; set; }
    public int Priorty { get; set; }
    public required ICollection<CategoryDetail> CategoryDetails { get; set; }
    public required ICollection<Product> Products { get; set; }

}
