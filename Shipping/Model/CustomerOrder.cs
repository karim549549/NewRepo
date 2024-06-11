namespace Shipping.Model
{
    public class CustomerOrder
    {
        public int Id { get; set; }

        public List<Customer> Customers { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public List<order> Order { get; set; }

        public DateTime DateTime { get; set; }

    }
}
