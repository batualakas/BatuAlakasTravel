using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            t.Status = false;
            _destinationDal.Update(t);
            
        }

        public Destination TGetByID(int id)
        {
            return _destinationDal.GetByID(id);
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetList();
        }

        public void TUpdate(Destination t)
        {
            t.Status = true;

            _destinationDal.Update(t);
        }
    }
}
