using _2022_0726;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2022_0726.One;
using System.Collections;
using System.Threading;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace _2022_0725
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("请输入需要的场地：");
            while (true)
            {
              
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num >= 3 && num <= 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("不在范围内，请输入3-5以内的数字！");
                        //Console.WriteLine(num);
                       // num++;
                    }
                }
                catch
                {
                    Console.WriteLine("输入内容不符合规范，请重新输入");
                    break;
                }
            
            }
            try
            {
                Venue[] Vlist = new Venue[8];
                using (StreamReader sr = new StreamReader(@"C:\Users\v-sxie\Documents\c#\代码\2022-0726 (2)\venues.txt", Encoding.Default))

                {
                    string line;
                    //string name;
                   
                    // 从文件读取并显示行，直到文件的末尾
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lines = line.Split(',');
                        string name = Convert.ToString(lines[0]);
                        int laps = Convert.ToInt32(lines[1]);
                        int time = int.Parse(lines[2]);
                        double chance = double.Parse(lines[3]);
                       /* Console.WriteLine(name);
                        Console.WriteLine(laps);
                        Console.WriteLine(time);
                        Console.WriteLine(chance);*/
                        Vlist[i] = new Venue(name, laps, time, chance);
                        // Console.WriteLine(Vlist[1]);
                        i++;
                        //Console.WriteLine(Vlist[i]);
                    }
                }
                for (int i = 0; i < num; i++)
                {
                   
                    Random r = new Random(Guid.NewGuid().GetHashCode());
                    int value = r.Next(0, Vlist.Length);
                    Console.WriteLine(Vlist[value].VenueName);
                  
                }

            }
            catch (Exception e)
            {
                // 向用户显示出错消息
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            //Console.ReadKey();
            ///随机输出
          

  
         /* 
            //运动员 
            Console.ReadKey();
            Driver dri = new Driver("小明", 50, "给", 's', 56, 2);
            dri._name = "小明";
            dri._ranking = 50;
            dri._specialskill = "给";
            dri._eligibletotace = 's';
            dri._accumlatedscore = 45;
            dri._accumulatedtime = 56;
            Console.ReadKey();
*/
        }



        
    }
}
    

