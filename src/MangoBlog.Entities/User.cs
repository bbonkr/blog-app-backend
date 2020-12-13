using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoBlog.Entities
{
    public class User : EntityBase
    {
        public string DisplayName { get; set; }

        public string Email { get; set; }

        public bool IsEmailVertified { get; set; }

        public bool IsEnabled { get; set; }
    }
}
