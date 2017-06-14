using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTTDash
{
    enum NodeType
    {
        Unknown = 0,
        Breathalyzer = 60,
        Mixer = 20,
        CupChecker = 40,
        Cooling = 80,
        Ui = 10

        
    }
}
