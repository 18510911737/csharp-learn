﻿using System;

namespace SocketsLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpSendReceive.Run();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
