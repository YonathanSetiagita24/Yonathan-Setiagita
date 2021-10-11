﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance310
{
    class Inheritance310
    {
        public class KomisiTambahanKaryawan
        {
            public string NamaDepan;
            public string NamaBelakang;
            public string KTP;
            private decimal penjualanKotor; // penjualan mingguan kotor
            private decimal tingkatKomisi; // persentase komisi
            private decimal gajiPokok; // gaji pokok per minggu

            // konstruktor enam parameter
            public KomisiTambahanKaryawan(string namaDepan, string namaBelakang, string ktp, decimal penjualanKotor, decimal tingkatKomisi, decimal gajiPokok)
            {
                // panggilan implisit ke konstruktor objek terjadi di sini
                NamaDepan = namaDepan;
                NamaBelakang = namaBelakang;
                KTP = ktp;
                PenjualanKotor = penjualanKotor; // memvalidasi penjualan kotor
                TingkatKomisi = tingkatKomisi; // memvalidasi tingkat komisi
                GajiPokok = gajiPokok; // memvalidasi gaji pokok
            }
            public void setNamaDepan(string namaDepan)
            {
                NamaDepan = namaDepan;
            }
            public string getNamaDepan()
            {
                return NamaDepan;
            }
            public void setNamaBelakang(string namaBelakang)
            {
                NamaBelakang = namaBelakang;
            }
            public string getNamaBelakang()
            {
                return NamaBelakang;
            }
            public void setSocialSecurityNumber(string ktp)
            {
                KTP = ktp;
            }
            public string getKTP()
            {
                return KTP;
            }
            // properti yang mendapatkan dan menetapkan komisi penjualan kotor karyawan
            public decimal PenjualanKotor
            {
                get
                {
                    return penjualanKotor;
                }
                set
                {
                    penjualanKotor = (value < 0) ? 0 : value; // memvalidasi
                }
            }
            // properti yang mendapatkan dan menetapkan tingkat komisi komisi karyawan
            public decimal TingkatKomisi
            {
                get
                {
                    return tingkatKomisi;
                }
                set
                {
                    tingkatKomisi = (value > 0 && value < 1) ? value : 0; // memvalidasi
                }
            }
            // properti yang mendapatkan dan menetapkan KomisiTambahanKaryawan gaji pokok
            public decimal GajiPokok
            {
                get
                {
                    return gajiPokok;
                }
                set
                {
                    gajiPokok = (value < 0) ? 0 : value; // memvalidasi
                }
            }
            // menghitung komisi gaji pegawai
            public decimal Pendapatan()
            {
                return gajiPokok + (tingkatKomisi * penjualanKotor);
            }
            // mengembalikan representasi string dari objek KomisiKaryawan
            public override string ToString()
            {
                return string.Format("Nama Depan : {0} \nNama Belakang : {1} \nSSN : {2} \nPenjualan Kotor : {3} \nTingkat Komisi : {4} \nGaji Pokok : {5}", NamaDepan, NamaBelakang, KTP, penjualanKotor, tingkatKomisi, gajiPokok);
            }
            // Menguji kelas KomisiKaryawan
            static void Main(string[] args)
            {
                // membuat instance objek KomisiKaryawan
                KomisiTambahanKaryawan karyawan = new KomisiTambahanKaryawan("Yonathan", "Setiagita", "123-45-678", 5000.00M, .04M, 300.00M);
                // menampilkan data KomisiKaryawan
                Console.WriteLine("Informasi karyawan diperoleh dengan properti dan metode : \n");
                Console.WriteLine("Nama Depan adalah {0}", karyawan.NamaDepan);
                Console.WriteLine("Nama Belakang adalah {0}", karyawan.NamaBelakang);
                Console.WriteLine("Nomor KTP adalah {0}", karyawan.KTP);
                Console.WriteLine("Penjualan Kotornya adalah {0:C}", karyawan.PenjualanKotor);
                Console.WriteLine("Tingkat Komisinya adalah {0:F2}", karyawan.TingkatKomisi);
                Console.WriteLine("Gaji Pokoknya adalah {0:C}", karyawan.GajiPokok);
                Console.WriteLine("Pendapatanya adalah {0:C}", karyawan.Pendapatan());

                karyawan.PenjualanKotor = 5000.00M; // menetapkan penjualan kotor
                karyawan.TingkatKomisi = .04M; // menetapkan tingkat  komisi
                karyawan.GajiPokok = 1000.00M; // menetapkan gaji pokok
                Console.WriteLine("\n{0}:\n\n{1}", "Informasi karyawan yang diperbarui diperoleh dari ToString", karyawan);
                Console.WriteLine("Pendapatan : {0:C}", karyawan.Pendapatan());
                Console.ReadLine();
            }
        }
    }
}