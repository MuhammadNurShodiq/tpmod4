// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using tpmod4_1302223054;
using static tpmod4_1302223054.Class1;


using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        // Buat object dari class KodePos
        KodePos kodePos = new KodePos();

        // Panggil method GetKodePos dengan parameter "Batununggal"
        string kodePosBatununggal = kodePos.GetKodePos("Batununggal");

        // Cetak kode pos
        Console.WriteLine($"Kode pos Batununggal: {kodePosBatununggal}");

        string kodePosKujangsari = kodePos.GetKodePos("Kujangsari");
        Console.WriteLine($"Kode pos Kujangsari: {kodePosKujangsari}");

        string kodePosMengger = kodePos.GetKodePos("Mengger");
        Console.WriteLine($"Kode pos Mengger: {kodePosMengger}");

        string kodePosWates = kodePos.GetKodePos("Wates");
        Console.WriteLine($"Kode pos Wates: {kodePosWates}");       

        string kodePosCijaura = kodePos.GetKodePos("Cijaura");
        Console.WriteLine($"Kode pos Cijaura: {kodePosCijaura}");

        string kodePosJatisari = kodePos.GetKodePos("Jatisari");
        Console.WriteLine($"Kode pos Jatisari: {kodePosJatisari}");

        string kodePosMargasari = kodePos.GetKodePos("Margasari");
        Console.WriteLine($"Kode pos Margasari: {kodePosMargasari}");

        string kodePosSekejati = kodePos.GetKodePos("Sekejati");
        Console.WriteLine($"Kode pos Sekejati: {kodePosSekejati}");

        string kodePosKebonwaru = kodePos.GetKodePos("Kebonwaru");
        Console.WriteLine($"Kode pos Kebonwaru: {kodePosKebonwaru}");

        string kodePosMaleer = kodePos.GetKodePos("Maleer");
        Console.WriteLine($"Kode pos Maleer: {kodePosMaleer}");

        string kodePosSamoja = kodePos.GetKodePos("Samoja");
        Console.WriteLine($"Kode pos Samoja: {kodePosSamoja}");
    }
}

