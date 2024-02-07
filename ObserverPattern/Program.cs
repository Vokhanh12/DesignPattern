using System;
using ObserverPattern.Notifiers;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var wheaterData = new WheaterData();
            
            _ = new EmailNotifier(wheaterData);
            _ = new PhoneNotifier(wheaterData);

            wheaterData.SetState("ON");




        }
    }
}