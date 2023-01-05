using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ping Test";
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("       Test Başlıyor Lütfen Bekleyiniz!");
            Console.WriteLine("------------------------------------------------");


            const int pingCount = 5; // 10 ping isteği göndereceğiz
            List<long> pingTimes = new List<long>(); // Ping sürelerini tutacağımız
            List<long> pingTimes2 = new List<long>(); 
            List<long> pingTimes3 = new List<long>();
            List<long> pingTimes4 = new List<long>();
            List<long> pingTimes5 = new List<long>();
            List<long> pingTimes6 = new List<long>();
            List<long> pingTimes7 = new List<long>();
            List<long> pingTimes8 = new List<long>();
            List<long> pingTimes9 = new List<long>();
            List<long> pingTimes10 = new List<long>();
            List<long> pingTimes11 = new List<long>();
            List<long> pingTimes12 = new List<long>();
            List<long> pingTimes13 = new List<long>();


            Ping ping = new Ping();

            for (int i = 0; i < pingCount; i++)
            {
                PingReply reply = ping.Send("100.127.254.1");
                PingReply reply2 = ping.Send("8.8.8.8");// Google'ın DNS sunucusuna ping gönder
                PingReply reply3 = ping.Send("104.160.143.212");
                PingReply reply4 = ping.Send("146.66.155.69");
                PingReply reply5 = ping.Send("3.64.0.0");
                PingReply reply6 = ping.Send("54.93.162.162");
                PingReply reply7 = ping.Send("1.1.1.1");
                PingReply reply8 = ping.Send("dns1.nextdns.io");
                PingReply reply9 = ping.Send("104.160.143.124");
                PingReply reply10 = ping.Send("155.133.226.71");
                PingReply reply11 = ping.Send("52.56.34.0");
                PingReply reply12 = ping.Send("qosping-aws-eu-west-3.ol.epicgames.com");
                PingReply reply13 = ping.Send("bucharest5424.discord.gg");

                if (reply.Status == IPStatus.Success)
                {
                    pingTimes.Add(reply.RoundtripTime); // Ping süresini listeye ekle
                    pingTimes2.Add(reply2.RoundtripTime);
                    pingTimes3.Add(reply3.RoundtripTime);
                    pingTimes4.Add(reply4.RoundtripTime);
                    pingTimes5.Add(reply5.RoundtripTime);
                    pingTimes6.Add(reply6.RoundtripTime);
                    pingTimes7.Add(reply7.RoundtripTime);
                    pingTimes8.Add(reply8.RoundtripTime);
                    pingTimes9.Add(reply9.RoundtripTime);
                    pingTimes10.Add(reply10.RoundtripTime);
                    pingTimes11.Add(reply11.RoundtripTime);
                    pingTimes12.Add(reply12.RoundtripTime);
                    pingTimes13.Add(reply13.RoundtripTime);
                }
            }

            long totalTime = pingTimes.Sum(); // Ping sürelerinin toplamını hesapla
            long totalTime2 = pingTimes2.Sum();
            long totalTime3 = pingTimes3.Sum();
            long totalTime4 = pingTimes4.Sum();
            long totalTime5 = pingTimes5.Sum();
            long totalTime6 = pingTimes6.Sum();
            long totalTime7 = pingTimes7.Sum();
            long totalTime8 = pingTimes8.Sum();
            long totalTime9 = pingTimes9.Sum();
            long totalTime10 = pingTimes10.Sum();
            long totalTime11 = pingTimes11.Sum();
            long totalTime12 = pingTimes12.Sum();
            long totalTime13 = pingTimes13.Sum();

            double averageTime = (double)totalTime / pingCount; // Ortalama ping süresini hesapla
            double averageTime2 = (double)totalTime2 / pingCount;
            double averageTime3 = (double)totalTime3 / pingCount;
            double averageTime4 = (double)totalTime4 / pingCount;
            double averageTime5 = (double)totalTime5 / pingCount;
            double averageTime6 = (double)totalTime6 / pingCount;
            double averageTime7 = (double)totalTime7 / pingCount;
            double averageTime8 = (double)totalTime8 / pingCount;
            double averageTime9 = (double)totalTime9 / pingCount;
            double averageTime10 = (double)totalTime10 / pingCount;
            double averageTime11 = (double)totalTime11 / pingCount;
            double averageTime12 = (double)totalTime12 / pingCount;
            double averageTime13 = (double)totalTime13 / pingCount;

            Console.WriteLine($"GIBIRNet Pop: {averageTime}ms");
            Console.WriteLine(" ");
            Console.WriteLine("-------------- DNS Servisleri ------------------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Cloudflare DNS: {averageTime7}ms");
            Console.WriteLine($"Google DNS: {averageTime2}ms");
            Console.WriteLine($"Next DNS: {averageTime8}ms");
            Console.WriteLine(" ");
            Console.WriteLine("-------------- Oyun Servisleri -----------------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Valve");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Valve Viyana: {averageTime4}ms");
            Console.WriteLine($"Valve Polonya: {averageTime10}ms");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Riot");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Riot Türkiye: {averageTime3}ms");
            Console.WriteLine($"Riot Avrupa: {averageTime9}ms");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Rainbow Six Siege");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Rainbow EU-Central: {averageTime5}ms");
            Console.WriteLine($"Rainbow EU-West 2: {averageTime11}ms");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Battlefield");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Battlefield: {averageTime6}ms");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Fortnite");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Fortnite: {averageTime12}ms");
            Console.WriteLine(" ");
            Console.WriteLine("--------- Sosyal Medya Servisleri --------------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Discord");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Discord: {averageTime13}ms");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("--------------- Test Tamamlandı ----------------");
            Console.ReadLine();    
                   
            
        }
    }
}
