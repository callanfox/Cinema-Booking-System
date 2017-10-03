using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Common.Business_Objects;

namespace GalaxyCinemas
{
    public class MidDaySpecialPlugin : ISpecialPlugin
    {
        public bool CalculateSpecial(Booking booking, ref string specialName, ref decimal specialPrice)
        {
            TimeSpan timeOfDay = booking.SessionDate.TimeOfDay;
            
            // If not mid-day, not applicable.
            // If movie doesn't start between 11am and 1pm
            if (timeOfDay < new TimeSpan(11, 0, 0) || timeOfDay > new TimeSpan(13, 0, 0))
            {
                return false;
            }

            // Calculate the discounted price that we would offer.
            decimal discountedPrice = (decimal) ((double) booking.OriginalPrice - ( (double) booking.OriginalPrice * 0.2 ));
            
            // If this discount is applicable, set specialName and specialPrice to our name and price.
            specialPrice = discountedPrice;
            specialName = "Mid-day special";
            return true;            
        }
    }
}
