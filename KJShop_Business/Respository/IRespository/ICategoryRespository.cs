using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using KJShop_Models;

namespace KJShop_Business.Respository.IRespository
{
    public interface ICategoryRespository
    {
        public CategoryDTO Create(CategoryDTO objDTO);

        public CategoryDTO update(CategoryDTO objDTO);

        public int Delete(int id);

        public CategoryDTO Get(int id);

        public IEnumerable<CategoryDTO> GetAll();
    }
}
