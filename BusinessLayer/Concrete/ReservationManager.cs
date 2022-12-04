using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Delete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public Reservation GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetList()
        {
            throw new NotImplementedException();
        }



        public List<Reservation> GetListByFilter(Expression<Func<Reservation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> GetlistWithReservationByWaitApproval(int id)
        {
            return _reservationDal.GetlistWithReservationByWaitApproval(id);
        }

        public void Insert(Reservation t)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }

        public void Update(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
