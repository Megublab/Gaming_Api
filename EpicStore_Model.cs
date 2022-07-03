namespace Curs_work_API.Models
{
    public class EpicStore_Model
    {
        public Freegames freeGames { get; set; }
    }
    public class Freegames
    {
        public List<Current> current { get; set; }
        public List<Upcoming> upcoming { get; set; }
    }

    public class Current
    {
        public string title { get; set; }
        public string id { get; set; }
        public string _namespace { get; set; }
        public string description { get; set; }
        public DateTime effectiveDate { get; set; }
        public string offerType { get; set; }
        public object expiryDate { get; set; }
        public string status { get; set; }
        public bool isCodeRedemptionOnly { get; set; }
        public Keyimage[] keyImages { get; set; }
        public Seller seller { get; set; }
        public string productSlug { get; set; }
        public string urlSlug { get; set; }
        public object url { get; set; }
        public Item[] items { get; set; }
        public Customattribute[] customAttributes { get; set; }
        public Category[] categories { get; set; }
        public Tag[] tags { get; set; }
        public Catalogns catalogNs { get; set; }
        public Offermapping[] offerMappings { get; set; }
        public Price price { get; set; }
        public Promotions promotions { get; set; }
    }

    public class Seller
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Catalogns
    {
        public Mapping[] mappings { get; set; }
    }

    public class Mapping
    {
        public string pageSlug { get; set; }
        public string pageType { get; set; }
    }

    public class Price
    {
        public Totalprice totalPrice { get; set; }
        public Lineoffer[] lineOffers { get; set; }
    }

    public class Totalprice
    {
        public int discountPrice { get; set; }
        public int originalPrice { get; set; }
        public int voucherDiscount { get; set; }
        public int discount { get; set; }
        public string currencyCode { get; set; }
        public Currencyinfo currencyInfo { get; set; }
        public Fmtprice fmtPrice { get; set; }
    }

    public class Currencyinfo
    {
        public int decimals { get; set; }
    }

    public class Fmtprice
    {
        public string originalPrice { get; set; }
        public string discountPrice { get; set; }
        public string intermediatePrice { get; set; }
    }

    public class Lineoffer
    {
        public Appliedrule[] appliedRules { get; set; }
    }

    public class Appliedrule
    {
        public string id { get; set; }
        public DateTime endDate { get; set; }
        public Discountsetting discountSetting { get; set; }
    }

    public class Discountsetting
    {
        public string discountType { get; set; }
    }

    public class Promotions
    {
        public Promotionaloffer[] promotionalOffers { get; set; }
        public object[] upcomingPromotionalOffers { get; set; }
    }

    public class Promotionaloffer
    {
        public Promotionaloffer1[] promotionalOffers { get; set; }
    }

    public class Promotionaloffer1
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Discountsetting1 discountSetting { get; set; }
    }

    public class Discountsetting1
    {
        public string discountType { get; set; }
        public int discountPercentage { get; set; }
    }

    public class Keyimage
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string _namespace { get; set; }
    }

    public class Customattribute
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Category
    {
        public string path { get; set; }
    }

    public class Tag
    {
        public string id { get; set; }
    }

    public class Offermapping
    {
        public string pageSlug { get; set; }
        public string pageType { get; set; }
    }

    public class Upcoming
    {
        public string title { get; set; }
        public string id { get; set; }
        public string _namespace { get; set; }
        public string description { get; set; }
        public DateTime effectiveDate { get; set; }
        public string offerType { get; set; }
        public object expiryDate { get; set; }
        public string status { get; set; }
        public bool isCodeRedemptionOnly { get; set; }
        public Keyimage1[] keyImages { get; set; }
        public Seller1 seller { get; set; }
        public string productSlug { get; set; }
        public string urlSlug { get; set; }
        public object url { get; set; }
        public Item1[] items { get; set; }
        public Customattribute1[] customAttributes { get; set; }
        public Category1[] categories { get; set; }
        public Tag1[] tags { get; set; }
        public Catalogns1 catalogNs { get; set; }
        public object[] offerMappings { get; set; }
        public Price1 price { get; set; }
        public Promotions1 promotions { get; set; }
    }

    public class Seller1
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Catalogns1
    {
        public Mapping1[] mappings { get; set; }
    }

    public class Mapping1
    {
        public string pageSlug { get; set; }
        public string pageType { get; set; }
    }

    public class Price1
    {
        public Totalprice1 totalPrice { get; set; }
        public Lineoffer1[] lineOffers { get; set; }
    }

    public class Totalprice1
    {
        public int discountPrice { get; set; }
        public int originalPrice { get; set; }
        public int voucherDiscount { get; set; }
        public int discount { get; set; }
        public string currencyCode { get; set; }
        public Currencyinfo1 currencyInfo { get; set; }
        public Fmtprice1 fmtPrice { get; set; }
    }

    public class Currencyinfo1
    {
        public int decimals { get; set; }
    }

    public class Fmtprice1
    {
        public string originalPrice { get; set; }
        public string discountPrice { get; set; }
        public string intermediatePrice { get; set; }
    }

    public class Lineoffer1
    {
        public object[] appliedRules { get; set; }
    }

    public class Promotions1
    {
        public object[] promotionalOffers { get; set; }
        public Upcomingpromotionaloffer[] upcomingPromotionalOffers { get; set; }
    }

    public class Upcomingpromotionaloffer
    {
        public Promotionaloffer2[] promotionalOffers { get; set; }
    }

    public class Promotionaloffer2
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Discountsetting2 discountSetting { get; set; }
    }

    public class Discountsetting2
    {
        public string discountType { get; set; }
        public int discountPercentage { get; set; }
    }

    public class Keyimage1
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Item1
    {
        public string id { get; set; }
        public string _namespace { get; set; }
    }

    public class Customattribute1
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Category1
    {
        public string path { get; set; }
    }

    public class Tag1
    {
        public string id { get; set; }
    }
}
