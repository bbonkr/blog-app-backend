using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoBlog.Entities
{
    public class Media : EntityBase
    {
        /// <summary>
        /// Server path where file saved.
        /// </summary>
        public string Path { get; set; }
        
        /// <summary>
        /// File name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// File name without extension
        /// </summary>
        public string Basename { get; set; }

        /// <summary>
        /// File extension
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Media type
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Size (bytes)
        /// </summary>
        public long Size { get; set; }
    }
}
