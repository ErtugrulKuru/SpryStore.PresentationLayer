using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryStore.DataAccessLayer.EntityFramework;
using SpryStore.EntityLayer.Concrete;

namespace SpryStore.DataAccessLayer.Abstract
{
    public interface IAddressDal:IGenericDal<Address>
    {
    }
}
