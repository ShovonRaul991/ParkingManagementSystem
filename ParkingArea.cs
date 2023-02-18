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

        public int MAreasCount { get; set; }
        public int NAreasCount { get; set; }
        
        public int OAreasCount { get; set; }

        public ParkingArea() 
        {
            Console.Write("Enter the M type areas count in Parking: ");
            MAreasCount = Convert.ToInt32.Console.ReadLine();
            Console.Write("Enter the N type areas count in Parking: ");
            MAreasCount = Convert.ToInt32(area2);
            Console.Write("Enter the O type areas count in Parking: ");
            MAreasCount = Convert.ToInt32(area3);

            for(int i =0;i< MAreasCount;i++)
            {
                mAreas.Add(new MArea());
            }
            for (int i = 0; i < NAreasCount; i++)
            {
                nAreas.Add(new NArea());
            }
            for (int i = 0; i < oAreasCount; i++)
            {
                oAreas.Add(new OArea());
            }

            Console.WriteLine(mAreas.Count);
            Console.WriteLine(nAreas.Count);
            Console.WriteLine(oAreas.Count);
        }



        


        
    }
}
