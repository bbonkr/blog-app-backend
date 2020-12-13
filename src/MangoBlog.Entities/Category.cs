using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoBlog.Entities
{
    public class Category : EntityBase
    {
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

        public IList<PostCategories> Posts { get; set; }
    }
}
