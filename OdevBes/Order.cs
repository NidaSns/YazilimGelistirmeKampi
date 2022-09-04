using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBes
{
    public class Order
    {
        public int OrderId { get; set; }

        public int GamerId { get; set; }

        public int CampaignId { get; set; }

        public int OrderPrice { get; set; }
    }
}
