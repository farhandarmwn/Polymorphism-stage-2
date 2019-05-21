using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // contoh data Mahasiswa
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "18.11.2273";
            mhs.nama = "Muhammad Farhan";
            mhs.email = "Farhan2273@students.amikom.ac.id";

            Console.WriteLine("Pilih Format Konversi Data:");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. Csv\n");

            Console.Write("Nomor Format Data [1...3]: ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            IConvertObject convert; // deklarasi objek konversi

            if (nomorFormatData == 1)
                convert = new ConvertToJson();
            else if (nomorFormatData == 2)
                convert = new ConvertToXml();
            else 
                convert = new ConvertToCsv();

            // konversi objek mhs berdasarkan format yang dipilih
            convert.Convert(mhs);

            Console.ReadKey();
        }
    }
}
