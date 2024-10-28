using ProductDataServises.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDataServises.interfaces
{
    public  interface IProductServises
    {
        Task<IEnumerable<Product>> GetAllproductDetails();
    }
}
