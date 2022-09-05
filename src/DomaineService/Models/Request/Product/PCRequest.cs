using DomaineService.Models.Product;
using DomainService.Models;

namespace DomaineService.Models.Request.Product
{
    public class PCRequest
    {
        public string ProductName { get; set; }
        public string Images { get; set; }
        public BrandModel BrandId { get; set; }
        public int Ram { get; set; }
        public int HardDisk { get; set; }
        public float ProcessorSpeed { get; set; }
        public string Failure { get; set; }
        public string Description { get; set; }
        public double FirtPrice { get; set; }
        public double LastPrice { get; set; }
        public UserModel UserId { get; set; }
    }
}
