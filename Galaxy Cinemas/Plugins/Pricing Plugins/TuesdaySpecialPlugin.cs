using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Common.Business_Objects;

namespace GalaxyCinemas
{
    public class TuesdaySpecialPlugin : ISpecialPlugin
    {
        public bool CalculateSpecial(Booking booking, ref string specialName, ref decimal specialPrice)
        {
            // If not Tuesday, not applicable.
            if (booking.SessionDate.DayOfWeek != DayOfWeek.Tuesday)
            {
                return false;
            }


            // Get base unit price.
            decimal basePrice = (decimal) ((double) booking.OriginalPrice / booking.Quantity);
            
            // Calculate the discounted price that we would offer.
            decimal discountedPrice = 0;
            
            if (booking.Quantity <= 5)
            {
                discountedPrice = 11 * booking.Quantity;
            }
            else
            {
                discountedPrice = (11 * 5) + ((booking.Quantity - 5) * basePrice);
            }

            // If this discount is applicable, set specialName and specialPrice to our name and price.
            if (discountedPrice < booking.OriginalPrice)
            {
                specialPrice = discountedPrice;
                specialName = "Tuesday special";
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}

