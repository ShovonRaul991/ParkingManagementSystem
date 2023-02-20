using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    class ParkingAreaService
    {
        int MAreasCount, NAreasCount, OAreasCount;
        static int mAreaId = 0, nAreaId = 0, oAreaId = 0;
        //Ticket noTicket = new(0, 0) {ticketNo=0 };
        public ParkingArea CurrentArea;
        public ParkingAreaService()
        {
            Console.Write("Enter the M type areas count in Parking: ");
            MAreasCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the N type areas count in Parking: ");
            NAreasCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the O type areas count in Parking: ");
            OAreasCount = Convert.ToInt32(Console.ReadLine());
            CurrentArea = new(MAreasCount, NAreasCount, OAreasCount);
        }

        public void VehicleEntry(Vehicle car)
        {
            //ticket creation
            DateTime now = DateTime.Now;
            if (car.type == 'M' && mAreaId!=MAreasCount)
            {
                mAreaId++;
                CurrentArea.mAreas.Where(c => c.occupied == false).First().occupied = true;
                CurrentArea.ticketList.Add(new Ticket(car.VehicleNumber, mAreaId,'M') { InTime = now });
            }
            else if (car.type == 'N' && nAreaId!=NAreasCount)
            {
                nAreaId++;
                CurrentArea.nAreas.Where(c => c.occupied == false).First().occupied = true;
                CurrentArea.ticketList.Add(new Ticket(car.VehicleNumber, nAreaId,'N') { InTime = now });
            }
            else if (car.type == 'O' && oAreaId!=OAreasCount)
            {
                oAreaId++;
                CurrentArea.oAreas.Where(c => c.occupied == false).First().occupied = true;
                CurrentArea.ticketList.Add(new Ticket(car.VehicleNumber, oAreaId,'O') { InTime = now });
            }
            else
            {
                Console.WriteLine("No place to park.");
                //return noTicket;  //all field zero or invalid ticket will be generated
                

            }
            //return CurrentArea.ticketList.Last();

        }

        public void VehicleExit(Vehicle car,Ticket ticket)
        {
            DateTime now = DateTime.Now;
            if (car.type == 'M')
            {
                mAreaId--;
                CurrentArea.mAreas.Where(c => c.occupied == true).Last().occupied = false;
                
                
            }
            else if (car.type == 'N')
            {
                nAreaId--;
                CurrentArea.nAreas.Where(c => c.occupied == true).Last().occupied = false;
                
            }
            else if (car.type == 'O')
            {
                oAreaId--;
                CurrentArea.oAreas.Where(c => c.occupied == true).First().occupied = false;
                
            }
            var nowTicket = CurrentArea.ticketList.Where(t => t.ticketNo == ticket.ticketNo);
            nowTicket.First().OutTime = now;
        }



        public void CalculatePlace()
        {
            var freeM = CurrentArea.mAreas.Where(c => c.occupied == false).Count();
            var freeN = CurrentArea.nAreas.Where(c => c.occupied == false).Count();
            var freeO = CurrentArea.oAreas.Where(c => c.occupied == false).Count();
            Console.WriteLine("Available areas for M: " + freeM);
            Console.WriteLine("Available areas for N: " + freeN);
            Console.WriteLine("Available areas for O: " + freeO);
            Console.WriteLine("M type car Count: "+mAreaId + "\tN type car Count: " + nAreaId + "\tO type car Count: " + oAreaId);
            Console.WriteLine();

        }
    }
}
