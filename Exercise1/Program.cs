using System;

namespace Exercise_1
{
    class program
    {
        //deklarasi ukuran array int
        private int[] Azhar = new int[30];

        //deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //fungsi / method untuk menerima masukan
        public void baca()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 30)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 30 elemen.\n");
            }

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("------------------------");

            //pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                Azhar[i] = Int32.Parse(s1);
            }
        }

        //fungsi / method untuk menampilkan array
        public void tampil()
        {
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int TA = 0; TA < n; TA++)
            {
                Console.WriteLine(Azhar[TA]);
            }
            Console.WriteLine("");
        }

        public void Sort()
        {
            for (int i = 1; i < n; i++)
            {
                //pada pass 1, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int TA = 0; TA < n - i; TA++)
                {
                    if (Azhar[TA] > Azhar[TA + 1]) //jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = Azhar[TA];
                        Azhar[TA] = Azhar[TA + 1];
                        Azhar[TA + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //membuat object untuk memanggil fungsi dari class program
            program lastsort = new program();

            //pemanggilan fungsi untuk menerima elemen array
            lastsort.baca();

            //pemanggilan fungsi untuk mengurutkan array
            lastsort.Sort();

            //pemanggilan fungsi untuk menampilkan array yang tersusun
            lastsort.tampil();

            //exit
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}