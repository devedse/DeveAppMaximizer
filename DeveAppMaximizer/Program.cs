using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace DeveAppMaximizer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            args = new string[] { "chrome", "www.google.nl" };

            if (args.Length == 0)
            {
                Console.WriteLine("Error: No command specified");
            }
            else
            {
                var appToStart = args[0];

                var arguments = "";

                if (args.Length > 1)
                {
                    arguments = string.Join(' ', args.Skip(1));
                }

                Console.WriteLine($"Starting '{appToStart}' with arguments '{arguments}'...");

                var psi = new ProcessStartInfo(appToStart, arguments);
                psi.UseShellExecute = true;

                Process.Start(psi);
            }
        }
    }
}
