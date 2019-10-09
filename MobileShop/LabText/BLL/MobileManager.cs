using System;
using LabText.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabText.Model;
using System.Data;

namespace LabText.BLL
{
   public class MobileManager
    {
        MobileRepository _mobileRepository = new MobileRepository();
        Mobile _mobile = new Mobile();

        public bool Add(Mobile mobile)
        {
           return _mobileRepository.Add(mobile);
        }
        public bool IsEMEIExist(Mobile mobile)
        {
           return _mobileRepository.IsEMEIExist(mobile);
        }
        public DataTable SearchValue(Mobile mobile)
        {
           return _mobileRepository.SearchValue(mobile);
        }

    }
}
