using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    interface ICustomerRating
    {
        int PositiveFeedback { get; set; }
        int Quality { get; set; }
        string customerRating();
        string checkFeedback();
    }
}
