using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SC2API_CSharp;
using SC2APIProtocol;

namespace ExampleBot
{
    class YourBot : Bot
    {
        public IEnumerable<SC2APIProtocol.Action> onFrame(ResponseGameInfo gameInfo, ResponseObservation observation, uint playerId)
        {
            List<SC2APIProtocol.Action> actions = new List<SC2APIProtocol.Action>();

            return actions;
        }
    }
}
