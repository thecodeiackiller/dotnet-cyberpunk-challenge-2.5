using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_cyberpunk_challenge_2._5.malware_daemons;

namespace dotnet_cyberpunk_challenge_2._5
{
    public class Handler
    {
        public static async Task RunDiagnostics() {
            KuangGradeSixMalware iceBreaker = new KuangGradeSixMalware();
            await iceBreaker.Initialize();
            await iceBreaker.GetProcessList();
        }
    }
}