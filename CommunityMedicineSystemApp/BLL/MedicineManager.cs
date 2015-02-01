using System.Collections.Generic;
using CommunityMedicineApp.DAO;
using CommunityMedicineSystemApp.DAL.DAO;
using CommunityMedicineSystemApp.DAL.DBGateway;

namespace CommunityMedicineSystemApp.UI
{
    internal class MedicineManager
    {

        MedicineDBGateway aMedicineDbGateway = new MedicineDBGateway();
        internal string SaveMedicineToDb(Medicine aMedicine)
        {
            if (HasMedicine(aMedicine))
            {
                return "The Medicine already Added";
            }
            else
            {
                return aMedicineDbGateway.SaveMedicineToDb(aMedicine);
            }
        }

        private bool HasMedicine(Medicine aMedicine)
        {
            return aMedicineDbGateway.HasMedicine(aMedicine);
        }
        internal Medicine Find(string medicineId)
        {
            return aMedicineDbGateway.Find(medicineId);
        }
  
    }
}