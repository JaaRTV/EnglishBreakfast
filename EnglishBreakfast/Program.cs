using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnglishBreakfast
{
    class Program
    {
        static void CutMushRoom(int mushroom)
        {
            Console.WriteLine("Start to cut of mushrooms");
            while (mushroom>0)
            {
                Console.WriteLine($"it remains to cut mushrooms {mushroom}");
                mushroom--;
            }
            Console.WriteLine("Finish to cut mushrooms");
        }
        static void FryMushRoom()
        {
            Console.WriteLine("Start to fry mushrooms");
            Thread.Sleep(1000);
            Console.WriteLine("Finish to fry mushrooms");
        }
        static void FryBreadSlices(int breadSlices)
        {
            Console.WriteLine("Start to fry Slices of Bread");
            while (breadSlices > 0)
            {
                Console.WriteLine($"it remains {breadSlices} to fry Slices of Bread");
                breadSlices--;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Finish to fry Slices of Bread");
        }
        static void FryEggs(int eggs)
        {
            Console.WriteLine("Start to fry eggs");
            while (eggs > 0)
            {
                Console.WriteLine($"it remains to fry eggs {eggs}");
                eggs--;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Finish to fry eggs");
        }
        static async void CutMushRoomAsync(int mushroom)
        {
            await Task.Run(() => CutMushRoom(mushroom));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start to cook breakfast");
            CutMushRoomAsync(5);
            FryBreadSlices(2);
            FryEggs(2);
            FryMushRoom();
            Console.WriteLine("BreakFest ready! Have a nice meal");
            Console.ReadKey();
        }
    }
}
