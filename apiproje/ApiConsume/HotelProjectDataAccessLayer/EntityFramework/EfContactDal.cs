using HotelProjectDataAccessLayer.Abstract;
using HotelProjectDataAccessLayer.Concrete;
using HotelProjectDataAccessLayer.Repositories;
using HotelProjectEntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(Context context) : base(context)
        {

        }

        public int GetContactCount()
        {
            var context = new Context();
            return context.Contacts.Count();
        }

        public List<Contact> GetListWithMessageCategory()
        {
            var context = new Context();
            return context.Contacts.Include(x => x.MessageCategory).ToList();
        }

        public Contact GetByIDWithMessageCategory(int id)
        {
            var context = new Context();
            return context.Contacts.Include(x => x.MessageCategory).Where(x => x.ContactID == id).FirstOrDefault()!;
        }
    }
}
