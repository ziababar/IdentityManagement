using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GettingStartedLib
{
    public class EchoService : IEcho
    {
        public void MessageEcho(string messageEcho)
        {
            Console.WriteLine("Message: {0}", messageEcho);
        }
    }
}