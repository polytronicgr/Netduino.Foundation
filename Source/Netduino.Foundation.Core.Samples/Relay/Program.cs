using System;
using System.Threading;
using Microsoft.SPOT;
using Netduino.Foundation;
using N = SecretLabs.NETMF.Hardware.Netduino;

namespace Relay
{
    public class Program
    {
        public static void Main()
        {
            var relay = new Netduino.Foundation.Relays.Relay(N.Pins.GPIO_PIN_D1);

            while (true)
            {
                Debug.Print("turning on");
                relay.IsOn = true;

                Thread.Sleep(500);

                Debug.Print("toggling to off");
                relay.Toggle();

                Thread.Sleep(250);

                Debug.Print("Toggling to on.");
                relay.Toggle();

                Thread.Sleep(250);

                Debug.Print("Turning off");
                relay.IsOn = false;

                Thread.Sleep(500);

            }
        }
    }
}
