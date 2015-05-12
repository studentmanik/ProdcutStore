using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore.DAL;
using ProductStore.Model;

namespace ProductStore.BLL
{
    class ProductManager
    {
        ProductGatway productGatway=new ProductGatway();
        public string InsertProduct(Product aProduct)
        {
            string msg="";

            if (!productGatway.GetProductCodeByCode(aProduct.ProductCode))
            {
                if (productGatway.Insert(aProduct) > 0)
                {
                    msg= "Insert Successfully";

                }

                else
                {
                    msg= "Failed To insert";
                }
            }
            else
            {
                msg= "Not Unique Product!";
            }


            return msg;

        }

        public List<Product> GetAllProduct()
        {
            
            return  productGatway.GetProduct();
        }
    }
}
