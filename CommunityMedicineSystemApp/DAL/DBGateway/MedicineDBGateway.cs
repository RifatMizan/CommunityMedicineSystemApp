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
        
        internal string SaveMedicineToDb(Medicine aMedicine)
        {
        }

        internal bool HasMedicine(Medicine aMedicine)
        {
            
        }

        internal List<Medicine> GetAllMedicine()
        {
            
        }

        internal Medicine Find(string medicinename)
        {
        }

        internal int SendMedicineToCenter(MedicineStockInCenter aMedicineStockInCenter)
        {
            
        }

        internal List<MedicineView> GetMedicine(int center_id)
        {
           
        }
    }
}