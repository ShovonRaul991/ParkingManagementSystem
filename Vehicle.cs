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
        public char Type { get; set; }

        public Vehicle(int id, char type)
        {
            VehicleNumber = id;
            if(type == 'M')
            {
                this.Type = 'M';
            }
            else if(type=='N')
            {
                this.Type = 'N';
            }
            else if (type == 'O')
            {
                this.Type = 'O';
            }
            
        }


    }
}
