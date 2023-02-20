using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    class Vehicle
    {
        public int VehicleNumber { get; set; }
        //public Char[] Types = { 'M', 'N', 'O' };
        public char type { get; set; }

        public Vehicle(int id, char type)
        {
            VehicleNumber = id;
            if(type == 'M')
            {
                this.type = 'M';
            }
            else if(type=='N')
            {
                this.type = 'N';
            }
            else if (type == 'O')
            {
                this.type = 'O';
            }
            
        }


    }
}
