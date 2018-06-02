using System;
using System.Collections.Generic;
using System.Text;
using SC2APIProtocol;

namespace SC2API_CSharp
{
    public interface Bot
    {
        IEnumerable<SC2APIProtocol.Action> OnFrame(ResponseGameInfo gameInfo, ResponseObservation observation, uint playerId);
        void OnEnd(ResponseGameInfo gameInfo, ResponseObservation observation, uint playerId, Result result);
        void OnStart(ResponseGameInfo gameInfo, ResponseObservation observation, uint playerId);
    }
}
