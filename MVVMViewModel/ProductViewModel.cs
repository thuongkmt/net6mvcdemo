using MVVMData;
using MVVMEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMViewModel
{
    public class ProductViewModel
    {
        public IProductRepository Repository { get; set; }

        /// <summary>
        /// NOTE: You need a parameterless     
        /// constructor for post-backs in MVC    
        /// </summary>
        public ProductViewModel()
        { }

        public ProductViewModel(IProductRepository repository)
        {
            Repository = repository;
        }
        
        public List<Product> Products { get; set; }

        public void HandleRequest()
        {
            LoadProducts();
        }

        protected virtual void LoadProducts()
        {
            if (Repository == null)
            {
                throw new ApplicationException("Must set the Repository property.");
            }
            else
            {
                Products = Repository.Get().OrderBy(p => p.Name).ToList();
            }
        }
    }
}
