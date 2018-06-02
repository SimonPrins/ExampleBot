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
        public void OnStart(ResponseGameInfo gameInfo, ResponseObservation observation, uint playerId)
        { }
    
        public IEnumerable<SC2APIProtocol.Action> OnFrame(ResponseGameInfo gameInfo, ResponseObservation observation, uint playerId)
        {
            List<SC2APIProtocol.Action> actions = new List<SC2APIProtocol.Action>();

            return actions;
        }
        
        public void OnEnd(ResponseGameInfo gameInfo, ResponseObservation observation, uint playerId, Result result)
        { }
    }
}
