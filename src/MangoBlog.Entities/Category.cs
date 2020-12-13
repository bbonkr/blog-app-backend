using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoBlog.Entities
{
    public class Category
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// category name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Url friendly category name
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        public bool IsEnabled { get; set; } = true;

        public bool IsDeleted { get; set; } = false;

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }
    }
}
