using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CommunityMedicineSystemApp.DAL.DAO;
using EmployeeInfirmationApp.DAL.DBGateway;

namespace CommunityMedicineSystemApp.DAL.DBGateway
{
    public class CenterDBGateway : CommonDBGateway
    {
        SqlConnectionManager aConnectionManager = new SqlConnectionManager();

        internal List<Center> GetTheCenter(string thanaId)
        {
          
        }

        internal bool CreateNewCenter(Center aCenter)
        {
           
        }

        internal bool HasCenter(Center aCenter)
        {
            
        }

        internal Center FindCodePswrd(Center aCenterLogin)
        {

           
        }

    }
}