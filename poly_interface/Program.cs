using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //buat objek mahasiswa
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "18.11.2314";
            mhs.nama = "Aryowwww";
            mhs.email = "akbar.w@amikom.ac.id";

            Console.WriteLine("Pilih Format Konversi Data:");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. Csv\n");

            Console.Write("Nomor Format Data [1..3]:");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            IConvertObject convert; //deklarasi objek konversi

            if (nomorPrinter == 1)
            {
                convert = new ConvertToJson();     
            }
            else if (nomorPrinter == 2)
            {
                convert = new ConvertToXml();
            }
            else
            {
                convert = new ConvertToCsv();
            }

            //konversi object mhs berdasarkan format yang dipilih
            convert.Convert(mhs);

            Console.ReadKey();
        }
    }
}
