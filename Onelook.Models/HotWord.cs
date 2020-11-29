using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onelook.Models
{
    public class HotWord
    {
        [Column(IsPrimary = true, IsIdentity = true)]
        public int? Id { get; set; }
        public string HotWordText { get; set; }
    }
}
