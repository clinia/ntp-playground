using System;
using System.Net;
using GuerrillaNtp;

namespace NTPPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            // query the SNTP server
            NtpPacket response;
            using (var ntp = new NtpClient(Dns.GetHostAddresses("pool.ntp.org")[0]))
                response = ntp.Query();
            // offset = ntp.GetCorrectionOffset();
            
            Console.WriteLine(response.CorrectionOffset);
        }
    }
}