using System;

namespace lab1
{
    class Program
    {
        static void Main()
        {
            
            int[] test1 = {5, 4, 3};
            int n1 = 1;
            HW1.QueueTime(test1, n1);

            int[] test2 = { 10, 2, 3, 3};
            int n2 = 2;
            HW1.QueueTime(test2, n2);

            int[] test3 = { 2, 3, 10};
            int n3 = 2;
            HW1.QueueTime(test3, n3);
        }
    }
    public class HW1
    {
        public static long QueueTime( int[] customers, int n)
        {
            int time = 0;
            int pustie_kassi = 0;
            int people = customers.Length;

            int[] kassa = new int[n];      
            //заполняем кассы первыми людьми из очереди
            for (int k = 0; k < n; k++)
            {
                kassa[k] = customers[k];
            }
            int num_klienta = n; //номер первого человека который не у кассы
            bool flag = true; //если flag = false то люди в очереди закончились 
            
            if (n == people) //если покупателей столько же сколько касс, значит людей в очереди не осталось
                flag = false;
            
            while (pustie_kassi != n)
            {
                for (int m = 0; m < n; m++)
                {
                    kassa[m]--;
                   
                    if (kassa[m] == 0)   
                    {
                        if (!flag) //если клиенты закончились, то касса остается пустой
                            pustie_kassi++;
                        else       //если клиенты ещё есть, то ставим за кассу следующего 
                        {                                  
                            kassa[m] = customers[num_klienta];
                            num_klienta++;                                                        
                        }
                    }

                    if (num_klienta == people) //очередь закончилась
                    {
                        flag = false;
                    }
                }            
                time++;
            }            
            Console.WriteLine(time);
            return 0;
        }
    }
}