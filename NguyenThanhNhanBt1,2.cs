using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
namespace NguyenThanNhan
{
    class NguyenThanhNhanBt1
    {
        static void Main(string []args)
        {
            //Khai bao 
            string link = "E:\\MangNguyen.txt";
            int[] arr = new int[] { 1, 1, 2, 3, 4, 5,6,7,8,9,10 };
 
            //ghi file
            GhiMangVaoFile(link, arr);

            //tao mang tu file va xuat 
            int []arr2=TaoMangTuFile(link);
            Console.WriteLine("Tao Mang tu file: "); 
            XuatMang(arr2);
            //Tong cac so vi tri chan 
            Console.WriteLine("Tong cac so vi tri chan: " + TongPTViTriChan(arr));
            //Tong cac so nguyen to trong mang
            Console.WriteLine("tong cac so nguyen to: " + TongSoNT(arr)); 

            Console.ReadKey(); 

        }

        /// <summary>
        /// ham Ghi mang vao file 
        /// </summary>
        /// <param name="link"></param>
        /// <param name="arr"></param>
        static void GhiMangVaoFile(string link, int []arr)
        {
             
            //mo file 
            StreamWriter varWriter = new StreamWriter(link);

            //ghi file 
            try
            {
                using (varWriter)
                {
                    //Nhap so phan tu mang
                    varWriter.WriteLine(arr.Length);

                    //Nhap phan tu mang 
                    for (int i = 0; i < arr.Length; i++)
                    {

                        varWriter.WriteLine(arr[i]);
                    }
                     
                }
                Console.Write("Ghi file thanh cong!");
 
            }
            catch (Exception)
            {
                Console.Write("ghi file that bai!");

            }

 
        }

        /// <summary>
        /// tao mang tu file 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        static int[] TaoMangTuFile(string link )
        {
            int[] arr = new int [0]; 
            StreamReader varReader = new StreamReader(link);
            int i = 0; 
            //so phan tu mang 
            arr = new int[int.Parse(varReader.ReadLine())]; 
            //chep gia tri tu file sang mang 
          
                while(varReader.Peek()!=-1)
                {
                    arr[i] = int.Parse(varReader.ReadLine()); 
                    i++;
                }

            //Dong file 
            varReader.Close();
            return arr;        

        }

        /// <summary>
        /// Ham xuat  mang 
        /// </summary>
        /// <param name="arr"></param>
        static void XuatMang(int []arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i + " "); 
            }
            Console.WriteLine(); 


        }
        /// <summary>
        /// Tong vi tri chan trong mang
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int TongPTViTriChan(int[]arr)
        {
            int tong = 0; 
            for(int i=0; i<arr.Length; i++)
            {
                if(i%2==0)
                {
                    tong += arr[i]; 
                }
            }
            return tong; 

        }
        /// <summary>
        /// Ham kiem tra so nguyen to 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static bool KTNT(int num)
        {
            bool kq = true;
            if (num < 2)
            {
                kq = false;
            }
            for(int i=2; i<=num/2; i++)
            {
                if(num%i==0)
                {
                    kq = false; 
                }

            }
            return kq; 


        }

        /// <summary>
        /// Ham tinh tong so nguyen to 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int TongSoNT(int[] arr)
        {
            int tong = 0; 
            for(int i=0; i<arr.Length; i++)
            {
                if(KTNT(arr[i]))
                {
                    tong += arr[i]; 
                }

            }
            return tong; 
        }
    }
}
