using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Models
{
    public class History
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int ToStatusId { get; set; }
        public virtual Status ToStatus { get; set; }
        public DateTime DateCreated { get; set; }
        public Dictionary<string, string> d = new Dictionary<string, string>()
        {

        };
    }
}
