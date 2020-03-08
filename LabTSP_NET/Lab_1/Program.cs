using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyType myType = new MyType();
            myType.beforePrint += (x =>
            {
                Console.WriteLine("test before print: " + x);
            });
            myType.afterPrint += (x =>
            {
                Console.WriteLine("test after print: " + x);
            });
            myType.Print("Test");

            PrimalAlgorithms primal = new PrimalAlgorithms();


            Thread thread1 = new Thread(thread =>
            {
                var startTh1 = DateTime.Now;
                Console.WriteLine("Start fir1: " + ((Thread)thread).Name + " " + startTh1.ToString("hh:mm:s:ms") + " Numar natural dat = 160");

                for (int i = 0; i < 100000; i++)
                    primal.GetMaxPrime_SmallerThenEfficient(160);

                var endTh1 = DateTime.Now;
                Console.WriteLine("End fir1: " + ((Thread)thread).Name + " " + endTh1.ToString("hh:mm:s:ms"));
            });

            //thread1.Start(thread1);



            Thread thread2 = new Thread((thread) =>
            {
                var startTh2 = DateTime.Now;
                Console.WriteLine("Start fir2: " + ((Thread)thread).Name + " " + startTh2.ToString("hh:mm:s:ms") + " Numar natural dat = 160");

                for (int i = 0; i < 100000; i++)
                    primal.GetMaxPrime_SmallerThenInefficient(160);

                var endTh2 = DateTime.Now;
                Console.WriteLine("End fir2: " + ((Thread)thread).Name + " " + endTh2.ToString("hh:mm:s:ms"));
            });

            //thread2.Start(thread2);

            BackgroundWorker backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += new DoWorkEventHandler(Program.backgroundWorker1_DoWork);

            BackgroundWorker backgroundWorker2 = new BackgroundWorker();
            backgroundWorker2.DoWork += new DoWorkEventHandler(Program.backgroundWorker2_DoWork);

            //backgroundWorker1.RunWorkerAsync(argument: primal);
            //backgroundWorker2.RunWorkerAsync(argument: primal);

            Program.RunTasks(primal);
        }

        private static void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            PrimalAlgorithms primal = (PrimalAlgorithms)e.Argument;
            var startTh1 = DateTime.Now;
            Console.WriteLine("Start fir1: " + startTh1.ToString("hh:mm:s:ms") + " Numar natural dat = 160");

            for (int i = 0; i < 100000; i++)
                primal.GetMaxPrime_SmallerThenEfficient(160);

            var endTh1 = DateTime.Now;
            Console.WriteLine("End fir1: " + endTh1.ToString("hh:mm:s:ms"));
        }

        private static void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            PrimalAlgorithms primal = (PrimalAlgorithms)e.Argument;
            var startTh2 = DateTime.Now;
            Console.WriteLine("Start fir2: " + startTh2.ToString("hh:mm:s:ms") + " Numar natural dat = 160");

            for (int i = 0; i < 100000; i++)
                primal.GetMaxPrime_SmallerThenInefficient(160);

            var endTh2 = DateTime.Now;
            Console.WriteLine("End fir2: " + endTh2.ToString("hh:mm:s:ms"));
        }

        private static void GetPrimeEff(PrimalAlgorithms primal)
        {
            var startTh1 = DateTime.Now;
            Console.WriteLine("Start fir1: " + startTh1.ToString("hh:mm:s:ms") + " Numar natural dat = 160");

            for (int i = 0; i < 100000000; i++)
                primal.GetMaxPrime_SmallerThenEfficient(160);

            var endTh1 = DateTime.Now;
            Console.WriteLine("End fir1: " + endTh1.ToString("hh:mm:s:ms"));
        }

        private static async Task GetPrimeIneff(PrimalAlgorithms primal)
        {
            var startTh2 = DateTime.Now;
            Console.WriteLine("Start fir2: " + startTh2.ToString("hh:mm:s:ms") + " Numar natural dat = 160");

            for (int i = 0; i < 100000; i++)
                primal.GetMaxPrime_SmallerThenInefficient(160);

            var endTh2 = DateTime.Now;
            Console.WriteLine("End fir2: " + endTh2.ToString("hh:mm:s:ms"));
        }

        private static void RunTasks(PrimalAlgorithms primal)
        {
            Action<PrimalAlgorithms> myAction = new Action<PrimalAlgorithms>(Program.GetPrimeEff);
            //var task1 = new Task(myAction,primal);

            //task1.Start();

            Program.GetPrimeEff(primal);
            //await Program.GetPrimeIneff(primal);
        }
    }

}
