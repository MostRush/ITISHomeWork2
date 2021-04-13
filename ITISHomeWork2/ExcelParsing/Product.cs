using System;

namespace ExcelParsing
{
    public enum Priority
    {
        Low,
        Medium,
        High,
        Critical,
        NotSpecified
    }

    public enum ShipMode
    {
        RegularAir,
        ExpressAir,
        DeliveryTruck
    }

    public enum Segment
    {
        SmallBusiness,
        Consumer,
        Couporate,
        HomeOffice
    }

    public enum Category
    {
        OfficeSupplies,
        Technology,
        Furniture,
    }

    public enum Container
    {
        JumboDrum,
        JumboBox,
        SmallBox,
        MediumBox,
        LargeBox,
        SmallPack,
        WrapBag
    }

    class Product
    {
        public int RowID { get; set; }
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public Priority OrderPriority { get; set; }
        public int OrderQuantity { get; set; }
        public double Sales { get; set; }
        public double Discount { get; set; }
        public ShipMode ShipMode { get; set; }
        public double Profit { get; set; }
        public double UnitPrice { get; set; }
        public double ShippingCost { get; set; }
        public string CustomerName { get; set; }
        public string Province { get; set; }
        public string Region { get; set; }
        public Segment CustomerSegment { get; set; }
        public Category ProductCategory { get; set; }
        public string ProductSubCategory { get; set; }
        public string ProductName { get; set; }
        public Container ProductContainer { get; set; }
        public double ProductBaseMargin { get; set; }
        public DateTime ShipDate { get; set; }
    }
}
