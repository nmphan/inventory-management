using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Data
{
    public class Equipment
    {
        int equipmentId, categoryId;
        string equipmentName, description;
        float dailyRate;

        public int EquipmentId { get => equipmentId; set => equipmentId = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string EquipmentName { get => equipmentName; set => equipmentName = value; }
        public string Description { get => description; set => description = value; }
        public float DailyRate { get => dailyRate; set => dailyRate = value; }

        public Equipment()
        {
            
        }

        public Equipment(int equipmentId, int categoryId, string equipmentName, string description, float dailyRate)
        {
            this.equipmentId = equipmentId;
            this.categoryId = categoryId;
            this.equipmentName = equipmentName;
            this.description = description;
            this.dailyRate = dailyRate;
        }
    }
}