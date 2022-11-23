namespace Bloaters
{
    public class DiscountManager
    {
        public Customer Customer { get; set; }
        public decimal ApplyDiscount(decimal orderedProductPrice)
        {


            decimal priceAfterDiscount = 0;
            decimal discountForLoyaltyPercentage = getDiscountRateForLoyalty();

            priceAfterDiscount = Customer.CustomerStatus.GetDiscountedPrice(orderedProductPrice);
            priceAfterDiscount = priceAfterDiscount - (discountForLoyaltyPercentage * priceAfterDiscount);

            return priceAfterDiscount;

        }

        private decimal getDiscountRateForLoyalty()
        {
            return Customer.TimeOfHavingAccountInYears > DiscountConstants.max_discount_for_loyalty ?
                                                     (decimal)DiscountConstants.max_discount_for_loyalty / 100 :
                                                     (decimal)Customer.TimeOfHavingAccountInYears / 100;
        }

        //private decimal calculatedDiscountPrice(decimal price, decimal loyaltyDiscount, decimal discountRate)
        //{
        //    decimal priceAfterDiscount = price - (discountRate * price);
        //    priceAfterDiscount = priceAfterDiscount - (loyaltyDiscount * priceAfterDiscount);
        //    return priceAfterDiscount;

        //}
    }

    public abstract class CustomerStatus
    {

        public abstract decimal GetDiscountedPrice(decimal orderedProductPrice);

        //NotRegistered = 1,
        //Standart = 2,
        //Medium = 3,
        //VIP = 4

    }

    public class NotRegisteredCustomer : CustomerStatus
    {
        public override decimal GetDiscountedPrice(decimal orderedProductPrice)
        {
            return orderedProductPrice;
        }
    }

    public class StandartCustomer : CustomerStatus
    {
        public override decimal GetDiscountedPrice(decimal orderedProductPrice)
        {
            return orderedProductPrice * (1 - DiscountConstants.standart_customers_discount);
        }
    }

    public class MediumCustomer : CustomerStatus
    {
        public override decimal GetDiscountedPrice(decimal orderedProductPrice)
        {
            return orderedProductPrice * (1 - DiscountConstants.medium_customers_discount);
        }
    }

    public class VIPCustomer : CustomerStatus
    {
        public override decimal GetDiscountedPrice(decimal orderedProductPrice)
        {
            return orderedProductPrice * (1 - DiscountConstants.most_valuable_customers_discount);
        }
    }

    public class AdvancedVIPCustomer : CustomerStatus
    {
        public override decimal GetDiscountedPrice(decimal orderedProductPrice)
        {
            return orderedProductPrice * (1 - 0.6m);
        }
    }



    public class DiscountConstants
    {
        public const int max_discount_for_loyalty = 5;
        public const decimal standart_customers_discount = 0.1m;
        public const decimal medium_customers_discount = 0.35m;
        public const decimal most_valuable_customers_discount = 0.5m;
    }

    public class Customer
    {
        public int TimeOfHavingAccountInYears { get; set; }
        public CustomerStatus CustomerStatus { get; set; }
    }
}
