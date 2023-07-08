namespace Exercise_15.Entities
{
    internal class Products
    {
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public Products(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double Total()
        {
            return this.price * this.quantity;
        }
    }
}
