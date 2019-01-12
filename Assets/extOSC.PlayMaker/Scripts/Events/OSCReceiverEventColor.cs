/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using UnityEngine;

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
    public class OSCReceiverEventColor : OSCReceiverEvent<FsmColor, Color>
    {
        #region Protected Methods

        protected override bool ProcessMessage(OSCMessage message, out Color value)
        {
            value = Color.black;

            if (message.ToColor(out value))
                return true;

            return false;
        }

        #endregion
    }
}

#endif