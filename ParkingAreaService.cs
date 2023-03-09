using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParkingManagementSystem
{
    class ParkingAreaService
    {
        public int MAreasCount, NAreasCount, OAreasCount;
        static int mAreaId = 0, nAreaId = 0, oAreaId = 0;
        //Ticket noTicket = new(0, 0) {ticketNo=0 };
        public ParkingArea CurrentArea;
        public ParkingAreaService()
        {
            MAreasCount = UserInputHandling.UserInput("M type Area: ");
            NAreasCount = UserInputHandling.UserInput("N Type Area: ");
            OAreasCount = UserInputHandling.UserInput("O Type Area: ");

            CurrentArea = new(MAreasCount, NAreasCount, OAreasCount);

        }

        public bool VehicleEntry(Vehicle car)
        {
            bool carHas = CurrentArea.ticketList.Any(c=>c.VehicleNumber== car.VehicleNumber);
            if (carHas)
            {
                Console.WriteLine("Car is already present.");
                return false;
            }
            //ticket creation
            DateTime now = DateTime.Now;
            if (car.Type == 'M' && mAreaId<MAreasCount)
            {
                mAreaId++;
                CurrentArea.mAreas.Where(c => c.occupied == false).First().occupied = true;
                CurrentArea.ticketList.Add(new Ticket(car.VehicleNumber, mAreaId,'M') { InTime = now });
                return true;
            }
            else if (car.Type == 'N' && nAreaId<NAreasCount)
            {
                nAreaId++;
                CurrentArea.nAreas.Where(c => c.occupied == false).First().occupied = true;
                CurrentArea.ticketList.Add(new Ticket(car.VehicleNumber, nAreaId,'N') { InTime = now });
                return true;
            }
            else if (car.Type == 'O' && oAreaId<OAreasCount)
            {
                oAreaId++;
                CurrentArea.oAreas.Where(c => c.occupied == false).First().occupied = true;
                CurrentArea.ticketList.Add(new Ticket(car.VehicleNumber, oAreaId,'O') { InTime = now });
                return true;
            }
            else
            {
                Console.WriteLine("No place to park or Car type should be \'M\' or \'N\' or \'O\'");
                return false;
            }
        }

        public void VehicleExit(Vehicle car,Ticket ticket)
        {
            DateTime now = DateTime.Now;
            if (car.Type == 'M')
            {
                mAreaId--;
                CurrentArea.mAreas.Where(c => c.occupied == true).Last().occupied = false;
                
                
            }
            else if (car.Type == 'N')
            {
                nAreaId--;
                CurrentArea.nAreas.Where(c => c.occupied == true).Last().occupied = false;
                
            }
            else if (car.Type == 'O')
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
