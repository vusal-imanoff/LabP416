using System;

namespace P416
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test1
            ////Verilmiş sözün ilk hərifinin böyük A olub olmamasını yoxlayan proqram yazın
            ///


            //Console.Write("Sozu daxil edin: ");
            //string txt =Console.ReadLine();
            ////bool check = false;
            ////for (int i = 0; i < txt.Length; i++)
            ////{
            //    if (txt[0] == 'a' || txt[0]=='A')
            //    {
            //    Console.WriteLine(true);
            //        //check = true;
            //        //break;
            //    }
            //else
            //{
            //    Console.WriteLine(false);
            //}
            ////}
            ////Console.WriteLine(check);
            #endregion





            #region Task2

            //Verilmiş sözdə b hərfi olub olmamasını yoxlayan proqram yazın


            //Console.WriteLine("sozu daxil edin");
            //string txt = Console.ReadLine();
            //bool check = false;
            //for (int i = 0; i < txt.Length; i++)
            //{
            //    if (txt[i] == 'b')
            //    {

            //        check = true;
            //        break;
            //    }
            //}
            //Console.WriteLine(check);


            #endregion

            #region Task3

            //İsdifadəçi Ədəd Daxil Edir. Daxil Edilən Ədədin Müsbət Olmalıdır. Daxil Edilən Ədədin


            //Həm 7-ə Həm Də 3-ə Bölünüb Bölünməməsini Tapan proqram yazın


            #endregion

            #region Task4
            //Verilmiş N ədədinin özünün son rəqəminə hasilini tapan proqram yazın(misalçün 132 ədədi verilibsə
            //nəticədə 132 * 2 tapılmalıdır)

            //Console.WriteLine("ededi daxil edin: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int last = n % 10;
            //Console.WriteLine(n*last);

            #endregion

            #region Task5
            //Verilmiş 3 ədəddin son rəqəmlərinin kvadratları cəmini tapan proqram yazın


            //Console.WriteLine("3 eded daxil edin:");
            //Console.Write("1- ");
            //int eded1=Convert.ToInt32(Console.ReadLine());
            //Console.Write("2- ");
            //int eded2=Convert.ToInt32(Console.ReadLine());
            //Console.Write("2- ");
            //int eded3 = Convert.ToInt32(Console.ReadLine());
            //int e1 = eded1 % 10;
            //int e2 = eded2 % 10;
            //int e3 = eded3 % 10;
            //Console.WriteLine(e1*e1+e2*e2+e3*e3);
            #endregion


            #region Task6
            //Verilən 4 rəqəmli ədədin rəqəmlərininin tək olanların cəmini və cüt olanlarının hasilinin tapan proqram yazın.


            //double n = int.Parse(Console.ReadLine());
            ////int count = 0;
            //double cut = 1;
            //double tek = 0;
            ////12
            //    while (n > 0)
            //    {
            //        double mod = n % 10;
            //        if (mod % 2 == 0)
            //        {
            //            cut = cut * mod;
            //        }
            //        else
            //        {
            //            tek = tek + mod;
            //        }
            //        n -= mod;
            //        n /= 10;
            //        //count++;
            //    }
            //Console.WriteLine($"cemi {tek} hasili {cut}");
            //Console.WriteLine(count);

            #endregion


            #region MyRegion
            //Verilmiş arraydaki ədələrin cüt yerde duranlarin cəmini və tək yerde duranlarin hasilini tapan proqram yazın;


            int[] arr= new int[] {4,2,6,7,1,9,3,7,2 };
            int cem = 0;
            int hasil = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i%2==0)
                {
                    cem += arr[i];

                }
                else
                {
                    hasil *= arr[i];
                }
            }
            Console.WriteLine($"cem {cem}, hasil {hasil}");
            #endregion
        }
    }
}
