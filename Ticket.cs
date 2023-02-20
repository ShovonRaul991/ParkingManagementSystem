using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    class Ticket
    {
        public static int TicketId=0;
        public int ticketNo;
        public int VehicleNumber { get; set; }
        public int SlotNumber { get; set; }
        public char SlotType { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }

        public Ticket(int VehicleNumber,int SlotNumber,char SlotType)
        {
            ticketNo = ++TicketId;
            this.VehicleNumber = VehicleNumber;
            this.SlotNumber = SlotNumber; 
            this.SlotType = SlotType;
            //this.InTime= InTime;
            //this.OutTime = OutTime;
        }
    }
}
