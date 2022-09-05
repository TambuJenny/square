using DomainService.Models;
using Models.Enum;

namespace DomaineService.Models.Product
{
    public class PCModel
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string Images { get; set; }
        public BrandModel Brand { get; set; }
        public StatusProduct Status { get; set; }
        public int Ram { get; set; }
        public int HardDisk { get; set; }
        public float ProcessorSpeed { get; set; }
        public string Failure { get; set; }
        public string Description { get; set; }
        public double FirtPrice { get; set; }
        public double LastPrice { get; set; }
        public UserModel UserId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
