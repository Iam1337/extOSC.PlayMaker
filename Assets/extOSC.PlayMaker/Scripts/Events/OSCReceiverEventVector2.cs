/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using UnityEngine;

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
    public class OSCReceiverEventVector2 : OSCReceiverEvent<FsmVector2, Vector2>
    {
        #region Protected Methods

        protected override bool ProcessMessage(OSCMessage message, out Vector2 value)
        {
            value = Vector2.zero;

            if (message.ToVector2(out value))
                return true;

            return false;
        }

        #endregion
    }
}

#endif