using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloneTheme.Models
{
    public interface IEntityWithTypedId<TId>
    {
        TId Id { get; set; }
    }
}
