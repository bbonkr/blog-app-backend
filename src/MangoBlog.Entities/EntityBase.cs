using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoBlog.Entities
{
    public abstract class EntityBase
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public string Id { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }
    }
}
