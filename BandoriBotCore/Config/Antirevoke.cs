using System;
using System.Collections.Generic;
using System.Text;

namespace BandoriBot.Config
{
    public class Antirevoke : HashConfiguration<long>
    {
        public override string Name => "antirevoke.json";
    }
}
