using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_akhir
{
    internal class Tulisanyar
    {//menu
        public void embuh()
        {
            Menu mn = new Menu();
            mn.menu();
            //looping input jumlah barang dengan menggunakan kondisi do while
            int jml;

            Console.Write("Masukkan jumlah barang yang dibeli: ");
            jml = int.Parse(Console.ReadLine());


            //looping dengan menggunakan kombinasi Array. Akan mencetak inputan nama barang dan harga barang
            string[] nama = new string[jml];
            int[] harga = new int[jml];
            int total = 0;
            int bayar, kembali;


            for (int i = 0; i < jml; i++)
            {
                do
                {
                    Console.Write("tulis nama barang ke-" + (i + 1) + ": ");
                    nama[i] = Console.ReadLine();
                } while (nama[i].Length <= 0 || nama[i].Length >= 20);

                do
                {
                    Console.Write("masukkan harga barang ke-" + (i + 1) + ": ");
                    harga[i] = int.Parse(Console.ReadLine());

                    //kondisi bajwa user harus input barang antara 1000-10000
                } while (harga[i] <= 100 || harga[i] >= 10000);
            }

            //Menampilkan list harga dan makanan yang dibeli
            Console.WriteLine("\n makanan yang dibeli");
            Console.WriteLine("**************************");
            for (int i = 0; i < jml; i++)
            {
                Console.WriteLine((i + 1) + ". " + nama[i] + "  " + harga[i]);
            }
            foreach (int i in harga)
            {
                total += i;
            }

            //menampilakan total harga barang
            Console.WriteLine("Total = " + total);
            Console.WriteLine("**************************");

            Console.Write("\n Uang bayar: ");
            bayar = int.Parse(Console.ReadLine());

            //Logika untuk mendapatkan uang kembali dari uang bayar yang di input oleh user
            kembali = bayar - total;
            Tulisanyar op = new Tulisanyar();
            //kondisi jika uang yang dibayar lebih kecil dari total harga
            if (bayar < total)
            {
                Console.WriteLine("maaf uang anda kurang! ");
                Console.WriteLine("-------------------------");

            }
            //jika kondisi benar (input uang bayar lebih besar dari total harga)
            else
            {
                Console.WriteLine(" uang kembalian anda Rp. " + kembali + ",00");
                op.meas();
            }
            //statment dimana uang bayar akan selalu di looping bila input uang bayar lebih dari total harga
            //dan akan mencetak kode
            
        }
        public void meas()
        {
            Tulisanyar lanjut = new Tulisanyar();
            Console.WriteLine("Mau pesan lagi?(y/n)");
            string desision = Console.ReadLine();
            if (desision == "y")
            {
                Console.Clear();
                lanjut.embuh();
            }
            
            else
            {
                //ucapan terimakasih
                Console.WriteLine("\n\t\t terimakasih telah berbelanja di NGANGKRING STORE ");
                Console.WriteLine("\n\t\t       kami tunggu kedatangannya kembali ");
            }
        }
    }
}
