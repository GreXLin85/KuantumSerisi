using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.QSharpApplication1
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator()) #Yeni kuantum simülasyonu oluştur
            {
                HelloQ.Run(qsim).Wait(); #Simülasyon yani programı çalıştırmak için kullanılan komut
            }
            System.Console.Write("[DRIVER]Programdan çıkmak için herhangi bir tuşa basınız."); #Bu ve
            Console.ReadKey(); #bu kısım simülasyon çalıştırılıp bittikten sonra direk kapatılmasını engellemesi sağlanmaktadır (Bu dosyada normal C# komutları kullanılınabilinir.)
        }
    }
}
