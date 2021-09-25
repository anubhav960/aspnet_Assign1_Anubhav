using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112Assign1.Controllers
{
    public class HostingCostController : ApiController
    {
        // Response- api/HostingCost/{id}

        public IEnumerable<string> Get(int id)
        {
            int fortnight = (id / 14)+1;
            double cost = Math.Round(5.50,2);
            double cost_fortnight = Math.Round(cost * fortnight,2);
            double tax = Math.Round(0.13*cost_fortnight,2);
            double total_amount = cost_fortnight + tax;

            return new string[] { fortnight + " fortnights at $" +
                                string.Format("{ 0:0.00 }", cost) + "/FN = $" + string.Format("{ 0:0.00 }",
                                cost_fortnight) + " CAD", "HST 13% =$" + string.Format("{ 0:0.00 }", tax) +
                                " CAD", "Total =$" + string.Format( "{ 0:0.00 }", total_amount ) + " CAD"
                                };
        }
    }
}
