using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1A2B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            string ask = "";

            do
            {
                Console.WriteLine("歡迎來到1A2B猜數字遊戲");
                int[] computers = new int[4];
                Random computer = new Random();
                for (int i = 0; i < 4; i++)
                {
                    computers[i] = computer.Next(0, 10);

                    for (int j = 0; j < i; j++)
                    {
                        while (computers[j] == computers[i])
                        {
                            j = 0;
                            computers[i] = computer.Next(0, 10);
                        }
                    }
                    //Console.WriteLine(computers[i]);
                }


                do
                {
                    Console.WriteLine("請輸入4個數字");
                    int[] players = new int[4];
                    int player = int.Parse(Console.ReadLine());
                    players[0] = player / 1000;
                    players[1] = (player % 1000) / 100;
                    players[2] = (player % 100) / 10;
                    players[3] = player % 10;
                    A = 0;
                    B = 0;


                    if (players[0] == computers[0])
                    {
                        A++;
                    }
                    if (players[1] == computers[1])
                    {
                        A++;
                    }
                    if (players[2] == computers[2])
                    {
                        A++;
                    }
                    if (players[3] == computers[3])
                    {
                        A++;
                    }

                    if (players[0] == computers[1] || players[0] == computers[2] || players[0] == computers[3])
                    {
                        B++;
                    }
                    if (players[1] == computers[0] || players[1] == computers[2] || players[1] == computers[3])
                    {
                        B++;
                    }
                    if (players[2] == computers[0] || players[2] == computers[1] || players[2] == computers[3])
                    {
                        B++;
                    }
                    if (players[3] == computers[0] || players[3] == computers[1] || players[3] == computers[2])
                    {
                        B++;
                    }
                    Console.WriteLine($"結果為:{A}A{B}B");
                    Console.WriteLine("----------------");
                }
                while (A < 4);
                {
                    Console.WriteLine("恭喜你猜對了!");
                    Console.WriteLine("是否繼續進行遊戲(y/n)");
                    ask = Console.ReadLine();
                    
                }
                /*if (ask != "n")
                {
                    Console.WriteLine("請不要輸入y或n以外的鍵");
                    ask = Console.ReadLine();
                }*/

            } while (ask == "y");
            {

                Console.WriteLine("遊戲結束，下次再來玩喔!");

            }





            Console.ReadLine();
        }
    }
}
