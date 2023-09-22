using Crud.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crud.EF
{
   public interface ICrud
   {
      Task<Student> AddBrand(string stname, string course);
      Task<bool> DeleteBrand(int id);
      Task<ICollection<Student>> ListBrands();
      Task<Student> SearchBrandbyID(int ID);
      Task<ICollection<Student>> SearchBrandByName(string stname);
      Task<Student> UpdateBrand(int id, string stname, string course);
   }
}
