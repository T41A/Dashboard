using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTTDash
{
    enum MixerStatus
    {
        SendingWeight = 0,
        Emptying = 1,
        Empty = 2,
        NoCup = 3
    }
}
