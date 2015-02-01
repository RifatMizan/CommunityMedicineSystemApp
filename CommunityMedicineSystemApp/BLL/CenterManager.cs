using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommunityMedicineSystemApp.DAL.DAO;
using CommunityMedicineSystemApp.DAL.DBGateway;

namespace CommunityMedicineSystemApp.BLL
{
    
    public class CenterManager
    {
        CenterDBGateway aCenterDbGateway = new CenterDBGateway();

        internal Center FindCodePswrd(Center aCenterLogin)
        {
            return aCenterDbGateway.FindCodePswrd(aCenterLogin);
        }
    }
}