/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using UnityEngine;

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
    public class OSCReceiverEventRect : OSCReceiverEvent<FsmRect, Rect>
    {
        #region Protected Methods

        protected override bool ProcessMessage(OSCMessage message, out Rect value)
        {
            value = Rect.zero;

            if (message.ToRect(out value))
                return true;

            return false;
        }

        #endregion
    }
}

#endif