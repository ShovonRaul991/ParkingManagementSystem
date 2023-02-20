using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingManagementSystem
{
    class Program
    {
        public static void Main()
        {
            //Console.WriteLine("Hello WOrld");
            ParkingAreaService areaService = new();

            do
            {
                Console.WriteLine("You can perform the following operations: ");
                Console.WriteLine("1. Park a Car: ");
                Console.WriteLine("2. Unpark a Car: ");
                Console.WriteLine("3. Parking Status: ");
                Console.WriteLine("4. Check Tickets: ");

                Console.WriteLine("Enter your choice: ");
                int UserChoice = Convert.ToInt32(Console.ReadLine());
                switch(UserChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the car Number: ");
                        var carNumber1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the car type: ");
                        var carType = Convert.ToChar(Console.ReadLine());
                        Vehicle tempV = new Vehicle(carNumber1, carType);
                        areaService.VehicleEntry(tempV);
                        areaService.CurrentArea.vehicleList.Add(tempV);
                        break;

                    case 2:
                        Console.WriteLine("Enter the car Number: ");
                        var carNumber2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the ticket no: ");
                        var ticketno = Convert.ToInt32(Console.ReadLine());
                        var car = areaService.CurrentArea.vehicleList.Where(c => c.VehicleNumber == carNumber2);
                        var ticket = areaService.CurrentArea.ticketList.Where(c => c.ticketNo == ticketno);
                        areaService.VehicleExit(car.First(), ticket.First());
                        break;

                    case 3:
                        Console.WriteLine("The availibility of parking space: ");
                        areaService.CalculatePlace();
                        break;
                    case 4:
                        Console.WriteLine("All the created tickets are: ");
                        var tempTicketlist = areaService.CurrentArea.ticketList
                            .Select(t=>"Ticket Number:"+t.ticketNo+
                                        " Vehicle No:"+t.VehicleNumber+
                                        " Slot Type:"+t.SlotType+
                                        " Slot Number:"+t.SlotNumber+
                                        " In Time:"+t.InTime+
                                        " Out time:"+t.OutTime);
                        foreach (var ticketItem in tempTicketlist)
                            Console.WriteLine(ticketItem);
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (true);
            
            /*
            Vehicle v1 = new Vehicle(2023, 'M');
            Vehicle v2 = new Vehicle(3021, 'N');
            Vehicle v3 = new Vehicle(3033, 'O');
            Vehicle v4 = new Vehicle(3011, 'M');
            Vehicle v5 = new Vehicle(1111, 'M');
            
            

            var myticket1 = areaService.VehicleEntry(v1);
            areaService.CalculatePlace();

            Console.WriteLine("For v1");
            Console.WriteLine(myticket1.ticketNo);
            Console.WriteLine(myticket1.VehicleNumber);
            Console.WriteLine(myticket1.SlotNumber);
            Console.WriteLine(myticket1.InTime);
            Console.WriteLine(myticket1.OutTime);

            var myticket2 = areaService.VehicleEntry(v2);
            areaService.CalculatePlace();

            Console.WriteLine("For v2");
            Console.WriteLine(myticket2.ticketNo);
            Console.WriteLine(myticket2.VehicleNumber);
            Console.WriteLine(myticket2.SlotNumber);
            Console.WriteLine(myticket2.InTime);
            Console.WriteLine(myticket2.OutTime);

            var myticket3 = areaService.VehicleEntry(v4);
            areaService.CalculatePlace();

            Console.WriteLine("For v4");
            Console.WriteLine(myticket3.ticketNo);
            Console.WriteLine(myticket3.VehicleNumber);
            Console.WriteLine(myticket3.SlotNumber);
            Console.WriteLine(myticket3.InTime);
            Console.WriteLine(myticket3.OutTime);

            
            areaService.VehicleExit(v1, myticket1);
            areaService.CalculatePlace();

            Console.WriteLine("For v1 exit");
            Console.WriteLine(myticket1.ticketNo);
            Console.WriteLine(myticket1.VehicleNumber);
            Console.WriteLine(myticket1.SlotNumber);
            Console.WriteLine(myticket1.InTime);
            Console.WriteLine(myticket1.OutTime);

            areaService.VehicleExit(v4, myticket3);
            areaService.CalculatePlace();

            Console.WriteLine("For v4 exit");
            Console.WriteLine(myticket3.ticketNo);
            Console.WriteLine(myticket3.VehicleNumber);
            Console.WriteLine(myticket3.SlotNumber);
            Console.WriteLine(myticket3.InTime);
            Console.WriteLine(myticket3.OutTime);

            var myticket5 = areaService.VehicleEntry(v5);
            areaService.CalculatePlace();

            Console.WriteLine("For v5");
            Console.WriteLine(myticket5.ticketNo);
            Console.WriteLine(myticket5.VehicleNumber);
            Console.WriteLine(myticket5.SlotNumber);
            Console.WriteLine(myticket5.InTime);
            Console.WriteLine(myticket5.OutTime);
            */
            
        }
        
    }
}