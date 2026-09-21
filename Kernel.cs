
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Cosmos.System.Graphics;
using Sys = Cosmos.System;
using System.Security.Cryptography;
using System.Threading;
using Cosmos.Core.IOGroup;



namespace Cosmosround
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            graf.starts();
        }

        protected override void Run()
        {
            while (true)
            {
                lines.Main();
                var input = Console.ReadLine();


            }


        }
    }
    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;


        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(640, 480, ColorDepth.ColorDepth32));
            Sys.MouseManager.ScreenHeight = (uint)(470);
            Sys.MouseManager.ScreenWidth = (uint)(630);






        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }






    class tests



    {


        public static void mainLoop()
        {
            //


            graf.cls(Color.White);
            
            Pen p = new Pen(Color.FromArgb(255,0,0,0), 3);
            graf.canvas.DrawFilledRectangle(p, 640 / 2-100/2, 480 / 2-100/2, 100,100);
            for (int a = 0; a < 50; a++)
            {
                graf.canvas.DrawLine(p, 640 / 2 - 100 / 2 + a*2, 480 / 2 - 100 / 2 - a, 640 / 2 + 100 / 2 - a*2, 480 / 2 - 100 / 2 - a);
                graf.canvas.DrawLine(p, 640 / 2 - 100 / 2 + a*2, 480 / 2 + 100 / 2 + a, 640 / 2 + 100 / 2 - a*2, 480 / 2 + 100 / 2 + a);
                graf.canvas.DrawLine(p, 640 / 2 - 100 / 2 - a, 480 / 2 - 100 / 2 + a*2, 640 / 2 - 100 / 2 - a, 480 / 2 + 100 / 2 - a*2);
                graf.canvas.DrawLine(p, 640 / 2 + 100 / 2 + a, 480 / 2 - 100 / 2 + a * 2, 640 / 2 + 100 / 2 + a, 480 / 2 + 100 / 2 - a * 2);
            }
            graf.canvas.DrawLine(p, 0,480/2,639,480/2);
            graf.canvas.DrawLine(p,640 / 2,0, 640 / 2,479);

            graf.displays();
        }



    }



    class lines
    {

        public static void Main()
        {
            tests.mainLoop();



        }



    }


}
