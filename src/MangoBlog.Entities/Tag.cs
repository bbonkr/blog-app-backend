using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoBlog.Entities
{
    public class Tag : EntityBase
    {
        /// <summary>
        /// Tag name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Url friendly tag name
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        public IList<PostTags> Posts { get; set; }
    }
}
