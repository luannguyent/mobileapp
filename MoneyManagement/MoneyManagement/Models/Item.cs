using System;

namespace MoneyManagement
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public double Amount { get; set; }

        public int TypeId { get; set; }
    }
}
