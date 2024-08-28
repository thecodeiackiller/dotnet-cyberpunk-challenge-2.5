using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_cyberpunk_challenge_2._5.malware_daemons;
using dotnet_cyberpunk_challenge_2._5.malware_daemons.lib;

namespace dotnet_cyberpunk_challenge_2._5
{
    public class Handler
    {
        public static async Task RunDiagnostics() {
            KuangGradeSixMalware iceBreaker = new KuangGradeSixMalware();
            await iceBreaker.Initialize();
            List<ArasakaMessageProcessList> processList = await iceBreaker.GetProcessList();
            /*
                TODO: Once you've finished *everything* else then come back here.

                We need to actually print out some data. Look at the properties on the `ArasakaMessageProcessList` class using F12
                on the class and check the properties on the class. Any properties you see on that class we need to loop over 
                with a `foreach(...)` and print them out. You got this :)
            */


            /*
                TODO: Once you've finished *everything* else then come back here.

                We need to print out the memory mapping. We need you to loop over the IEnumerable of strings 
                with a `foreach(...)` and print each of them out.
            */
            IEnumerable<string> processMemoryMapping = await iceBreaker.GetProcessMemoryMapping();
        }
    }
}