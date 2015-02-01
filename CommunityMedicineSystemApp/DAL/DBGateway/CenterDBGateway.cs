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
        internal Center FindCodePswrd(Center aCenterLogin)
        {

            string query = "SELECT id, code, password FROM tbl_centers WHERE code='" + aCenterLogin.CenterUserId + "'AND password='" + aCenterLogin.CenterPassword + "'";

            aSqlCommand = new SqlCommand(query, aConnectionManager.GetConnection());
            aReader = aSqlCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                Center aCenter = new Center();
                while (aReader.Read())
                {
                    aCenter.CenterId = Convert.ToInt32(aReader["id"]);
                    aCenter.CenterUserId = aReader["code"].ToString();
                    aCenter.CenterPassword = aReader["password"].ToString();
                }
                aConnectionManager.CloseConnection();
                return aCenter;
            }
            aConnectionManager.CloseConnection();
            return null;

        }

    }
}