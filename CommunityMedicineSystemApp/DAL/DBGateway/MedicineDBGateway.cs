using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CommunityMedicineApp.DAO;
using CommunityMedicineSystemApp.DAL.DAO;
using EmployeeInfirmationApp.DAL.DBGateway;

namespace CommunityMedicineSystemApp.DAL.DBGateway
{
    public class MedicineDBGateway:CommonDBGateway
    {

        SqlConnectionManager aConnectionManager = new SqlConnectionManager();
        internal string SaveMedicineToDb(Medicine aMedicine)
        {
            string sqlQuery = "INSERT INTO tbl_medicines VALUES('" + aMedicine.MedicineName + "', '" +
                              aMedicine.MedicinePower + "')";
            aSqlCommand = new SqlCommand(sqlQuery, aConnectionManager.GetConnection());
            int effectedRows = aSqlCommand.ExecuteNonQuery();
            aConnectionManager.CloseConnection();
            if (effectedRows > 0)
            {
                return "Medicine Add SuccesFully";
            }
            else
            {
                return "fail";
            }
        }

        internal bool HasMedicine(Medicine aMedicine)
        {
            string sqlQuery = "SELECT * FROM tbl_medicines WHERE LOWER(name) = '" + aMedicine.MedicineName.ToLower() + "' AND mg_mL = '" + aMedicine.MedicinePower + "'";
            aSqlCommand = new SqlCommand(sqlQuery, aConnectionManager.GetConnection());
            aReader = aSqlCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

        internal Medicine Find(string medicinename)
        {
            string sqlQuery = "SELECT * FROM tbl_medicines WHERE name= '" + medicinename + "'";
            aSqlCommand = new SqlCommand(sqlQuery, aConnectionManager.GetConnection());
            aReader = aSqlCommand.ExecuteReader();
            aReader.Read();
            Medicine aMedicine = new Medicine();
            aMedicine.MedicineId = Convert.ToInt32(aReader["id"]);
            aConnectionManager.CloseConnection();
            return aMedicine;
        }

       
    }
}