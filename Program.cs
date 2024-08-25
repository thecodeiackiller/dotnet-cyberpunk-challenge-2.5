using System;
using System.Runtime.InteropServices;
using dotnet_cyberpunk_challenge_2._5.malware_daemons;

namespace dotnet_cyberpunk_challenge_2._5
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await Handler.RunDiagnostics();
        }
    }
}