﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryStore.EntityLayer.Concrete;

namespace SpryStore.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> TGetProductListWithCategory();
        List<Product> TGetLast4Product();

    }
}
