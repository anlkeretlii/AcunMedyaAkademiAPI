using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectBusinessLayer.Abstract
{
   public interface IContactService:IGenericService<Contact>
    {
        public int TGetContactCount();
        public List<Contact> TGetListWithMessageCategory();
        public Contact TGetByIDWithMessageCategory(int id);
    }
}
