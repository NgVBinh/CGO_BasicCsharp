using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class Program
    {
        public class StopWatch
        {
            private DateTime endTime;
            private DateTime startTime;

            public StopWatch() {
            
            }
            public DateTime getEndTime()
            {
                return this.endTime;
            }
           
            public DateTime getStartTime()
            {
                return this.startTime;
            }
            public void Start()
            {
                this.startTime=DateTime.Now;
            }
            public void Stop()
            {
                this.endTime=DateTime.Now;
            }
            public int getela()
            {
                int a = (this.endTime.Millisecond - this.startTime.Millisecond) ;
                return a;
            }
            

        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr= new int[1000];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i]=random.Next(0,1000);
            }
            StopWatch watch1 = new StopWatch();
            watch1.Start();
            Console.WriteLine("start time: "+watch1.getStartTime());

            //selection sort

            for (int i = 0; i < arr.Length-1; i++)
            {
                int min_index = i;
                
                for(int j = i+1; j < arr.Length;j++)
                    if (arr[j] < arr[min_index])
                        {
                            min_index= j;
                        }

                int tem = arr[i];
                arr[i]= arr[min_index];
                arr[min_index]=tem;
                
            }
            foreach (int i in arr)
            {
                Console.Write(i + "   ");
            }
            watch1.Stop();
            Console.WriteLine("end time: "+watch1.getEndTime());
            Console.WriteLine("Thoi gian thuc hien :"+watch1.getela()+" miliseconds");
            Console.ReadKey();
        }

    }
}
