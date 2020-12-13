using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoBlog.Entities
{
    public class Setting : EntityBase
    {
        /// <summary>
        /// Allow media file extension. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// Whitelist
        /// </para>
        /// <para>Comma separated. </para>
        /// <para>e.g.)<code>.png,.jpg,.gif</code></para>
        /// </remarks>
        public string AllowMediaExtensions { get; set; }
    }
}
