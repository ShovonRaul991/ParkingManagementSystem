using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    class Ticket
    {
        public int VehicleNumber { get; set; }
        public int SlotNumber { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }

        public Ticket(int VehicleNumber,int SlotNumber,DateTime InTime, DateTime OutTime)
        {
            this.VehicleNumber = VehicleNumber;
            this.SlotNumber = SlotNumber;   
            this.InTime= InTime;
            this.OutTime = OutTime;
        }
    }
}
