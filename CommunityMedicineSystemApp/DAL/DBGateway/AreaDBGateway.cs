using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CommunityMedicineSystemApp.DAL.DAO;
using EmployeeInfirmationApp.DAL.DBGateway;

namespace CommunityMedicineSystemApp.DAL.DBGateway
{
    public class AreaDBGateway:CommonDBGateway
    {
       
        internal List<District> GetAllDistrict()
        {
            
        }

        internal List<Thana> GetTheThana(int districtId)
        {
           
        }
    }
}