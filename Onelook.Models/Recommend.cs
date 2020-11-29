using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onelook.Models
{
    public class Recommend
    {
        [Column(IsPrimary = true, IsIdentity = true)]
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Cover { get; set; }
        public bool HasDetail { get; set; }
    }
}
