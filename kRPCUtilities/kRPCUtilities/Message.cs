using System;
using System.Threading;
using KRPC.Client;
using KRPC.Client.Services.SpaceCenter;
using KRPC.Client.Services.UI;

namespace kRPCUtilities
{
    public class Message
    {
        public static void SendMessage(string Message, Connection Connection)
        {
            var ui = Connection.UI();
            var spaceCenter = Connection.SpaceCenter();
            var vessel = spaceCenter.ActiveVessel;

            var timeSpan = TimeSpan.FromSeconds(vessel.MET);
            var metFormated = String.Format($"{timeSpan.Hours}h:{timeSpan.Minutes}m:{timeSpan.Seconds}s");

            ui.Message(Message, 5, MessagePosition.TopCenter);

            if (vessel.Situation == VesselSituation.PreLaunch)
            {
                Console.WriteLine($"Pre-launch: {Message}");
                Console.WriteLine();
            }
            else if (Message == "Liftoff!")
            {
                Console.WriteLine($"{Message}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{metFormated}: {Message}");
                Console.WriteLine();
            }
        }

        public static void CountdownMessage(string Message, Connection Connection, bool Delay)
        {
            var ui = Connection.UI();
            ui.Message(Message, 1, MessagePosition.TopCenter);
            Console.WriteLine($"{Message}");

            if (Delay)
            {
                Thread.Sleep(1000);
            }
        }
    }
}