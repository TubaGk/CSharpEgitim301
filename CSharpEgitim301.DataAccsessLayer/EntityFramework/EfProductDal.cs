using System;
using CSharpEgitim301.DataAccsessLayer.Abstract;
using CSharpEgitim301.DataAccsessLayer.Repositories;
using CSharpEgitim301.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitim301.DataAccsessLayer.EntityFramework
{
    public class EfProductDal:GenericRepository<Product>,IProductDal
    {
    }
}
