/*
 * HoTen: Nguyen Thanh Nhan 
 * Tom Tat
 * 
 * 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom;

/// <summary>
/// struct quan ly hang hoa 
/// </summary>
struct HangHoa
{
    public string maHang;
    public string tenHang;
    public int soLuong;
    public double donGia;
    public double thanhTien; 

    public HangHoa(string ma, string ten, int so, double don)
    {
        maHang = ma;
        tenHang = ten; 
        soLuong=so;
        donGia = don;
        thanhTien = so*don;


    }
}; 




namespace NguyenThanhNhanFile
{
    internal class NguyenThanhNhanBT3
    {
        static void Main(string[]args)
        {
            //khai bao mang 
            StreamReader varReader = MoFile();
            HangHoa[] arr = new HangHoa[int.Parse(varReader.ReadLine())];
           


            varReader.Close(); 






            Console.ReadKey(); 

        }
        /// <summary>
        /// Mo file
        /// </summary>
        /// <param name="link"></param>
        static StreamReader MoFile()
        {
            string link = "E:\\NguyenThanhNhanFile\\NguyenThanhNhanFile\\FileS.txt";
            StreamReader varReader=new StreamReader(link); ; 
            return varReader;
        }

        static void BoQuaKhoangTrang(StreamReader rd)
        {
            if(rd.ReadLine()=="")
            {

            }

        }
        static HangHoa[] GhiFileVaoMang(HangHoa[]arr,StreamReader varReader)
        {
            
            using(varReader)
            {
                for(int i=0; i<arr.Length; i++)
                {
                    arr[i]


                }


            }

            return arr; 
        }
    }
}
