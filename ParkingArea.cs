using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    class ParkingArea
    {
        public List<MArea> mAreas = new();
        public List<NArea> nAreas  = new();
        public List<OArea> oAreas = new();
        public List<Ticket> ticketList= new();
        public List<Vehicle> vehicleList= new();
        

        //public int MAreasCount { get; set; }
        //public int NAreasCount { get; set; }
        
        //public int OAreasCount { get; set; }

        public ParkingArea(int MAreasCount,int NAreasCount, int OAreasCount) 
        {
            

            for(int i =0;i< MAreasCount;i++)
            {
                mAreas.Add(new MArea());
            }
            for (int i = 0; i < NAreasCount; i++)
            {
                nAreas.Add(new NArea());
            }
            for (int i = 0; i < OAreasCount; i++)
            {
                oAreas.Add(new OArea());
            }

            //Console.WriteLine(mAreas.Count);
            //Console.WriteLine(nAreas.Count);
            //Console.WriteLine(oAreas.Count);
            

        }
        
    }
}
