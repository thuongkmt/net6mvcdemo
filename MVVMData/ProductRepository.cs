using MVVMEntity;

namespace MVVMData
{
    public class ProductRepository : IProductRepository
    {
        private AdvWorksDbContext DbContext { get; set; }

        public ProductRepository(AdvWorksDbContext context)
        {
            DbContext = context;
        }

        public List<Product> Get()
        {
            return DbContext.Products.ToList();
        }
    }
}
