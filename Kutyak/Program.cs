using System;
using System.IO;
using System.Collections.Generic;

class MainClass
{
    static List<KutyaNev> kutyaNevek = new List<KutyaNev>();
    static List<KutyaFajta> kutyafajtak = new List<KutyaFajta>();
    static List<Kutya> kutyalista = new List<Kutya>();

    static void KutyanevekBeolvasas()
    {
        StreamReader be = new StreamReader("KutyaNevek.csv");

        be.ReadLine();

        while (!be.EndOfStream)
        {
            string[] adat = be.ReadLine().Split(';');

            kutyaNevek.Add(new KutyaNev(
              Convert.ToInt32(adat[0]),
              adat[1]
            ));
        }

        be.Close();
    }

    static void Harmadik()
    {
        Console.WriteLine($"3.feladat: Kutya nevek száma: {kutyaNevek.Count}");
    }

    static void KutyafajtaBeolvasas()
    {
        StreamReader olvas = new StreamReader("KutyaFajtak.csv");
        olvas.ReadLine();
        while (!olvas.EndOfStream)
        {
            string[] tarol = olvas.ReadLine().Split(';');

            kutyafajtak.Add(new KutyaFajta(Convert.ToInt32(tarol[0]),
              tarol[1],tarol[2]));
        }
        olvas.Close();
    }

    static void KutyaBeolvasas()
    {
        StreamReader olvas = new StreamReader("Kutyak.csv");
        olvas.ReadLine();
        while (!olvas.EndOfStream)
        {
            string[] tarol = olvas.ReadLine().Split(';');

            kutyalista.Add(new Kutya(Convert.ToInt32(tarol[0]),
              Convert.ToInt32(tarol[1]), Convert.ToInt32(tarol[2]),Convert.ToInt32(tarol[3]),tarol[4]));
        }
        olvas.Close();
    }
    public static void Main(string[] args)
    {
        KutyanevekBeolvasas();
        Harmadik();
        KutyafajtaBeolvasas();
        KutyaBeolvasas();

        Console.ReadKey();
    }
}