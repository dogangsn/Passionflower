using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Passionflower.Controllers.HomeController;

namespace Passionflower.Models
{
    public class SegmentsList
    {
        

        public string txtDisplayText { get; set; }
        public string txtResultText { get; set; }
        public string txtBackgroundColor { get; set; }
        public string ddlGravity { get; set; }
        public string hdnGravityPerc { get; set; }
        public string IsCouponCode { get; set; }
        public string CouponCode { get; set; }


        public List<ikramlar> ikramlar { get; set; }


    }
}
