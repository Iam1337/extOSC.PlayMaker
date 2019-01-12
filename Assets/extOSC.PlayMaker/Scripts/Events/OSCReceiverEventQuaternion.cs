/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using UnityEngine;

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
    public class OSCReceiverEventQuaternion : OSCReceiverEvent<FsmQuaternion, Quaternion>
    {
        #region Protected Methods

        protected override bool ProcessMessage(OSCMessage message, out Quaternion value)
        {
            value = Quaternion.identity;

            if (message.ToQuaternion(out value))
                return true;

            return false;
        }

        #endregion
    }
}

#endif