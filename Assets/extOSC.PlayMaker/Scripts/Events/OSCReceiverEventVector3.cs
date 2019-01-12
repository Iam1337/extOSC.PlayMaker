/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER 

using UnityEngine;

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
    public class OSCReceiverEventVector3 : OSCReceiverEvent<FsmVector3, Vector3>
    {
        #region Protected Methods

        protected override bool ProcessMessage(OSCMessage message, out Vector3 value)
        {
            value = Vector3.zero;

            if (message.ToVector3(out value))
                return true;

            return false;
        }

        #endregion
    }
}

#endif