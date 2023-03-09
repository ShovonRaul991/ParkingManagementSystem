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
            if(areaService.MAreasCount==0 && areaService.NAreasCount==0 && areaService.OAreasCount==0 )
            {
                Console.WriteLine("No space available");
                return;
            }
            do
            {
                Console.WriteLine("You can perform the following operations: ");
                Console.WriteLine("1. Park a Car: ");
                Console.WriteLine("2. Unpark a Car: ");
                Console.WriteLine("3. Parking Status: ");
                Console.WriteLine("4. Check Tickets: ");

                //Console.WriteLine("Enter your choice: ");
                int UserChoice = UserInputHandling.UserInput("Choice type: ");
                switch(UserChoice)
                {
                    case 1:
                        var carNumberParked = UserInputHandling.UserInput("Car: ");
                        Console.WriteLine("Enter the car type: ");
                        try
                        {
                            var carType = Convert.ToChar(Console.ReadLine());
                            Vehicle tempV = new(carNumberParked, carType);
                            if (areaService.VehicleEntry(tempV))
                            {
                                areaService.CurrentArea.vehicleList.Add(tempV);

                            }
                        }
                        catch
                        {
                            Console.WriteLine("Car type should be \'M\' or \'N\' or \'O\'");
                        }
                        break;

                    case 2:
                        var carNumberUnparked = UserInputHandling.UserInput("Car: ");
                        var ticketno = UserInputHandling.UserInput("Ticket: ");
                        try
                        {
                            var car = areaService.CurrentArea.vehicleList.Where(c => c.VehicleNumber == carNumberUnparked);
                            var ticket = areaService.CurrentArea.ticketList.Where(c => c.ticketNo == ticketno);
                            areaService.VehicleExit(car.First(), ticket.First());
                                
                        }
                        catch
                        {
                            Console.WriteLine("The details is not correct: ");
                        }
                        break;

                    case 3:
                        Console.WriteLine("The availibility of parking space: ");
                        areaService.CalculatePlace();
                        break;

                    case 4:
                        if(areaService.CurrentArea.ticketList.Count!=0)
                        {
                            Console.WriteLine("All the created tickets are: ");
                            var tempTicketlist = areaService.CurrentArea.ticketList
                                .Select(t => "Ticket Number:" + t.ticketNo +
                                            " Vehicle No:" + t.VehicleNumber +
                                            " Slot Type:" + t.SlotType +
                                            " Slot Number:" + t.SlotNumber +
                                            " In Time:" + t.InTime +
                                            " Out time:" + t.OutTime);
                            foreach (var ticketItem in tempTicketlist)
                                Console.WriteLine(ticketItem);
                        }
                        else
                        {
                            Console.WriteLine("No ticket available: ");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (true);
            
        }
        
    }
}